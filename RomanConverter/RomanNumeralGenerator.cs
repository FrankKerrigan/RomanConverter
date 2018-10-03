using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using CommonInterfaces;

namespace RomanConverter
{
   public class RomanNumeralGenerator : IGenerator
   {
       //This will keep the order as they are added to the list
       private readonly List<KeyValuePair<int, string>> _valueBuilder;
    
       /// <summary>
       /// Constructor for initialising 
       /// </summary>
       public RomanNumeralGenerator()
       {
           _valueBuilder = LoadValues();
       }

       
        /// <summary>
        /// Run Generate for Int to Roman Nums
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public string Generate(int number)
        {
            try
            {
                if (number < 0 || number > 3999) //likely config max value
                    throw new ArgumentOutOfRangeException($"Number value '{number}' not supported ");

                return RunGenerate(number);
            }
            catch (Exception ex)
            {
                //Replace with Logging framework
                //Console.WriteLine($"{DateTime.Now.ToString(CultureInfo.InvariantCulture)}  Exception in RomanNumeralGenerator.Generate for number {number}  Error: {ex.Message}  Stack:  {ex.StackTrace}  ");
                throw;
            }
        }


       /// <summary>
       /// Run the Generator:
       /// Uses reduction to make workingnumber smaller looking for bigger numerals first.
       /// </summary>
       /// <param name="number">Integer for conversion</param>
       /// <returns>string of Roman Number</returns>
        private string RunGenerate(int number)
        {
            StringBuilder result = new StringBuilder();
            int workingNumber = number;

            while (workingNumber > 0)
            {
                foreach (var pair in _valueBuilder)
                {
                    if (workingNumber >= pair.Key)
                    {
                        result.Append(pair.Value);
                        workingNumber -= pair.Key;
                        break; //enables MM etc.
                    }
                }
            }
            return result.ToString();
        }


       /// <summary>
       /// Get Values for Conversion
       /// This might come from a DAL layer or config
       ///  </summary>
       /// <returns>Ordered List of Conversions KVP</returns>
       private List<KeyValuePair<int, string>> LoadValues()
       {
           var vbuilders = new List<KeyValuePair<int, string>>();
           
           
           vbuilders.Add(new KeyValuePair<int, string>(1000, "M"));
           vbuilders.Add(new KeyValuePair<int, string>(900, "CM"));
           vbuilders.Add(new KeyValuePair<int, string>(500, "D"));
           vbuilders.Add(new KeyValuePair<int, string>(400, "CD"));
           vbuilders.Add(new KeyValuePair<int, string>(100, "C"));
           vbuilders.Add(new KeyValuePair<int, string>(90, "XC"));
           vbuilders.Add(new KeyValuePair<int, string>(50, "L"));
           vbuilders.Add(new KeyValuePair<int, string>(40, "XL"));
           vbuilders.Add(new KeyValuePair<int, string>(10, "X"));
           vbuilders.Add(new KeyValuePair<int, string>(9, "IX"));
           vbuilders.Add(new KeyValuePair<int, string>(5, "V"));
           vbuilders.Add(new KeyValuePair<int, string>(4, "IV"));
           vbuilders.Add(new KeyValuePair<int, string>(1, "I"));

           return vbuilders;
       }
   }
}
