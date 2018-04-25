using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreedySnake {
    public partial class MainForm : Form {
        private int time=0;
        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            // timer1.Tick += new EventHandler(timer1_Tick);
            //键盘敲击事件
            Console.Write("MainForm_Load");
        }

        private void LabTitle_Click(object sender, EventArgs e) {
            //造 蛇 身体，长度为5
            for (int i = 0; i < 5; i++) {
                Label lb = new Label();
                lb.Width = lb.Height = 20;
                lb.Top = 400;
                lb.Left = 400 - i * 20;
                lb.BackColor = Color.Red;
                lb.Text = "O";
                lb.Font = new System.Drawing.Font("宋体", 18);
                lb.Tag = i;
                //l_b[i] = lb;
                this.Controls.Add(lb);
            }
        }


        private void Startbutton_Click(object sender, EventArgs e) {
            MainClass.StartGame();
            LabTitle.Text = "贪食蛇";
        }

        private void timer1_Tick(object sender, EventArgs e) {
            time += 1;
           // Console.Write(" "+time);
            labelScore.Text = time.ToString();
          //  SnakeMove();
        }

        private void SnakeMove() {
           // Snakehand.Left += Snakehand.Left+1;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode.ToString() == "W")   //向右
            {
                LabTitle.Text = "up";
            }
            if (e.KeyCode.ToString() == "A")    //向上
            {
                LabTitle.Text = "left";
            }
            if (e.KeyCode.ToString() == "S")     //向下
            {
                LabTitle.Text = "down";
            }
            if (e.KeyCode.ToString() == "D")    //向左
            {
                LabTitle.Text = "right";
            }
        }


    }
}
