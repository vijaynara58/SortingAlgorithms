using System;

namespace SortingAlgorithms
{
    public class cLists
    {
        private int[] listOfNumbers;
        private string[] listOfLetters;

        public static Random rnd = new Random();

        //getter and setter for listOfNumbers
        public int[] listOfNumber
        {
            get
            {
                return listOfNumbers;
            }

            set
            {
                listOfNumbers = value;
            }
        }

        //getter and setter for listOfLetters
        public string[] listOfLetter
        {
            get
            {
                return listOfLetters;
            }

            set
            {
                listOfLetters = value;
            }
        }

        //constructor
        public cLists()
        {
        }

        //method to create and fill the list of numbers
        public void createListOfNumbers(int _nbOfNumbers)
        {
            int[] tempListOfNumbers = new int[_nbOfNumbers];

            for (int i = 0; i < _nbOfNumbers; i++)
            {
                tempListOfNumbers[i] = rnd.Next(0, _nbOfNumbers);
            }

            listOfNumbers = tempListOfNumbers;
        }

        //method to create and fill the list of letters
        public void createListOfLetters(int _nbOfLetters)
        {
            string[] tempListOfLetters = new string[_nbOfLetters];

            for(int i=0; i < _nbOfLetters; i++)
            {
                char x = (char)rndLetters();
                tempListOfLetters[i] = x.ToString();
            }

            listOfLetters = tempListOfLetters;
        }

        //create a string of numbers with comma+space between each number
        public string convListNbToString(int[] _tempListOfNumber)
        {
            string theReturn = "";

            foreach (int num in _tempListOfNumber)
            {
                theReturn += num + ", ";
            }

            return theReturn;
        }

        //create a string of letters with comma+space between each letters
        public string convListLetterToString(string[] _tempListOfLetter)
        {
            string theReturn = "";

            foreach (string letter in _tempListOfLetter)
            {
                theReturn += letter + ",";
            }

            theReturn = theReturn.Substring(0, theReturn.Length - 1);

            return theReturn;
        }

        //randomly generate a letter (ASCII code)
        public int rndLetters()
        {
            int tempo;

            //generate a random number between 65 and 122
            tempo = rnd.Next(65, 122);

            //validate that the number is not between 90 and 97
            if(tempo > 90 && tempo < 97)
            {
                //recursiveness ... run rndLetters() again
                tempo = rndLetters();
            }

            return tempo;
        }
    }
}
