namespace Volleyball_Statistics_Tracker
{
    partial class FormNewMatchWarning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewMatchWarning));
            this.labelQuestion = new System.Windows.Forms.Label();
            this.labelWarning = new System.Windows.Forms.Label();
            this.pictureBoxBackground = new System.Windows.Forms.PictureBox();
            this.buttonNo = new System.Windows.Forms.Button();
            this.buttonYes = new System.Windows.Forms.Button();
            this.textBoxMatchNameInput = new System.Windows.Forms.TextBox();
            this.labelPrompt = new System.Windows.Forms.Label();
            this.buttonAcceptName = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.BackColor = System.Drawing.Color.Black;
            this.labelQuestion.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestion.ForeColor = System.Drawing.Color.Gold;
            this.labelQuestion.Location = new System.Drawing.Point(18, 12);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(248, 81);
            this.labelQuestion.TabIndex = 0;
            this.labelQuestion.Text = "Are you sure you want to\r\nstart taking stats for a\r\nnew match?";
            this.labelQuestion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelWarning
            // 
            this.labelWarning.AutoSize = true;
            this.labelWarning.BackColor = System.Drawing.Color.Black;
            this.labelWarning.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWarning.ForeColor = System.Drawing.Color.Coral;
            this.labelWarning.Location = new System.Drawing.Point(24, 92);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(236, 69);
            this.labelWarning.TabIndex = 1;
            this.labelWarning.Text = "If so, you won\'t be able to\r\ngo back and update the\r\nstats of the previous match." +
    "";
            this.labelWarning.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBoxBackground
            // 
            this.pictureBoxBackground.BackColor = System.Drawing.Color.Black;
            this.pictureBoxBackground.Location = new System.Drawing.Point(12, 10);
            this.pictureBoxBackground.Name = "pictureBoxBackground";
            this.pictureBoxBackground.Size = new System.Drawing.Size(259, 157);
            this.pictureBoxBackground.TabIndex = 2;
            this.pictureBoxBackground.TabStop = false;
            // 
            // buttonNo
            // 
            this.buttonNo.BackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNo.Location = new System.Drawing.Point(12, 189);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(120, 60);
            this.buttonNo.TabIndex = 3;
            this.buttonNo.Text = "No. Back to Main Menu";
            this.buttonNo.UseVisualStyleBackColor = false;
            this.buttonNo.Click += new System.EventHandler(this.buttonNo_Click);
            // 
            // buttonYes
            // 
            this.buttonYes.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonYes.Location = new System.Drawing.Point(152, 189);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(120, 60);
            this.buttonYes.TabIndex = 4;
            this.buttonYes.Text = "Yes. Start new match.";
            this.buttonYes.UseVisualStyleBackColor = false;
            this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click);
            // 
            // textBoxMatchNameInput
            // 
            this.textBoxMatchNameInput.Location = new System.Drawing.Point(23, 92);
            this.textBoxMatchNameInput.Name = "textBoxMatchNameInput";
            this.textBoxMatchNameInput.Size = new System.Drawing.Size(237, 20);
            this.textBoxMatchNameInput.TabIndex = 5;
            this.textBoxMatchNameInput.Visible = false;
            // 
            // labelPrompt
            // 
            this.labelPrompt.AutoSize = true;
            this.labelPrompt.BackColor = System.Drawing.Color.Black;
            this.labelPrompt.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrompt.ForeColor = System.Drawing.Color.Linen;
            this.labelPrompt.Location = new System.Drawing.Point(49, 36);
            this.labelPrompt.Name = "labelPrompt";
            this.labelPrompt.Size = new System.Drawing.Size(181, 46);
            this.labelPrompt.TabIndex = 6;
            this.labelPrompt.Text = "Enter a name for the\r\nnew match:";
            this.labelPrompt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelPrompt.Visible = false;
            // 
            // buttonAcceptName
            // 
            this.buttonAcceptName.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonAcceptName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAcceptName.Location = new System.Drawing.Point(83, 118);
            this.buttonAcceptName.Name = "buttonAcceptName";
            this.buttonAcceptName.Size = new System.Drawing.Size(120, 32);
            this.buttonAcceptName.TabIndex = 7;
            this.buttonAcceptName.Text = "Continue";
            this.buttonAcceptName.UseVisualStyleBackColor = false;
            this.buttonAcceptName.Visible = false;
            this.buttonAcceptName.Click += new System.EventHandler(this.buttonAcceptName_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.DarkRed;
            this.labelError.Location = new System.Drawing.Point(59, 167);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(168, 13);
            this.labelError.TabIndex = 8;
            this.labelError.Text = "*Must enter a name for the match*";
            this.labelError.Visible = false;
            // 
            // FormNewMatchWarning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonAcceptName);
            this.Controls.Add(this.labelPrompt);
            this.Controls.Add(this.textBoxMatchNameInput);
            this.Controls.Add(this.buttonYes);
            this.Controls.Add(this.buttonNo);
            this.Controls.Add(this.labelWarning);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.pictureBoxBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormNewMatchWarning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Volleyball Stats Tracker";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormNewMatchWarning_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Label labelWarning;
        private System.Windows.Forms.PictureBox pictureBoxBackground;
        private System.Windows.Forms.Button buttonNo;
        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.TextBox textBoxMatchNameInput;
        private System.Windows.Forms.Label labelPrompt;
        private System.Windows.Forms.Button buttonAcceptName;
        private System.Windows.Forms.Label labelError;

        public System.Windows.Forms.TextBox TextBoxMatchNameInput
        {
            get { return textBoxMatchNameInput; }   //Read only
        }
    }
}