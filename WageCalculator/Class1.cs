using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WageCalc
{
    class Salary
    {
        private double hourlyWage;
        private double hours;
        private double overtimeHours;
        private double wagePerWeek;
        private double wagePerYear;

        public double HourlyWage
        {
            get { return this.hourlyWage; }
            set { this.hourlyWage = value; }
        }

        public double Hours
        {
            get { return this.hours; }
            set { this.hours = value; }
        }

        public double GetOvertimeHours()
        {
            if (hours <= 40)
            {
                return this.overtimeHours = 0;
            }
            else
            {
                return this.overtimeHours = (this.hours - 40);
            }
        }

        public double GetWagePerWeek()
        {
            this.overtimeHours = GetOvertimeHours();
            this.wagePerWeek = ((this.hourlyWage * 40) + ((this.hourlyWage * 1.5) * this.overtimeHours));
            return this.wagePerWeek;
        }

        public double GetWagePerYear()
        {
            this.wagePerWeek = this.GetWagePerWeek();
            this.wagePerYear = this.wagePerWeek * 52;
            return this.wagePerYear;
        }
    }
}
