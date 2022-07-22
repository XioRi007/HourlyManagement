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
    public partial class TemplateForm : AsignmentForm
    {
        public TemplateForm()
        {
            SubmitBtn.Click += SubmitBtn_Click;
            this.Load += TemplateForm_Load;
        }

        private void TemplateForm_Load(object sender, EventArgs e)
        {
            _Load();
            this.Text = "Додати шаблон";
            SubmitBtn.Text = "Додати";
            if (Settings.isTemplate)
            {
                TypeComboBox.SelectedItem = Settings.template.Type;
                HoursTextBox.Text = Settings.template.Hours.ToString();
                JobComboBox.Text = Settings.template.Job;
                DepartmentComboBox.SelectedItem = Settings.template.Department;
                PurposeComboBox.Text = Settings.template.Purpose;
                DateFromDateTimePicker.Value = DateTime.Parse(Settings.template.DateFrom);
                DateToDateTimePicker.Value = DateTime.Parse(Settings.template.DateTo);
                DocumentDateDateTimePicker.Value = DateTime.Parse(Settings.template.DocumentDate);
                DocumentNumberTextBox.Text = Settings.template.DocumentNumber;
            }
            else
            {
                Settings.template = new Settings.Template();
                Settings.isTemplate = true;
            }
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            Settings.template.Type = TypeComboBox.SelectedItem.ToString();
            Settings.template.Hours = (float)Convert.ToDouble(HoursTextBox.Text.ToString());
            Settings.template.Job = JobComboBox.Text.ToString();
            Settings.template.Department = DepartmentComboBox.SelectedItem.ToString();
            Settings.template.Purpose = PurposeComboBox.Text.ToString();
            Settings.template.DateFrom = DateFromDateTimePicker.Value.ToShortDateString();
            Settings.template.DateTo = DateToDateTimePicker.Value.ToShortDateString();
            Settings.template.DocumentDate = DocumentDateDateTimePicker.Value.ToShortDateString();
            Settings.template.DocumentNumber = DocumentNumberTextBox.Text.ToString();
            this.Close();
        }
    }
}
