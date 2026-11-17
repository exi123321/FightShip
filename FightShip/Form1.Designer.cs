namespace FightShip
{
    partial class FightShip
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FightShip));
            this.PirateShip = new System.Windows.Forms.PictureBox();
            this.Ship = new System.Windows.Forms.PictureBox();
            this.TimerPirateShip = new System.Windows.Forms.Timer(this.components);
            this.BallTimer = new System.Windows.Forms.Timer(this.components);
            this.balls = new System.Windows.Forms.PictureBox();
            this.boom = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PirateShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boom)).BeginInit();
            this.SuspendLayout();
            // 
            // PirateShip
            // 
            this.PirateShip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PirateShip.BackColor = System.Drawing.Color.Transparent;
            this.PirateShip.Image = ((System.Drawing.Image)(resources.GetObject("PirateShip.Image")));
            this.PirateShip.InitialImage = null;
            this.PirateShip.Location = new System.Drawing.Point(26, 12);
            this.PirateShip.Name = "PirateShip";
            this.PirateShip.Size = new System.Drawing.Size(143, 90);
            this.PirateShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PirateShip.TabIndex = 0;
            this.PirateShip.TabStop = false;
            // 
            // Ship
            // 
            this.Ship.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Ship.BackColor = System.Drawing.Color.Transparent;
            this.Ship.Image = ((System.Drawing.Image)(resources.GetObject("Ship.Image")));
            this.Ship.Location = new System.Drawing.Point(296, 348);
            this.Ship.Name = "Ship";
            this.Ship.Size = new System.Drawing.Size(143, 90);
            this.Ship.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ship.TabIndex = 1;
            this.Ship.TabStop = false;
            // 
            // TimerPirateShip
            // 
            this.TimerPirateShip.Enabled = true;
            this.TimerPirateShip.Interval = 2;
            this.TimerPirateShip.Tick += new System.EventHandler(this.TimerShip_Tick);
            // 
            // BallTimer
            // 
            this.BallTimer.Interval = 2;
            this.BallTimer.Tick += new System.EventHandler(this.TimerBall_Tick);
            // 
            // balls
            // 
            this.balls.BackColor = System.Drawing.Color.Transparent;
            this.balls.Image = ((System.Drawing.Image)(resources.GetObject("balls.Image")));
            this.balls.Location = new System.Drawing.Point(333, 292);
            this.balls.Name = "balls";
            this.balls.Size = new System.Drawing.Size(67, 50);
            this.balls.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.balls.TabIndex = 2;
            this.balls.TabStop = false;
            this.balls.Visible = false;
            // 
            // boom
            // 
            this.boom.BackColor = System.Drawing.Color.Transparent;
            this.boom.Image = ((System.Drawing.Image)(resources.GetObject("boom.Image")));
            this.boom.Location = new System.Drawing.Point(267, 123);
            this.boom.Name = "boom";
            this.boom.Size = new System.Drawing.Size(184, 149);
            this.boom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boom.TabIndex = 3;
            this.boom.TabStop = false;
            this.boom.Visible = false;
            // 
            // FightShip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boom);
            this.Controls.Add(this.balls);
            this.Controls.Add(this.Ship);
            this.Controls.Add(this.PirateShip);
            this.Name = "FightShip";
            this.Text = "FightShip";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShipsGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.PirateShip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PirateShip;
        private System.Windows.Forms.PictureBox Ship;
        private System.Windows.Forms.Timer TimerPirateShip;
        private System.Windows.Forms.Timer BallTimer;
        private System.Windows.Forms.PictureBox balls;
        private System.Windows.Forms.PictureBox boom;
    }
}

