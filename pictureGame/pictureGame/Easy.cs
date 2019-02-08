using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pictureGame
{
    public partial class Easy : Form
    {

        Button[,] btn = new Button[3, 3];       // Create 2D array of buttons
        PictureBox[,] pic = new PictureBox[3, 3];
        Label label1 = new Label();              // Create new label


        private System.Windows.Forms.Timer timer1;//initialize timer 
        private int counter = 60;//set counter 

        public Easy()
        {

            //initialize label for timer
            InitializeComponent();
            label1.SetBounds(410, 60, 30, 30);     // Set size & position
            label1.BackColor = Color.PowderBlue;   // Set colour
            label1.Text = "Start";         Controls.Add(label1);

            // timer code 
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // 1 second
            timer1.Start();
            label1.Text = counter.ToString();


            for (int x = 0; x < btn.GetLength(0); x++)         // Loop for x
            {
                for (int y = 0; y < btn.GetLength(1); y++)     // Loop for y
                {
                    btn[x, y] = new Button();
                    btn[x, y].SetBounds(120 * x, 120 * y, 100, 100);
                    btn[x, y].BackColor = Color.PowderBlue;
                    //btn[x, y].Text = Convert.ToString((x + 1) + "" + (y + 1));
                    btn[x, y].Click += new EventHandler(this.btnEvent_Click);
                    // btn[x, y].Visible = false;
                    Controls.Add(btn[x, y]);     // Put the item onto the GUI

                }
            }

            for (int x = 0; x < pic.GetLength(0); x++)         // Loop for x
            {
                for (int y = 0; y < pic.GetLength(1); y++)     // Loop for y
                {
                    pic[x, y] = new PictureBox();
                    pic[x, y].SetBounds(120 * x, 120 * y, 100, 100);
                   // pic[x, y].Visible = true;
                    Controls.Add(pic[x, y]);     // Put the item onto the GUI

                }
            }


           

            
            string[] images = Directory.GetFiles(@"C:\Users\Alex\Desktop", "*.jpg");
            int index = 0;
            int check = 0;
            for (int x = 0; x < pic.GetLength(0); x++)         // Loop for x
            {
                for (int y = 0; y < pic.GetLength(1); y++)     // Loop for y
                {
                    if (check == 2)
                    {
                        index++;
                        check = 0;
                    }
                    if (index > 3)
                    { btn[x, y].Text = "x"; break; }
                    pic[x, y].Image = new Bitmap(images[index]);
                    btn[x, y].Text = Convert.ToString(index +""+ check);
                    check++;

                }
            }
                  


        }

        void btnEvent_Click(object sender, EventArgs e)
        {
            label3.Text = label2.Text;

            var btn = sender as Button;
            btn.Visible = false;

            label2.Text = btn.Text;

            
            if(label2.Text[0]==label3.Text[0])
            {
                /*
                foreach (Button item in Controls.OfType<Button>())
                {

                    
                        if (item.Text[0].Equals(label2.Text[0]) || item.Text.Equals(label3.Text[0]))
                        {
                            item.Visible = false;

                        }
                  
                }*/
            }
            


        }



        private void timer1_Tick(object sender, EventArgs e)

        {
            counter--;
            if (counter == 0)

                timer1.Stop();
            label1.Text = counter.ToString();

        }

        private void Easy_Load(object sender, EventArgs e)
        {

        }


        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Homepage ss = new Homepage();
            ss.Show();
        }
    }
}
