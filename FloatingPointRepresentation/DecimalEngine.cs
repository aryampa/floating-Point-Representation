using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatingPointRepresentation
{
    class DecimalEngine
    {

        private string inputString;
        private List<char> inputStringCharsList = new List<char> { };
        private Bases.bases inputBase;
        private List<char> HexChars = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

        private List<string> DecimalChars = new List<string> { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" };

        public DecimalEngine(string rawInput, Bases.bases baseInput) {


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

        private Boolean HasNonDigits(string inputStr)
        {
            Boolean hasNonDigits = false;

            foreach (char stringChar in inputStr)
            {
                if (!char.IsDigit(stringChar)) hasNonDigits = true;
            }

            return hasNonDigits;
        }

        private Boolean HasNonBinaryDigits(string inputStr)
        {
            string allowedBinary = "01";
            Boolean hasNonDigits = false;

            foreach (char stringChar in inputStr)
            {
                if (!char.IsDigit(stringChar)) hasNonDigits = true;
                else if(!allowedBinary.Contains(stringChar)) hasNonDigits = true;
            }

            return hasNonDigits;
        }

        public string  ConvertFromBinary(){

            string Answer = "";

            string processedString = "";

            List<int> listWithBinaryDigits = new List<int>{};

            foreach (char listChar in inputStringCharsList) {
                processedString = processedString + listChar.ToString();
            }

            Boolean has_NonBinaryDigit = HasNonDigits(processedString);




            if (inputBase != Bases.bases.BIN) throw new Exception("Invalid InputBase!-Aborting");
            else if (inputStringCharsList.Count == 0) throw new Exception("The Input String is Either Invalid or Empty.");
            else if (has_NonBinaryDigit) throw new Exception("Non Binary Digits Found in Input String");
            else{

                listWithBinaryDigits.Clear();
                long decimalTotal = 0;
                int totalBinaryDigits = inputStringCharsList.Count;

                for(int y =0; y<inputStringCharsList.Count; y++){

                    decimalTotal = decimalTotal +(long.Parse(inputStringCharsList[y].ToString())*(long) Math.Pow(2, totalBinaryDigits-(y+1)));


                   // listWithBinaryDigits.Add(int.Parse(inputStringCharsList[y].ToString()));
                }

                Answer = decimalTotal.ToString();



            }

            return Answer;

        }










    }
}
