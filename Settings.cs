using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HourlyManagment
{
    public static class Settings
    {
        //<summary>
        //Чи ректор на зараз має право першого підпису
        //</summary>
        public static bool isRector { get; set; } = true;

        //<summary>
        //Чи підписує витяги начальниця відділу кадрів
        //</summary>
        public static bool isChief { get; set; } = true;

        //<summary>
        //Чи на данний час є шаблон для створення призначення
        //</summary>
        public static bool isTemplate { get; set; } = false;

        //<summary>
        //Шаблон для створення призначення
        //</summary>
        public static Template template { get; set; }

        //<summary>
        //Чи ректор на зараз має право першого підпису
        //</summary>
        public static double fontSize { get; set; } = 13;
        public static string font { get; set; } = "Times New Roman";

        public class Template
        {
            //<summary>
            //Тип
            //</summary>
            public string Type { get; set; } = "прийом";

            //<summary>
            //Дата з
            //</summary>
            public string DateFrom { get; set; }

            //<summary>
            //Дата до
            //</summary>
            public string DateTo { get; set; }
            //<summary>
            //Посада
            //</summary>
            public string Job { get; set; }

            //<summary>
            //Місце призначення
            //</summary>
            public string Department { get; set; }

            //<summary>
            //Кількість годин
            //</summary>
            public float Hours { get; set; }

            //<summary>
            //Ціль
            //</summary>
            public string Purpose { get; set; }

            //<summary>
            //Номер наказу
            //</summary>
            public string DocumentNumber { get; set; }

            //<summary>
            //Дата наказу
            //</summary>
            public string DocumentDate { get; set; }
                       
        }
    }
}
