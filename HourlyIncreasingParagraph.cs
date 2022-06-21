using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;
using Word =  Microsoft.Office.Interop.Word;

namespace HourlyManagment
{
    public class HourlyChangeHoursParagraph : Paragraph
    {
        private bool increase;
        public HourlyChangeHoursParagraph(Person p, bool increase)
        {
            this.p = p;
            this.increase = increase;
        }
        public override void MakeParagraphs(Word._Document document, int num)
        {
            this.document = document;
            this.num = num;
            MakeNum();
            MakeChange();
            MakeText();
            MakeMemoReason();
        }

        protected override void MakeText()
        {
            string res = FormatNameRankDegreeJobInDative();
            if (p.Gender == "жіноча")
            {
                res += "працюючій на умовах погодинної оплати праці ";
            }
            else
            {
                res += "працюючому на умовах погодинної оплати праці ";
            }                            
            if (p.assignments[0].Job != "")
            {
                res += $"на посаді {Declenser.JobInAkkuzative(p.assignments[0].Job, p.assignments[0].Department)}";
            }
            else
            {
                res += $"на {Declenser.DepartmentInLocative(p.assignments[0].Department)}";
            }
            if (increase)
            {
                res += $", збільшити ";
            }
            else
            {
                res += $", зменшити ";
            }
            res +=$"кількість годин за погодинним фондом " +
                $"до {p.assignments[0].Hours} годин, у зв’язку з виробничою необхідністю.";



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
