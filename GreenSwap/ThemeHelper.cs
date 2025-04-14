using MaterialSkin;
using MaterialSkin.Controls;

namespace GreenSwap
{
    public static class ThemeHelper
    {
        private static readonly MaterialSkinManager materialSkinManager;

        // Initialize the MaterialSkinManager with the "Little Plants" color scheme
        static ThemeHelper()
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Green800,    // Primary color (darker green)
                Primary.Green900,    // Dark Primary color 
                Primary.Green500,    // Light Primary color
                Accent.LightGreen200, // Accent color (light lime)
                TextShade.WHITE      // Text color
            );
        }

        // Apply the theme to a form
        public static void ApplyTheme(MaterialForm form)
        {
            materialSkinManager.AddFormToManage(form);
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
        }
    }
}