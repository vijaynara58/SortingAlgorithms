using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SortingAlgorithms
{
    public partial class Sortings : Form
    {
        //initialize cList class
        cLists originalLists = new cLists();

        //calculate the time of sorting
        public Stopwatch sortingTime;

        public Sortings()
        {
            InitializeComponent();
        }

        //button - create list
        private void btnCreateList_Click(object sender, EventArgs e)
        {
            int theNb;

            bool result = int.TryParse(txtNumbers.Text, out theNb);

            if(result == false)
            {
                theNb = 40;
            }

            if (radNumbers.Checked)
            {
                originalLists.createListOfNumbers(theNb);
                txtRaw.Text = originalLists.convListNbToString(originalLists.listOfNumber);
            }
            else
            {
                originalLists.createListOfLetters(theNb);
                txtRaw.Text = originalLists.convListLetterToString(originalLists.listOfLetter);
            }

        }

        //calculate sorting time
        public void calculateSortingTime(Control theTimeTextBox, Control theCounterTextBox, int counter)
        {
            theTimeTextBox.Text = sortingTime.ElapsedMilliseconds.ToString();
            theCounterTextBox.Text = counter.ToString();
        }

        //copy numbers array
        private int[] CopyNbArray(int[] ArrayOriginal)
        {
            int[] NewArray = new int[ArrayOriginal.Length];

            for(int increm = 0; increm < ArrayOriginal.Length; increm++)
            {
                NewArray[increm] = ArrayOriginal[increm];
            }
            return NewArray;
        }

        //copy letters array
        private string[] CopyNbArray(string[] ArrayOriginal)
        {
            string[] NewArray = new string[ArrayOriginal.Length];

            for (int increm = 0; increm < ArrayOriginal.Length; increm++)
            {
                NewArray[increm] = ArrayOriginal[increm];
            }
            return NewArray;
        }

        //Bubble Sort
        private void btnBubble_Click(object sender, EventArgs e)
        {

        }

        //Bubble Sort Optimized
        private void btnBubbleOpt_Click(object sender, EventArgs e)
        {

        }

        //Selection Sort
        private void btnSelection_Click(object sender, EventArgs e)
        {

        }

        //Insertion Sort
        private void btnInsertion_Click(object sender, EventArgs e)
        {

        }

        //Merge Sort
        private void btnMerge_Click(object sender, EventArgs e)
        {

        }

        //Quick Sort
        private void btnQuick_Click(object sender, EventArgs e)
        {

        }

        //Microsoft Default Sort
        private void btnMicrosoft_Click(object sender, EventArgs e)
        {
            if (radNumbers.Checked)
            {
                int[] sortedList;
                //copy array from class to sortedList array
                sortedList = CopyNbArray(originalLists.listOfNumber);
                //start timer
                sortingTime = Stopwatch.StartNew();


                //sorting
                Array.Sort(sortedList);


                //stop timer
                sortingTime.Stop();
                //send sorted array into a list
                List<int> sortedNbList1 = sortedList.ToList();
                //bind listbox to sortedNbList
                lstMicrosoft.DataSource = sortedNbList1;
            }
            else
            {
                string[] sortedList = originalLists.listOfLetter;
                //copy array from class to sortedList array
                sortedList = CopyNbArray(originalLists.listOfLetter);
                //start timer
                sortingTime = Stopwatch.StartNew();
                //sorting
                Array.Sort(sortedList);
                //stop timer
                sortingTime.Stop();
                //send sorted array into a list
                List<string> sortedNbList1 = sortedList.ToList();
                //bind listbox to sortedNbList
                lstMicrosoft.DataSource = sortedNbList1;
            }

            calculateSortingTime(txtMicrosoftTime, txtMicrosoftCount, 0);
        }
    }
}
