using GreenSwap.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GreenSwap
{
    public partial class UsersForm : MaterialForm
    {
        private readonly GreenSwapDbContext _context;
        private readonly MaterialSkinManager materialSkinManager;

        public UsersForm()
        {
            InitializeComponent();

            // Initialize Material Skin
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Green800,
                Primary.Green900,
                Primary.Green500,
                Accent.LightGreen200,
                TextShade.WHITE
            );

            // Initialize database context
            _context = new GreenSwapDbContext();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            try
            {
                // Clear existing items
                dgvUsers.Rows.Clear();

                // Get all users from database
                var users = _context.Users.ToList();

                // Add users to DataGridView
                foreach (var user in users)
                {
                    dgvUsers.Rows.Add(
                        user.UserID,
                        user.Username,
                        user.Email,
                        user.Location,
                        user.JoinDate.ToString("yyyy-MM-dd"),
                        user.ProfileDescription
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtPassword.Text) ||
                    string.IsNullOrWhiteSpace(txtLocation.Text))
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Check if username or email already exists
                if (_context.Users.Any(u => u.Username == txtUsername.Text))
                {
                    MessageBox.Show("Username already exists.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (_context.Users.Any(u => u.Email == txtEmail.Text))
                {
                    MessageBox.Show("Email already exists.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create new user
                var user = new User
                {
                    Username = txtUsername.Text,
                    Email = txtEmail.Text,
                    PasswordHash = txtPassword.Text, // In a real app, hash this password
                    Location = txtLocation.Text,
                    ProfileDescription = txtProfileDesc.Text,
                    JoinDate = DateTime.Now
                };

                // Add to database
                _context.Users.Add(user);
                _context.SaveChanges();

                // Refresh the list
                LoadUsers();

                // Clear form
                ClearForm();

                MessageBox.Show("User added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding user: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a user is selected
                if (string.IsNullOrWhiteSpace(txtUserID.Text))
                {
                    MessageBox.Show("Please select a user to update.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate input
                if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtLocation.Text))
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int userId = int.Parse(txtUserID.Text);

                // Find user
                var user = _context.Users.Find(userId);
                if (user == null)
                {
                    MessageBox.Show("User not found.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if username or email already exists for other users
                if (_context.Users.Any(u => u.Username == txtUsername.Text && u.UserID != userId))
                {
                    MessageBox.Show("Username already exists.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (_context.Users.Any(u => u.Email == txtEmail.Text && u.UserID != userId))
                {
                    MessageBox.Show("Email already exists.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Update user
                user.Username = txtUsername.Text;
                user.Email = txtEmail.Text;
                user.Location = txtLocation.Text;
                user.ProfileDescription = txtProfileDesc.Text;

                // Update password if provided
                if (!string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    user.PasswordHash = txtPassword.Text; // In a real app, hash this password
                }

                // Save changes
                _context.SaveChanges();

                // Refresh the list
                LoadUsers();

                // Clear form
                ClearForm();

                MessageBox.Show("User updated successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating user: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a user is selected
                if (string.IsNullOrWhiteSpace(txtUserID.Text))
                {
                    MessageBox.Show("Please select a user to delete.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int userId = int.Parse(txtUserID.Text);

                // Confirm deletion
                var result = MessageBox.Show("Are you sure you want to delete this user? This will also delete all their plants and trades.",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    return;
                }

                // Find user
                var user = _context.Users.Find(userId);
                if (user == null)
                {
                    MessageBox.Show("User not found.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Delete user
                _context.Users.Remove(user);
                _context.SaveChanges();

                // Refresh the list
                LoadUsers();

                // Clear form
                ClearForm();

                MessageBox.Show("User deleted successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting user: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtUserID.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtLocation.Text = string.Empty;
            txtProfileDesc.Text = string.Empty;
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvUsers.Rows[e.RowIndex];
                txtUserID.Text = row.Cells["UserID"].Value.ToString();
                txtUsername.Text = row.Cells["Username"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtPassword.Text = ""; // Don't display password
                txtLocation.Text = row.Cells["Location"].Value.ToString();
                txtProfileDesc.Text = row.Cells["ProfileDescription"].Value?.ToString() ?? "";

                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void btnFindUsersByLocation_Click(object sender, EventArgs e)
        {
            try
            {
                string searchLocation = txtSearchLocation.Text.Trim();
                if (string.IsNullOrWhiteSpace(searchLocation))
                {
                    LoadUsers();
                    return;
                }

                // Clear existing items
                dgvUsers.Rows.Clear();

                // Find users by location (using SQL's LIKE operator via EF Core)
                var users = _context.Users
                    .Where(u => EF.Functions.Like(u.Location, $"%{searchLocation}%"))
                    .ToList();

                // Add users to DataGridView
                foreach (var user in users)
                {
                    dgvUsers.Rows.Add(
                        user.UserID,
                        user.Username,
                        user.Email,
                        user.Location,
                        user.JoinDate.ToString("yyyy-MM-dd"),
                        user.ProfileDescription
                    );
                }

                if (users.Count == 0)
                {
                    MessageBox.Show($"No users found in locations containing '{searchLocation}'", "Search Results",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching users: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFindUsersWithPlants_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear existing items
                dgvUsers.Rows.Clear();

                // Execute a join query to find users with available plants
                var usersWithPlants = _context.Users
                    .Where(u => u.Plants.Any(p => p.Status == "Available"))
                    .OrderByDescending(u => u.Plants.Count(p => p.Status == "Available"))
                    .ToList();

                // Add users to DataGridView
                foreach (var user in usersWithPlants)
                {
                    dgvUsers.Rows.Add(
                        user.UserID,
                        user.Username,
                        user.Email,
                        user.Location,
                        user.JoinDate.ToString("yyyy-MM-dd"),
                        user.ProfileDescription
                    );
                }

                if (usersWithPlants.Count == 0)
                {
                    MessageBox.Show("No users with available plants found.", "Search Results",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching users: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UsersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context.Dispose();
        }
    }
}