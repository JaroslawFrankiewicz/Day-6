using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    internal class Employee
    {
        private List<int> score = new List<int>();

        public Employee(string firstName, string surName, int age)
        {
            this.FirstName = firstName;
            this.SurName = surName;
            this.Age = age;
        }
        public string FirstName
        {
            get;
            private set;
        }
        public string SurName
        {
            get;
            private set;
        }
        public int Age
        {
            get;
            private set;
        }
        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }
        public void AddScore(int number)
        {
            this.score.Add(number);
        }

    }
}
