using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.KeyEventHandler;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Практическая_27___игра
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
            this.KeyPreview = true;//Для того чтобы событие KeyDown работало,
                                   //нужно установить свойство KeyPreview формы в значение true.
                                   //Это позволит форме первым получать события нажатия клавиш перед тем,
                                   //как они будут переданы элементам управления на форме.
        }

        Rectangle Square = new Rectangle(375, 252, 10, 10);
        //  Random rand = new Random();

        int dx = 0;
        int dy = 0;
        bool start = false;
        int directionX = 0;
        int directionY = 0;

        private void pBFieldOfPlay_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Green, Square);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 100;
            timer.Tick += new EventHandler(CausedLoop);
            timer.Start();
        }

        void CausedLoop(object sender, EventArgs e)
        {
            Loop(Square, dx, dy);
        }

        void Loop(Rectangle Square, int dx, int dy) {
            Square.Offset(dx, dy);
            this.Square = Square;//ВАЖНАЯ ХУЙНЯ

            pBFieldOfPlay.Invalidate();
           
            //MessageBox.Show(Convert.ToString(Square.Y));
        }

        private void btnStartOrStop_Click(object sender, EventArgs e)
        {
          
            if (start == false) {
                if (directionX == 0 && directionY == 0)
                {
                    dx = 0;
                    dy = 10;
                    btnStartOrStop.Text = "Остановить";
                }
                else {
                    dx = directionX;
                    dy = directionY;

                    directionX = 0;
                    directionY = 0;
                    btnStartOrStop.Text = "Остановить";
                }  
            }
            if (start == true)
            {
                directionX = dx;
                directionY = dy;

                dx = 0;
                dy = 0;

                start = false;
                btnStartOrStop.Text = "Начать";
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (btnStartOrStop.Text == "Остановить")
            {
                start = true;

                if (e.KeyCode == Keys.A && dx != 10)
                {
                    dy = 0;
                    dx = -10;
                }
                if (e.KeyCode == Keys.D && dx != -10)
                {
                    dy = 0;
                    dx = 10;
                }
                if (e.KeyCode == Keys.W && dy != 10)
                {
                    dy = -10;
                    dx = 0;
                }
                if (e.KeyCode == Keys.S && dy != -10)
                {
                    dy = 10;
                    dx = 0;
                }
            }
        }

        private void lblMaxScore_Click(object sender, EventArgs e)
        {

        }
    }
}
//  MessageBox.Show(Convert.ToString(Square.X));
//MessageBox.Show("Мы дебилы?");
//Square.Offset(dx,dy);
//ControlPaint.DrawReversibleFrame(Square,SystemColors.Highlight, FrameStyle.Thick);

/* if (e.KeyCode == Keys.Left && dx!=-20)
            {
                dy = 0;
                dx = 20;  
            }
            if (e.KeyCode == Keys.Right && dx != 20)
            {
                dy = 0;
                dx = -20;
            }
            if (e.KeyCode == Keys.Up && dy != -20)
            {
                dy = 20;
                dx = 0;
            }
            if (e.KeyCode == Keys.Down && dy != 20)
            {
                dy = -20;
                dx = 0;
            }*/