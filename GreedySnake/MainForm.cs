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
        private enum direct {W,A,S,D,stop,};
        private enum GameState { ready,Gameing,GameOver };
        private direct dir= direct.stop;
        private GameState state = GameState.ready;
        private int time=0;
        private List<Label> bodys = new List<Label>();
        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {

            for (int i=0;i<2;i++) {
                Label lb = new Label();
                lb.Width = lb.Height = 20;
                lb.Top = Snakehand.Top;
                lb.Left = Snakehand.Left + 20;
                lb.BackColor = Color.Red;
                bodys.Add(lb);
                this.Controls.Add(lb);

                Console.Write("bodys.count:" + bodys.Count);
            }
         
        }

        private void Startbutton_Click(object sender, EventArgs e) {
            Label lb = new Label();
            lb.Width = lb.Height = 20;
            lb.Top = bodys[bodys.Count-1].Top;
            lb.Left = bodys[bodys.Count - 1].Left;
            lb.BackColor = Color.Red;
            bodys.Add(lb);
            this.Controls.Add(lb);

            Console.Write("bodys.count:"+bodys.Count);
        }

        private void timer1_Tick(object sender, EventArgs e) {
            time += 1;
            labelScore.Text = time.ToString();
            IsAlive();
            CheckGameState();
            
        }

        void IsAlive() {
            foreach (var obj in bodys) {
                if (obj.Left==Snakehand.Left&&obj.Top==Snakehand.Top) {
                    state = GameState.GameOver;
                    break;
                }
            }
        }

        private void CheckGameState() {
            switch (state) {
                case GameState.ready:
                
                    break;
                case GameState.Gameing:
                    SnakeMove();
                    break;
                case GameState.GameOver:
                    break;
       
            }
        }

        private void SnakeMove() {
            BodyMove();
            switch (dir) {
                case direct.W:
                    Snakehand.Top -= 20;
                    break;
                case direct.A:
                    Snakehand.Left -= 20;
                    break;
                case direct.S:
                    Snakehand.Top += 20;
                    break;
                case direct.D:
                    Snakehand.Left += 20;
                    break;
                case direct.stop:
                  
                    break;
            }

        }

        void BodyMove() {
            if (bodys.Count >1) {
                for (int i = bodys.Count - 2; i >= 0; i--) {
                    //每个蛇尾都移动到它前一个目标点的位置  
                    bodys[i + 1].Left = bodys[i].Left;
                    bodys[i + 1].Top = bodys[i].Top;
                }

                bodys[0].Left = Snakehand.Left;
                bodys[0].Top = Snakehand.Top;
            } else {
                for (int i = 1; i < bodys.Count; i++) {
                    bodys[i].Left = bodys[i - 1].Left;
                    bodys[i].Top = bodys[i - 1].Top;
                }
            }
            //if (bodys.Count>1) {

            //}

        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode.ToString() == "W"&& dir!= direct.S)   //向上
            {
                dir = direct.W;
                LabTitle.Text = "up";
            }
            if (e.KeyCode.ToString() == "A" && dir != direct.D)    //向左
            {
                dir = direct.A;
                LabTitle.Text = "left";
            }
            if (e.KeyCode.ToString() == "S" && dir != direct.W)     //向下
            {
                dir = direct.S;
                LabTitle.Text = "down";
            }
            if (e.KeyCode.ToString() == "D" && dir != direct.A)    //向右
            {
                dir = direct.D;
                LabTitle.Text = "right";
            }
        }

        private void OnStart_Click(object sender, EventArgs e) {
            state = GameState.Gameing;
            dir = direct.W;
        }
    }
}
