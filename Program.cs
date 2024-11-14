using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel;

namespace ALBRIGHT_WEEK2_CHALLENGE_CODE
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /* MSSA CCAD 16 - CHRIS ALBRIGHT
             * WEEK 2 - CHALLENGE LABS
             * 11NOV2024
             * 
             * PROBLEM 1:
             * Write a C# Sharp program to read temperature in Fahrenheit and display a suitable message according to temperature state below :
                Temp 0< 10 then Freezing weather
                temp 11-20 then Very Cold weather
                Temp 21-35 then Cold weather
                Temp 36-50 then Normal in Weather
                Temp 51-65 then Its Hot
                Temp 66-80 then Its Very Hot
                Test Data :
                67
                Expected Output :
                Its very hot.
             */

            Console.WriteLine("Please enter the current temperature:");
            int tempVar = Convert.ToInt32(Console.ReadLine());

            switch (tempVar)
            {
                case int n when (n < 10 && n >= 0):
                    Console.WriteLine("\nFreezing weather");
                    break;

                case int n when (n < 20 && n >= 11):
                    Console.WriteLine("\nVery Cold weather");
                    break;

                case int n when (n < 35 && n >= 21):
                    Console.WriteLine("\nCold weather");
                    break;

                case int n when (n < 50 && n >= 36):
                    Console.WriteLine("\nNormal in Weather");
                    break;

                case int n when (n < 65 && n >= 51):
                    Console.WriteLine("\nIts Hot");
                    break;
                case int n when (n < 80 && n >= 66):
                    Console.WriteLine("\nIts Very Hot");
                    break;
                default:
                    Console.WriteLine("\nValue out of range.");
                    break;
            }
            //======================================================================================================================================

            /*PROBLEM 2:
            *Write a C# Sharp program that takes userid and password as input (type string). After 3 wrong attempts, user will be rejected.
            */

            string actualUsername = "EvelKnievel";
            string actualPassword = "M0t0rBik3";
            int loginAttempts;

            for (loginAttempts = 0; loginAttempts < 3; loginAttempts++)
            {
                Console.WriteLine("\n\n\nPlease enter your username:");
                string userVar = Console.ReadLine();

                Console.WriteLine("\nPlease enter your password:");
                string passVar = Console.ReadLine();

                if (actualUsername == userVar && actualPassword == passVar)
                {
                    Console.WriteLine("\nWelcome back " + actualUsername + " !");
                    break;
                }
                else
                {
                    Console.WriteLine("\nlogin attempt failed...You have " + (2 - loginAttempts) + " trys remaining.");
                }
            }

            if (loginAttempts >= 2)
            {
                Console.WriteLine("\nYour account has been locked, contact customer service to unlock your premissions.");
            }
            //======================================================================================================================================

            /*PROBLEM 3:
            *Write a C# Sharp program that takes a number and a width also a number, as input and then displays a triangle of that width, using that number.
            *Test Data
            *Enter a number: 6
            *Enter the desired width: 6
            *Expected Output:
            *666666
            *66666
            *6666
            *666
            *66
            *6            
            */

            Console.WriteLine("\n\n\nEnter a number:");
            int intVar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter the desired width:");
            int intWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int intHeight = intWidth;

            for (int i = 0; i < intHeight; i++)
            {
                for (int j = 0; j < intWidth; j++)
                {
                    Console.Write(intVar + "");
                }
                Console.WriteLine();
                intWidth--;
            }
            //========================================================================================================================================
            /* PROBLEM 4:
             * Write a C# Sharp program to read roll no, name and marks of three subjects and calculate the total, percentage and division.
             * (May use a struct / class to represent the student)
            Test Data :
            Input the Roll Number of the student :784
            Input the Name of the Student :James
            Input the marks of Physics, Chemistry and Computer Application : 70 80 90
            Expected Output :
            Roll No : 784
            Name of Student : James
            Marks in Physics : 70
            Marks in Chemistry : 80
            Marks in Computer Application : 90
            Total Marks = 240
            Percentage = 80.00
            Division = First
            */          

            //Console.WriteLine("Please enter the number of grades you'd like to input:");
            //int N = Convert.ToInt32(Console.ReadLine());
                        
            //List<Grades> myObjects = new List<Grades>();
            //for (int i = 0;i < N; i++)
            //{
            //    myObjects.Add(new Grades()); // instantiation
            //}
            

        }

        public class Grades
        {
            public int RollNumber
            { get; set; }
            public string StudName
            { get; set; }
            public string StudSubject
            { get; set; }
            public double StudGrade
            { get; set; }
        }
    }
}

