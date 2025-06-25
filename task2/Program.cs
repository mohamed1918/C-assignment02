using System;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Console.WriteLine(" Enter a number : ");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine($"number : {num} ");
            #endregion

            #region Q2
            //string str = "123abc";
            //int val = int.Parse(str);
            //Console.WriteLine(val);
            #endregion

            #region Q3
            //float num1 = 5.5f, num2 = 2.2f;
            //float sum = num1 + num2;
            //Console.WriteLine(sum);
            #endregion

            #region Q4
            //string str = "mohammed";
            //string sub = str.Substring(0,5);
            //Console.WriteLine(sub);
            #endregion

            #region Q5
            //int a = 10;
            //int b = a;
            //b = 20;
            //Console.WriteLine($"a = {a}, b = {b}");
            #endregion

            #region Q6
            //int[] arr1 = { 1, 2, 3 };
            //int[] arr2 = arr1;
            //arr2[0] = 99;
            //Console.WriteLine($"arr1[0] = {arr1[0]}");
            #endregion

            #region Q7
            //string str1 = "mohamed";
            //string str2 = "hossam";
            //string stringg = str1 + " " + str2;
            //Console.WriteLine(stringg);
            #endregion

            #region Q8
            //Console.Write("Principal: ");
            //double p = double.Parse(Console.ReadLine());
            //Console.Write("Rate: ");
            //double r = double.Parse(Console.ReadLine());
            //Console.Write("Time: ");
            //double t = double.Parse(Console.ReadLine());
            //double si = (p * r * t) / 100;
            //Console.WriteLine($"Simple Interest: {si}");
            #endregion

            #region Q9
            //Console.Write("Weight (kg): ");
            //double weight = double.Parse(Console.ReadLine());
            //Console.Write("Height (m): ");
            //double height = double.Parse(Console.ReadLine());
            //double bmi = weight / (height * height);
            //Console.WriteLine($"BMI: {bmi}");
            #endregion

            #region Q10
            //Console.Write("Temperature: ");
            //int temp = int.Parse(Console.ReadLine());
            //string status = temp < 10 ? "Just Cold" : temp > 30 ? "Just Hot" : "Just Good";
            //Console.WriteLine(status);
            #endregion

            #region Q11
            //Console.Write("Day: ");
            //int day = int.Parse(Console.ReadLine());
            //Console.Write("Month: ");
            //int month = int.Parse(Console.ReadLine());
            //Console.Write("Year: ");
            //int year = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Today's date: {day} , {month} , {year}");
            //Console.WriteLine($"Today's date: {day} / {month} / {year}");
            //Console.WriteLine($"Today's date: {day} - {month} - {year}");
            #endregion

            #region Q12
            //Console.Write("Enter number: ");
            //int n = int.Parse(Console.ReadLine());
            //if (n % 3 == 0 && n % 4 == 0)
            //    Console.WriteLine("Yes");
            //else
            //    Console.WriteLine("No");
            #endregion

            #region Q13
            //Console.Write("Enter integer: ");
            //int num2 = int.Parse(Console.ReadLine());
            //if (num2 < 0)
            //    Console.WriteLine("Negative");
            //else
            //    Console.WriteLine("Positive");
            #endregion

            #region Q14
            //Console.Write("Enter first number: ");
            //int n1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter second number: ");
            //int n2 = int.Parse(Console.ReadLine());
            //Console.Write("Enter third number: ");
            //int n3 = int.Parse(Console.ReadLine());
            //int max = Math.Max(n1, Math.Max(n2, n3));
            //int min = Math.Min(n1, Math.Min(n2, n3));
            //Console.WriteLine($"Max number = {max}");
            //Console.WriteLine($"Min number = {min}");
            #endregion

            #region Q15
            //Console.Write("Enter integer: ");
            //int num = int.Parse(Console.ReadLine());
            //if (num % 2 == 0)
            //    Console.WriteLine("Even");
            //else
            //    Console.WriteLine("Odd");
            #endregion

            #region Q16
            Console.Write("Enter character: ");
            char ch = char.Parse(Console.ReadLine().ToLower());
            if ("aeiou".Contains(ch))
                Console.WriteLine("vowel");
            else
                Console.WriteLine("consonant");
            #endregion
        }
    }
}
