using System;
using System.Text;
using System.Text.RegularExpressions;

namespace UtilityLibrary
{
    public class StringHelpers
    {



        public static string IncrementAlphaNumericValue(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return "";
            }

            if (Regex.IsMatch(value, "^[a-zA-Z0-9]+$") == false)
            {
                throw new Exception("Invalid Character: Must be a-Z or 0-9");
            }

            var characterArray = value.ToCharArray();

            for (var characterIndex = characterArray.Length - 1; characterIndex >= 0; characterIndex--)
            {
                var characterValue = Convert.ToInt32(characterArray[characterIndex]);

                if (characterValue != 57 && characterValue != 90 && characterValue != 122)
                {
                    characterArray[characterIndex]++;

                    for (int resetIndex = characterIndex + 1; resetIndex < characterArray.Length; resetIndex++)
                    {
                        characterValue = Convert.ToInt32(characterArray[resetIndex]);
                        if (characterValue >= 65 && characterValue <= 90)
                        {
                            characterArray[resetIndex] = 'A';
                        }
                        else if (characterValue >= 97 && characterValue <= 122)
                        {
                            characterArray[resetIndex] = 'a';
                        }
                        else if (characterValue >= 48 && characterValue <= 57)
                        {
                            characterArray[resetIndex] = '0';
                        }
                    }

                    return new string(characterArray);

                }
            }

            //If we got through the Character Loop and were not able to increment anything, we return a NULL string. 
            return null;
        }
        /// <summary>
        /// WIP
        /// https://www.experts-exchange.com/questions/29190293/C-automatic-number-create.html
        /// </summary>
        /// <param name="sequenceIdentifier"></param>
        /// <returns></returns>
        public static string IncrementAlphaNumericSequence(long sequenceIdentifier)
        {
            const long div1 = 25 * 25 * 25 * 99;
            const long div2 = 25 * 25 * 99;
            const long div3 = 25 * 99;


            var initialBalance = sequenceIdentifier;
            var code1 = (int)(initialBalance / div1); initialBalance = initialBalance - (code1 * div1);
            var code2 = (int)(initialBalance / div2); initialBalance = initialBalance - (code2 * div2);
            var code3 = (int)(initialBalance / div3); initialBalance = initialBalance - (code3 * div3); ;
            var code4 = initialBalance;

            var sb = new StringBuilder();

            sb.Append(Convert.ToChar(code1 + 64));
            sb.Append(Convert.ToChar(code2 + 64));
            sb.Append("-");
            sb.Append(Convert.ToChar(code3 + 64));
            sb.Append(code4.ToString("00"));

            return sb.ToString();

        }
    }
}
