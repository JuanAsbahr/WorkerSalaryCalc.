using System;
using WorkerSalary.Entities.Enums;
using System.Collections.Generic;

namespace WorkerSalary.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; }

        public List<HourContract> Contracts { get; set; } = new List<HourContract>();


        public Worker() { 
        }

        public Worker(string name, WorkerLevel level, double basesalary, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = basesalary;
            Departament = departament;
        }




    }

}
