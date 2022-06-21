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
    public partial class PersonForm : Form
    {
        private int PersonId;
        private Person person;
        private Database db;
        
        public PersonForm(int PersonId)
        {
            InitializeComponent();
            this.PersonId = PersonId;
            db = Database.GetDatabase();
            DeleteBtn.BackColor = Color.White;
            EditBtn.BackColor = Color.White;
            AddAssignmentBtn.BackColor = Color.White;
        }


        private void PersonForm_Load(object sender, EventArgs e)
        {
            /*for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var cell = ((DataGridViewButtonCell)dataGridView1.Rows[i].Cells[9]);
                cell.FlatStyle = FlatStyle.Flat;
                dataGridView1.Rows[i].Cells[9].Style.BackColor = Color.White;

                cell = ((DataGridViewButtonCell)dataGridView1.Rows[i].Cells[10]);
                cell.FlatStyle = FlatStyle.Flat;
                dataGridView1.Rows[i].Cells[10].Style.BackColor = Color.White;

                cell = ((DataGridViewButtonCell)dataGridView1.Rows[i].Cells[11]);
                cell.FlatStyle = FlatStyle.Flat;
                dataGridView1.Rows[i].Cells[11].Style.BackColor = Color.White;
            }*/
            try
            {
                person = db.GetPersonById(PersonId);
                FullNameTextBox.Text = person.FullName;
                JobTextBox.Text = person.Job;
                WorkPlaceTextBox.Text = person.WorkPlace;
                DegreeTextBox.Text = person.Degree;
                RankTextBox.Text = person.Rank;
                GenderTextBox.Text = person.Gender;
                SpecialInfoTextBox.Text = person.SpecialInfo;
                
                if (person.IsForeign) checkBox1.CheckState = CheckState.Checked;
                if(person.assignments != null)
                {
                    person.assignments.ForEach((a) =>
                    {
                        dataGridView1.Rows.Add(a.Type, a.DateFrom, 
                                                a.DateTo, a.Job, a.Department, a.Purpose, 
                                                a.Hours, a.DocumentNumber, a.DocumentDate.Substring(0, 10));
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка");
            }
        }

        private void PersonForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            int idx = 0;
            if(Application.OpenForms.Count == 1)
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

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {            
            if (e.RowIndex < 0)
                return;
            int w = 30, h = 30;
            

            if (e.ColumnIndex == 9)
            {
                var cell = ((DataGridViewButtonCell)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex]);
                cell.FlatStyle = FlatStyle.Flat;
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                //e.Graphics.DrawImage(Properties.Resources.ChangeImage, new Rectangle(x, y, w, h));
                e.Graphics.DrawImage(Properties.Resources.ChangeImage, new Rectangle(x, y, w, h));
                e.Handled = true;
            }

            if (e.ColumnIndex == 10)
            {
                var cell = ((DataGridViewButtonCell)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex]);
                cell.FlatStyle = FlatStyle.Flat;
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.EditImage, new Rectangle(x, y, w,h));
                e.Handled = true;
            }
            if (e.ColumnIndex == 11)
            {
                var cell = ((DataGridViewButtonCell)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex]);
                cell.FlatStyle = FlatStyle.Flat;
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.DeleteImage, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //change
            if(e.ColumnIndex == 9)
            {
                Form f = new AddAsignmentForm(PersonId, person.assignments[e.RowIndex]);
                f.Show();
            }

            //edit
            if (e.ColumnIndex == 10)
            {
                Form f = new EditAsignmentForm(PersonId, person.assignments[e.RowIndex]);
                f.Show();
            }

            //delete
            if (e.ColumnIndex == 11)
            {
                DialogResult res = MessageBox.Show("Ви дійсно хочете видалити призначення?", "Підтвердження", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    db.DeleteAssignment(person.assignments[e.RowIndex].AssignmentId);
                    this.Close();
                    Form frm = Application.OpenForms["SearchForm"];
                    frm.Hide();
                    frm = new PersonForm(PersonId);
                    frm.Show();                    
                }
                if (res == DialogResult.Cancel)
                {

                }
            }
        }

        private void AddAssignmentBtn_Click(object sender, EventArgs e)
        {
            AddAsignmentForm f = new AddAsignmentForm(PersonId);
            f.Show();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Ви дійсно хочете видалити працівника?", "Підтвердження", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                db.DeletePerson(PersonId);
                this.Close();
                Form frm = Application.OpenForms["SearchForm"];
                frm.Show();
            }
            if (res == DialogResult.Cancel)
            {

            }
            
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            Form f = new EditPersonForm(person);
            f.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (e.ColumnIndex == 9 || e.ColumnIndex == 10 || e.ColumnIndex == 11)
            {
                var cell = ((DataGridViewButtonCell)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex]);
                cell.FlatStyle = FlatStyle.Flat;
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
            }            
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (e.ColumnIndex == 9 || e.ColumnIndex == 10 || e.ColumnIndex == 11)
            {
                var cell = ((DataGridViewButtonCell)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex]);
                cell.FlatStyle = FlatStyle.Flat;
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
            }
        }
    }
}
