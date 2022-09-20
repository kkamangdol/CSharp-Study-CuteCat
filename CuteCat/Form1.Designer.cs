namespace CuteCat
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CatTimer = new System.Windows.Forms.Timer(this.components);
            this.Play = new System.Windows.Forms.Button();
            this.Feed = new System.Windows.Forms.Button();
            this.CatScreen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CatTimer
            // 
            this.CatTimer.Enabled = true;
            this.CatTimer.Interval = 5000;
            this.CatTimer.Tick += new System.EventHandler(this.CatTimer_Tick);
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(45, 625);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(191, 142);
            this.Play.TabIndex = 1;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Feed
            // 
            this.Feed.Location = new System.Drawing.Point(45, 799);
            this.Feed.Name = "Feed";
            this.Feed.Size = new System.Drawing.Size(191, 144);
            this.Feed.TabIndex = 2;
            this.Feed.Text = "Feed";
            this.Feed.UseVisualStyleBackColor = true;
            this.Feed.Click += new System.EventHandler(this.Feed_Click);
            // 
            // CatScreen
            // 
            this.CatScreen.BackColor = System.Drawing.Color.Transparent;
            this.CatScreen.Font = new System.Drawing.Font("Showcard Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CatScreen.Location = new System.Drawing.Point(349, 9);
            this.CatScreen.Name = "CatScreen";
            this.CatScreen.Size = new System.Drawing.Size(918, 237);
            this.CatScreen.TabIndex = 0;
            this.CatScreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1627, 1002);
            this.Controls.Add(this.Feed);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.CatScreen);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer CatTimer;
        private Button Play;
        private Button Feed;
        private Label CatScreen;
    }
}