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
    public partial class IPersonForm : Form
    {
        protected Database db;
        public IPersonForm()
        {
            InitializeComponent();
            db = Database.GetDatabase();
        }
        protected void _Load()
        {
            SubmitBtn.BackColor = Color.White;
            //get deps
            List<string> deps = db.GetDepartments();
            WorkPlaceTextBox.Items.Add("");
            foreach (var dep in deps)
            {
                WorkPlaceTextBox.Items.Add(dep);
            }
        }
    }
}
