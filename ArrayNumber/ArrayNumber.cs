/*
* Created by: Matthew Clement
* Created for: Unit #5-02
* Created on: 13-Nov-2015
* This program generates an array of random values and returns the highest one
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

namespace ArrayNumber
{
    public partial class frmArrayNumber : Form
    {
        private int FindHighest(int[] array)
        {
            //Find and return highest number
            int highestNum = 0;

            highestNum = array.Max();

            return highestNum;
        }

        public frmArrayNumber()
        {
            InitializeComponent();
        }

        private void btnClickHere_Click(object sender, EventArgs e)
        {
            //Local variables
            int highestValue;
            int[] numArray = new int[5];

            //Random number generator
            Random rndNumber = new Random();

            for (int counter = 0; counter < 5; counter++)
            {
                //Add 5 random numbers to array
                int randomValue = rndNumber.Next(1,10+1);
                numArray[counter] = randomValue;
            }
            //Call function and pass array
            highestValue = FindHighest(numArray);

            //Output
            MessageBox.Show("The highest value is: " + highestValue);
        }
    }
}
