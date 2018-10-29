using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsOfProgrammingExercises
{
    class Taxpayer
    {
        private double income;

        public string SocialNumber { get; set; }
        public double Income
        {
            get
            {
                return income;
            }
            set
            {
                income = value;
                calcTax();
            }
        }
        public double TaxOwed { get; private set; }

        private void calcTax()
        {
            if (income < 30000)
            {
                TaxOwed = income * .15;
            }
            else
            {
                TaxOwed = income * .28;
            }
        }
    }
}
