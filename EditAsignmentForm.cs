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
    public partial class EditAsignmentForm : Form
    {
        private Database db;
        int PersonId;
        Assignment a;
        public EditAsignmentForm(int PersonId, Assignment a)
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
            TypeComboBox.SelectedItem = a.Type;
            HoursTextBox.Text = a.Hours.ToString();
            JobComboBox.Text = a.Job;
            DepartmentComboBox.SelectedItem = a.Department;
            PurposeComboBox.Text = a.Purpose;
            DateFromDateTimePicker.Value = DateTime.Parse(a.DateFrom);
            DateToDateTimePicker.Value = DateTime.Parse(a.DateTo);
            DocumentDateDateTimePicker.Value = DateTime.Parse(a.DocumentDate);
            DocumentNumberTextBox.Text = a.DocumentNumber;
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
                db.UpdateAssignment(new Assignment(TypeComboBox.SelectedItem.ToString(),
                                                        JobComboBox.Text.ToString(),
                                                        DepartmentComboBox.SelectedItem.ToString(),
                                                        PurposeComboBox.Text.ToString(),
                                                        DateFromDateTimePicker.Value.ToShortDateString(),
                                                        DateToDateTimePicker.Value.ToShortDateString(),
                                                        (float)Convert.ToDouble(HoursTextBox.Text),
                                                        DocumentNumberTextBox.Text.ToString(),
                                                        DocumentDateDateTimePicker.Value.ToShortDateString(), a.AssignmentId));
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка");
            }
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
