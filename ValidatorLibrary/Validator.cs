using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project1
{
    public class Validator
    {
        protected bool isThere(string input)
        {
            bool present = false;
            if (input == "")
            {
                present = false;
                displayError.Text += " Entry cannot be blank.";
            }

            else
            {
                present = true;
            }

            return present;
        }

        protected bool isLongEnough(string input)
        {
            int length = 0;
            bool longEnough = false;

            length = input.Length;

            if (length < 9)
            {
                displayError.Text += " Entry is not long enough. Must be atleast 9 digits long.";
                longEnough = false;
            }

            else if (length > 9)
            {
                displayError.Text += " Entry is too long. Must be only 9 digits long.";
                longEnough = false;
            }

            else
            {
                longEnough = true;
            }

            return longEnough;
        }

        protected bool isNumber(string input)
        {
            double number = 0;
            bool isaNum = false;

            if (Double.TryParse(input, out number))
            {
                isaNum = true;
            }

            else
            {
                displayError.Text += " Entry is not a number.";
            }

            return isaNum;
        }

        protected bool validateNumber(string input)
        {
            bool valid = false;

            if (isThere(input) && isLongEnough(input) && isNumber(input))
            {
                valid = true;
            }

            else
            {
                valid = false;
            }

            return valid;
        }

        protected bool validateString(string input)
        {
            bool valid = false;

            if (isThere(input))
            {
                valid = true;
            }

            else
            {
                valid = false;
            }

            return valid;
        }
    }
}
