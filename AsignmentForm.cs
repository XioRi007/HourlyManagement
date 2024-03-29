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
    public partial class AsignmentForm : Form
    {
        protected Database db;
        protected int PersonId;
        protected Assignment a;

        public AsignmentForm()
        {
            InitializeComponent();
            db = Database.GetDatabase();
        }
        

        protected void _Load()
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
        }

        
    }
}
