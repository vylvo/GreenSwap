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
    public partial class PlantCareForm : MaterialForm
    {
        private readonly GreenSwapDbContext _context;
        public PlantCareForm()
        {
            InitializeComponent();
            ThemeHelper.ApplyTheme(this);
            // Initialize database context
            _context = new GreenSwapDbContext();
        }

        private void PlantCareForm_Load(object sender, EventArgs e)
        {
            // Initialize difficulty levels in combobox
            for (int i = 1; i <= 5; i++)
            {
                cmbDifficulty.Items.Add(i.ToString());
            }

            // Load initial data
            LoadPlantCareInfo();
        }

        private void LoadPlantCareInfo()
        {
            try
            {
                // Clear existing items
                dgvPlantCare.Rows.Clear();

                // Get all plant care info from database
                var plantCareInfos = _context.PlantCareInfos
                    .OrderBy(p => p.PlantTypeName)
                    .ToList();

                // Add plant care info to DataGridView
                foreach (var info in plantCareInfos)
                {
                    dgvPlantCare.Rows.Add(
                        info.InfoID,
                        info.PlantTypeName,
                        info.WateringFrequency,
                        info.LightRequirements,
                        info.SoilPreferences,
                        info.DifficultyLevel,
                        info.GrowthHabits,
                        info.CommonIssues
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading plant care information: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPlantCare_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvPlantCare.Rows[e.RowIndex];
                txtInfoID.Text = row.Cells["InfoID"].Value.ToString();
                txtPlantType.Text = row.Cells["PlantTypeName"].Value.ToString();
                txtWatering.Text = row.Cells["WateringFrequency"].Value.ToString();
                txtLight.Text = row.Cells["LightRequirements"].Value.ToString();
                txtSoil.Text = row.Cells["SoilPreferences"].Value?.ToString() ?? string.Empty;
                cmbDifficulty.Text = row.Cells["DifficultyLevel"].Value.ToString();
                txtGrowthHabits.Text = row.Cells["GrowthHabits"].Value?.ToString() ?? string.Empty;
                txtCommonIssues.Text = row.Cells["CommonIssues"].Value?.ToString() ?? string.Empty;

                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (string.IsNullOrWhiteSpace(txtPlantType.Text) ||
                    string.IsNullOrWhiteSpace(txtWatering.Text) ||
                    string.IsNullOrWhiteSpace(txtLight.Text) ||
                    cmbDifficulty.SelectedIndex < 0)
                {
                    MessageBox.Show("Please fill in all required fields: Plant Type, Watering Frequency, Light Requirements, and Difficulty Level.",
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Check if plant type already exists
                if (_context.PlantCareInfos.Any(p => p.PlantTypeName == txtPlantType.Text))
                {
                    MessageBox.Show("Plant type already exists.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create new plant care info
                var plantCareInfo = new PlantCareInfo
                {
                    PlantTypeName = txtPlantType.Text,
                    WateringFrequency = txtWatering.Text,
                    LightRequirements = txtLight.Text,
                    SoilPreferences = txtSoil.Text,
                    DifficultyLevel = int.Parse(cmbDifficulty.Text),
                    GrowthHabits = txtGrowthHabits.Text,
                    CommonIssues = txtCommonIssues.Text
                };

                // Add to database
                _context.PlantCareInfos.Add(plantCareInfo);
                _context.SaveChanges();

                // Refresh the list
                LoadPlantCareInfo();

                // Clear form
                ClearForm();

                MessageBox.Show("Plant care information added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding plant care information: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if an item is selected
                if (string.IsNullOrWhiteSpace(txtInfoID.Text))
                {
                    MessageBox.Show("Please select a plant care info to update.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate input
                if (string.IsNullOrWhiteSpace(txtPlantType.Text) ||
                    string.IsNullOrWhiteSpace(txtWatering.Text) ||
                    string.IsNullOrWhiteSpace(txtLight.Text) ||
                    cmbDifficulty.SelectedIndex < 0)
                {
                    MessageBox.Show("Please fill in all required fields: Plant Type, Watering Frequency, Light Requirements, and Difficulty Level.",
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int infoId = int.Parse(txtInfoID.Text);

                // Find plant care info
                var plantCareInfo = _context.PlantCareInfos.Find(infoId);
                if (plantCareInfo == null)
                {
                    MessageBox.Show("Plant care information not found.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if plant type already exists for other info
                if (_context.PlantCareInfos.Any(p => p.PlantTypeName == txtPlantType.Text && p.InfoID != infoId))
                {
                    MessageBox.Show("Plant type already exists.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Update plant care info
                plantCareInfo.PlantTypeName = txtPlantType.Text;
                plantCareInfo.WateringFrequency = txtWatering.Text;
                plantCareInfo.LightRequirements = txtLight.Text;
                plantCareInfo.SoilPreferences = txtSoil.Text;
                plantCareInfo.DifficultyLevel = int.Parse(cmbDifficulty.Text);
                plantCareInfo.GrowthHabits = txtGrowthHabits.Text;
                plantCareInfo.CommonIssues = txtCommonIssues.Text;

                // Save changes
                _context.SaveChanges();

                // Refresh the list
                LoadPlantCareInfo();

                // Clear form
                ClearForm();

                MessageBox.Show("Plant care information updated successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating plant care information: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if an item is selected
                if (string.IsNullOrWhiteSpace(txtInfoID.Text))
                {
                    MessageBox.Show("Please select a plant care info to delete.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int infoId = int.Parse(txtInfoID.Text);

                // Confirm deletion
                var result = MessageBox.Show("Are you sure you want to delete this plant care information?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    return;
                }

                // Find plant care info
                var plantCareInfo = _context.PlantCareInfos.Find(infoId);
                if (plantCareInfo == null)
                {
                    MessageBox.Show("Plant care information not found.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Delete plant care info
                _context.PlantCareInfos.Remove(plantCareInfo);
                _context.SaveChanges();

                // Refresh the list
                LoadPlantCareInfo();

                // Clear form
                ClearForm();

                MessageBox.Show("Plant care information deleted successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting plant care information: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtInfoID.Text = string.Empty;
            txtPlantType.Text = string.Empty;
            txtWatering.Text = string.Empty;
            txtLight.Text = string.Empty;
            txtSoil.Text = string.Empty;
            cmbDifficulty.SelectedIndex = -1;
            txtGrowthHabits.Text = string.Empty;
            txtCommonIssues.Text = string.Empty;
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnFindEasyPlants_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear existing items
                dgvPlantCare.Rows.Clear();

                // Execute a query to find the easiest plants (difficulty level 1-2)
                var easyPlants = _context.PlantCareInfos
                    .Where(p => p.DifficultyLevel <= 2)
                    .OrderBy(p => p.DifficultyLevel)
                    .ThenBy(p => p.PlantTypeName)
                    .ToList();

                // Add plants to DataGridView
                foreach (var info in easyPlants)
                {
                    dgvPlantCare.Rows.Add(
                        info.InfoID,
                        info.PlantTypeName,
                        info.WateringFrequency,
                        info.LightRequirements,
                        info.SoilPreferences,
                        info.DifficultyLevel,
                        info.GrowthHabits,
                        info.CommonIssues
                    );
                }

                if (easyPlants.Count == 0)
                {
                    MessageBox.Show("No easy plants found.", "Search Results",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Found {easyPlants.Count} easy plants (difficulty level 1-2).", "Search Results",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching plant care info: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFindHardestPlants_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear existing items
                dgvPlantCare.Rows.Clear();

                // Execute a query to find the hardest plants (difficulty level 4-5)
                var hardPlants = _context.PlantCareInfos
                    .Where(p => p.DifficultyLevel >= 4)
                    .OrderByDescending(p => p.DifficultyLevel)
                    .ThenBy(p => p.PlantTypeName)
                    .ToList();

                // Add plants to DataGridView
                foreach (var info in hardPlants)
                {
                    dgvPlantCare.Rows.Add(
                        info.InfoID,
                        info.PlantTypeName,
                        info.WateringFrequency,
                        info.LightRequirements,
                        info.SoilPreferences,
                        info.DifficultyLevel,
                        info.GrowthHabits,
                        info.CommonIssues
                    );
                }

                if (hardPlants.Count == 0)
                {
                    MessageBox.Show("No difficult plants found.", "Search Results",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Found {hardPlants.Count} difficult plants (difficulty level 4-5).", "Search Results",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching plant care info: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFindPopularTypes_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear existing items
                dgvPlantCare.Rows.Clear();

                // Execute a complex join query to find the most popular plant types based on trade count
                var popularTypes = _context.PlantCareInfos
                    .Join(
                        _context.Plants.GroupBy(p => p.PlantType)
                            .Select(g => new { PlantType = g.Key, Count = g.Count() }),
                        pci => pci.PlantTypeName,
                        pt => pt.PlantType,
                        (pci, pt) => new
                        {
                            PlantCareInfo = pci,
                            PlantCount = pt.Count
                        })
                    .OrderByDescending(x => x.PlantCount)
                    .Select(x => x.PlantCareInfo)
                    .ToList();

                // Add plant care info to DataGridView
                foreach (var info in popularTypes)
                {
                    dgvPlantCare.Rows.Add(
                        info.InfoID,
                        info.PlantTypeName,
                        info.WateringFrequency,
                        info.LightRequirements,
                        info.SoilPreferences,
                        info.DifficultyLevel,
                        info.GrowthHabits,
                        info.CommonIssues
                    );
                }

                if (popularTypes.Count == 0)
                {
                    MessageBox.Show("No plant types found.", "Search Results",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Found {popularTypes.Count} plant types sorted by popularity.",
                        "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching plant care info: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PlantCareForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context.Dispose();
        }
    }
}