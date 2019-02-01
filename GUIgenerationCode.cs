using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace ProjectPicturesGame
{
    public partial class Form1 : Form
    {
        Button[,] btn = new Button[5, 5];       // Create 2D array of buttons
        PictureBox[,] pic = new PictureBox[5, 5];
        Button btn1 = new Button();              // Create new button
        public Form1()
        {
            InitializeComponent();
            btn1.SetBounds(650, 500, 120, 60);     // Set size & position
            btn1.BackColor = Color.PowderBlue;   // Set colour
            btn1.Text = "Start";      
            btn1.Click += new EventHandler(this.btn1Event_Click);
            Controls.Add(btn1);
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
    }
}
