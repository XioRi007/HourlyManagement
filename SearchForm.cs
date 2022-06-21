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
    public partial class SearchForm : Form
    {
        private Database db;
        private List<Person> people;
        public SearchForm()
        {
            InitializeComponent();
            db = Database.GetDatabase();
            people = new List<Person>();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            SubmitBtn.BackColor = Color.White;
            SearchComboBox.Visible = true;
            SearchTypeComboBox.SelectedIndex = 0;
        }

        private void SearchForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            int idx = 0;
            if (Application.OpenForms.Count == 1)
            {
                Form form = new MainForm();
                form.Show();
                return;
            }

            if (Application.OpenForms.Count < 2)
                idx = 1;
            else idx = Application.OpenForms.Count - 2;
            Form frm = Application.OpenForms[idx];
            frm.Show();
        }

        private void SearchTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {            
            switch (SearchTypeComboBox.SelectedItem.ToString())
            {
                case "за ПІБ":
                    SearchTextBox.Visible = true;
                    SearchComboBox.Visible = false;
                    break;
                case "за підрозділом":
                    SearchTextBox.Visible = false;
                    SearchComboBox.Visible = true;
                    List<string> deps = db.GetDepartments();     
                    foreach(var dep in deps)
                    {
                        SearchComboBox.Items.Add(dep);
                    }                    
                    break;

                default:
                    SearchTextBox.Visible = false;
                    SearchComboBox.Visible = false;
                    break;                    
            }
            
        }
        private void resetDataGrif()
        {
            dataGridView1.Rows.Clear();
        }
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            resetDataGrif();
            if (SearchComboBox.Visible == true)
            {
                people = db.GetPeopleByDepartment(SearchComboBox.SelectedItem.ToString());
            }
            else
            {
                people = db.GetPeopleByFullName(SearchTextBox.Text.ToString());
            }
            people.ForEach((elem) =>
            {
                dataGridView1.Rows.Add(elem.FullName, elem.Job, elem.WorkPlace, "Деталі");
                
            });

        }

        private void SearchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 3)
            {
                PersonForm f = new PersonForm(people[e.RowIndex].PersonId);
                this.Hide();
                f.Show();

            }
        }
        private void SearchTypeComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            /*var combo = sender as ComboBox;

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.Yellow), e.Bounds);
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(SystemColors.Window), e.Bounds);
            }
            int index = e.Index >= 0 ? e.Index : 0;
            e.Graphics.DrawString(combo.Items[index].ToString(),
                                          e.Font,
                                          new SolidBrush(Color.Black),
                                          new Point(e.Bounds.X, e.Bounds.Y));
                                          */
        }
    }
}
