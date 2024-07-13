using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_AS_03
{
    //3
    public enum Gender : int
    {
        male,female
    }

    //4
    [Flags]
    enum SecurtyLevel
    {
        DBA = 1,
        guest = 2,
        developer = 4,
        secretary = 8
    }
    //1
    internal class Employee
    {
        #region Attributes
        public int id;
        public string? name;
        public SecurtyLevel security { get; set; }
        public double salary;
        public HiringDate hireDate { get; set; }
        public Gender gender { get; set; } 
        #endregion

        #region constructors
        public Employee()
        {

        }
        public Employee(int iD, string? name, SecurtyLevel security, double salary, HiringDate hireDate, Gender gender)
        {
            id = iD;
            this.name = name;
            this.security = security;
            this.salary = salary;
            this.hireDate = hireDate;
            this.gender = gender;
        }
        #endregion

        #region Property

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value > 0 ? value : -1;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value is not null ? value : "not found";
            }
        }

        public double Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value > 5000 ? value : 5000;
            }
        }
        #endregion

        //5
        #region Methods
        public override string ToString()
        {
            return $"Id : {id}\nName : {name}\nsecurity level : {security}\nSalary : {salary.ToString("C")}\nGender : {gender}\nHiring date : {hireDate.getHiringDate()}";
        } 
        #endregion
    }
}
