using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace TravelExpertsData
{
    public static class Validator
    {
        // all methods in a static class are static

        // checks valid phone numbers
        public static bool IsPhoneNumber(TextBox tb, string name)
        {
            bool valid = true;
            if (!Regex.Match(tb.Text, @"^(\(?\d{3}\)?-? *\d{3}-? *-?\d{4})$").Success)
            {
                valid = false;
                MessageBox.Show("Add a valid " + name);
                tb.Focus();
            }
            return valid;
        }

        // checks for letter string value
        public static bool IsLetters(TextBox tb, string name)
        {
            bool valid = true;
            if (!Regex.Match(tb.Text, @"^[a-zA-Z]+$").Success)
            {
                valid = false;
                MessageBox.Show("Add a valid " + name);
                tb.Focus();
            }
            return valid;
        }

        // checks for letters and spaces
        public static bool IsLettersAndSpaces(TextBox tb, string name)
        {
            bool valid = true;
            if (!Regex.Match(tb.Text, @"^[A-Za-z ]+$").Success)
            {
                valid = false;
                MessageBox.Show("Add a valid " + name);
                tb.Focus();
                tb.Clear();
            }
            return valid;
        }

        public static bool IsAddress(TextBox tb, string name)
        {
            bool valid = true;
            if (!Regex.Match(tb.Text, @"^[a-zA-Z0-9 .]*$").Success)
            {
                valid = false;
                MessageBox.Show("Add a valid " + name);
                tb.Focus();
            }
            return valid;
        }

        public static bool IsEmail(TextBox tb, string name)
        {
            bool valid = true;
            string validEmailPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
            + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
            + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            if (!Regex.Match(tb.Text.ToLower(), validEmailPattern).Success)
            {
                valid = false;
                MessageBox.Show("Add a valid " + name);
                tb.Focus();
            }
            return valid;
        }

        public static bool IsCurrency(TextBox tb, string name)
        {
            bool valid = true;
            string validCurrencyPattern = @"^\p{Sc}?[0-9]+(?:\.[0-9]{2})?$";

            string tbA = Regex.Replace(tb.Text, "\\$", "");
            tbA = Regex.Replace(tb.Text, ",", "");

            if (!Regex.Match(tbA, validCurrencyPattern).Success)
            {
                valid = false;
                MessageBox.Show("Add a valid " + name);
                tb.Focus();
            }
            return valid;
        }

        // tests for an empty string
        public static bool IsNotEmpty(TextBox tb, string name)
        {
            bool valid = true; // setting parameter
            if (tb.Text == "") // empty
            {
                valid = false;
                MessageBox.Show(name + " is required");
                tb.Focus();
            }
            return valid;
        }

        // test if text box contains integer value
        public static bool IsInteger(TextBox tb, string name)
        {
            bool valid = true;
            int value;
            if (!Int32.TryParse(tb.Text, out value)) // parse unsuccessful
            {
                valid = false;
                MessageBox.Show(name + " must be a whole number");
                tb.SelectAll(); // select all content for replacement
                tb.Focus();
            }
            return valid;
        }

        // test if text box contains double value
        public static bool IsDouble(TextBox tb, string name)
        {
            bool valid = true;
            double value;
            if (!Double.TryParse(tb.Text, out value)) // parse unsuccessful
            {
                valid = false;
                MessageBox.Show(name + " has to be a decimal number");
                tb.SelectAll(); // select all content for replacement
                tb.Focus();
            }
            return valid;
        }

        // test if text box contains non-negative integer value
        public static bool IsNonNegativeInt(TextBox tb, string name)
        {
            bool valid = true;
            int value;
            if (!Int32.TryParse(tb.Text, out value)) // parse unsuccessful
            {
                valid = false;
                MessageBox.Show(name + " must be a positive number");
                tb.SelectAll(); // select all content for replacement
                tb.Focus();
                tb.Clear();
            }
            else // parsed correctly
            {
                if (value < 0)
                {
                    valid = false;
                    MessageBox.Show(name + " has to be positive or zero");
                    tb.SelectAll(); // select all content for replacement
                    tb.Focus();
                    tb.Clear();
                }
            }
            return valid;
        }

        // test if text box contains non-negative integer value
        public static bool IsNonNegativeDouble(TextBox tb, string name)
        {
            bool valid = true;
            double value;
            if (!Double.TryParse(tb.Text, out value)) // parse unsuccessful
            {
                valid = false;
                MessageBox.Show(name + " has to be a decimal number");
                tb.SelectAll(); // select all content for replacement
                tb.Focus();
            }
            else // parsed correctly
            {
                if (value < 0)
                {
                    valid = false;
                    MessageBox.Show(name + " has to be positive or zero");
                    tb.SelectAll(); // select all content for replacement
                    tb.Focus();
                }
            }
            return valid;
        }

        public static string ToTitleCase(string str)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
        }

        public static bool IsPrice(TextBox tb, string name)
        {
            bool valid = false;
            decimal Number;
            if (decimal.TryParse(tb.Text, out Number)) // parse successful
            {
                valid = true;
            }
            else  // not parsed correctly
            {
                valid = false;
                MessageBox.Show(name + " must be a positive value");
                tb.SelectAll(); // select all content for replacement
                tb.Focus();
                tb.Clear();
            }
            return valid;
        }

        public static bool IsValidStartDate(DateTimePicker dateStart)
        {
            if (dateStart.Value == null)
            {
                MessageBox.Show("Start date must be selected");
                return false;
            }
            else if (Convert.ToDateTime(dateStart.Value).Ticks < Convert.ToDateTime(DateTime.Today).Ticks)
            {
                MessageBox.Show("Start date must be later than or equal to today's date");
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool IsValidEndDate(DateTimePicker dateStart, DateTimePicker dateEnd)
        {
            if (dateEnd.Value == null)
            {
                MessageBox.Show("End date must be selected");
                return false;
            }
            else if (Convert.ToDateTime(dateEnd.Value).Ticks < Convert.ToDateTime(DateTime.Today).Ticks)
            {
                MessageBox.Show("End date must be later than or equal to today's date");
                return false;
            }
            else if (Convert.ToDateTime(dateEnd.Value).Ticks < Convert.ToDateTime(dateStart.Value).Ticks)
            {
                MessageBox.Show("End date must be later than start date");
                return false;
            }
            else
            {
                return true;
            }

        }

        public static bool ValidateCommission(TextBox txtBasePrice, decimal basePrice, decimal agencyCommission)
        {
            if (agencyCommission > basePrice)
            {
                MessageBox.Show("Agency commission cannot be greater than base price");
                return false;
            }
            else { 
                return true; // Commission is valid 
            }
           
        }
    }
}