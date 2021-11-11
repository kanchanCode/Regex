using System;
using System.Text.RegularExpressions;


namespace regexPractice
{
    public class regexProblems
    {

        public static string firstName = "^[A-Z]{1}[a-zA-Z]{3,}$";
        public static string lastName = "^[A-Z]{1}[a-zA-Z]{3,}$";
        public static string email = "^[a-zA-Z]{3,}([.|#|+|_|-]?[a-zA-Z0-9]+)?[@]{1}[a-zA-Z0-9]+([.]{1}[a-zA-Z]{2,4})?[.]{1}[a-zA-Z]{2,4}$";
        public static string mobileNo = "^[1-9]{2}[ ][1-9]{1}[0-9]{9}$";
        public static string password = "^.*(?=.{8,})(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$";
        //"^(?=.*[a-z])(?=.*[A-Z])(?=.*[*.!@$%^&(){}[]:;<>,.?/~_+-=|])(?=.[^[*.!@$%^&(){}[]:;
        //(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.[*.!@$%^&(){}[]:;<>,.?/~_+-=|]).{8,32}$";
        // naresh shared[A-Z]{1}[0-9]{1} ([!|@|#|$|%|^|&|*|_|.|-]){1}[A-Za-z]{5,}$
        // worked "^.*(?=.{8,})(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]){1}$"
        // sir gave "^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=[^$@!#%*?&]*[$#@!%*?&][^$@!#%*?&]*$).{8,}$


        public bool Check(string input, int n)
        {
            if (n == 1)
            {
             
                return Regex.IsMatch(input, firstName);
            }
            if (n == 2)
            {
                return Regex.IsMatch(input, lastName);
            }
            if (n == 5)
            {
                return Regex.IsMatch(input, password);
            }
            if (n == 4)
            {
                return Regex.IsMatch(input, mobileNo);
            }
            else
            {
                return Regex.IsMatch(input, email);
            }

        }
    }
    class Program 
    { 
        static void Main(string[] args)
        {
            regexProblems obj1 = new regexProblems();



            Console.WriteLine(" 1. First name  \n 2. Last name  \n 3. email  \n 4. Mobile no with country code \n 5. password  \n");
            Console.WriteLine("Enter your choice");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.Write("Raghav ");
                    Console.Write(obj1.Check("Raghav", 1));
                    break;
                case 2:
                    Console.Write("Janki ");
                    Console.Write(obj1.Check("Janki", 2));
                    break;
                case 3:
                    Console.Write("abc.100@gmail.co.in ");
                    Console.Write(obj1.Check("abc.100@gmail.co.in", 3));
                    break;
                case 4:
                    Console.WriteLine("91 7654321890 ");
                    Console.Write(obj1.Check("91 7654321890", 4));
                    break;
                case 5:
                    Console.WriteLine("Passw@rd1 ");
                    Console.WriteLine(obj1.Check("Passw@rd1", 5));
                    break;
                default:
                    Console.WriteLine("invalid choice");
                    break;

            }
        }
    }


}
