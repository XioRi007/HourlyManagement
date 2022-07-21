using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;

namespace HourlyManagment
{
    class ExtractDocument: DocumentWithParagraphs
    {
        public ExtractDocument()
        {
            paragraphs = new List<Paragraph>();
            path = Directory.GetCurrentDirectory();
        }
        public override void CreateDocument()
        {
            application = new Word.Application();
            Object _missingObj = System.Reflection.Missing.Value;
            Object _trueObj = true;
            Object _falseObj = false;

            Object templatePathObj = $@"{path}\templates\extract_template.docx";
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
                CopyDocToTheEnd("extract_start");
                paragraphs[i].MakeParagraphs(document, i + 1);
                CopyDocToTheEnd("extract_end");
            }
            FindAndReplace(application, "number", number);
            FindAndReplace(application, "date", date);
            
        }
        private void CopyDocToTheEnd(string name)
        {
            Object templatePathObj = $@"{path}\templates\{name}.docx";
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
        }

    }
}
