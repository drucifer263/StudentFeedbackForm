using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project1
{
    //Validates all input from user
    public class Validator
    {
        //Checks the input to see if it is empty
        public static bool isThere(string input, Label displayError)
        {
            bool present = false;
            if (input == "")
            {
                present = false;
                displayError.Text += " Entry (Name or TUID) cannot be blank.";
            }

            else
            {
                present = true;
            }

            return present;
        }

        //Checks the input to see if it has the required length
        public static bool isLongEnough(string input, Label displayError)
        {
            int length = 0;
            bool longEnough = false;

            length = input.Length;

            if (length < 9)
            {
                displayError.Text += " Entry (TUID) is not long enough. Must be atleast 9 digits long.";
                longEnough = false;
            }

            else if (length > 9)
            {
                displayError.Text += " Entry (TUID) is too long. Must be only 9 digits long.";
                longEnough = false;
            }

            else
            {
                longEnough = true;
            }

            return longEnough;
        }

        //Checks to see if the input is a number
        public static bool isNumber(string input, Label displayError)
        {
            double number = 0;
            bool isaNum = false;

            if (Double.TryParse(input, out number))
            {
                isaNum = true;
            }

            else
            {
                displayError.Text += " Entry (TUID) is not a number.";
            }

            return isaNum;
        }

        //Validates a number input
        public static bool validateNumber(string input, Label displayError)
        {
            bool valid = false;

            //checks to see if the string is empty, long enough, and is a number
            if (isThere(input, displayError) && isLongEnough(input, displayError) && isNumber(input, displayError))
            {
                valid = true;
            }

            else
            {
                valid = false;
            }

            return valid;
        }

        //Validates a string input
        public static bool validateString(string input, Label displayError)
        {
            bool valid = false;

            //checks to see if the string is empty
            if (isThere(input, displayError))
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