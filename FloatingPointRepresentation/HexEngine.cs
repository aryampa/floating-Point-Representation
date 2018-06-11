using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatingPointRepresentation
{
    class HexEngine
    {
        private string inputString;
        private List<char> inputStringCharsList = new List<char> { };
        private Bases.bases inputBase;
        private List<char> HexChars = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

         private List<string> DecimalChars = new List<string> {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" };

        public HexEngine(string rawInput, Bases.bases baseInput) {

            inputString = rawInput;
            inputBase = baseInput;

            foreach (char inputStringChar in rawInput)
            {
                char ProcessedChar = ' ';
                if (inputStringChar == ' ') { }// ignore white space
                else
                {
                    if (!char.IsDigit(inputStringChar)) ProcessedChar = char.ToUpper(inputStringChar);
                    else ProcessedChar = inputStringChar;

                    inputStringCharsList.Add(ProcessedChar);
                }
            }
        }


        private int returnIndexOfItemInCollection(string CharString2Find, List<string> items)
        {
            int index = -1;

            for (int i = 0; i < items.Count; i++)
            {
                if (items[i] == CharString2Find) index = i;
            }

            return index;
        }

        private Boolean HasNonDigits(string inputStr) {
            Boolean hasNonDigits = false ;

            foreach (char stringChar in inputStr) { 
                if(!char.IsDigit(stringChar )) hasNonDigits = true;
            }

            return hasNonDigits;
        }

        public string ConvertFromDec()
        {
         
            string Answer = "";

            string processedString = "";

            foreach (char listChar in inputStringCharsList) {
                processedString = processedString + listChar.ToString();
            }

            Boolean has_NonDigit = HasNonDigits(processedString);




            if (inputBase != Bases.bases.DEC) throw new Exception("Invalid InputBase!-Aborting");
            else if (inputStringCharsList.Count == 0) throw new Exception("The Input String is Either Invalid or Empty.");
            else if (has_NonDigit) throw new Exception("Non Digits Found in Input String");
            else
            {

                long inputString2Decimal = long.Parse(processedString);

                long decimal2Convert = inputString2Decimal;

                while (decimal2Convert > 16) {

                    int devisionReminder = (int)(decimal2Convert % 16);
                    decimal2Convert = decimal2Convert / 16;

                    int conversionIndex = returnIndexOfItemInCollection(devisionReminder.ToString(), DecimalChars);
                    Answer = Answer + HexChars[conversionIndex].ToString();

                    if (decimal2Convert < 16) Answer = Answer + HexChars[returnIndexOfItemInCollection(decimal2Convert.ToString(), DecimalChars)].ToString();

                }

            }

            string reversedAnswer ="";

            int counter = Answer.Length;
            for(int k = 0; k<Answer.Length; k++){

                reversedAnswer = reversedAnswer+Answer[counter-1].ToString ();
                counter--;
            }

            return reversedAnswer;

        }

        public string  convertFromBinary(){

            DecimalEngine dEngine = new DecimalEngine(inputString, Bases.bases.BIN);

            HexEngine hEngine = new HexEngine(dEngine.ConvertFromBinary(), Bases.bases.DEC);
            string hexFromDecimal = hEngine.ConvertFromDec();

            return hexFromDecimal;

        }







    }
}
