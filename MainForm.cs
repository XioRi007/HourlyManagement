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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchForm f = new SearchForm();
            this.Hide();
            f.Show();
        }

        private void AddWorkerButton_Click(object sender, EventArgs e)
        {
            Form f = new AddPersonForm();
            //this.Hide();
            f.Show();
        }

        private void AddAssignmentButton_Click(object sender, EventArgs e)
        {

        }

        private void CreateDocumentButton_Click(object sender, EventArgs e)
        {
            Form f = new CreateDocumentForm();
            //this.Hide();
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SearchButton.BackColor = Color.White;
            AddWorkerButton.BackColor = Color.White;
            CreateDocumentButton.BackColor = Color.White;
        }
    }
}
