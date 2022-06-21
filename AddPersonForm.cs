﻿using System;
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
    public partial class AddPersonForm : Form
    {
        private Database db;
        public AddPersonForm()
        {
            InitializeComponent();
            SubmitBtn.BackColor = Color.White;
            db = Database.GetDatabase();
            FullNameTextBox.Text = "";
            JobTextBox.Text = "";
            WorkPlaceTextBox.Text = "";
            RankComboBox.SelectedIndex = 0;
            DegreeTextBox.Text = "";
            AdditionalInfoTextBox.Text = "";
            GenderComboBox.SelectedIndex = 0;
            ForeignCheckBox.Checked = false;
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            Person p = new Person(FullNameTextBox.Text, JobTextBox.Text, WorkPlaceTextBox.Text, 
                                RankComboBox.SelectedItem.ToString(),DegreeTextBox.Text, 
                                AdditionalInfoTextBox.Text, GenderComboBox.SelectedItem.ToString(),
                                ForeignCheckBox.Checked);
            int id = db.AddPerson(p);
            Form f = new PersonForm(id);
            f.Show();
            this.Close();
        }

        private void AddPersonForm_Load(object sender, EventArgs e)
        {

        }
    }
}