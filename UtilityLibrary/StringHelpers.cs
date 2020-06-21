using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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

    }
}
