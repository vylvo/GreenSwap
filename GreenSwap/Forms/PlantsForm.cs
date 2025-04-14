using GreenSwap.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GreenSwap
{
    public partial class PlantsForm : MaterialForm
    {
        private readonly GreenSwapDbContext _context;

        public PlantsForm()
        {
            InitializeComponent();
            ThemeHelper.ApplyTheme(this);

            // Initialize database context
            _context = new GreenSwapDbContext();
        }

        private void PlantsForm_Load(object sender, EventArgs e)
        {
            LoadPlants();
            LoadUsers();
            LoadPlantTypes();

            // Set default date to today
            dtpDateListed.Value = DateTime.Now;

            // Set up status dropdown
            cmbStatus.Items.AddRange(new string[] { "Available", "Not Available", "Traded" });
            cmbStatus.SelectedIndex = 0;
        }

        private void LoadPlants()
        {
            try
            {
                // Clear existing items
                dgvPlants.Rows.Clear();

                // Get all plants from database with their owners
                var plants = _context.Plants
                    .Include(p => p.Owner)
                    .ToList();

                // Add plants to DataGridView
                foreach (var plant in plants)
                {
                    dgvPlants.Rows.Add(
                        plant.PlantID,
                        plant.PlantName,
                        plant.PlantType,
                        plant.Owner?.Username ?? "Unknown",
                        plant.AgeOrStage,
                        plant.DateListed.ToString("yyyy-MM-dd"),
                        plant.Status,
                        plant.Description
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading plants: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadUsers()
        {
            try
            {
                // Clear existing items
                cmbUser.Items.Clear();

                // Add empty item
                cmbUser.Items.Add("");

                // Get all users from database
                var users = _context.Users
                    .OrderBy(u => u.Username)
                    .ToList();

                // Create dictionary to store UserID by display name
                Dictionary<string, int> userDict = new Dictionary<string, int>();

                // Add users to dropdown
                foreach (var user in users)
                {
                    string displayName = $"{user.Username} ({user.Email})";
                    cmbUser.Items.Add(displayName);
                    userDict[displayName] = user.UserID;
                }

                // Store user dictionary in tag
                cmbUser.Tag = userDict;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPlantTypes()
        {
            try
            {
                // Clear existing items
                cmbPlantType.Items.Clear();

                // Add empty item
                cmbPlantType.Items.Add("");

                // Get all unique plant types from database
                var plantTypes = _context.Plants
                    .Select(p => p.PlantType)
                    .Distinct()
                    .OrderBy(pt => pt)
                    .ToList();

                // Add plant types from PlantCareInfo table
                var careInfoTypes = _context.PlantCareInfos
                    .Select(pci => pci.PlantTypeName)
                    .Distinct()
                    .OrderBy(pt => pt)
                    .ToList();

                // Combine and remove duplicates
                var allTypes = plantTypes.Union(careInfoTypes).OrderBy(pt => pt).ToList();

                // Add types to dropdown
                foreach (var type in allTypes)
                {
                    cmbPlantType.Items.Add(type);
                }

                // Also populate the search plant type dropdown
                cmbSearchPlantType.Items.Clear();
                cmbSearchPlantType.Items.Add("");
                foreach (var type in allTypes)
                {
                    cmbSearchPlantType.Items.Add(type);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading plant types: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (string.IsNullOrWhiteSpace(txtPlantName.Text) ||
                    string.IsNullOrWhiteSpace(cmbPlantType.Text) ||
                    cmbUser.SelectedIndex <= 0)
                {
                    MessageBox.Show("Please fill in all required fields: Plant Name, Plant Type, and User.",
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get selected user ID
                int userID;
                if (cmbUser.SelectedIndex > 0)
                {
                    string selectedUserDisplay = cmbUser.SelectedItem.ToString();
                    var userDict = (Dictionary<string, int>)cmbUser.Tag;
                    userID = userDict[selectedUserDisplay];
                }
                else
                {
                    MessageBox.Show("Please select a user.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create new plant
                var plant = new Plant
                {
                    PlantName = txtPlantName.Text,
                    PlantType = cmbPlantType.Text,
                    UserID = userID,
                    Description = txtDescription.Text,
                    AgeOrStage = txtAgeOrStage.Text,
                    DateListed = dtpDateListed.Value,
                    Status = cmbStatus.SelectedItem.ToString()
                };

                // Add to database
                _context.Plants.Add(plant);
                _context.SaveChanges();

                // Refresh the list
                LoadPlants();

                // Clear form
                ClearForm();

                MessageBox.Show("Plant added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding plant: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a plant is selected
                if (string.IsNullOrWhiteSpace(txtPlantID.Text))
                {
                    MessageBox.Show("Please select a plant to update.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate input
                if (string.IsNullOrWhiteSpace(txtPlantName.Text) ||
                    string.IsNullOrWhiteSpace(cmbPlantType.Text) ||
                    cmbUser.SelectedIndex <= 0)
                {
                    MessageBox.Show("Please fill in all required fields: Plant Name, Plant Type, and User.",
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int plantId = int.Parse(txtPlantID.Text);

                // Find plant
                var plant = _context.Plants.Find(plantId);
                if (plant == null)
                {
                    MessageBox.Show("Plant not found.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Get selected user ID
                int userID;
                if (cmbUser.SelectedIndex > 0)
                {
                    string selectedUserDisplay = cmbUser.SelectedItem.ToString();
                    var userDict = (Dictionary<string, int>)cmbUser.Tag;
                    userID = userDict[selectedUserDisplay];
                }
                else
                {
                    MessageBox.Show("Please select a user.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Update plant
                plant.PlantName = txtPlantName.Text;
                plant.PlantType = cmbPlantType.Text;
                plant.UserID = userID;
                plant.Description = txtDescription.Text;
                plant.AgeOrStage = txtAgeOrStage.Text;
                plant.DateListed = dtpDateListed.Value;
                plant.Status = cmbStatus.SelectedItem.ToString();

                // Save changes
                _context.SaveChanges();

                // Refresh the list
                LoadPlants();

                // Clear form
                ClearForm();

                MessageBox.Show("Plant updated successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating plant: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a plant is selected
                if (string.IsNullOrWhiteSpace(txtPlantID.Text))
                {
                    MessageBox.Show("Please select a plant to delete.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int plantId = int.Parse(txtPlantID.Text);

                // Confirm deletion
                var result = MessageBox.Show("Are you sure you want to delete this plant? This will also delete all related trades.",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    return;
                }

                // Find plant
                var plant = _context.Plants.Find(plantId);
                if (plant == null)
                {
                    MessageBox.Show("Plant not found.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Delete plant
                _context.Plants.Remove(plant);
                _context.SaveChanges();

                // Refresh the list
                LoadPlants();

                // Clear form
                ClearForm();

                MessageBox.Show("Plant deleted successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting plant: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtPlantID.Text = string.Empty;
            txtPlantName.Text = string.Empty;
            cmbPlantType.SelectedIndex = -1;
            cmbPlantType.Text = string.Empty;
            cmbUser.SelectedIndex = -1;
            txtDescription.Text = string.Empty;
            txtAgeOrStage.Text = string.Empty;
            dtpDateListed.Value = DateTime.Now;
            cmbStatus.SelectedIndex = 0;
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void dgvPlants_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    var row = dgvPlants.Rows[e.RowIndex];

                    // Get plant ID from the grid
                    int plantId = Convert.ToInt32(row.Cells["PlantID"].Value);

                    // Load the plant with full details from database
                    var plant = _context.Plants
                        .Include(p => p.Owner)
                        .FirstOrDefault(p => p.PlantID == plantId);

                    if (plant != null)
                    {
                        // Populate the form
                        txtPlantID.Text = plant.PlantID.ToString();
                        txtPlantName.Text = plant.PlantName;
                        cmbPlantType.Text = plant.PlantType;
                        txtDescription.Text = plant.Description;
                        txtAgeOrStage.Text = plant.AgeOrStage;
                        dtpDateListed.Value = plant.DateListed;
                        cmbStatus.Text = plant.Status;

                        // Select the user in the dropdown
                        if (plant.Owner != null)
                        {
                            string userDisplay = $"{plant.Owner.Username} ({plant.Owner.Email})";
                            cmbUser.SelectedItem = userDisplay;
                        }

                        // Enable/disable buttons
                        btnAdd.Enabled = false;
                        btnUpdate.Enabled = true;
                        btnDelete.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading plant details: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSearchByType_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cmbSearchPlantType.Text))
                {
                    LoadPlants();
                    return;
                }

                string searchType = cmbSearchPlantType.Text;

                // Clear existing items
                dgvPlants.Rows.Clear();

                // Find plants by type
                var plants = _context.Plants
                    .Include(p => p.Owner)
                    .Where(p => p.PlantType == searchType)
                    .ToList();

                // Add plants to DataGridView
                foreach (var plant in plants)
                {
                    dgvPlants.Rows.Add(
                        plant.PlantID,
                        plant.PlantName,
                        plant.PlantType,
                        plant.Owner?.Username ?? "Unknown",
                        plant.AgeOrStage,
                        plant.DateListed.ToString("yyyy-MM-dd"),
                        plant.Status,
                        plant.Description
                    );
                }

                if (plants.Count == 0)
                {
                    MessageBox.Show($"No plants found with type '{searchType}'", "Search Results",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching plants: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFindAvailablePlants_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear existing items
                dgvPlants.Rows.Clear();

                // Find available plants
                var plants = _context.Plants
                    .Include(p => p.Owner)
                    .Where(p => p.Status == "Available")
                    .OrderBy(p => p.DateListed)
                    .ToList();

                // Add plants to DataGridView
                foreach (var plant in plants)
                {
                    dgvPlants.Rows.Add(
                        plant.PlantID,
                        plant.PlantName,
                        plant.PlantType,
                        plant.Owner?.Username ?? "Unknown",
                        plant.AgeOrStage,
                        plant.DateListed.ToString("yyyy-MM-dd"),
                        plant.Status,
                        plant.Description
                    );
                }

                if (plants.Count == 0)
                {
                    MessageBox.Show("No available plants found.", "Search Results",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching plants: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFindPlantsByLocation_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSearchLocation.Text))
                {
                    LoadPlants();
                    return;
                }

                string searchLocation = txtSearchLocation.Text.Trim();

                // Clear existing items
                dgvPlants.Rows.Clear();

                // Find plants by owner location using a subquery
                var plants = _context.Plants
                    .Include(p => p.Owner)
                    .Where(p => p.Owner.Location.Contains(searchLocation))
                    .ToList();

                // Add plants to DataGridView
                foreach (var plant in plants)
                {
                    dgvPlants.Rows.Add(
                        plant.PlantID,
                        plant.PlantName,
                        plant.PlantType,
                        plant.Owner?.Username ?? "Unknown",
                        plant.AgeOrStage,
                        plant.DateListed.ToString("yyyy-MM-dd"),
                        plant.Status,
                        plant.Description
                    );
                }

                if (plants.Count == 0)
                {
                    MessageBox.Show($"No plants found in locations containing '{searchLocation}'", "Search Results",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching plants: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPlantCare_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbPlantType.Text))
            {
                MessageBox.Show("Please select a plant type first.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Try to find care info for the selected plant type
            var careInfo = _context.PlantCareInfos
                .FirstOrDefault(pci => pci.PlantTypeName == cmbPlantType.Text);

            if (careInfo == null)
            {
                MessageBox.Show("No care information found for this plant type.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Display care information
            string careDetails =
                $"Plant Type: {careInfo.PlantTypeName}\n\n" +
                $"Watering Frequency: {careInfo.WateringFrequency}\n\n" +
                $"Light Requirements: {careInfo.LightRequirements}\n\n" +
                $"Soil Preferences: {careInfo.SoilPreferences}\n\n" +
                $"Difficulty Level: {careInfo.DifficultyLevel}/5\n\n" +
                $"Growth Habits: {careInfo.GrowthHabits}\n\n" +
                $"Common Issues: {careInfo.CommonIssues}";

            MessageBox.Show(careDetails, $"Care Information for {careInfo.PlantTypeName}",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PlantsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context.Dispose();
        }

        private void cmbUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}