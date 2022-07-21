using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HourlyManagment
{
    class Declenser
    {
        private static NameCaseLib.Ua ua = new NameCaseLib.Ua();
        Declenser(){}
        public static NameCaseLib.Gender GetGender(string gender)
        {
            
            NameCaseLib.Gender g = NameCaseLib.Gender.Woman;
            if (gender == "жіноча")
            {
                g = NameCaseLib.Gender.Woman;
            }
            else
            {
                g = NameCaseLib.Gender.Man;
            }
            return g;
        }
        public static string FullNameInDative(string name, string gender)
        {
            NameCaseLib.Gender g = GetGender(gender);
            name = ua.Q(name, NameCaseLib.Padeg.UaDavalnyi, g);
            if (g == NameCaseLib.Gender.Man)
            {
                name = name.Replace("єві", "ю");
                name = name.Replace("еві", "ю");
            }
            
            return name;
        }
        public static string FullNameInGenitive(string name, string gender)
        {
            NameCaseLib.Gender g = GetGender(gender);
            name = ua.Q(name, NameCaseLib.Padeg.UaRodovyi, g);     
            return name;
        }
        public static string FullNameInAkkuzative(string name, string gender)
        {
            NameCaseLib.Gender g = GetGender(gender);
            name = ua.Q(name, NameCaseLib.Padeg.UaZnahidnyi, g);
            return name;
        }
        public static string SpecialInfoInDative(string info)
        {
            info = info.Replace("пенсіонер", "пенсіонеру");
            return info;
        }
        public static string SpecialInfoInAkkuzative(string info)
        {
            info = info.Replace("пенсіонер", "пенсіонера");
            return info;
        }
        public static string RankInAkkuzative(string rank)
        {
            rank = rank + "а";
            return rank;
        }
        public static string DegreeInAkkuzative(string degree)
        {
            degree = degree.Replace("доктор", "доктора");
            degree = degree.Replace("кандидат", "кандидата");
            return degree;
        }
        public static string RankInDative(string rank)
        {
            rank = rank + "у";
            return rank;
        }
        public static string DegreeInDative(string degree)
        {
            degree = degree.Replace("доктор", "доктору");
            degree = degree.Replace("кандидат", "кандидату");
            return degree;
        }
        public static string JobInDative(string posada, string pidrozdil)
        {
            if (posada.IndexOf("кафедри") != -1)
            {
                if(posada.IndexOf("в.о.") != -1)
                {
                    return $"в.о. завідувача " + DepartmentInGenitive(pidrozdil) + ", "+
                        JobInDative(posada.Substring(posada.LastIndexOf(" ")), "");
                }
                else
                {
                    return $"завідувачу " + DepartmentInGenitive(pidrozdil) + ", " +
                        JobInDative(posada.Substring(posada.LastIndexOf(" ")), "");
                }
            }
            string res = "";
            //склоняем должность
            posada = posada.Replace("доцент", "доценту");
            posada = posada.Replace("вчитель", "вчителю");
            posada = posada.Replace("декан", "декану");
            posada = posada.Replace("ректор", "ректору");
            posada = posada.Replace("ректоруа", "ректора");
            posada = posada.Replace("стажист", "стажисту");
            posada = posada.Replace("викладач", "викладачу");
            posada = posada.Replace("асистент", "асистенту");
            posada = posada.Replace("інституту", "");
            posada = posada.Replace("професор", "професору");


            posada = posada.Replace("диспетчер", "диспетчеру");
            posada = posada.Replace("майстер", "майстру");
            posada = posada.Replace("підсобний", "підсобному");
            posada = posada.Replace("робітник", "робітнику");
            posada = posada.Replace("р.", "розряду");
            posada = posada.Replace("столяр", "столяру");
            posada = posada.Replace("швейцар", "швейцару");
            posada = posada.Replace("сторож", "сторожу");
            posada = posada.Replace("двірник", "двірнику");
            posada = posada.Replace("прибиральник", "прибиральнику");
            posada = posada.Replace("водій", "водію");
            posada = posada.Replace("технік", "техніку");
            posada = posada.Replace("черговий", "черговому");
            posada = posada.Replace("електрогазозварник", "електрогазозварнику");
            posada = posada.Replace("електронік", "електроніку");
            posada = posada.Replace("токар", "токарю");
            posada = posada.Replace("маляр", "маляру");
            posada = posada.Replace("столяр", "столяру");
            posada = posada.Replace("електромонтер", "електромонтеру");
            posada = posada.Replace("енергетик", "енергетику");
            posada = posada.Replace("виконавець", "виконавцю");
            posada = posada.Replace("слюсар-сантехнік", "слюсарю-сантехніку");
            posada = posada.Replace("теплотехнік", "теплотехніку");
            posada = posada.Replace("каштелян", "каштеляну");
            posada = posada.Replace("комендант", "коменданту");
            posada = posada.Replace("садівник", "садівнику");
            


            //ндп
            posada = posada.Replace("фахівець", "фахівцю");
            posada = posada.Replace("к.", "категорії");
            posada = posada.Replace("завідувач", "завідувачу");
            posada = posada.Replace("головний", "головному");
            posada = posada.Replace("бухгалтер", "бухгалтеру");
            posada = posada.Replace("економіст", "економісту");
            posada = posada.Replace("провідний", "провідному");
            posada = posada.Replace("інженер", "інженеру");
            posada = posada.Replace("програміст", "програмісту");
            posada = posada.Replace("заступник", "заступнику");
            posada = posada.Replace("начальник", "начальнику");
            posada = posada.Replace("психолог", "психологу");
            posada = posada.Replace("практичний", "практичному");
            posada = posada.Replace("паспортист", "паспортисту");
            posada = posada.Replace("старший", "старшому");
            posada = posada.Replace("інспектор", "інспектору");
            posada = posada.Replace("секретар", "секретарю");
            posada = posada.Replace("друкарка", "друкарці");
            posada = posada.Replace("акомпаніатор", "акомпаніатору");
            posada = posada.Replace("звукооператор", "звукооператору");
            posada = posada.Replace("лаборант", "лаборанту");
            posada = posada.Replace("гуртожитку", "");
            posada = posada.Replace("керівник", "керівнику");
            posada = posada.Replace("помічник", "помічнику");
            posada = posada.Replace("медична сестра", "медичній сестрі");
            posada = posada.Replace("фельдшер", "фельдшеру");
            posada = posada.Replace(" навчальної лабораторії", "");
            posada = posada.Replace(" навчальною лабораторією", "");
            posada = posada.Replace(" навчальними лабораторіями", "");
            posada = posada.Replace("бібліотекар", "бібліотекарю");
            posada = posada.Replace("бібліограф", "бібліографу");
            posada = posada.Replace("директор", "директору");
            posada = posada.Replace("оператор", "оператору");
            posada = posada.Replace("редактор", "редактору");
            posada = posada.Replace("комірник", "комірнику");
            posada = posada.Replace("юрисконсульт", "юрисконсульту");

            //ндч
            posada = posada.Replace("молодший", "молодшому");
            posada = posada.Replace("науковий", "науковому");
            posada = posada.Replace("уу", "у");



            //склоняем место работы
            pidrozdil = DepartmentInGenitive(pidrozdil);

            //результат
            res = posada + " " + pidrozdil;

            return res;
        }
        public static string DepartmentInGenitive(string pidrozdil)
        {
            pidrozdil = pidrozdil.Replace("Адміністративно-господарська частина", "адміністративно-господарської частини");
            pidrozdil = pidrozdil.Replace("чний", "чного");
            pidrozdil = pidrozdil.Replace("предметна екзаменаційна комісія", "предметної екзаменаційної комісії");
            pidrozdil = pidrozdil.Replace("Ректорат", "ректорату");
            pidrozdil = pidrozdil.Replace("керівний склад", "");            
            pidrozdil = pidrozdil.Replace("кафедра", "кафедри");
            pidrozdil = pidrozdil.Replace("Дирекція", "дирекції");
            pidrozdil = pidrozdil.Replace("факультет", "факультету");
            pidrozdil = pidrozdil.Replace("факультетуу", "факультету");
            pidrozdil = pidrozdil.Replace("Відокремлений структурний підрозділ", "Відокремленого структурного підрозділу");
            pidrozdil = pidrozdil.Replace("Біостанція-профілакторій", "біостанції-профілакторію");
            pidrozdil = pidrozdil.Replace("Бюро", "бюро");
            pidrozdil = pidrozdil.Replace("Експлуатаційно", "експлуатаційно");
            pidrozdil = pidrozdil.Replace("Коворкінг", "коворкінг");           
            pidrozdil = pidrozdil.Replace("Відділ", "відділу");
            pidrozdil = pidrozdil.Replace("відділ", "відділу");
            pidrozdil = pidrozdil.Replace("Господарський", "господарського");
            pidrozdil = pidrozdil.Replace("Група", "групи");
            pidrozdil = pidrozdil.Replace("Гуртожиток", "гуртожитку");
            pidrozdil = pidrozdil.Replace("Деканат", "деканату");
            pidrozdil = pidrozdil.Replace("Держбюджетна", "держбюджетної");
            pidrozdil = pidrozdil.Replace("технічний", "технічного");
            pidrozdil = pidrozdil.Replace("центр", "центру");
            pidrozdil = pidrozdil.Replace("Центр", "центру");
            pidrozdil = pidrozdil.Replace("Лабораторія", "лабораторії");
            pidrozdil = pidrozdil.Replace("Медичний", "медичного");
            pidrozdil = pidrozdil.Replace("кабінет", "кабінету");
            pidrozdil = pidrozdil.Replace("Навчальна ", "навчальної ");
            pidrozdil = pidrozdil.Replace("лабораторія", "лабораторії");
            pidrozdil = pidrozdil.Replace("Навчальний", "навчального");
            pidrozdil = pidrozdil.Replace("корпус", "корпусу");
            pidrozdil = pidrozdil.Replace("лабораторний", "лабораторного");
            pidrozdil = pidrozdil.Replace("Навчальні лабораторії", "навчальних лабораторій");
            pidrozdil = pidrozdil.Replace("наукова", "наукової");
            pidrozdil = pidrozdil.Replace("частина", "частини");
            pidrozdil = pidrozdil.Replace("Науково-", "науково-");
            pidrozdil = pidrozdil.Replace("наукової-", "науково-");
            pidrozdil = pidrozdil.Replace("Навчально", "навчально");
            pidrozdil = pidrozdil.Replace("Наукова", "наукової");
            pidrozdil = pidrozdil.Replace("бібліотека", "бібліотеки");
            pidrozdil = pidrozdil.Replace("дослідна", "дослідної");
            pidrozdil = pidrozdil.Replace("Пресслужба", "пресслужби");
            pidrozdil = pidrozdil.Replace("Приймальна комісія", "приймальної комісії");
            pidrozdil = pidrozdil.Replace("інформаційно-виробничий вузол", "інформаційно-виробничого вузлу");
            pidrozdil = pidrozdil.Replace("Регіональний", "регіонального");
            pidrozdil = pidrozdil.Replace("науковоий", "наукового");
            pidrozdil = pidrozdil.Replace("науковий", "наукового");
            pidrozdil = pidrozdil.Replace("оздоровчий", "оздоровчого");
            pidrozdil = pidrozdil.Replace("комплекс", "комплексу");            
            pidrozdil = pidrozdil.Replace("Спортивно", "спортивно");
            pidrozdil = pidrozdil.Replace("Студентське містечко", "Студентського містечка");
            pidrozdil = pidrozdil.Replace("Студентський спортивно-оздоровчий", "Студентського спортивно-оздоровчого");
            pidrozdil = pidrozdil.Replace("Юридичний", "юридичного");
            pidrozdil = pidrozdil.Replace("юридичний", "юридичного");
            pidrozdil = pidrozdil.Replace("уу", "у");
            pidrozdil = pidrozdil.Replace("табір", "табору");
            return pidrozdil;
        }

        public static string DepartmentInLocative(string pidrozdil)
        {            
            pidrozdil = pidrozdil.Replace("кафедра", "на кафедрі");
            pidrozdil = pidrozdil.Replace("Центр", "в центрі");
            pidrozdil = pidrozdil.Replace("Відділ", "у відділі");
            return pidrozdil;
        }
        public static string DepartmentInAkkuzative(string pidrozdil)
        {
            pidrozdil = pidrozdil.Replace("кафедра", "на кафедру");
            pidrozdil = pidrozdil.Replace("Центр", "у центр");
            pidrozdil = pidrozdil.Replace("Відділ", "у відділ");
            pidrozdil = pidrozdil.Replace("Відділ", "у відділ");
            return pidrozdil;
        }

        public static string JobInAkkuzative(string posada, string pidrozdil)
        {
            if (posada.IndexOf("кафедри") != -1)
            {
                if (posada.IndexOf("в.о.") != -1)
                {
                    return $"в.о. завідувача " + DepartmentInGenitive(pidrozdil) +
                        JobInAkkuzative(posada.Substring(posada.LastIndexOf(" ") + 1), "");
                }
                else
                {
                    return $"завідувача " + DepartmentInGenitive(pidrozdil) +
                        JobInAkkuzative(posada.Substring(posada.LastIndexOf(" ") + 1), "");
                }
            }
            string res = "";
            //склоняем должность
            posada = posada.Replace("доцент", "доцента");
            posada = posada.Replace("вчитель", "вчителя");
            posada = posada.Replace("декан", "декана");
            posada = posada.Replace("стажист", "стажиста");
            posada = posada.Replace("ректор", "ректора");
            posada = posada.Replace("ректораа", "ректора");
            posada = posada.Replace("викладач", "викладача");
            posada = posada.Replace("асистент", "асистента");
            posada = posada.Replace("інституту", "");
            posada = posada.Replace("професор", "професора");
            posada = posada.Replace("член", "члена");
            posada = posada.Replace("голова", "голови");

            posada = posada.Replace("диспетчер", "диспетчера");
            posada = posada.Replace("майстер", "майстра");
            posada = posada.Replace("підсобний", "підсобного");
            posada = posada.Replace("робітник", "робітника");
            posada = posada.Replace("р.", "розряду");
            posada = posada.Replace("столяр", "столяра");
            posada = posada.Replace("швейцар", "швейцара");
            posada = posada.Replace("сторож", "сторожа");
            posada = posada.Replace("двірник", "двірника");
            posada = posada.Replace("прибиральник", "прибиральника");
            posada = posada.Replace("водій", "водія");
            posada = posada.Replace("технік", "техніка");
            posada = posada.Replace("черговий", "чергового");
            posada = posada.Replace("електрогазозварник", "електрогазозварника");
            posada = posada.Replace("електронік", "електроніка");
            posada = posada.Replace("токар", "токаря");
            posada = posada.Replace("маляр", "маляра");
            posada = posada.Replace("столяр", "столяра");
            posada = posada.Replace("електромонтер", "електромонтера");
            posada = posada.Replace("енергетик", "енергетика");
            posada = posada.Replace("виконавець", "виконавця");
            posada = posada.Replace("слюсар-сантехнік", "слюсаря-сантехніка");
            posada = posada.Replace("теплотехнік", "теплотехніка");
            posada = posada.Replace("каштелян", "каштеляна");
            posada = posada.Replace("комендант", "коменданта");
            posada = posada.Replace("садівник", "садівника");



            //ндп
            posada = posada.Replace("фахівець", "фахівця");
            posada = posada.Replace("к.", "категорії");
            posada = posada.Replace("завідувач", "завідувача");
            posada = posada.Replace("головний", "головного");
            posada = posada.Replace("бухгалтер", "бухгалтера");
            posada = posada.Replace("економіст", "економіста");
            posada = posada.Replace("провідний", "провідного");
            posada = posada.Replace("інженер", "інженера");
            posada = posada.Replace("програміст", "програміста");
            posada = posada.Replace("заступник", "заступника");
            posada = posada.Replace("начальник", "начальника");
            posada = posada.Replace("психолог", "психолога");
            posada = posada.Replace("практичний", "практичного");
            posada = posada.Replace("паспортист", "паспортиста");
            posada = posada.Replace("старший", "старшого");
            posada = posada.Replace("інспектор", "інспектора");
            posada = posada.Replace("секретар", "секретаря");
            posada = posada.Replace("друкарка", "друкарки");
            posada = posada.Replace("акомпаніатор", "акомпаніатора");
            posada = posada.Replace("звукооператор", "звукооператора");
            posada = posada.Replace("лаборант", "лаборанта");
            posada = posada.Replace("керівник", "керівника");
            posada = posada.Replace("помічник", "помічника");
            posada = posada.Replace("медична сестра", "медичної сестри");
            posada = posada.Replace("фельдшер", "фельдшера");
            posada = posada.Replace(" навчальної лабораторії", "");
            posada = posada.Replace(" навчальними лабораторіями", "");
            posada = posada.Replace("бібліотекар", "бібліотекаря");
            posada = posada.Replace("бібліограф", "бібліографа");
            posada = posada.Replace("оператор", "оператора");
            posada = posada.Replace("редактор", "редактора");
            posada = posada.Replace("комірник", "комірника");
            posada = posada.Replace("юрисконсульт", "юрисконсульта");


            //ндч
            posada = posada.Replace("молодший", "молодшого");
            posada = posada.Replace("науковий", "наукового");
            posada = posada.Replace("співробітник", "співробітника");


            //склоняем место работы
            pidrozdil = DepartmentInGenitive(pidrozdil);

            //результат
            res = posada + " " + pidrozdil;

            return res;
        }

    }
}
