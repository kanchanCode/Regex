/*using regexPractice;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace regexPractice
{
    public class regexPattern
    {


        public static string pincodeUC1 = "^[1-9][0-9]{5}$";
        public static string pincodeUC2 = "^!([A-Z][.|!|@|#|$|%|^|&|*]?)[1-9][0-9]{5}$";
        public static string pincodeUC3 = "^[1-9][0-9]{5}!([A-Z][.|!|@|#|$|%|^|&|*]?)$";
        public static string pincodeUC4 = "^[1-9][0-9]{2}[  ][0-9]{3}$";
        public static string emailValidation = "^[a-zA-Z]{3,}([.|#|+|_|-]?[a-zA-Z0-9]+)?[@]{1}[a-zA-Z0-9]+([.]{1}[a-zA-Z]{2,4})?[.]{1}[a-zA-Z]{2,4}$";


        public bool InputCheck(string input, int n)
        {
            if (n == 1)
            {
                return Regex.IsMatch(input, pincodeUC1);
            }
            if (n == 2)
            {
                return Regex.IsMatch(input, pincodeUC2);
            }
            if (n == 5)
            {
                return Regex.IsMatch(input, emailValidation);
            }
            if (n == 4)
            {
                return Regex.IsMatch(input, pincodeUC4);
            }
            else
            {
                return Regex.IsMatch(input, pincodeUC3);
            }

        }



    }


    class program
    {

        static void Main(string[] args)
        {
            regexPattern obj1 = new regexPattern();
            Console.WriteLine(" 1. Pincode UC1 \n 2. Pincode UC2 \n 3. Pincode UC3 \n 4. Pincode UC4 \n 5. email Validation \n");
            Console.WriteLine("Enter your choice");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine(obj1.InputCheck("400088", 1));
                    break;
                case 2:
                    Console.WriteLine(obj1.InputCheck("A400088", 2));
                    break;
                case 3:
                    Console.WriteLine(obj1.InputCheck("400088B", 3));
                    break;
                case 4:
                    Console.WriteLine(obj1.InputCheck("400 088", 4));
                    break;
                case 5:
                    Console.WriteLine(obj1.InputCheck("abc.100@gmail.co.in", 5));
                    break;
                default:
                    Console.WriteLine("invalid choice");
                    break;

            }
        }
    }

}
*/