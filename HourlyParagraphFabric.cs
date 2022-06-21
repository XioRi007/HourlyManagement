using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HourlyManagment
{
    public class HourlyParagraphFabric
    {
        public HourlyParagraphFabric() { }

        public Paragraph GetParagraph(Person p)
        {
            switch (p.assignments[0].Type)
            {
                case "прийом":
                    return new HourlyHiringParagraph(p);
                case "збільшення":
                    return new HourlyChangeHoursParagraph(p, true);
                case "зменшення":
                    return new HourlyChangeHoursParagraph(p, false);
                case "звільнення":
                    return new HourlyFiringParagraph(p);
                case "продовження":
                    return new HourlyExtensionParagraph(p);
                default:
                    return new HourlyHiringParagraph(p);
            }
        }
    }
}
