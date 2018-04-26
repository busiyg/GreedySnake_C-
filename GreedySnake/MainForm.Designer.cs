namespace GreedySnake {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.labelScore = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Snakehand = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.状态ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开始游戏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重新开始ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出游戏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.难度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.简单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.困难ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.疯狂ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(737, 9);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(35, 12);
            this.labelScore.TabIndex = 1;
            this.labelScore.Text = "Score";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Snakehand
            // 
            this.Snakehand.BackColor = System.Drawing.Color.Black;
            this.Snakehand.Location = new System.Drawing.Point(300, 300);
            this.Snakehand.Name = "Snakehand";
            this.Snakehand.Size = new System.Drawing.Size(20, 20);
            this.Snakehand.TabIndex = 3;
            this.Snakehand.Text = "label1";
            this.Snakehand.Click += new System.EventHandler(this.Snakehand_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.状态ToolStripMenuItem,
            this.难度ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 状态ToolStripMenuItem
            // 
            this.状态ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始游戏ToolStripMenuItem,
            this.重新开始ToolStripMenuItem,
            this.退出游戏ToolStripMenuItem});
            this.状态ToolStripMenuItem.Name = "状态ToolStripMenuItem";
            this.状态ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.状态ToolStripMenuItem.Text = "操作";
            // 
            // 开始游戏ToolStripMenuItem
            // 
            this.开始游戏ToolStripMenuItem.Name = "开始游戏ToolStripMenuItem";
            this.开始游戏ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.开始游戏ToolStripMenuItem.Text = "开始游戏";
            this.开始游戏ToolStripMenuItem.Click += new System.EventHandler(this.开始游戏ToolStripMenuItem_Click);
            // 
            // 重新开始ToolStripMenuItem
            // 
            this.重新开始ToolStripMenuItem.Name = "重新开始ToolStripMenuItem";
            this.重新开始ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.重新开始ToolStripMenuItem.Text = "重新开始";
            this.重新开始ToolStripMenuItem.Click += new System.EventHandler(this.重新开始ToolStripMenuItem_Click);
            // 
            // 退出游戏ToolStripMenuItem
            // 
            this.退出游戏ToolStripMenuItem.Name = "退出游戏ToolStripMenuItem";
            this.退出游戏ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.退出游戏ToolStripMenuItem.Text = "退出游戏";
            this.退出游戏ToolStripMenuItem.Click += new System.EventHandler(this.退出游戏ToolStripMenuItem_Click);
            // 
            // 难度ToolStripMenuItem
            // 
            this.难度ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.简单ToolStripMenuItem,
            this.困难ToolStripMenuItem,
            this.疯狂ToolStripMenuItem});
            this.难度ToolStripMenuItem.Name = "难度ToolStripMenuItem";
            this.难度ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.难度ToolStripMenuItem.Text = "难度";
            // 
            // 简单ToolStripMenuItem
            // 
            this.简单ToolStripMenuItem.Checked = true;
            this.简单ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.简单ToolStripMenuItem.Name = "简单ToolStripMenuItem";
            this.简单ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.简单ToolStripMenuItem.Text = "简单";
            this.简单ToolStripMenuItem.Click += new System.EventHandler(this.简单ToolStripMenuItem_Click);
            // 
            // 困难ToolStripMenuItem
            // 
            this.困难ToolStripMenuItem.Name = "困难ToolStripMenuItem";
            this.困难ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.困难ToolStripMenuItem.Text = "正常";
            this.困难ToolStripMenuItem.Click += new System.EventHandler(this.困难ToolStripMenuItem_Click);
            // 
            // 疯狂ToolStripMenuItem
            // 
            this.疯狂ToolStripMenuItem.Name = "疯狂ToolStripMenuItem";
            this.疯狂ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.疯狂ToolStripMenuItem.Text = "困难";
            this.疯狂ToolStripMenuItem.Click += new System.EventHandler(this.疯狂ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.Snakehand);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "贪食蛇";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Snakehand;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 状态ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开始游戏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重新开始ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出游戏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 难度ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 简单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 困难ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 疯狂ToolStripMenuItem;
    }
}