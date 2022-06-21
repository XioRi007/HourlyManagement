using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HourlyManagment
{    
     public class Database
    {
        private string connectionString;
        private OleDbConnection dbConnection;
        private static Database _instance;
        private Database() {
            connectionString = $@"provider=Microsoft.Jet.OLEDB.4.0;Data Source={Directory.GetCurrentDirectory()}\db\HourlyWorkers.mdb";//строка соеденения;
            dbConnection = new OleDbConnection(connectionString);
            dbConnection.Open();
        }
        ~Database()
        {
            dbConnection.Close();
        }
        public static Database GetDatabase()
        {
            if (_instance == null)
            {
                _instance = new Database();
            }
            return _instance;
        }
        

        public List<Tuple<string, string>> GetDocuments()
        {
            OleDbDataReader dbReader;            
            string query = "SELECT DISTINCT Assignment.DocumentNumber, Assignment.DocumentDate FROM Assignment " +
                "ORDER BY Assignment.DocumentDate DESC, Assignment.DocumentNumber DESC;";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection); 
            dbReader = dbCommand.ExecuteReader();                           
            List <Tuple<string, string>> res = new List<Tuple<string, string>>();
            // Проверяем данные
            if (dbReader.HasRows == false)
            {
                throw new Exception("Дані не знайдено!");
            }
            else
            {
                while (dbReader.Read())
                {
                    res.Add(Tuple.Create(dbReader["DocumentNumber"].ToString(), 
                        dbReader["DocumentDate"].ToString().Substring(0, 10)));
                }
            }
            dbReader.Close();
            return res;
        }
        public List<string> GetDepartments()
        {
            OleDbDataReader dbReader;
            string query = "SELECT Department.DepartmentName FROM Department ORDER BY Department.DepartmentName ASC;";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
            dbReader = dbCommand.ExecuteReader();
            List<string> ls = new List<string>();
            // Проверяем данные
            if (dbReader.HasRows == false)
            {
                throw new Exception("Дані не знайдено!");
            }
            else
            {
                while (dbReader.Read())
                {
                    ls.Add(dbReader["DepartmentName"].ToString());
                }
            }
            dbReader.Close();
            return ls;
        }
        public List<Person> GetPeopleByDepartment(string department)
        {
            
            OleDbDataReader dbReader;
            List<Person> res = new List<Person>();
            string query = $"SELECT * FROM AllAssignments WHERE DepartmentName='{department}' " +
                             $"ORDER BY AllAssignments.FullName ASC;";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection); // команда
            dbReader = dbCommand.ExecuteReader();     
            // Проверяем данные
            if (dbReader.HasRows == false)
            {
                throw new Exception("Дані не знайдено!");
            }
            else
            {
                while (dbReader.Read())
                {
                    res.Add(new Person( 
                        dbReader["FullName"].ToString(),
                        dbReader["MainJob"].ToString(), dbReader["WorkPlace"].ToString(),
                        dbReader["Rank"].ToString(), dbReader["Degree"].ToString(),
                        dbReader["SpecialInfo"].ToString(), dbReader["Gender"].ToString(), 
                        (dbReader["IsForeign"].ToString() == "True" ? true:false),
                        Convert.ToInt32(dbReader["PersonId"])));
                }

            }
            dbReader.Close();
            
            return res;
        }

        public List<Person> GetPeopleByFullName(string name)
        {
            List<Person> res = new List<Person>();
            OleDbDataReader dbReader;
            string query = $"SELECT * FROM Person WHERE (((Person.FullName) Like '%{name}%')) " +
                $"ORDER BY Person.FullName ASC;";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection); // команда
            dbReader = dbCommand.ExecuteReader();
            // Проверяем данные
            if (dbReader.HasRows == false)
            {
                throw new Exception("Дані не знайдено!");
            }
            else
            {
                while (dbReader.Read())
                {
                    res.Add(new Person(
                        dbReader["FullName"].ToString(),
                        dbReader["Job"].ToString(), dbReader["WorkPlace"].ToString(),
                        dbReader["Rank"].ToString(), dbReader["Degree"].ToString(),
                        dbReader["SpecialInfo"].ToString(), dbReader["Gender"].ToString(),
                        (dbReader["IsForeign"].ToString() == "True" ? true : false),
                        Convert.ToInt32(dbReader["PersonId"])));
                }

            }
            dbReader.Close();
            
            return res;
        }

        public List<Person> GetPeopleByDocument(string docNumber, string docDate)
        {
            List<Person> res = new List<Person>();
            OleDbDataReader dbReader;
            string query = $"SELECT * FROM AllAssignments WHERE (((AllAssignments.DocumentNumber)=\"{docNumber}\") AND " +
                $"((AllAssignments.DocumentDate) like \"{docDate}\")) ORDER BY AllAssignments.FullName ASC;";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection); // команда
            dbReader = dbCommand.ExecuteReader();
            // Проверяем данные
            if (dbReader.HasRows == false)
            {
                throw new Exception("Дані не знайдено!");
            }
            else
            {
                int i = 0;
                while (dbReader.Read())
                {
                    res.Add(new Person(
                        dbReader["FullName"].ToString(),
                        dbReader["MainJob"].ToString(), dbReader["WorkPlace"].ToString(),
                        dbReader["Rank"].ToString(), dbReader["Degree"].ToString(),
                        dbReader["SpecialInfo"].ToString(), dbReader["Gender"].ToString(),
                        (dbReader["IsForeign"].ToString() == "True" ? true : false),
                        Convert.ToInt32(dbReader["PersonId"])));

                    res[i].AddAssignment( new Assignment( dbReader["Type"].ToString(),
                        dbReader["Job"].ToString(), dbReader["DepartmentName"].ToString(), dbReader["Purpose"].ToString(),
                        dbReader["DateFrom"].ToString().Substring(0, 10), dbReader["DateTo"].ToString().Substring(0, 10),
                        (float)Convert.ToDouble(dbReader["Hours"]), dbReader["DocumentNumber"].ToString(),
                        dbReader["DocumentDate"].ToString().Substring(0, 10), Convert.ToInt32(dbReader["AssignmentId"])));
                    i++;
                }

            }
            dbReader.Close();
            
            return res;
        }

        public Person GetPersonById(int id)
        {
            Person res = new Person();
            
            OleDbDataReader dbReader;
            string query = $"SELECT * FROM Person WHERE (((Person.PersonId) ={id}));";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection); // команда
            dbReader = dbCommand.ExecuteReader();
            // Проверяем данные
            if (dbReader.HasRows == false)
            {
                throw new Exception("Дані не знайдено!");
            }
            else
            {
                while (dbReader.Read())
                {
                    res = new Person(
                        dbReader["FullName"].ToString(),
                        dbReader["Job"].ToString(), dbReader["WorkPlace"].ToString(),
                        dbReader["Rank"].ToString(), dbReader["Degree"].ToString(),
                        dbReader["SpecialInfo"].ToString(), dbReader["Gender"].ToString(),
                        (dbReader["IsForeign"].ToString() == "True" ? true : false),
                        Convert.ToInt32(dbReader["PersonId"]));
                }

            }
            dbReader.Close();

            query = $"SELECT * FROM AllAssignments WHERE (((AllAssignments.PersonId) ={id}));";
            dbCommand = new OleDbCommand(query, dbConnection); // команда
            dbReader = dbCommand.ExecuteReader();
            // Проверяем данные
            if (dbReader.HasRows == false)
            {
                //throw new Exception("Дані не знайдено!");
            }
            else
            {
                while (dbReader.Read())
                {
                    res.AddAssignment(new Assignment( dbReader["Type"].ToString(), 
                        dbReader["Job"].ToString(),dbReader["DepartmentName"].ToString(), dbReader["Purpose"].ToString(), 
                        dbReader["DateFrom"].ToString().Substring(0, 10), dbReader["DateTo"].ToString().Substring(0, 10), 
                        (float)Convert.ToDouble(dbReader["Hours"]), dbReader["DocumentNumber"].ToString(), 
                        dbReader["DocumentDate"].ToString().Substring(0, 10), Convert.ToInt32(dbReader["AssignmentId"])));
                }

            }
            dbReader.Close();

            
            return res;
        }

        public List<string> GetPurposes()
        {
            
            OleDbDataReader dbReader;
            List<string> res = new List<string>();
            string query = $"SELECT * FROM Purposes;";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection); // команда
            dbReader = dbCommand.ExecuteReader();
            // Проверяем данные
            if (dbReader.HasRows == false)
            {
                throw new Exception("Дані не знайдено!");
            }
            else
            {
                while (dbReader.Read())
                {
                    res.Add(dbReader["Purpose"].ToString());
                }

            }
            dbReader.Close();
            
            return res;
        }

        public void AddAssignment(int PersonId, Assignment a)
        {
            string query = $"INSERT INTO Assignment (PersonId, Type, Job, " +
            $"DepartmentId, Purpose, DateFrom, DateTo, Hours, DocumentNumber, DocumentDate) " +
            $"VALUES ({PersonId}, '{a.Type}','{a.Job}', DMin(\"DepartmentId\", \"Department\", \"DepartmentName='{a.Department}'\")," +
            $"'{a.Purpose}','{a.DateFrom}','{a.DateTo}'," +
            $"{a.Hours},'{a.DocumentNumber}','{a.DocumentDate}');";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection); // команда
            dbCommand.ExecuteNonQuery();            
            
        }

        public void DeleteAssignment(int AssignmentId)
        {
            string query = $"DELETE FROM Assignment WHERE AssignmentId={AssignmentId};";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection); // команда
            dbCommand.ExecuteNonQuery();
            
        }
        public void UpdateAssignment(Assignment a)
        {
            string query = $"Update Assignment " +
                $"SET Type='{a.Type}', Job='{a.Job}', " +
            $"DepartmentId=DMin(\"DepartmentId\", \"Department\", \"DepartmentName='{a.Department}'\"), Purpose='{a.Purpose}', " +
            $"DateFrom='{a.DateFrom}', DateTo='{a.DateTo}', " +
            $"Hours={a.Hours}, DocumentNumber='{a.DocumentNumber}', DocumentDate='{a.DocumentDate}' " +
                $"WHERE AssignmentId={a.AssignmentId};";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection); // команда
            dbCommand.ExecuteNonQuery();
            
        }
        public int AddPerson(Person p)
        {            
            OleDbDataReader dbReader;
            string query = $"INSERT INTO Person (FullName, Job, WorkPlace, Gender, IsForeign, Rank, Degree, SpecialInfo) " +
            $"VALUES ('{p.FullName}', '{p.Job}','{p.WorkPlace}', " +
            $"'{p.Gender}', {p.IsForeign}, '{p.Rank}', " +
            $"'{p.Degree}', '{p.SpecialInfo}');";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection); // команда
            dbCommand.ExecuteNonQuery();

            query = $"SELECT PersonId FROM Person WHERE (((Person.FullName) Like '%{p.FullName}%'));";
            dbCommand = new OleDbCommand(query, dbConnection); // команда
            dbReader = dbCommand.ExecuteReader();
            int res = -1;
            // Проверяем данные
            if (dbReader.HasRows == false)
            {
                throw new Exception("Дані не знайдено!");
            }
            else
            {
                while (dbReader.Read())
                {
                    res = Convert.ToInt32(dbReader["PersonId"]);
                }

            }
            dbReader.Close();
            
            return res;
        }
        public void UpdatePerson(Person p)
        {
            string query = $"UPDATE Person SET FullName='{p.FullName}', Job='{p.Job}', " +
                $"WorkPlace='{p.WorkPlace}', Gender='{p.Gender}', IsForeign={p.IsForeign}, Rank='{p.Rank}', " +
                $"Degree='{p.Degree}', SpecialInfo='{p.SpecialInfo}' WHERE PersonId={p.PersonId};";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection); // команда
            dbCommand.ExecuteNonQuery();
            
        }
        public void DeletePerson(int PersonId)
        {
            string query = $"DELETE FROM Person WHERE PersonId={PersonId};";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection); // команда
            dbCommand.ExecuteNonQuery();
            
        }
    }
}
