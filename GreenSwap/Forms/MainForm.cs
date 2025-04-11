using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Security.Cryptography.Xml;
using System.Windows.Forms;

namespace GreenSwap
{
    public partial class MainForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public MainForm()
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
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Initialize database
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            try
            {
                using (var context = new GreenSwapDbContext())
                {
                    context.Database.EnsureCreated();
                    // You can add seed data here if needed
                }

                MessageBox.Show("Database initialized successfully!", "GreenSwap",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing database: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            // Open Users form
            var usersForm = new UsersForm();
            usersForm.ShowDialog();
        }

        private void btnPlants_Click(object sender, EventArgs e)
        {
            // Open Plants form
            var plantsForm = new PlantsForm();
            plantsForm.ShowDialog();
        }

        private void btnTrades_Click(object sender, EventArgs e)
        {
            // Open Trades form
            var tradesForm = new TradesForm();
            tradesForm.ShowDialog();
        }

        private void btnPlantCare_Click(object sender, EventArgs e)
        {
            // Open Plant Care form
            var plantCareForm = new PlantCareForm();
            plantCareForm.ShowDialog();
        }
    }
}