using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace HourlyManagment
{
    public class Document
    {
        private List<Paragraph> paragraphs;
        private Word._Document document;
        private Word._Application application;
        private string path;
        public Document()
        {
            paragraphs = new List<Paragraph>();
            path = Directory.GetCurrentDirectory();
        }
        public void AddParagraph(Paragraph p)
        {
            paragraphs.Add(p);
        }
        public void CreateDocument()
        {
            application = new Word.Application();
            Object _missingObj = System.Reflection.Missing.Value;
            Object _trueObj = true;
            Object _falseObj = false;

            Object templatePathObj = $@"{path}\templates\templat.docx";
            try
            {
                document = application.Documents.Add(ref templatePathObj, ref _missingObj, ref _missingObj, ref _missingObj);
            }
            catch (Exception error)
            {
                application.Quit(ref _missingObj, ref _missingObj, ref _missingObj);
                document = null;
                application = null;
                throw error;
            }
            paragraphs.Sort();
            int n = paragraphs.Count;
            for (int i = 0; i < n; i++)
            {
                paragraphs[i].MakeParagraphs(document, i+1);
            }           
        }
        public void SetDocNumberDate(string num, string date)
        {
            FindAndReplace(application, "number", num);
            FindAndReplace(application, "date", date);
        }
        public void Save(string name)
        {
            Object templatePathObj = $@"{path}\templates\templat2.docx";
            Object _missingObj = System.Reflection.Missing.Value;
            //копируем нижнюю часть с подписями
            Word._Document document2 = application.Documents.Add(ref templatePathObj, 
                                                                ref _missingObj, ref _missingObj, ref _missingObj);
            object start = document2.Content.Start;
            object end = document2.Content.End;
            document2.Range(ref start, ref end).Copy();
            document2.Close();
            application.ActiveDocument.Characters.Last.Select();  
            application.Selection.Collapse();
            application.Selection.Paste();
            //сохраняем
            Object pathToSaveObj = name;
            document.SaveAs(ref pathToSaveObj, Word.WdSaveFormat.wdFormatDocument,
                ref _missingObj, ref _missingObj, ref _missingObj, ref _missingObj, ref _missingObj,
                ref _missingObj, ref _missingObj, ref _missingObj, ref _missingObj, ref _missingObj,
                ref _missingObj, ref _missingObj, ref _missingObj, ref _missingObj);
            application.Visible = true;
        }
        private void FindAndReplace(Microsoft.Office.Interop.Word._Application doc, object findText, object replaceWithText)
        {
            //options
            object matchCase = false;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundsLike = false;
            object matchAllWordForms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiacritics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;
            //execute find and replace
            doc.Selection.Find.Execute(ref findText, ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundsLike, ref matchAllWordForms, ref forward, ref wrap, ref format, ref replaceWithText, ref replace,
                ref matchKashida, ref matchDiacritics, ref matchAlefHamza, ref matchControl);
        }
    }
}
