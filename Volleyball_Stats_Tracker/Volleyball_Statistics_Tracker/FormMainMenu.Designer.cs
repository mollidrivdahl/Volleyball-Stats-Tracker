namespace Volleyball_Statistics_Tracker
{
    partial class FormMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.labelAppTitle = new System.Windows.Forms.Label();
            this.picVolleyball = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonUpdateCurrent = new System.Windows.Forms.Button();
            this.buttonViewStats = new System.Windows.Forms.Button();
            this.buttonUpdateNew = new System.Windows.Forms.Button();
            this.labelUpdateStats = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picVolleyball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAppTitle
            // 
            this.labelAppTitle.AutoSize = true;
            this.labelAppTitle.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppTitle.ForeColor = System.Drawing.Color.LemonChiffon;
            this.labelAppTitle.Location = new System.Drawing.Point(12, 9);
            this.labelAppTitle.Name = "labelAppTitle";
            this.labelAppTitle.Size = new System.Drawing.Size(754, 67);
            this.labelAppTitle.TabIndex = 0;
            this.labelAppTitle.Text = "Volleyball Stats Tracker";
            // 
            // picVolleyball
            // 
            this.picVolleyball.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picVolleyball.Image = ((System.Drawing.Image)(resources.GetObject("picVolleyball.Image")));
            this.picVolleyball.Location = new System.Drawing.Point(551, 236);
            this.picVolleyball.Name = "picVolleyball";
            this.picVolleyball.Size = new System.Drawing.Size(200, 200);
            this.picVolleyball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVolleyball.TabIndex = 1;
            this.picVolleyball.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExit.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonExit.Font = new System.Drawing.Font("Papyrus", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(150, 363);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(248, 83);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.TabStop = false;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            this.buttonExit.MouseEnter += new System.EventHandler(this.buttonExit_MouseEnter);
            this.buttonExit.MouseLeave += new System.EventHandler(this.buttonExit_MouseLeave);
            // 
            // buttonUpdateCurrent
            // 
            this.buttonUpdateCurrent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpdateCurrent.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonUpdateCurrent.Font = new System.Drawing.Font("Papyrus", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateCurrent.Location = new System.Drawing.Point(23, 145);
            this.buttonUpdateCurrent.Name = "buttonUpdateCurrent";
            this.buttonUpdateCurrent.Size = new System.Drawing.Size(248, 83);
            this.buttonUpdateCurrent.TabIndex = 0;
            this.buttonUpdateCurrent.TabStop = false;
            this.buttonUpdateCurrent.Text = "Current Match";
            this.buttonUpdateCurrent.UseVisualStyleBackColor = false;
            this.buttonUpdateCurrent.Click += new System.EventHandler(this.buttonUpdateCurrent_Click);
            this.buttonUpdateCurrent.MouseEnter += new System.EventHandler(this.buttonUpdateCurrent_MouseEnter);
            this.buttonUpdateCurrent.MouseLeave += new System.EventHandler(this.buttonUpdateCurrent_MouseLeave);
            // 
            // buttonViewStats
            // 
            this.buttonViewStats.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonViewStats.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonViewStats.Font = new System.Drawing.Font("Papyrus", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewStats.Location = new System.Drawing.Point(150, 255);
            this.buttonViewStats.Name = "buttonViewStats";
            this.buttonViewStats.Size = new System.Drawing.Size(248, 83);
            this.buttonViewStats.TabIndex = 1;
            this.buttonViewStats.TabStop = false;
            this.buttonViewStats.Text = "View Player Stats";
            this.buttonViewStats.UseVisualStyleBackColor = false;
            this.buttonViewStats.Click += new System.EventHandler(this.buttonViewStats_Click);
            this.buttonViewStats.MouseEnter += new System.EventHandler(this.buttonViewStats_MouseEnter);
            this.buttonViewStats.MouseLeave += new System.EventHandler(this.buttonViewStats_MouseLeave);
            // 
            // buttonUpdateNew
            // 
            this.buttonUpdateNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpdateNew.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonUpdateNew.Font = new System.Drawing.Font("Papyrus", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateNew.Location = new System.Drawing.Point(280, 145);
            this.buttonUpdateNew.Name = "buttonUpdateNew";
            this.buttonUpdateNew.Size = new System.Drawing.Size(248, 83);
            this.buttonUpdateNew.TabIndex = 3;
            this.buttonUpdateNew.TabStop = false;
            this.buttonUpdateNew.Text = "Start New Match";
            this.buttonUpdateNew.UseVisualStyleBackColor = false;
            this.buttonUpdateNew.Click += new System.EventHandler(this.buttonUpdateNew_Click);
            this.buttonUpdateNew.MouseEnter += new System.EventHandler(this.buttonUpdateNew_MouseEnter);
            this.buttonUpdateNew.MouseLeave += new System.EventHandler(this.buttonUpdateNew_MouseLeave);
            // 
            // labelUpdateStats
            // 
            this.labelUpdateStats.AutoSize = true;
            this.labelUpdateStats.BackColor = System.Drawing.Color.LightCoral;
            this.labelUpdateStats.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpdateStats.ForeColor = System.Drawing.Color.LemonChiffon;
            this.labelUpdateStats.Location = new System.Drawing.Point(143, 105);
            this.labelUpdateStats.Name = "labelUpdateStats";
            this.labelUpdateStats.Size = new System.Drawing.Size(262, 38);
            this.labelUpdateStats.TabIndex = 4;
            this.labelUpdateStats.Text = "Update Player Stats";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightCoral;
            this.pictureBox1.Location = new System.Drawing.Point(14, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(525, 139);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkCyan;
            this.pictureBox2.Location = new System.Drawing.Point(141, 247);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(266, 99);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Gold;
            this.pictureBox3.Location = new System.Drawing.Point(141, 355);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(266, 99);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.labelUpdateStats);
            this.Controls.Add(this.buttonUpdateNew);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonViewStats);
            this.Controls.Add(this.buttonUpdateCurrent);
            this.Controls.Add(this.picVolleyball);
            this.Controls.Add(this.labelAppTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Volleyball Stats Tracker";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMainMenu_FormClosed);
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picVolleyball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAppTitle;
        private System.Windows.Forms.PictureBox picVolleyball;
        private System.Windows.Forms.Button buttonUpdateCurrent;
        private System.Windows.Forms.Button buttonViewStats;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonUpdateNew;
        private System.Windows.Forms.Label labelUpdateStats;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

