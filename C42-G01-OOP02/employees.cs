using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_OOP02

{
    public class Employee
    {
        #region Private Fields
        private int id;
        private string name;
        private SecurityLevel securityLevel;
        private decimal salary;
        private HiringDate hireDate;
        private char gender; // Use char for Gender (M/F)
        #endregion

        #region Public Properties

        public int ID
        {
            get { return id; }
            set { id = (value > 0) ? value : 0; }
        }

        public string Name
        {
            get { return name; }
            set { name = !string.IsNullOrEmpty(value) ? value : "Unknown"; }
        }

        public SecurityLevel SecurityLevel
        {
            get { return securityLevel; }
            set { securityLevel = value; }
        }

        public decimal Salary
        {
            get { return salary; }
            set { salary = (value >= 0) ? value : 0; }
        }

        public HiringDate HireDate
        {
            get { return hireDate; }
            set { hireDate = value ?? new HiringDate(1, 1, 1900); } // Default to a sensible date if null
        }

        public char Gender
        {
            get { return gender; }
            set { gender = (value == 'M' || value == 'F') ? value : 'U'; }
        }

        #endregion

        #region Constructor
        public Employee(int id, string name, SecurityLevel securityLevel, decimal salary, HiringDate hireDate, char gender)
        {
            ID = id;
            Name = name;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Security Level: {SecurityLevel}, Salary: {Salary:C}, Hire Date: {HireDate}, Gender: {Gender}";
        }

        public static int CompareByHireDate(Employee x, Employee y)
        {
            if (x == null || y == null)
                throw new ArgumentException("Arguments cannot be null");

            // Compare years first
            int yearComparison = x.HireDate.Year.CompareTo(y.HireDate.Year);
            if (yearComparison != 0) return yearComparison;

            // Compare months if years are equal
            int monthComparison = x.HireDate.Month.CompareTo(y.HireDate.Month);
            if (monthComparison != 0) return monthComparison;

            // Compare days if months are equal
            return x.HireDate.Day.CompareTo(y.HireDate.Day);
        }
        #endregion
    }

}
