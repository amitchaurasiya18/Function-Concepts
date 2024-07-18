using System;
class Program
{
        public static string FindLargestNumber(int number1, int number2)
        {
            return (number1 > number2) ? number1 + " is Largest" : number2+" is Largest";
        }

        public static double FindLargestNumber(double number1, double number2, double number3)
        {
            if(number1 > number2 && number1 > number3) 
                return number1;
            if(number2 > number3 && number2 > number3)
                return number2;
            return number3;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("From 100 and 250 : " + FindLargestNumber(100, 250));
            Console.WriteLine("From 121.453 , 564.23 and 98.234352 : " + FindLargestNumber(121.453, 564.23, 98.234352) + " is the largest number");
        }
}

