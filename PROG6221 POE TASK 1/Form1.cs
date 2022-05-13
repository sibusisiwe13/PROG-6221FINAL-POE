using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG6221_POE_TASK_1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) 
        {
        private string monthlytaxdeductions;
        private string groceries;
        private string waterandlights;
        private string cellphoneandtelephone;
        private string otherexpenses;
        private string travelcost;
        private string rentingproperty;
        private string buyingproperty;

        public string Grossmonthlyincome { get => grossmonthlyincome; set => grossmonthlyincome = value; }
        public string Monthlytaxdeductions { get => monthlytaxdeductions; set => monthlytaxdeductions = value; }
        public string Groceries { get => groceries; set => groceries = value; }
        public string Waterandlights { get => waterandlights; set => waterandlights = value; }
        public string Cellphoneandtelephone { get => cellphoneandtelephone; set => cellphoneandtelephone = value; }
        public string Otherexpenses { get => otherexpenses; set => otherexpenses = value; }
        public string Travelcost { get => travelcost; set => travelcost = value; }
        public string Rentingproperty { get => rentingproperty; set => rentingproperty = value; }
        public string Buyingproperty { get => buyingproperty; set => buyingproperty = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            
                
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if("")
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //getting values for the user
            Price1 = double.Parse(textboxname.Text);
            totaldeposit1 = double.Parse(textBox.Text);
            string temp = Textnum.ContextMenuStripChanged();
            interestrate1 = double.Parse(textname.Text);
            grossmonthlyincome = double.Parse(textBox2.Text);
            monthlyincome = double.Parse(textBox3.Text);

            //Calculations for Homeloan Monthly Repayment
            Principle = Price1 - totaldeposit1;
            numberofmonths = numberofmonths / 12;
            interestback = 1 + (interestrate1 /100) * numberofmonths;
            totalpayment = principle * interestrate1;
            monthlyincome = totalpayment / numberofmonths;

            //calculations for monthlyincome
            monthlyincome = grossmonthlyincome - monthlytaxdeductions;

            //Display to user the message box the monthly payment
            string message = "Monthly payment is R" +Monthly payment;
                


        }

        private void comboboxone_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboboxone.SelectedItem == "Renting properrty")
            {
                textboxname.Visible = true;
                Textnum.Visible = false;
                textBox.Visible = false;
                textname.Visible = false;
                texttwo.Visible = false;
            }
            else if(comboboxone.SelectedItem == "Buying property")
            {
                Textnum.Visible = true;
                textBox.Visible = true;
                textname.Visible = true;
                texttwo.Visible = true;
            }
        }
    }
    }

}
