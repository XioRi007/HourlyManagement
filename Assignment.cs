using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HourlyManagment
{
    public class Assignment
    {
        private int _AssignmentId;
        private string _Type;
        private string _Job;
        private string _Department;
        private string _Purpose;
        private string _DateFrom;
        private string _DateTo;
        private float _Hours;
        private string _DocumentNumber;
        private string _DocumentDate;
        public Assignment(string _type, 
                            string _Job, string _Department, 
                            string _Purpose, string _DateFrom, string _DateTo, 
                            float _Hours, string _DocumentNumber, string _DocumentDate,int _AssignmentId=-1) {

            this._AssignmentId = _AssignmentId;
            this._Type = _type;
            this._Job = _Job;
            this._Department = _Department;
            this._Purpose = _Purpose;
            this._DateFrom = _DateFrom;
            this._DateTo = _DateTo;
            this._Hours = _Hours;
            this._DocumentNumber = _DocumentNumber;
            this._DocumentDate = _DocumentDate;
        }
        public int AssignmentId
        {
            get { return _AssignmentId; }
        }
        public string Type
        {
            get { return _Type; }
        }
        public string Job
        {
            get { return _Job; }
        }
        public string Department
        {
            get { return _Department; }
        }
        public string Purpose
        {
            get { return _Purpose; }
        }
        public string DateFrom
        {
            get { return _DateFrom; }
        }
        public string DateTo
        {
            get { return _DateTo; }
        }
        public float Hours
        {
            get { return _Hours; }
        }
        public string DocumentNumber
        {
            get { return _DocumentNumber; }
        }
        public string DocumentDate
        {
            get { return _DocumentDate; }
        }
    }
}
