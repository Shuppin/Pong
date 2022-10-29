namespace Pong
{
    partial class Pong
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pong));
            this.paddle_player = new System.Windows.Forms.PictureBox();
            this.paddle_cpu = new System.Windows.Forms.PictureBox();
            this.pong_ball = new System.Windows.Forms.PictureBox();
            this.score_player = new System.Windows.Forms.Label();
            this.score_cpu = new System.Windows.Forms.Label();
            this.pongTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.paddle_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddle_cpu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pong_ball)).BeginInit();
            this.SuspendLayout();
            // 
            // paddle_player
            // 
            this.paddle_player.BackColor = System.Drawing.Color.White;
            this.paddle_player.Location = new System.Drawing.Point(12, 223);
            this.paddle_player.Name = "paddle_player";
            this.paddle_player.Size = new System.Drawing.Size(20, 154);
            this.paddle_player.TabIndex = 0;
            this.paddle_player.TabStop = false;
            // 
            // paddle_cpu
            // 
            this.paddle_cpu.BackColor = System.Drawing.Color.White;
            this.paddle_cpu.Location = new System.Drawing.Point(1032, 223);
            this.paddle_cpu.Name = "paddle_cpu";
            this.paddle_cpu.Size = new System.Drawing.Size(20, 154);
            this.paddle_cpu.TabIndex = 1;
            this.paddle_cpu.TabStop = false;
            // 
            // pong_ball
            // 
            this.pong_ball.BackColor = System.Drawing.Color.Transparent;
            this.pong_ball.Image = global::Pong.Properties.Resources.ball;
            this.pong_ball.Location = new System.Drawing.Point(530, 290);
            this.pong_ball.Name = "pong_ball";
            this.pong_ball.Size = new System.Drawing.Size(20, 20);
            this.pong_ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pong_ball.TabIndex = 2;
            this.pong_ball.TabStop = false;
            // 
            // score_player
            // 
            this.score_player.BackColor = System.Drawing.Color.Transparent;
            this.score_player.Font = new System.Drawing.Font("Cascadia Mono", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.score_player.ForeColor = System.Drawing.Color.White;
            this.score_player.Location = new System.Drawing.Point(500, 9);
            this.score_player.Name = "score_player";
            this.score_player.Size = new System.Drawing.Size(35, 50);
            this.score_player.TabIndex = 3;
            this.score_player.Text = "0";
            this.score_player.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // score_cpu
            // 
            this.score_cpu.BackColor = System.Drawing.Color.Transparent;
            this.score_cpu.Font = new System.Drawing.Font("Cascadia Mono", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.score_cpu.ForeColor = System.Drawing.Color.White;
            this.score_cpu.Location = new System.Drawing.Point(545, 9);
            this.score_cpu.Name = "score_cpu";
            this.score_cpu.Size = new System.Drawing.Size(35, 50);
            this.score_cpu.TabIndex = 4;
            this.score_cpu.Text = "0";
            this.score_cpu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pongTimer
            // 
            this.pongTimer.Enabled = true;
            this.pongTimer.Interval = 20;
            this.pongTimer.Tick += new System.EventHandler(this.pongTimer_Tick);
            // 
            // Pong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1064, 561);
            this.Controls.Add(this.paddle_cpu);
            this.Controls.Add(this.paddle_player);
            this.Controls.Add(this.score_player);
            this.Controls.Add(this.score_cpu);
            this.Controls.Add(this.pong_ball);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pong";
            this.Text = "Pong";
            this.Load += new System.EventHandler(this.Pong_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pong_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Pong_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.paddle_player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddle_cpu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pong_ball)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox paddle_player;
        private PictureBox paddle_cpu;
        private PictureBox pong_ball;
        private Label score_player;
        private Label score_cpu;
        private System.Windows.Forms.Timer pongTimer;
    }
}