﻿using System.Globalization;

namespace ExercicioList01 {
    internal class Employee {

        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get;  set; }


        public void increaseSalary(double percentage) {
            Salary *= percentage / 100 + 1; 
        }


        override public string ToString() {
            return $"{Id}, {Name}, {Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
