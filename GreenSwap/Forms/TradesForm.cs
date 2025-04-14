using GreenSwap.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace GreenSwap
{
    public partial class TradesForm : MaterialForm
    {
        private readonly GreenSwapDbContext _context;
        private Dictionary<string, int> userDictionary = new Dictionary<string, int>();
        private Dictionary<string, int> plantDictionary = new Dictionary<string, int>();
        private bool initialLoad = true;

        public TradesForm()
        {
            InitializeComponent();
            ThemeHelper.ApplyTheme(this);

            // Initialize database context
            _context = new GreenSwapDbContext();
        }

        private void TradesForm_Load(object sender, EventArgs e)
        {
            initialLoad = true;
            LoadAllData();
            initialLoad = false;
        }

        private void LoadAllData()
        {
            try
            {
                LoadTradeStatuses();
                LoadUsers();
                LoadPlants();
                LoadTrades();

                // Set default dates
                dtpRequestDate.Value = DateTime.Now;
                dtpCompletionDate.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTradeStatuses()
        {
            try
            {
                // Clear existing items
                cmbTradeStatus.Items.Clear();

                // Add trade statuses
                cmbTradeStatus.Items.Add("Pending");
                cmbTradeStatus.Items.Add("Accepted");
                cmbTradeStatus.Items.Add("Completed");
                cmbTradeStatus.Items.Add("Declined");
                cmbTradeStatus.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading trade statuses: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadUsers()
        {
            try
            {
                // Clear existing items
                cmbRequestor.Items.Clear();
                cmbProvider.Items.Clear();
                cmbSearchUser.Items.Clear();
                userDictionary.Clear();

                // Add empty item to search combo
                cmbSearchUser.Items.Add("");

                // Get all users from database
                var users = _context.Users
                    .OrderBy(u => u.Username)
                    .ToList();

                // Add users to dropdowns
                foreach (var user in users)
                {
                    string displayName = $"{user.Username} ({user.Email})";
                    cmbRequestor.Items.Add(displayName);
                    cmbProvider.Items.Add(displayName);
                    cmbSearchUser.Items.Add(displayName);
                    userDictionary[displayName] = user.UserID;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPlants()
        {
            try
            {
                // Clear existing items
                cmbPlant.Items.Clear();
                plantDictionary.Clear();

                // Get all available plants from database
                var plants = _context.Plants
                    .Include(p => p.Owner)
                    .Where(p => p.Status == "Available")
                    .OrderBy(p => p.PlantName)
                    .ToList();

                // Add plants to dropdown
                foreach (var plant in plants)
                {
                    string displayName = $"{plant.PlantName} ({plant.PlantType}) - {plant.Owner?.Username ?? "Unknown"}";
                    cmbPlant.Items.Add(displayName);
                    plantDictionary[displayName] = plant.PlantID;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading plants: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPlantsForProvider(int providerId)
        {
            try
            {
                if (initialLoad) return;

                // Clear existing items
                cmbPlant.Items.Clear();
                plantDictionary.Clear();

                // Get plants belonging to the selected provider
                var plants = _context.Plants
                    .Include(p => p.Owner)
                    .Where(p => p.UserID == providerId && p.Status == "Available")
                    .OrderBy(p => p.PlantName)
                    .ToList();

                // Add plants to dropdown
                foreach (var plant in plants)
                {
                    string displayName = $"{plant.PlantName} ({plant.PlantType})";
                    cmbPlant.Items.Add(displayName);
                    plantDictionary[displayName] = plant.PlantID;
                }

                if (plants.Count == 0)
                {
                    MessageBox.Show("Selected provider has no available plants.", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading plants for provider: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTrades()
        {
            try
            {
                // Clear existing items
                dgvTrades.Rows.Clear();

                // Get all trades from database with related data
                var trades = _context.Trades
                    .Include(t => t.Requestor)
                    .Include(t => t.Provider)
                    .Include(t => t.Plant)
                    .OrderByDescending(t => t.RequestDate)
                    .ToList();

                // Add trades to DataGridView
                foreach (var trade in trades)
                {
                    dgvTrades.Rows.Add(
                        trade.TradeID,
                        trade.Requestor?.Username ?? "Unknown",
                        trade.Provider?.Username ?? "Unknown",
                        trade.Plant?.PlantName ?? "Unknown",
                        trade.RequestDate.ToString("yyyy-MM-dd"),
                        trade.Status,
                        trade.CompletionDate?.ToString("yyyy-MM-dd") ?? string.Empty,
                        trade.TradeNotes
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading trades: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbRequestor_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Logic to prevent requestor and provider from being the same user
            if (cmbRequestor.SelectedIndex >= 0 && cmbProvider.SelectedIndex >= 0 &&
                cmbRequestor.SelectedItem.ToString() == cmbProvider.SelectedItem.ToString())
            {
                MessageBox.Show("Requestor and Provider cannot be the same user.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbRequestor.SelectedIndex = -1;
            }
        }

        private void cmbProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Logic to prevent requestor and provider from being the same user
            if (cmbRequestor.SelectedIndex >= 0 && cmbProvider.SelectedIndex >= 0 &&
                cmbRequestor.SelectedItem.ToString() == cmbProvider.SelectedItem.ToString())
            {
                MessageBox.Show("Requestor and Provider cannot be the same user.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbProvider.SelectedIndex = -1;
                return;
            }

            // Load plants for the selected provider
            if (cmbProvider.SelectedIndex >= 0)
            {
                string selectedProviderDisplay = cmbProvider.SelectedItem.ToString();
                if (userDictionary.TryGetValue(selectedProviderDisplay, out int providerId))
                {
                    LoadPlantsForProvider(providerId);
                }
            }
        }

        private void cmbTradeStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Enable/disable completion date based on status
            dtpCompletionDate.Enabled = cmbTradeStatus.SelectedItem?.ToString() == "Completed";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (cmbRequestor.SelectedIndex < 0 ||
                    cmbProvider.SelectedIndex < 0 ||
                    cmbPlant.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select a Requestor, Provider, and Plant.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get selected IDs
                string requestorDisplay = cmbRequestor.SelectedItem.ToString();
                string providerDisplay = cmbProvider.SelectedItem.ToString();
                string plantDisplay = cmbPlant.SelectedItem.ToString();

                if (!userDictionary.TryGetValue(requestorDisplay, out int requestorId) ||
                    !userDictionary.TryGetValue(providerDisplay, out int providerId) ||
                    !plantDictionary.TryGetValue(plantDisplay, out int plantId))
                {
                    MessageBox.Show("Error retrieving selected item IDs.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create new trade
                var trade = new Trade
                {
                    RequestorID = requestorId,
                    ProviderID = providerId,
                    PlantID = plantId,
                    RequestDate = dtpRequestDate.Value,
                    Status = cmbTradeStatus.SelectedItem.ToString(),
                    TradeNotes = txtTradeNotes.Text
                };

                // Set completion date if status is "Completed"
                if (trade.Status == "Completed")
                {
                    trade.CompletionDate = dtpCompletionDate.Value;
                }

                // Add to database
                _context.Trades.Add(trade);
                _context.SaveChanges();

                // Refresh the list
                LoadTrades();

                // Clear form
                ClearForm();

                MessageBox.Show("Trade added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding trade: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a trade is selected
                if (string.IsNullOrWhiteSpace(txtTradeID.Text))
                {
                    MessageBox.Show("Please select a trade to update.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate input
                if (cmbRequestor.SelectedIndex < 0 ||
                    cmbProvider.SelectedIndex < 0 ||
                    cmbPlant.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select a Requestor, Provider, and Plant.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int tradeId = int.Parse(txtTradeID.Text);

                // Find trade
                var trade = _context.Trades.Find(tradeId);
                if (trade == null)
                {
                    MessageBox.Show("Trade not found.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Get selected IDs
                string requestorDisplay = cmbRequestor.SelectedItem.ToString();
                string providerDisplay = cmbProvider.SelectedItem.ToString();
                string plantDisplay = cmbPlant.SelectedItem.ToString();

                if (!userDictionary.TryGetValue(requestorDisplay, out int requestorId) ||
                    !userDictionary.TryGetValue(providerDisplay, out int providerId) ||
                    !plantDictionary.TryGetValue(plantDisplay, out int plantId))
                {
                    MessageBox.Show("Error retrieving selected item IDs.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Update trade
                trade.RequestorID = requestorId;
                trade.ProviderID = providerId;
                trade.PlantID = plantId;
                trade.RequestDate = dtpRequestDate.Value;
                trade.Status = cmbTradeStatus.SelectedItem.ToString();
                trade.TradeNotes = txtTradeNotes.Text;

                // Set or clear completion date based on status
                if (trade.Status == "Completed")
                {
                    trade.CompletionDate = dtpCompletionDate.Value;
                }
                else
                {
                    trade.CompletionDate = null;
                }

                // Save changes
                _context.SaveChanges();

                // Refresh the list
                LoadTrades();

                // Clear form
                ClearForm();

                MessageBox.Show("Trade updated successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating trade: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a trade is selected
                if (string.IsNullOrWhiteSpace(txtTradeID.Text))
                {
                    MessageBox.Show("Please select a trade to delete.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int tradeId = int.Parse(txtTradeID.Text);

                // Confirm deletion
                var result = MessageBox.Show("Are you sure you want to delete this trade?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    return;
                }

                // Find trade
                var trade = _context.Trades.Find(tradeId);
                if (trade == null)
                {
                    MessageBox.Show("Trade not found.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Delete trade
                _context.Trades.Remove(trade);
                _context.SaveChanges();

                // Refresh the list
                LoadTrades();

                // Clear form
                ClearForm();

                MessageBox.Show("Trade deleted successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting trade: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtTradeID.Text = string.Empty;
            cmbRequestor.SelectedIndex = -1;
            cmbProvider.SelectedIndex = -1;
            cmbPlant.Items.Clear();
            plantDictionary.Clear();
            dtpRequestDate.Value = DateTime.Now;
            cmbTradeStatus.SelectedIndex = 0;
            dtpCompletionDate.Value = DateTime.Now;
            dtpCompletionDate.Enabled = false;
            txtTradeNotes.Text = string.Empty;
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void dgvTrades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    var row = dgvTrades.Rows[e.RowIndex];

                    // Get trade ID from the grid
                    int tradeId = Convert.ToInt32(row.Cells["TradeID"].Value);

                    // Load the trade with full details from database
                    var trade = _context.Trades
                        .Include(t => t.Requestor)
                        .Include(t => t.Provider)
                        .Include(t => t.Plant)
                        .FirstOrDefault(t => t.TradeID == tradeId);

                    if (trade != null)
                    {
                        // Populate the form
                        txtTradeID.Text = trade.TradeID.ToString();
                        dtpRequestDate.Value = trade.RequestDate;
                        cmbTradeStatus.Text = trade.Status;
                        txtTradeNotes.Text = trade.TradeNotes ?? string.Empty;

                        // Handle completion date
                        if (trade.CompletionDate.HasValue)
                        {
                            dtpCompletionDate.Value = trade.CompletionDate.Value;
                            dtpCompletionDate.Enabled = trade.Status == "Completed";
                        }
                        else
                        {
                            dtpCompletionDate.Value = DateTime.Now;
                            dtpCompletionDate.Enabled = trade.Status == "Completed";
                        }

                        // Select the requestor in the dropdown
                        if (trade.Requestor != null)
                        {
                            string requestorDisplay = $"{trade.Requestor.Username} ({trade.Requestor.Email})";
                            cmbRequestor.SelectedItem = requestorDisplay;
                        }

                        // Select the provider in the dropdown
                        if (trade.Provider != null)
                        {
                            string providerDisplay = $"{trade.Provider.Username} ({trade.Provider.Email})";
                            cmbProvider.SelectedItem = providerDisplay;
                        }

                        // Load plants for this provider
                        LoadPlantsForProvider(trade.ProviderID);

                        // Add the current plant if it's not already in the list (might be traded already)
                        if (trade.Plant != null)
                        {
                            string plantDisplay = $"{trade.Plant.PlantName} ({trade.Plant.PlantType})";
                            if (!plantDictionary.ContainsKey(plantDisplay))
                            {
                                cmbPlant.Items.Add(plantDisplay);
                                plantDictionary[plantDisplay] = trade.PlantID;
                            }
                            cmbPlant.SelectedItem = plantDisplay;
                        }

                        // Enable/disable buttons
                        btnAdd.Enabled = false;
                        btnUpdate.Enabled = true;
                        btnDelete.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading trade details: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnFindTradesByUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbSearchUser.SelectedIndex <= 0)
                {
                    LoadTrades();
                    return;
                }

                string selectedUserDisplay = cmbSearchUser.SelectedItem.ToString();
                if (!userDictionary.TryGetValue(selectedUserDisplay, out int userId))
                {
                    MessageBox.Show("Please select a valid user.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Clear existing items
                dgvTrades.Rows.Clear();

                // Execute a join query to find trades for the selected user
                var trades = _context.Trades
                    .Include(t => t.Requestor)
                    .Include(t => t.Provider)
                    .Include(t => t.Plant)
                    .Where(t => t.RequestorID == userId || t.ProviderID == userId)
                    .OrderByDescending(t => t.RequestDate)
                    .ToList();

                // Add trades to DataGridView
                foreach (var trade in trades)
                {
                    dgvTrades.Rows.Add(
                        trade.TradeID,
                        trade.Requestor?.Username ?? "Unknown",
                        trade.Provider?.Username ?? "Unknown",
                        trade.Plant?.PlantName ?? "Unknown",
                        trade.RequestDate.ToString("yyyy-MM-dd"),
                        trade.Status,
                        trade.CompletionDate?.ToString("yyyy-MM-dd") ?? string.Empty,
                        trade.TradeNotes
                    );
                }

                if (trades.Count == 0)
                {
                    MessageBox.Show($"No trades found for the selected user.", "Search Results",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching trades: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFindPendingTrades_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear existing items
                dgvTrades.Rows.Clear();

                // Find pending trades
                var trades = _context.Trades
                    .Include(t => t.Requestor)
                    .Include(t => t.Provider)
                    .Include(t => t.Plant)
                    .Where(t => t.Status == "Pending")
                    .OrderBy(t => t.RequestDate)
                    .ToList();

                // Add trades to DataGridView
                foreach (var trade in trades)
                {
                    dgvTrades.Rows.Add(
                        trade.TradeID,
                        trade.Requestor?.Username ?? "Unknown",
                        trade.Provider?.Username ?? "Unknown",
                        trade.Plant?.PlantName ?? "Unknown",
                        trade.RequestDate.ToString("yyyy-MM-dd"),
                        trade.Status,
                        trade.CompletionDate?.ToString("yyyy-MM-dd") ?? string.Empty,
                        trade.TradeNotes
                    );
                }

                if (trades.Count == 0)
                {
                    MessageBox.Show("No pending trades found.", "Search Results",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching trades: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFindCompletedTrades_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear existing items
                dgvTrades.Rows.Clear();

                // Find completed trades using a more complex query with aggregation
                var trades = _context.Trades
                    .Include(t => t.Requestor)
                    .Include(t => t.Provider)
                    .Include(t => t.Plant)
                    .Where(t => t.Status == "Completed")
                    .OrderByDescending(t => t.CompletionDate)
                    .ToList();

                // Add trades to DataGridView
                foreach (var trade in trades)
                {
                    dgvTrades.Rows.Add(
                        trade.TradeID,
                        trade.Requestor?.Username ?? "Unknown",
                        trade.Provider?.Username ?? "Unknown",
                        trade.Plant?.PlantName ?? "Unknown",
                        trade.RequestDate.ToString("yyyy-MM-dd"),
                        trade.Status,
                        trade.CompletionDate?.ToString("yyyy-MM-dd") ?? string.Empty,
                        trade.TradeNotes
                    );
                }

                if (trades.Count == 0)
                {
                    MessageBox.Show("No completed trades found.", "Search Results",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Calculate average days to completion
                    double avgDaysToCompletion = trades
                        .Where(t => t.CompletionDate.HasValue)
                        .Average(t => (t.CompletionDate.Value - t.RequestDate).TotalDays);

                    MessageBox.Show($"Found {trades.Count} completed trades.\nAverage days to completion: {avgDaysToCompletion:F2}",
                        "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching trades: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TradesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context.Dispose();
        }
    }
}