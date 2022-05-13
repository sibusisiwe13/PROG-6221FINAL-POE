using System;
using System.Collections.Generic;
using System.Text;

namespace PROG6221_POE_TASK_1
{
    public class Income 
    {
        private double grossmonthlyincome;
        private double monthlytaxdeductions;

        public double Grossmonthlyincome { get => grossmonthlyincome; set => grossmonthlyincome = value; }
        public double Monthlytaxdeductions { get => monthlytaxdeductions; set => monthlytaxdeductions = value; }
    }
}
