
using System.Data.SqlTypes;
using System.Diagnostics.Metrics;
using System.Diagnostics.Tracing;
using System.Globalization;

string input;

Console.WriteLine("Mata in en sträng:");

input = Console.ReadLine();

List<string> validSubstrings = new List<string>();

int index;

long sumOfNumbers = 0;

for (int i = 0; i < input.Length; i++)

{
    
    index = i;

    if (char.IsDigit(input[i]))

    {

        for (int j = i + 1; j < input.Length; j++)
        {



            if (!char.IsDigit(input[j]))
            {
                break;
            }
            if (input[i] == input[j])
            {

                string substring = input.Substring(i, j - i + 1);
                validSubstrings.Add(substring);

                string substringFöre = input.Substring(0, i);

                string substringEfter = input.Substring(j + 1, input.Length-substring.Length-substringFöre.Length);

                long result;
                long.TryParse(substring, out result);
                sumOfNumbers += result;


                Console.Write(substringFöre);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(substring);
                Console.ResetColor();
                Console.WriteLine(substringEfter);

                break;

            }

        }


    }

}

Console.WriteLine("Summan: " + sumOfNumbers);












