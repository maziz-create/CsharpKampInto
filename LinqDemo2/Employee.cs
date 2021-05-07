using System;
using System.Collections.Generic;
using System.Text;

namespace LinqDemo2
{
    class Employee
    {
        public int Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        private decimal MothlySalary; //üsttekiler auto-implemented bu değil.

        public Employee(int id, string firstName, string lastName, decimal monthlySalary)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            MothlySalary = monthlySalary;
        }

        public decimal mothlySalary
        {
            get
            {
                return MothlySalary;
            }
            set
            {
                if (value>0)
                {
                    MothlySalary = value;
                }
            }
        }
        public override string ToString() => $"{FirstName,-10} {LastName,-10} {MothlySalary,10:C}";
    }
}