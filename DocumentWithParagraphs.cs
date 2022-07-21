using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HourlyManagment
{
    public abstract class DocumentWithParagraphs: IDocument
    {
        protected List<Paragraph> paragraphs;
        protected string number;
        protected string date;
        public void AddParagraph(Paragraph p)
        {
            paragraphs.Add(p);
        }
        public void SetDocNumberDate(string num, string date)
        {
            this.number = num;
            this.date = date;
        }
    }

}
