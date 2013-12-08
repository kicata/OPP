using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class Worker:Human
    {
        //field
        private double weekSalary;
        private int workHoursPerDay;
        private int workDaysPerWeek;
        private List<Worker> workerList = new List<Worker>();

        //prop
        

        public List<Worker> WorkerList
        {
            get { return this.workerList; }
        }
        public int WorkHoursPerDay
        {
            get { return workHoursPerDay; }
            set 
            {
                if (workHoursPerDay <= 0 && workHoursPerDay>14)
                {
                    throw new ArgumentException("invalid Work hour");
                }
                workHoursPerDay = value;
            }
        }
        
        public double WeekSalary
        {
            get { return weekSalary; }
            set
            {
                if (weekSalary<0)
                {
                    throw new ArgumentException("invalid week salary");
                }
                weekSalary = value; 
            }
        }
        public int WorkDaysPerWeek
        {
            get { return workDaysPerWeek; }
            set
            {
                if (workDaysPerWeek <= 0 && workDaysPerWeek > 7)
                {
                    throw new ArgumentException("invalid Work hour");
                }
                workDaysPerWeek = value;
            }
        }
        //ctor
        public Worker(string firstName, string lastName, double weekSalary, int workHoursPerDay, int workDaysPerWeek):base(firstName,lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.WeekSalary = weekSalary;
            this.workDaysPerWeek = workDaysPerWeek;
            this.workHoursPerDay = workHoursPerDay;

        }
        //methods
        public double MoneyPerHour(double weekSalary, int workHoursPerDay, int workDayPerWeek)
        {
            double moneyPerHour = (weekSalary / workDayPerWeek) / workHoursPerDay;
            return moneyPerHour;
 
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var worker in workerList)
            {
                sb.Append(worker.FirstName + " " + worker.LastName + Environment.NewLine + " week Salary: " +
                    worker.WeekSalary + "\t" + "work HoursPerDay: "+worker.workHoursPerDay + "\t" + "work DaysPerWeek: "+
                    worker.WorkDaysPerWeek+Environment.NewLine);
            }
            return sb.ToString();
        }
    }
}
