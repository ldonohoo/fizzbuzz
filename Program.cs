using System;

namespace fizzbuzz {


public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("hey");
        bool isFizz, isBuzz;
        for (int i=1; i<=15; i++) 
        {
            string stringOutput = "";
            bool isValidInput = int.TryParse(Console.ReadLine(), out int num);
            if (isValidInput) {
                isFizz = num % 3 == 0 ? true : false;
                isBuzz = num % 5 == 0 ? true : false;
                if (isFizz || isBuzz) {
                    if(isFizz) stringOutput += "fizz"; 
                    if(isBuzz) stringOutput += "buzz"; 
                } else {
                    stringOutput += Convert.ToString(num);
                }
                System.Console.WriteLine(stringOutput);
            } else {
                System.Console.WriteLine("invalid numer!");
            }

        }

    }
}

}