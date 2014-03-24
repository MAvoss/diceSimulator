using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
namespace Week2JoshuavossIndividual
{
    /*
     * 
     * Design, implement, test, and debug a C# program to simulate the rolling of two dice 100 times, and write and read results from a file.
 
 When the user clicks a Write button, the program will write the sum of the dice for each roll into a sequential data file. After the file is written, the user may click a Read button to read the items back in and display the results.
 
Design a GUI for the program that will be intuitive for a novice user.
 
Write the code for the program and test the results.
 
Zip the files of the project together and submit the zipped file.
     * 
     * 
     * all images are licenenced under creative commons licence with no copy right for free non commerical use 
     * joshau voss 
     * 
     * version 1.0
     * 
     * */
    public partial class Form1 : Form
    {
        int number = 0;//dice number 1
        int number2 = 0;//dice number 2
        int counter = 0;
        
        double[] freq = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }; // creates place holders for array to allow reading of frequency 

       



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;


            

            
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox1.Visible = true;
            counter = 0; //resets counter every time it is clicked 

            

            timer1.Start();//runs a timer to allow visual changes of dice 
            //set visual formating before loop is run so user understand what they are seeing 

           // listBox1.Items.Add("Counter" + "        " + "dice 1" + "        " + "dice 2" + "        " + "Total");

            button1.Enabled = true;
            
         


        }

        private void die1changer()
        {
            if (number == 6)
            {
                Dice1.Image = Properties.Resources.d6;

            }
            if (number == 5)
            {
                Dice1.Image = Properties.Resources.d5;

            }
            if (number == 4)
            {
                Dice1.Image = Properties.Resources.d4;

            }
            if (number == 3)
            {
                Dice1.Image = Properties.Resources.d3;

            }
            if (number == 2)
            {
                Dice1.Image = Properties.Resources.d2;

            }
            if (number == 1)
            {
                Dice1.Image = Properties.Resources.d1;

            }

        }
        private void die2changer()
        {
            if (number2 == 6)
            {
                Dice2.Image = Properties.Resources.d6;

            }
            if (number2 == 5)
            {
                Dice2.Image = Properties.Resources.d5;

            }
            if (number2 == 4)
            {
                Dice2.Image = Properties.Resources.d4;

            }
            if (number2 == 3)
            {
                Dice2.Image = Properties.Resources.d3;

            }
            if (number2 == 2)
            {
                Dice2.Image = Properties.Resources.d2;

            }
            if (number2 == 1)
            {
                Dice2.Image = Properties.Resources.d1;

            }

        }
        private StreamWriter sr;
        private StreamWriter tr;
        
        private void writeFile()
        {
            string FILE_NAME = "C:\\data.txt";

            tr = new System.IO.StreamWriter("C:\\total.txt");


            //loads file if it exist if not creats a file to write to 

            sr = new System.IO.StreamWriter(FILE_NAME);
            

            int i = 0;

            for (i = 0; i <= listBox1.Items.Count - 1; i++)
            {
                
                sr.Write(listBox1.Items[i]);
                sr.Write(Environment.NewLine);
            }
            for (i = 0; i <= listBox2.Items.Count - 1; i++)
            {
                tr.Write(listBox2.Items[i]);
                tr.Write(Environment.NewLine);
                
            }





            MessageBox.Show("Text written to file  C:\\data.txt");

            btnSave.Enabled = true;
            btnLoad.Enabled = true;

            tr.Close();
            sr.Close();//file will not save unless closed 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            timer1.Stop();
            writeFile();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            loadinfo();
            freqcheck();
        }

        private void loadinfo()
        {
            listBox1.Items.Clear();
            timer1.Stop();
            //reads the file and writes back to the listbox 
            try
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader("C:\\data.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            string strListItem = sr.ReadLine();
                            if (!String.IsNullOrEmpty(strListItem))
                                listBox1.Items.Add(strListItem);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("no file exist try saving first");
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //frequency code does not work with out 100 values it wound round properly and glicthes if using itme.count 
            // so i diables the ability to save until the total is 100 
            if (listBox2.Items.Count == 100)
            {
                btnSave.Enabled = true;

            }
            
            //assigns random number variable for both die 
            
            Random randomnumber1 = null;

            //holds a defualt value of zero untill loop begins 


            int total = 0;
            randomnumber1 = new Random();

            //grabs new random number for every amount of int selected 
            //set the bounds to 1 -6 because standared d6 is what im basing this program on 
            number = randomnumber1.Next(1, 7);//needed to change to seven to get to show six number probaly could have used 0,6 as bounds as well but it works 
            number2 = randomnumber1.Next(1, 7);
            total = (number + number2);



            //this can be used to run the equations in a for loop but would not allow for the graphical changes so i left it in case i want to change later 
            int i = 0;
            for (i = 1; i <= 100; i++)
            {

                counter = counter + 1;

            }
            counter = counter - 99; // this fixes weird formattng with counter 
            listBox1.Items.Add(counter  + "                  " + number + "               " + number2 + "                 " + total);
            listBox2.Items.Add(total);

            if (listBox1.Items.Count.Equals(101))//gives one extra line for the title line 
            {
                //stops timer or else program loops for ever as the timer will just not stop
                timer1.Stop();
                writeFile();
                freqcheck();
            }

            //keeps focus on last item in list box 
            listBox1.SetSelected(listBox1.Items.Count - 1, true);
            //calls the die changer methods used because i didnt want a million if statments for some thing simple sitting in the logic 
            die1changer();
            die2changer();
        }

        private void btnQuick_Click(object sender, EventArgs e)
        {
            quickroll();
            timer1.Stop();
            writeFile();
            freqcheck();

        }
        private void quickroll()
        {
            timer1.Stop();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            Random randomnumber1 = null;

            //holds a defualt value of zero untill loop begins 


            int total = 0;
            randomnumber1 = new Random();


            counter = 0;

            //  listBox1.Items.Add("Counter" + "        " + "dice 1" + "        " + "dice 2" + "        " + "Total");
            //this can be used to run the equations in a for loop but would not allow for the graphical changes so i left it in case i want to change later 
            int i = 0;
            for (i = 1; i <= 100; i++)
            {
                //grabs new random number for every amount of int selected 
                //set the bounds to 1 -6 because standared d6 is what im basing this program on 
                number = randomnumber1.Next(1, 7);//needed to change to seven to get to show six number probaly could have used 0,6 as bounds as well but it works 
                number2 = randomnumber1.Next(1, 7);
                total = (number + number2);

                counter = counter + 1;
                listBox2.Items.Add(total);
                listBox1.Items.Add(counter + "                  " + number + "               " + number2 + "                 " + total);
            }




            btnSave.Enabled = true;

            //keeps focus on last item in list box 
            listBox1.SetSelected(listBox1.Items.Count - 1, true);
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //exits program
            Environment.Exit(0);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //shows the about menu and loads from that class a webpage with info about the program hope to reuses this class and make it a standard 
            About about = new About();
            about.Show();
        }

        private void btnfrequency_Click(object sender, EventArgs e)
        {

            freqcheck();
            
        }
        private void freqcheck()
        {
            int temp = 100;


            string line;
            listBox2.Items.Clear();
            try
            {
                StreamReader sr = new StreamReader("C:\\total.txt");

                while ((line = sr.ReadLine()) != null)
                {

                    listBox2.Items.Add(line.ToString());


                    //wasnt able to get percentage to fill dustin pauly helped with this section of code it gets the value of a total whcich can 
                    //be no lower than 2 
                    temp = Convert.ToInt16(line);
                    freq[temp - 2] += 1;







                }
                sr.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("no file exist...Yet");
            }



            //   rolls = listBox2.Items.Count;
            for (int i = 0; i < freq.Length; ++i)
            {
                //tried to use list2.items.count so i could calculate with a limited number of rolls 10 replace the 100 value for the divider 
                //but when you click the frequency button it does not calculate corecctley but will after multiple clicks ****must be a glitch or bug *****
                freq[i] = Math.Round(freq[i] / 100, 2);// numbers need to be rounded or itll change a few times before settleing 
            }

            label2freq.Text = freq[0].ToString("P");
            label3freq.Text = freq[1].ToString("P");
            label4freq.Text = freq[2].ToString("P");
            label5freq.Text = freq[3].ToString("P");
            label6freq.Text = freq[4].ToString("P");
            label7freq.Text = freq[5].ToString("P");
            labe8freq.Text = freq[6].ToString("P");
            label9freq.Text = freq[7].ToString("P");
            labe10freq.Text = freq[8].ToString("P");
            label11freq.Text = freq[9].ToString("P");
            label12freq.Text = freq[10].ToString("P");

            
        }
      
    }
}
