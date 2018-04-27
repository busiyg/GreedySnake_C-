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
        private Random rad=new Random();
        private enum direct {W,A,S,D,stop,};
        private enum GameState { ready,Gameing,GameOver };
        private direct dir= direct.stop;
        private GameState state = GameState.ready;
        private int Score=0;
        private List<Label> bodys = new List<Label>();
        private List<Point> mapPoint = new List<Point>();
        private Label Food;
        private float speed;
        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            SaveMap();
            Snakehand.Left = 300;
            Snakehand.Top = 300;
            InitBaseBodys();
            InitFood();      
        }

        void DestoryBodys(object sender, EventArgs e) {
            foreach (var obj in bodys) {
                this.Controls.Remove(obj);
            }
            bodys.Clear();
          
            Snakehand.Left = 300;
            Snakehand.Top = 300;
            InitBaseBodys();
            开始游戏ToolStripMenuItem_Click(sender,e);
        }

        void SaveMap() {
            for (int i=1;i<38;i++) {
                for (int j=2;j<28;j++) {
                    Point point = new Point();
                    point.X = i * 20;
                    point.Y = j * 20;
                    mapPoint.Add(point);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {      
            CheckGameState();
        }

        private void OnStart_Click(object sender, EventArgs e) {
            state = GameState.Gameing;
            dir = direct.W;
        }

        void InitBaseBodys() {
            for (int i = 0; i < 2; i++) {
                Label lb = new Label();
                lb.Width = lb.Height = 20;
                lb.Top = Snakehand.Top;
                lb.Left = Snakehand.Left + 20;
                lb.BackColor = Color.Red;
                bodys.Add(lb);
                this.Controls.Add(lb);
            }
        }

        void SnakeGrow() {
            Label lb = new Label();
            lb.Width = lb.Height = 20;
            lb.Top = bodys[bodys.Count - 1].Top;
            lb.Left = bodys[bodys.Count - 1].Left;
            lb.BackColor = Color.Red;
            bodys.Add(lb);
            this.Controls.Add(lb);
        }

        void InitFood() {
            var AllowPos = new List<Point>();
            AllowPos.AddRange(mapPoint);

            for (int i=0;i< bodys.Count;i++) {
                Point poi = new Point(bodys[i].Location.X, bodys[i].Location.Y);
                AllowPos.Remove(poi);
            }

            if (Food==null) {
                Label lb = new Label();
                lb.Width = lb.Height = 20;
                lb.Location = AllowPos[rad.Next(0, AllowPos.Count-1)];          
                lb.BackColor = Color.Green;
                Food = lb;
                this.Controls.Add(lb);
            }
            AllowPos.Clear();
        }

        void IsEat() {
            if (Food!=null) {
                if (Snakehand.Location == Food.Location) {
                    SnakeGrow();
                    this.Controls.Remove(Food);
                    Food = null;
                    Score += 1;
                    labelScore.Text = "Score:" + Score.ToString();
                    InitFood();
                }
            }         
        }

        void IsAlive() {
            if (Snakehand.Left<20|| Snakehand.Left>760|| Snakehand.Top < 20 || Snakehand.Top > 560) {
                state = GameState.GameOver;
                MessageBox.Show("Game Over!  Socre:" + Score);
                return;
            }          

            foreach (var obj in bodys) {
                if (obj.Location==Snakehand.Location) {
                    state = GameState.GameOver;
                    MessageBox.Show("Game Over!  Socre:"+Score);
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
                    IsAlive();
                    IsEat();
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
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode.ToString() == "W"&& dir!= direct.S)   //向上
            {
                dir = direct.W;

            }
            if (e.KeyCode.ToString() == "A" && dir != direct.D)    //向左
            {
                dir = direct.A;

            }
            if (e.KeyCode.ToString() == "S" && dir != direct.W)     //向下
            {
                dir = direct.S;
 
            }
            if (e.KeyCode.ToString() == "D" && dir != direct.A)    //向右
            {
                dir = direct.D;
            }
        }

        private void 开始游戏ToolStripMenuItem_Click(object sender, EventArgs e) {
            state = GameState.Gameing;
            dir = direct.A;
        }

        private void Snakehand_Click(object sender, EventArgs e) {

        }

        private void 退出游戏ToolStripMenuItem_Click(object sender, EventArgs e) {
            System.Environment.Exit(0);
        }

        private void 简单ToolStripMenuItem_Click(object sender, EventArgs e) {
            SingleCheck(sender);
            timer1.Interval = 500;
        }

        private void 困难ToolStripMenuItem_Click(object sender, EventArgs e) {
            SingleCheck(sender);
            timer1.Interval = 100;
        }

        private void 疯狂ToolStripMenuItem_Click(object sender, EventArgs e) {
            SingleCheck(sender);
            timer1.Interval = 20;
        }

        private void SingleCheck(object sender)   //单选  
        {
            简单ToolStripMenuItem.Checked = false;
            困难ToolStripMenuItem.Checked = false;
            疯狂ToolStripMenuItem.Checked = false;
            ((ToolStripMenuItem)sender).Checked = true;

        }

        private void 重新开始ToolStripMenuItem_Click(object sender, EventArgs e) {
            DestoryBodys(sender,e);
            Score = 0;
            labelScore.Text ="Score:"+ Score.ToString();
        }

        private void 关于贪食蛇ToolStripMenuItem_Click(object sender, EventArgs e) {
            About about = new About();//首先实例化
            about.Show();//Show方法
        }
    }
}
