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
    public partial class AddAsignmentForm : HourlyManagment.AsignmentForm
    {
        public AddAsignmentForm(int PersonId)
        {
            this.PersonId = PersonId;
            SubmitBtn.Click += SubmitBtn_Click;
            this.Load += AddAsignmentForm_Load;
            this.FormClosed += AsignmentForm_FormClosed;
        }
        public AddAsignmentForm(int PersonId, Assignment a)
        {
            this.PersonId = PersonId;
            this.a = a;
            SubmitBtn.Click += SubmitBtn_Click;
            this.Load += AddAsignmentForm_Load;
            this.FormClosed += AsignmentForm_FormClosed;
        }
        protected void AsignmentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form frm = Application.OpenForms["PersonForm"];
            frm.Close();
            frm = new PersonForm(PersonId);
            frm.Show();
            frm = Application.OpenForms["SearchForm"];
            frm.Hide();
        }

        private void AddAsignmentForm_Load(object sender, EventArgs e)
        {
            _Load();
            this.Text = "Додати призначення";
            SubmitBtn.Text = "Додати";
            if (a != null)
            {
                HoursTextBox.Text = a.Hours.ToString();
                JobComboBox.Text = a.Job;
                DepartmentComboBox.SelectedItem = a.Department;
                PurposeComboBox.Text = a.Purpose;
                DateFromDateTimePicker.Value = DateTime.Parse(a.DateFrom);
                DateToDateTimePicker.Value = DateTime.Parse(a.DateTo);
            }
            else if(Settings.isTemplate)
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
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                db.AddAssignment(PersonId, new Assignment(TypeComboBox.SelectedItem.ToString(),
                                                        JobComboBox.Text,
                                                        DepartmentComboBox.SelectedItem.ToString(),
                                                        PurposeComboBox.Text.ToString(),
                                                        DateFromDateTimePicker.Value.ToShortDateString(),
                                                        DateToDateTimePicker.Value.ToShortDateString(),
                                                        (float)Convert.ToDouble(HoursTextBox.Text),
                                                        DocumentNumberTextBox.Text.ToString(),
                                                        DocumentDateDateTimePicker.Value.ToShortDateString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка");
            }
            this.Close();

        }
    }
}
