using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;

namespace HourlyManagment
{
    public abstract class IDocument
    {
        protected Word._Document document;
        protected Word._Application application;
        protected string path;
        public abstract void CreateDocument();
        public void Save(string name)
        {
            Object _missingObj = System.Reflection.Missing.Value;
            Object pathToSaveObj = name;
            document.SaveAs(ref pathToSaveObj, Word.WdSaveFormat.wdFormatDocument,
                ref _missingObj, ref _missingObj, ref _missingObj, ref _missingObj, ref _missingObj,
                ref _missingObj, ref _missingObj, ref _missingObj, ref _missingObj, ref _missingObj,
                ref _missingObj, ref _missingObj, ref _missingObj, ref _missingObj);
            application.Visible = true;
        }
        protected void FindAndReplace(Microsoft.Office.Interop.Word._Application doc, object findText, object replaceWithText)
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
