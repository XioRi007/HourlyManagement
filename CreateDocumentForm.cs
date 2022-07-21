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
    public partial class CreateDocumentForm : Form
    {
        List<Tuple<string, string>> docs;
        Database db;
        
        public CreateDocumentForm()
        {
            InitializeComponent();
            db = Database.GetDatabase();
            docs = db.GetDocuments();
            foreach (var doc in docs)
            {
                DocumentComboBox.Items.Add(doc.Item1+" від "+doc.Item2);
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                
                Tuple<string, string> d = docs[DocumentComboBox.SelectedIndex];
                List<Person> ls = db.GetPeopleByDocument(d.Item1, d.Item2);
                OrderDocument doc = new OrderDocument();
                ExtractDocument extract = new ExtractDocument();
                HourlyParagraphFabric fabric = new HourlyParagraphFabric();
                ls.ForEach((p) =>
                {
                    doc.AddParagraph(fabric.GetParagraph(p));
                    extract.AddParagraph(fabric.GetParagraph(p));
                });
                doc.SetDocNumberDate(d.Item1, d.Item2);
                extract.SetDocNumberDate(d.Item1, d.Item2);
                doc.CreateDocument();
                extract.CreateDocument();
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Word document|*.doc";
                saveFileDialog1.Title = "Зберегти наказ";
                saveFileDialog1.FileName = d.Item1 + " від " + d.Item2;
                if (DialogResult.OK == saveFileDialog1.ShowDialog())
                {
                    string docName = saveFileDialog1.FileName;
                    if (docName.Length > 0)
                    {
                        doc.Save(docName);
                        extract.Save("extracts");
                    }
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, "Помилка");
            }
        }

        private void CreateDocumentForm_Load(object sender, EventArgs e)
        {
            submitBtn.BackColor = Color.White;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(
                this.ClientSize.Width / 2 - this.tableLayoutPanel1.Size.Width / 2,
                this.ClientSize.Height / 2 - this.tableLayoutPanel1.Size.Height / 2);

        }

        private void DocumentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
