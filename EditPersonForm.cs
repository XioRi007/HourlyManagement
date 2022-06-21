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
    public partial class EditPersonForm : Form
    {
        private Database db;
        private int PersonId;
        public EditPersonForm(Person p)
        {
            InitializeComponent();
            SubmitBtn.BackColor = Color.White;
            PersonId = p.PersonId;
            db = Database.GetDatabase();
            FullNameTextBox.Text = p.FullName;
            JobTextBox.Text = p.Job;
            WorkPlaceTextBox.Text = p.WorkPlace;
            RankComboBox.SelectedItem = p.Rank;
            DegreeTextBox.Text = p.Degree;
            AdditionalInfoTextBox.Text = p.SpecialInfo;
            GenderComboBox.SelectedItem = p.Gender;
            ForeignCheckBox.Checked = p.IsForeign;
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            Person p = new Person(FullNameTextBox.Text, JobTextBox.Text, WorkPlaceTextBox.Text, 
                                RankComboBox.SelectedItem.ToString(),DegreeTextBox.Text, 
                                AdditionalInfoTextBox.Text, GenderComboBox.SelectedItem.ToString(),
                                ForeignCheckBox.Checked, PersonId);
            db.UpdatePerson(p);
            this.Close();
        }

        private void EditPersonForm_Load(object sender, EventArgs e)
        {

        }
    }
}
