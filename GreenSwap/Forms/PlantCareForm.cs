using GreenSwap.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GreenSwap
{
    public partial class PlantCareForm : MaterialForm
    {
        private readonly GreenSwapDbContext _context;
        private readonly MaterialSkinManager materialSkinManager;

        public PlantCareForm()
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

        private void PlantCareForm_Load(object sender, EventArgs e)
        {
            // Implement loading plant care information from database
        }

        private void PlantCareForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context.Dispose();
        }
    }
}