using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HourlyManagment
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();/*
            firstSignCB.SelectedIndex = 0;
            SignsExtractsCB.SelectedIndex = 0;
            fontSizeCB.SelectedIndex = 0;
            fontCB.SelectedIndex = 0;*/
        }
        

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            firstSignCB.Text = Settings.isRector ? "Ректор": "Перший проректор";
            SignsExtractsCB.Text = Settings.isChief ? "Начальник ВК" : "Заступник начальника ВК";
            fontSizeCB.Text = Settings.fontSize.ToString();
            fontCB.Text = Settings.font;
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.isRector = firstSignCB.Text.ToString() == "Ректор" ? true: false;
            Settings.isChief = SignsExtractsCB.Text.ToString() == "Начальник ВК" ? true : false;
            Settings.fontSize = Convert.ToDouble(fontSizeCB.Text.ToString());
            Settings.font = fontCB.Text.ToString();
        }

        private void addTemplateButton_Click(object sender, EventArgs e)
        {
            Form f = new TemplateForm();
            f.Show();
        }

        private void clearTemplateButton_Click(object sender, EventArgs e)
        {
            if (Settings.isTemplate)
            {
                Settings.template = null;
                Settings.isTemplate = false;
            }
        }
    }
}
