using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanConverter.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            var  parse = parseArgs(args);

            if (parse.HasError)
            {
                Console.WriteLine($"Arguements are not valid: {parse.ExceptionMessage}");
                return;
            }

            RomanNumeralGenerator generator = new RomanNumeralGenerator();
            var inRomanNums = generator.Generate(parse.ParsedInt);

            Console.WriteLine($"{parse.ParsedInt} in Roman Numerals is {inRomanNums}");


        }


        

        static ParseMessage parseArgs(string[] args)
        {
            var result = new ParseMessage();

            try
            {
                
                if (args == null || args.Length != 1)
                {
                    result.HasError = true;
                    result.ExceptionMessage = "Only one arguement is excepted";
                    return result;
                }

                result.HasError = !int.TryParse(args[0], out var parsednumber);
                result.ExceptionMessage = result.HasError ? "Parse Error" : string.Empty;
            }
            catch (Exception ex)
            {
                result.HasError = true;
                result.ExceptionMessage = ex.Message;
            }

            return result;
        }
    }
}
