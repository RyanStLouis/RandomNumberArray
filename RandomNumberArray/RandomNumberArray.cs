/*
 * Created by: Ryan St. Louis
 * Created on: 11-11-2015
 * Created for: ICS3U
 * Daily Assignment – Unit#5-01
 * This program displays an example of a array
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumberArray
{
    public partial class frmRandomNumberArray : Form
    {
        // global variables
        int[] arrayOfNumbers = new int[10];

        public frmRandomNumberArray()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            this.lstRandomBox.Items.Clear();


            // Variables
            int loopCounter = 0;
            int average = 0;
            int listAdder;
            int randomNumbers;

            Random rnd = new Random();

            while (loopCounter < 10)
            {

                randomNumbers = rnd.Next(1, 11);
                arrayOfNumbers[loopCounter] = randomNumbers;
                listAdder = arrayOfNumbers[loopCounter];
                this.lstRandomBox.Items.Add(listAdder);
                average = average + arrayOfNumbers[loopCounter];
                loopCounter++;
            }
            average = average / 10;
            this.lblQuestion.Text = "This is the average: " + average;

        }
    }
}
