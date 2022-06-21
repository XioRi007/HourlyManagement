using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;
using Word =  Microsoft.Office.Interop.Word;

namespace HourlyManagment
{
    public class HourlyFiringParagraph : Paragraph
    {        
        public HourlyFiringParagraph(Person p)
        {
            this.p = p;
        }
        public override void MakeParagraphs(Word._Document document, int num)
        {
            this.document = document;
            this.num = num;
            MakeNum();
            MakeText();
            MakePersonReason();
        }

        protected override void MakeText()
        {
            string res = FormatNameRankDegreeJobInAkkuzative();            

            if (p.Gender == "жіноча")
            {
                res += "працюючу на умовах погодинної оплати праці ";
            }
            else
            {
                res += "працюючого на умовах погодинної оплати праці ";
            }
            if (p.assignments[0].Job != "")
            {
                res += $"на посаді {Declenser.JobInAkkuzative(p.assignments[0].Job, p.assignments[0].Department)} ";
            }
            else
            {
                res += $"на {Declenser.DepartmentInLocative(p.assignments[0].Department)} для {p.assignments[0].Purpose}, ";
            }
            res += $"звільнити {p.assignments[0].DateTo} з умов погодинної оплати праці за власним бажанням, ст. 38 КЗпП України.";



            Word.Paragraph wordParag1 = document.Paragraphs.Add(Type.Missing);
            wordParag1.Format.FirstLineIndent = 35F;
            wordParag1.Range.Font.Name = "Times New Roman";
            wordParag1.Range.Font.Size = 13;
            wordParag1.Range.ParagraphFormat.LineUnitAfter = 0.1F;
            wordParag1.Range.ParagraphFormat.LineUnitBefore = 0.1F;
            wordParag1.Range.ParagraphFormat.LineSpacingRule = Word.WdLineSpacing.wdLineSpaceSingle;
            wordParag1.Range.Font.Bold = 0;
            wordParag1.Range.Text = res;
            wordParag1.Range.Paragraphs.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphJustify;
            document.Paragraphs.Add(Type.Missing).Format.FirstLineIndent = 35F;
        }
    }
}
