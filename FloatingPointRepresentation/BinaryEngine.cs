using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet;
using MathNet.Numerics;
using System.Windows.Forms;

namespace FloatingPointRepresentation
{
    class BinaryEngine
    {
        string inputString;
        List<char> inputStringCharsList = new List<char> { };
        Bases.bases inputBase;
        List<char> HexChars = new List <char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
       // string [] DecChars = new string [] {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" };

        public BinaryEngine(string rawInput, Bases.bases baseInput){
            inputString = rawInput;
            inputBase = baseInput;

            foreach (char inputStringChar in rawInput) { 
                char ProcessedChar=' ';
                if (inputStringChar == ' ') { }
                else {
                    if (!char.IsDigit(inputStringChar)) ProcessedChar = char.ToUpper(inputStringChar);
                    else ProcessedChar = inputStringChar;

                    inputStringCharsList.Add(ProcessedChar);
                }
            }
            
        }

        private int returnIndexOfItemInCollection(char char2Find, List<char> items) {
            int counter = -1;

            for (int i = 0; i < items.Count; i++) {
                if (items[i] == char2Find) counter = i;
            }

            return counter;
        }

        private Boolean HasNonDigits(string inputStr)
        {
            Boolean hasNonDigits = false;

            foreach (char stringChar in inputStr)
            {
                if (!char.IsDigit(stringChar)) hasNonDigits = true;
            }

            return hasNonDigits;
        }



        public string ConvertFromHex() {
            string remedy = "";
            string Answer = "";
            
            List<int> Hex2DecList = new List<int> { };


            if (inputBase != Bases.bases.HEX) throw new Exception("Invalid InputBase!-Aborting");
            else if (inputStringCharsList.Count == 0) throw new Exception("The Input String is Either Invalid or Empty.");
            else
            {
                
                Hex2DecList.Clear();
                for (int i = 0; i < inputStringCharsList.Count; i++)
                {
                    int IndexPosition = returnIndexOfItemInCollection(inputStringCharsList[i], HexChars);

                    if (IndexPosition == -1) throw new Exception("Invalid HEX Characters Found!");
                    else {
                        string[] defaultStringChars = new string[4];

                        int charCounter = defaultStringChars.Count();
                        int IndexPositionTemp = IndexPosition;
                        
                        while (IndexPositionTemp > 1) {
                            int divisionRemainder = IndexPositionTemp % 2;


                            defaultStringChars[charCounter - 1] = divisionRemainder.ToString();
                            IndexPositionTemp = IndexPositionTemp / 2;
                            charCounter = charCounter - 1;

                            if (IndexPositionTemp <= 1) defaultStringChars[charCounter - 1] = IndexPositionTemp.ToString ();
                            

                        }

                        if (IndexPosition == 0) Answer = Answer + "0000";
                        else if (IndexPosition == 1) Answer = Answer + "0001";
                        else {
                            for (int j = 0; j < defaultStringChars.Count(); j++) {

                                Answer = Answer + defaultStringChars[j];

                            }
                        }
                    }
                }
            }

            return Answer;
      
        }

        public string ConvertFromDecimal() {

            string Answer = "";

            string processedString = "";

            foreach (char listChar in inputStringCharsList)
            {
                processedString = processedString + listChar.ToString();
            }

            Boolean has_NonDigit = HasNonDigits(processedString);



            if (inputBase != Bases.bases.DEC) throw new Exception("Invalid InputBase!-Aborting");
            else if (inputStringCharsList.Count == 0) throw new Exception("The Input String is Either Invalid or Empty.");
            else if (has_NonDigit) throw new Exception("Non Digits Found in Input String");
            else {

                long inputString2Decimal = long.Parse(processedString);

                long decimal2Convert = inputString2Decimal;

                while (decimal2Convert > 1) {

                    Answer = Answer + (decimal2Convert % 2).ToString();
                    decimal2Convert = decimal2Convert / 2;
                    if (decimal2Convert <= 1) Answer = Answer + decimal2Convert.ToString();
                }
            }

            string reversedAnswer = "";

            int counter = Answer.Length;
            for (int k = 0; k < Answer.Length; k++)
            {

                reversedAnswer = reversedAnswer + Answer[counter - 1].ToString();
                counter--;
            }

            return reversedAnswer;
        }

        //public string ConvertFromOct() { 
        //}

        //public string ConvertFromBCD() { 
        //}

        //public string ConvertFromASCII() { 
        //}
    }
}
