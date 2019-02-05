using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjectPicturesGame
{
    public partial class Form1 : Form
    {
        Button[,] btn = new Button[5, 5];       // Create 2D array of buttons
        PictureBox[,] pic = new PictureBox[5, 5];
        Button btn1 = new Button();              // Create new button


        private System.Windows.Forms.Timer timer1;//initialize timer 
        private int counter = 120;//set counter 
        public Form1()
        {
            InitializeComponent();
            btn1.SetBounds(650, 500, 120, 60);     // Set size & position
            btn1.BackColor = Color.PowderBlue;   // Set colour
            btn1.Text = "Start";      
            btn1.Click += new EventHandler(this.btn1Event_Click);
            Controls.Add(btn1);

         // timer code 
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // 1 second
            timer1.Start();
            label1.Text = counter.ToString();
        }
        private void timer1_Tick(object sender, EventArgs e)

        {

            counter--;
            if (counter == 0)

                timer1.Stop();
            label1.Text = counter.ToString();

        }



        void btn1Event_Click(object sender, EventArgs e) // when we click the button we generate array of buttons and pictureboxes for images
        {
            for (int x = 0; x < pic.GetLength(0); x++)         // Loop for x
            {
                for (int y = 0; y < pic.GetLength(1); y++)     // Loop for y
                {
                    pic[x, y] = new PictureBox();
                    pic[x, y].SetBounds(120 * x, 120 * y, 100, 100);
                    pic[x, y].Visible = false;
                    Controls.Add(pic[x, y]);     // Put the item onto the GUI

                }
            }


            for (int x = 0; x < btn.GetLength(0); x++)         // Loop for x
            {
                for (int y = 0; y < btn.GetLength(1); y++)     // Loop for y
                {
                    btn[x, y] = new Button();
                    btn[x, y].SetBounds(120 * x, 120 * y, 100, 100);
                    btn[x, y].BackColor = Color.PowderBlue;
                    btn[x, y].Text = Convert.ToString((x + 1) + "," + (y + 1));
                    btn[x, y].Click += new EventHandler(this.btnEvent_Click);
                    Controls.Add(btn[x, y]);     // Put the item onto the GUI

                }
            }
        }

        void btnEvent_Click(object sender, EventArgs e)
        {
            Console.WriteLine(((Button)sender).Text);    // SAME handler as before
        }

        private void Form1_Load(object sender, EventArgs e)  //REQUIRED
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
