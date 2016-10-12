namespace Volleyball_Statistics_Tracker
{
    partial class FormViewStats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormViewStats));
            this.buttonMainMenu = new System.Windows.Forms.Button();
            this.comboBoxMatches = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonMainMenu
            // 
            this.buttonMainMenu.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonMainMenu.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMainMenu.Location = new System.Drawing.Point(12, 426);
            this.buttonMainMenu.Name = "buttonMainMenu";
            this.buttonMainMenu.Size = new System.Drawing.Size(130, 23);
            this.buttonMainMenu.TabIndex = 0;
            this.buttonMainMenu.Text = "<-- Return to Main Menu";
            this.buttonMainMenu.UseVisualStyleBackColor = false;
            this.buttonMainMenu.Click += new System.EventHandler(this.buttonMainMenu_Click);
            this.buttonMainMenu.MouseEnter += new System.EventHandler(this.buttonMainMenu_MouseEnter);
            this.buttonMainMenu.MouseLeave += new System.EventHandler(this.buttonMainMenu_MouseLeave);
            // 
            // comboBoxMatches
            // 
            this.comboBoxMatches.BackColor = System.Drawing.Color.LemonChiffon;
            this.comboBoxMatches.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMatches.DropDownWidth = 400;
            this.comboBoxMatches.FormattingEnabled = true;
            this.comboBoxMatches.Location = new System.Drawing.Point(198, 12);
            this.comboBoxMatches.Name = "comboBoxMatches";
            this.comboBoxMatches.Size = new System.Drawing.Size(400, 21);
            this.comboBoxMatches.TabIndex = 1;
            this.comboBoxMatches.DropDown += new System.EventHandler(this.comboBoxMatches_DropDown);
            this.comboBoxMatches.DropDownClosed += new System.EventHandler(this.comboBoxMatches_DropDownClosed);
            // 
            // FormViewStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.comboBoxMatches);
            this.Controls.Add(this.buttonMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormViewStats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Volleyball Stats Tracker";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormViewStats_FormClosed);
            this.VisibleChanged += new System.EventHandler(this.FormViewStats_VisibleChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMainMenu;
        private System.Windows.Forms.ComboBox comboBoxMatches;
    }
}