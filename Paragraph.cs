using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;
using Word = Microsoft.Office.Interop.Word;
namespace HourlyManagment
{
    public abstract class Paragraph:IComparable<Paragraph>
    {
        protected Person p;
        protected Word._Document document;
        protected int num;
        public abstract void MakeParagraphs(Word._Document document, int num);
        protected abstract void MakeText();
        protected void MakeNum()
        {
            Word.Paragraph wordParag = document.Paragraphs.Add(Type.Missing);
            wordParag.Range.Font.Name = "Times New Roman";
            wordParag.Range.Font.Size = 13;
            wordParag.Range.Font.Bold = 0;
            wordParag.Range.Text = "§" + num;
            wordParag.Range.ParagraphFormat.LineUnitAfter = 0.1F;
            wordParag.Range.ParagraphFormat.LineUnitBefore = 0.1F;
            wordParag.Range.ParagraphFormat.LineSpacingRule = Word.WdLineSpacing.wdLineSpaceSingle;
            wordParag.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            document.Paragraphs.Add(Type.Missing);
        }
        protected void MakePersonReason()
        {
            string res = "";
            string name = Declenser.FullNameInGenitive(p.FullName, p.Gender);
            string[] words = name.Split(' ');

            res = "Підстава: заява " + words[0] + " " + words[1][0] + "." + words[2][0] + ".";
            Word.Paragraph wordPara2 = document.Paragraphs.Add(Type.Missing);
            wordPara2.Format.FirstLineIndent = 35F;
            wordPara2.Range.ParagraphFormat.LineUnitAfter = 0.1F;
            wordPara2.Range.ParagraphFormat.LineUnitBefore = 0.1F;
            wordPara2.Range.ParagraphFormat.LineSpacingRule = Word.WdLineSpacing.wdLineSpaceSingle;
            wordPara2.Range.Font.Name = "Times New Roman";
            wordPara2.Range.Font.Size = 13;
            wordPara2.Range.Font.Bold = 0;
            wordPara2.Range.Text = res;
            wordPara2.Range.Paragraphs.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
            document.Paragraphs.Add(Type.Missing).Format.FirstLineIndent = 35F;
            document.Paragraphs.Add(Type.Missing).Format.FirstLineIndent = 35F;
        }
        protected void MakeMemoReason()
        {
            string res = "";
            res = "Підстава: доповідна записка проректора з науково-педагогічної та навчальної  роботи Гури О.І.";
            Word.Paragraph wordPara2 = document.Paragraphs.Add(Type.Missing);
            wordPara2.Format.LeftIndent = 35F;
            wordPara2.Range.ParagraphFormat.LineUnitAfter = 0.1F;
            wordPara2.Range.ParagraphFormat.LineUnitBefore = 0.1F;
            wordPara2.Range.ParagraphFormat.LineSpacingRule = Word.WdLineSpacing.wdLineSpaceSingle;
            wordPara2.Range.Font.Name = "Times New Roman";
            wordPara2.Range.Font.Size = 13;
            wordPara2.Range.Font.Bold = 0;
            wordPara2.Range.Text = res;
            wordPara2.Range.Paragraphs.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphJustify;
            document.Paragraphs.Add(Type.Missing).Format.LeftIndent = 35F;
            document.Paragraphs.Add(Type.Missing).Format.LeftIndent = 35F;
        }
        protected void MakeChange()
        {
            string res = "";
            res = "На часткову зміну § наказу № -к від :";
            Word.Paragraph wordPara2 = document.Paragraphs.Add(Type.Missing);
            wordPara2.Format.LeftIndent = 35F;
            wordPara2.Range.ParagraphFormat.LineUnitAfter = 0.1F;
            wordPara2.Range.ParagraphFormat.LineUnitBefore = 0.1F;
            wordPara2.Range.ParagraphFormat.LineSpacingRule = Word.WdLineSpacing.wdLineSpaceSingle;
            wordPara2.Range.Font.Name = "Times New Roman";
            wordPara2.Range.Font.Size = 13;
            wordPara2.Range.Font.Bold = 0;
            wordPara2.Range.Text = res;
            wordPara2.Range.Paragraphs.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphJustify;
            document.Paragraphs.Add(Type.Missing).Format.LeftIndent = 35F;
        }
        protected string FormatName(string name)
        {
            int idx = name.IndexOf(" ");
            name = name.Substring(0, idx).ToUpper() + name.Substring(idx);
            return name;
        }
        protected string FormatForeignInAkkuzative()
        {
            string res = "";
            if (p.IsForeign)
            {
                if (p.SpecialInfo != "")
                {
                    res += Declenser.SpecialInfoInAkkuzative(p.SpecialInfo) + ", ";
                }
                if (p.Rank != " " || p.Degree != "")
                {
                    if (p.Degree != "")
                    {
                        res += Declenser.DegreeInAkkuzative(p.Degree);
                    }
                    if (p.Rank != " ")
                    {
                        res += ", " + Declenser.RankInAkkuzative(p.Rank);
                    }
                    res += ", ";
                }
            }
            return res;
        }
        protected string FormatForeignInDative()
        {
            string res = "";            
            if (p.IsForeign)
            {
                if (p.SpecialInfo != "")
                {
                    res += Declenser.SpecialInfoInDative(p.SpecialInfo) + ", ";
                }
                if (p.Degree != "")
                {
                    res += Declenser.DegreeInDative(p.Degree);
                }
                if (p.Rank != " ")
                {
                    res += ", " + Declenser.RankInDative(p.Rank);
                }
                res += ", ";
            }
            return res;
        }
        protected string FormatNameRankDegreeJobInAkkuzative()
        {
            string res = $"{FormatName(Declenser.FullNameInAkkuzative(p.FullName, p.Gender))}, ";
            res += FormatForeignInAkkuzative();
            res += $"{Declenser.JobInAkkuzative(p.Job, p.WorkPlace)}, ";
            return res;
        }

        protected string FormatNameRankDegreeJobInDative()
        {
            string res = $"{FormatName(Declenser.FullNameInDative(p.FullName, p.Gender))}, ";
            res += FormatForeignInDative();
            res += $"{Declenser.JobInDative(p.Job, p.WorkPlace)}, ";
            return res;
        }


        public int CompareTo(Paragraph other)
        {
            return p.FullName.CompareTo(other.p.FullName);
        }
    }
}
