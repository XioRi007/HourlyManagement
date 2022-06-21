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
    public partial class AddAsignmentForm : Form
    {
        private Database db;
        int PersonId;
        Assignment a;
        public AddAsignmentForm(int PersonId)
        {
            InitializeComponent();
            this.PersonId = PersonId;
            db = Database.GetDatabase();
        }
        public AddAsignmentForm(int PersonId, Assignment a)
        {
            InitializeComponent();
            this.PersonId = PersonId;
            db = Database.GetDatabase();
            this.a = a;
        }

        private void AddAsignmentForm_Load(object sender, EventArgs e)
        {
            SubmitBtn.BackColor = Color.White;
            //get deps
            List<string> deps = db.GetDepartments();
            foreach (var dep in deps)
            {
                DepartmentComboBox.Items.Add(dep);
            }
            //get purposes
            List<string> purposes = db.GetPurposes();
            foreach (var p in purposes)
            {
                PurposeComboBox.Items.Add(p);
            }
            //
            if (a != null)
            {
                HoursTextBox.Text = a.Hours.ToString();
                JobComboBox.SelectedItem = a.Job;
                DepartmentComboBox.SelectedItem = a.Department;
                PurposeComboBox.SelectedItem = a.Purpose;
                DateFromDateTimePicker.Value = DateTime.Parse(a.DateFrom);
                DateToDateTimePicker.Value = DateTime.Parse(a.DateTo);
                DocumentNumberTextBox.Text = a.DocumentNumber;
            }
            
        }

        private void AddAsignmentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form frm = Application.OpenForms["PersonForm"];            
            frm.Close();
            frm = new PersonForm(PersonId);
            frm.Show();
            frm = Application.OpenForms["SearchForm"];
            frm.Hide();
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
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка");
            }
            this.Close();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
