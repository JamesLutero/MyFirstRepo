using System;
using System.Drawing;
using System.Windows.Forms;

namespace DataFinderWinForm
{
    static class Program
    {
        public static bool IsDarkMode = Properties.Settings.Default.DarkMode;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SearchForm());
        }

        public static void ApplyTheme(Form form)
        {
            Color backColor = IsDarkMode ? Color.FromArgb(30, 30, 30) : SystemColors.Control;
            Color foreColor = IsDarkMode ? Color.White : Color.Black;
            Color textboxBackColor = IsDarkMode ? Color.FromArgb(50, 50, 50) : Color.White;
            Color textboxForeColor = IsDarkMode ? Color.White : Color.Black;
            Color buttonBackColor = IsDarkMode ? Color.FromArgb(60, 60, 60) : SystemColors.ControlLight;
            Color buttonForeColor = IsDarkMode ? Color.White : Color.Black;
            Color buttonBorderColor = IsDarkMode ? Color.Gray : SystemColors.ActiveBorder;

            form.BackColor = backColor;

            ApplyThemeToControls(form.Controls, backColor, foreColor, textboxBackColor, textboxForeColor, buttonBackColor, buttonForeColor, buttonBorderColor);
        }

        private static void ApplyThemeToControls(Control.ControlCollection controls,
                                                 Color backColor, Color foreColor,
                                                 Color textboxBackColor, Color textboxForeColor,
                                                 Color buttonBackColor, Color buttonForeColor, Color buttonBorderColor)
        {
            foreach (Control ctrl in controls)
            {
                if (ctrl is Label || ctrl is GroupBox)
                {
                    ctrl.ForeColor = foreColor;
                }
                else if (ctrl is TextBox)
                {
                    ctrl.BackColor = textboxBackColor;
                    ctrl.ForeColor = textboxForeColor;
                    ((TextBox)ctrl).BorderStyle = BorderStyle.FixedSingle;
                }
                else if (ctrl is Button)
                {
                    ctrl.BackColor = buttonBackColor;
                    ctrl.ForeColor = buttonForeColor;
                    ((Button)ctrl).FlatStyle = FlatStyle.Flat;
                    ((Button)ctrl).FlatAppearance.BorderColor = buttonBorderColor;
                    ((Button)ctrl).FlatAppearance.BorderSize = 1;
                }
                else if (ctrl is Panel || ctrl is TabControl || ctrl is TabPage)
                {
                    ctrl.BackColor = backColor;
                }
                else if (ctrl is DataGridView)
                {
                    DataGridView dgv = (DataGridView)ctrl;
                    dgv.BackgroundColor = backColor;
                    dgv.DefaultCellStyle.BackColor = textboxBackColor;
                    dgv.DefaultCellStyle.ForeColor = textboxForeColor;
                    dgv.ColumnHeadersDefaultCellStyle.BackColor = buttonBackColor;
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = buttonForeColor;
                    dgv.GridColor = buttonBorderColor;
                }

                if (ctrl.HasChildren)
                {
                    ApplyThemeToControls(ctrl.Controls, backColor, foreColor, textboxBackColor, textboxForeColor, buttonBackColor, buttonForeColor, buttonBorderColor);
                }
            }
        }
    }
}
