using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Member
    {
        private string _Name;
        public string Name { get { return _Name; } set { _Name = value;  } }
        private int _Age;
        public int Age { get { return _Age; } set { _Age = value; } }
        private bool _IsStudent;
        public bool isStudent { get { return _IsStudent; } set { _IsStudent = value; } }
        private int _Visits;
        public int Visits { get { return _Visits; } set { _Visits = value; }}

        public Member(string name, int age, bool isStudent)
        {
            _Name = name;
            _Age = age;
            _IsStudent = isStudent;
            _Visits = 0;
        }
        public void CheckIn()
        {
            Visits++;
        }
        public string Describe()
        {
            string student = string.Empty;
            if (isStudent)
            {
                student = "diák";
            }
            else
            {
                student = "normál";
            }
                return $"{Name} ({Age} éves, {student}) - {Visits} látogatás";
        }
    }
}
