using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jira_Example
{
    internal class clsEmployee
    {
        public string Name { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal Allowcess { get; set; }
        public decimal Deductions { get; set; }

        public clsEmployee(string Name, decimal BasicSalary, decimal Allowcess, decimal Deductions)
        {
            this.Name = Name;
            this.BasicSalary = BasicSalary;
            this.Allowcess = Allowcess;
            this.Deductions = Deductions;
        }

        public decimal ClucluteSalary()
        {
            if (BasicSalary < 0 || Allowcess < 0 || Deductions < 0)
                Console.WriteLine("value cannot be negtave");


            return BasicSalary + Allowcess - Deductions;
        }

    }

}
