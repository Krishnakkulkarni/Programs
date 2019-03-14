//-----------------------------------------------------------------------
// <copyright file="RegexExpression.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace ObjectOrientedPrograms.RegularExpression
{
    using System;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Class to take string input
    /// </summary>
    public class RegexExpression
    {
        /// <summary>
        /// Shows the match.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="expression">The expression.</param>
        /// <param name="pattern">The pattern.</param>
        /// <returns>returns string</returns>
        public static string CheckMatch(string text, string expression, string pattern)
        {
            Regex regex = new Regex(pattern);
            string newString = regex.Replace(text, expression);
            return newString;
        }

        /// <summary>
        /// Operations this instance.
        /// </summary>
        public void Operation()
        {
            this.ReadData();
        }

        /// <summary>
        /// Retrieves the information.
        /// </summary>
        /// <param name="firstname">The first name.</param>
        /// <param name="fullname">The full name.</param>
        /// <param name="mobileno">The m n o.</param>
        /// <param name="date">The date.</param>
        public void RetrieveInfo(string firstname, string fullname, string mobileno, string date)
        {
            try
            {
                string message = "Hello <<name>>, We have your full name as <<full name>> in our system your contact number is <<91-xxxxxxxxx>>, Please,let us know in case of any clarification Thank you BridgeLabz <<dd/mm/yyyy>>.";
                string patternForName = "<<name>>";
                message = RegexExpression.CheckMatch(message, firstname, patternForName);
                string patternForfame = "<<full name>>";
                message = RegexExpression.CheckMatch(message, firstname + " " + fullname, patternForfame);
                string contactNumber = "<<91-xxxxxxxxx>>";
                message = RegexExpression.CheckMatch(message, "91" + " " + mobileno, contactNumber);
                string currentdate = "<<dd/mm/yyyy>>";
                DateTime today = DateTime.Today;
                message = RegexExpression.CheckMatch(message, today.ToString(), currentdate);
                Console.WriteLine(message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Reads the data.
        /// </summary>
        public void ReadData()
        {
            try
            {
                Console.WriteLine("Enter your First name");
                string firstname = RegexClass.IsString(Console.ReadLine());
                Console.WriteLine("Enter your Full name");
                string fullname = RegexClass.IsString(Console.ReadLine());
                Console.WriteLine("Enter your mobile number");
                string mobileno = Console.ReadLine();
                DateTime thisDay = DateTime.Today;
                string date = thisDay.ToString("date");
                if (Regex.IsMatch(mobileno, @"[0-9]{10}") && Regex.IsMatch(fullname, @"[a-zA-z]") && Regex.IsMatch(fullname, @"[a-zA-z]"))
                {
                    this.RetrieveInfo(firstname, fullname, mobileno, date);
                }
                else
                {
                    Console.WriteLine("Data is invalid,Try again");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}