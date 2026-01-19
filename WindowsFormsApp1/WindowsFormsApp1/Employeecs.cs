using System;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Employeecs
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [NonSerialized]
        private int salary;  

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
    }
}


