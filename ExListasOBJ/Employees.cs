using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExListasOBJ
{
    class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employees(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public void IncreaseSalary(double porc)
        {
            Salary = (porc / 100 * Salary) + Salary;
        }
       
        public override string ToString()
        {
            return Id + ", " + Name + ", " + Salary.ToString(); 
        }
    }
}
