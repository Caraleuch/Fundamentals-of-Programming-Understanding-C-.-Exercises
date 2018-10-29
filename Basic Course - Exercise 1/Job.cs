using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsOfProgrammingExercises
{
    class Job
    {
        private double time;
        private double ratePerHour;
        private double fee;
        public string Description { get; set; }

        public Job(double time, double hourlyRate, string desc)
        {
            Time = time;
            RatePerHour = hourlyRate;
            Description = desc;
        }

        public double Time
        {
            get
            {
                return time;
            }
            set
            {
                time = value;
                CalcFee();
            }
        }
        public double RatePerHour
        {
            get
            {
                return ratePerHour;
            }
            set
            {
                ratePerHour = value;
                CalcFee();
            }
        }
        public double Fee
        {
            get
            {
                return fee;
            }
        }

        private void CalcFee()
        {
            fee = ratePerHour * time;
        }

        public static Job operator +(Job job1, Job job2)
        {
            string multiDesc = job1.Description + " and " + job2.Description;
            double multiTime = job1.Time + job2.Time;
            double averageRate = (job1.RatePerHour + job2.RatePerHour) / 2;
            Job multiJob = new Job(multiTime, averageRate,multiDesc);
            return multiJob;
        }
    }
}
