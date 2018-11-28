using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PlantPlaces18FS001
{
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            String number1 = Number1.Text;
            int intNumber1 = Convert.ToInt32(number1);
            String number2 = Number2.Text;
            int intNumber2 = Convert.ToInt32(number2);
            // get a reference to the web service calculator.
            Calculator.CalculatorSoapClient calc = new Calculator.CalculatorSoapClient("CalculatorSoap");
            int sum = calc.Add(intNumber1, intNumber2);

            LblSum.Text = Convert.ToString(sum);

        }
    }
}