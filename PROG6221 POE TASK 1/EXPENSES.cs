using System;
using System.Collections.Generic;
using System.Text;

namespace PROG6221_POE_TASK_1
{
    public abstract class EXPENSES
    {
        public double groceries;
        public double waterandlights;
        public double cellphoneandtelephone;
        public double travelcost;
        public double otherexpenses;
        public double MonthlyExpenses;
        public double DailyExpenses;
        String input = "c";


        

        internal void ExpensesPrompts()
        {
            throw new NotImplementedException();
        }

        public abstract int MyExpenses { get; set; }
        public double Groceries { get => groceries; set => groceries = value; }
        public double Waterandlights { get => waterandlights; set => waterandlights = value; }
        public double Cellphoneandtelephone { get => cellphoneandtelephone; set => cellphoneandtelephone = value; }
        public double Travelcost { get => travelcost; set => travelcost = value; }
        public double Otherexpenses { get => otherexpenses; set => otherexpenses = value; }

        public abstract int GetMyExpenses();


    }
}
