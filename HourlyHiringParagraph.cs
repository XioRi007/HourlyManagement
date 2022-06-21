using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;
using Word =  Microsoft.Office.Interop.Word;

namespace HourlyManagment
{
    public class HourlyHiringParagraph:Paragraph
    {        
        public HourlyHiringParagraph(Person p)
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
            string res = "";
            if (p.IsForeign)
            {
                res += FormatNameRankDegreeJobInAkkuzative() +
                $"прийняти з {p.assignments[0].DateFrom} по {p.assignments[0].DateTo} на ";
            }
            else
            {
                res += FormatNameRankDegreeJobInDative() +
                $"дозволити з {p.assignments[0].DateFrom} по {p.assignments[0].DateTo} ";
                
            }
            res+= $"роботу ";
            if (p.assignments[0].Job != "")
            {
                if (p.assignments[0].Department == "предметна екзаменаційна комісія")
                {
                    res += $"в якості {Declenser.JobInAkkuzative(p.assignments[0].Job, p.assignments[0].Department)} ";
                }
                else
                {
                    res += $"на посаді {Declenser.JobInAkkuzative(p.assignments[0].Job, p.assignments[0].Department)} ";
                }                
            }
            else
            {
                res += $"на {Declenser.DepartmentInLocative(p.assignments[0].Department)} ";
            }
            res += $"для {p.assignments[0].Purpose} на умовах погодинної оплати праці " +
                    $"в обсязі {p.assignments[0].Hours} годин.";



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
