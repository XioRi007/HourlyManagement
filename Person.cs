using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HourlyManagment
{
    public class Person
    {
        private int _PersonId;
        private string _FullName;
        private string _Job;
        private string _WorkPlace;
        private string _Rank;
        private string _Degree;
        private string _SpecialInfo;
        private string _Gender;
        private bool _IsForeign;
        private List<Assignment> _assignments;
        public Person()
        {

        }
        public Person(string _FullName,string _Job,
            string _WorkPlace,string _Rank,string _Degree,
            string _SpecialInfo,string _Gender,bool _IsForeign,int _PersonId=-1)
        {
            this._PersonId = _PersonId;
            this._FullName = _FullName;
            this._Job = _Job;
            this._WorkPlace = _WorkPlace;
            this._Rank = _Rank;
            this._Degree = _Degree;
            this._SpecialInfo = _SpecialInfo;
            this._Gender = _Gender;
            this._IsForeign = _IsForeign;
            _assignments = new List<Assignment>();
        }
        public void AddAssignment(Assignment a)
        {
            _assignments.Add(a);
        }
        public int PersonId
        {
            get { return _PersonId; }
        }
        public string FullName
        {
            get { return _FullName; }
        }
        public string Job
        {
            get { return _Job; }
        }
        public string WorkPlace
        {
            get { return _WorkPlace; }
        }
        public string Rank
        {
            get { return _Rank; }
        }
        public string Degree
        {
            get { return _Degree; }
        }
        public string SpecialInfo
        {
            get { return _SpecialInfo; }
        }
        public string Gender
        {
            get { return _Gender; }
        }
        public bool IsForeign
        {
            get { return _IsForeign; }
        }
        public List<Assignment> assignments
        {
            get { return _assignments; }
        }
    }
}
