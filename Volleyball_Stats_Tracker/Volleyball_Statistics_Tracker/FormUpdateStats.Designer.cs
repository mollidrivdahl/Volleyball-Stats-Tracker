namespace Volleyball_Statistics_Tracker
{
    partial class FormUpdateStats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpdateStats));
            this.buttonMainMenu = new System.Windows.Forms.Button();
            this.groupBoxServing = new System.Windows.Forms.GroupBox();
            this.buttonServeError = new System.Windows.Forms.Button();
            this.buttonServeAce = new System.Windows.Forms.Button();
            this.buttonServeAttempt = new System.Windows.Forms.Button();
            this.groupBoxReceiving = new System.Windows.Forms.GroupBox();
            this.buttonReceive3 = new System.Windows.Forms.Button();
            this.buttonReceive1 = new System.Windows.Forms.Button();
            this.buttonReceive0 = new System.Windows.Forms.Button();
            this.buttonReceive2 = new System.Windows.Forms.Button();
            this.groupBoxHitting = new System.Windows.Forms.GroupBox();
            this.buttonHitError = new System.Windows.Forms.Button();
            this.buttonHitAttempt = new System.Windows.Forms.Button();
            this.buttonHitKill = new System.Windows.Forms.Button();
            this.groupBoxSetting = new System.Windows.Forms.GroupBox();
            this.buttonSetError = new System.Windows.Forms.Button();
            this.buttonSetAssist = new System.Windows.Forms.Button();
            this.buttonSetAttempt = new System.Windows.Forms.Button();
            this.groupBoxBlocking = new System.Windows.Forms.GroupBox();
            this.buttonBlockError = new System.Windows.Forms.Button();
            this.buttonBlockSolo = new System.Windows.Forms.Button();
            this.buttonBlockAssist = new System.Windows.Forms.Button();
            this.groupBoxDigging = new System.Windows.Forms.GroupBox();
            this.buttonDigError = new System.Windows.Forms.Button();
            this.buttonDigAttempt = new System.Windows.Forms.Button();
            this.labelMatchName = new System.Windows.Forms.Label();
            this.groupBoxServing.SuspendLayout();
            this.groupBoxReceiving.SuspendLayout();
            this.groupBoxHitting.SuspendLayout();
            this.groupBoxSetting.SuspendLayout();
            this.groupBoxBlocking.SuspendLayout();
            this.groupBoxDigging.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonMainMenu
            // 
            this.buttonMainMenu.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonMainMenu.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMainMenu.Location = new System.Drawing.Point(12, 421);
            this.buttonMainMenu.Name = "buttonMainMenu";
            this.buttonMainMenu.Size = new System.Drawing.Size(180, 28);
            this.buttonMainMenu.TabIndex = 1;
            this.buttonMainMenu.TabStop = false;
            this.buttonMainMenu.Text = "<-- Save and Return to Main Menu";
            this.buttonMainMenu.UseVisualStyleBackColor = false;
            this.buttonMainMenu.Click += new System.EventHandler(this.buttonMainMenu_Click);
            this.buttonMainMenu.MouseEnter += new System.EventHandler(this.buttonMainMenu_MouseEnter);
            this.buttonMainMenu.MouseLeave += new System.EventHandler(this.buttonMainMenu_MouseLeave);
            // 
            // groupBoxServing
            // 
            this.groupBoxServing.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBoxServing.Controls.Add(this.buttonServeError);
            this.groupBoxServing.Controls.Add(this.buttonServeAce);
            this.groupBoxServing.Controls.Add(this.buttonServeAttempt);
            this.groupBoxServing.Font = new System.Drawing.Font("Segoe Print", 21F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxServing.ForeColor = System.Drawing.Color.White;
            this.groupBoxServing.Location = new System.Drawing.Point(36, 48);
            this.groupBoxServing.Name = "groupBoxServing";
            this.groupBoxServing.Size = new System.Drawing.Size(156, 184);
            this.groupBoxServing.TabIndex = 2;
            this.groupBoxServing.TabStop = false;
            this.groupBoxServing.Text = "Serving";
            // 
            // buttonServeError
            // 
            this.buttonServeError.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonServeError.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonServeError.ForeColor = System.Drawing.Color.Black;
            this.buttonServeError.Location = new System.Drawing.Point(24, 137);
            this.buttonServeError.Name = "buttonServeError";
            this.buttonServeError.Size = new System.Drawing.Size(108, 39);
            this.buttonServeError.TabIndex = 2;
            this.buttonServeError.TabStop = false;
            this.buttonServeError.Text = "Error";
            this.buttonServeError.UseVisualStyleBackColor = false;
            this.buttonServeError.Click += new System.EventHandler(this.buttonServeError_Click);
            this.buttonServeError.MouseEnter += new System.EventHandler(this.buttonServeError_MouseEnter);
            this.buttonServeError.MouseLeave += new System.EventHandler(this.buttonServeError_MouseLeave);
            // 
            // buttonServeAce
            // 
            this.buttonServeAce.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonServeAce.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonServeAce.ForeColor = System.Drawing.Color.Black;
            this.buttonServeAce.Location = new System.Drawing.Point(24, 92);
            this.buttonServeAce.Name = "buttonServeAce";
            this.buttonServeAce.Size = new System.Drawing.Size(108, 39);
            this.buttonServeAce.TabIndex = 1;
            this.buttonServeAce.TabStop = false;
            this.buttonServeAce.Text = "Ace";
            this.buttonServeAce.UseVisualStyleBackColor = false;
            this.buttonServeAce.Click += new System.EventHandler(this.buttonServeAce_Click);
            this.buttonServeAce.MouseEnter += new System.EventHandler(this.buttonServeAce_MouseEnter);
            this.buttonServeAce.MouseLeave += new System.EventHandler(this.buttonServeAce_MouseLeave);
            // 
            // buttonServeAttempt
            // 
            this.buttonServeAttempt.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonServeAttempt.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonServeAttempt.ForeColor = System.Drawing.Color.Black;
            this.buttonServeAttempt.Location = new System.Drawing.Point(24, 47);
            this.buttonServeAttempt.Name = "buttonServeAttempt";
            this.buttonServeAttempt.Size = new System.Drawing.Size(108, 39);
            this.buttonServeAttempt.TabIndex = 0;
            this.buttonServeAttempt.TabStop = false;
            this.buttonServeAttempt.Text = "Attempt";
            this.buttonServeAttempt.UseVisualStyleBackColor = false;
            this.buttonServeAttempt.Click += new System.EventHandler(this.buttonServeAttempt_Click);
            this.buttonServeAttempt.MouseEnter += new System.EventHandler(this.buttonServeAttempt_MouseEnter);
            this.buttonServeAttempt.MouseLeave += new System.EventHandler(this.buttonServeAttempt_MouseLeave);
            // 
            // groupBoxReceiving
            // 
            this.groupBoxReceiving.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBoxReceiving.Controls.Add(this.buttonReceive3);
            this.groupBoxReceiving.Controls.Add(this.buttonReceive1);
            this.groupBoxReceiving.Controls.Add(this.buttonReceive0);
            this.groupBoxReceiving.Controls.Add(this.buttonReceive2);
            this.groupBoxReceiving.Font = new System.Drawing.Font("Segoe Print", 21F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxReceiving.ForeColor = System.Drawing.Color.White;
            this.groupBoxReceiving.Location = new System.Drawing.Point(242, 48);
            this.groupBoxReceiving.Name = "groupBoxReceiving";
            this.groupBoxReceiving.Size = new System.Drawing.Size(303, 184);
            this.groupBoxReceiving.TabIndex = 3;
            this.groupBoxReceiving.TabStop = false;
            this.groupBoxReceiving.Text = "Receiving";
            // 
            // buttonReceive3
            // 
            this.buttonReceive3.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonReceive3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReceive3.ForeColor = System.Drawing.Color.Black;
            this.buttonReceive3.Location = new System.Drawing.Point(160, 115);
            this.buttonReceive3.Name = "buttonReceive3";
            this.buttonReceive3.Size = new System.Drawing.Size(108, 39);
            this.buttonReceive3.TabIndex = 10;
            this.buttonReceive3.TabStop = false;
            this.buttonReceive3.Text = "3 - Perfect";
            this.buttonReceive3.UseVisualStyleBackColor = false;
            this.buttonReceive3.Click += new System.EventHandler(this.buttonReceive3_Click);
            this.buttonReceive3.MouseEnter += new System.EventHandler(this.buttonReceive3_MouseEnter);
            this.buttonReceive3.MouseLeave += new System.EventHandler(this.buttonReceive3_MouseLeave);
            // 
            // buttonReceive1
            // 
            this.buttonReceive1.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonReceive1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReceive1.ForeColor = System.Drawing.Color.Black;
            this.buttonReceive1.Location = new System.Drawing.Point(160, 56);
            this.buttonReceive1.Name = "buttonReceive1";
            this.buttonReceive1.Size = new System.Drawing.Size(108, 39);
            this.buttonReceive1.TabIndex = 9;
            this.buttonReceive1.TabStop = false;
            this.buttonReceive1.Text = "1 - Playable";
            this.buttonReceive1.UseVisualStyleBackColor = false;
            this.buttonReceive1.Click += new System.EventHandler(this.buttonReceive1_Click);
            this.buttonReceive1.MouseEnter += new System.EventHandler(this.buttonReceive1_MouseEnter);
            this.buttonReceive1.MouseLeave += new System.EventHandler(this.buttonReceive1_MouseLeave);
            // 
            // buttonReceive0
            // 
            this.buttonReceive0.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonReceive0.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReceive0.ForeColor = System.Drawing.Color.Black;
            this.buttonReceive0.Location = new System.Drawing.Point(36, 56);
            this.buttonReceive0.Name = "buttonReceive0";
            this.buttonReceive0.Size = new System.Drawing.Size(108, 39);
            this.buttonReceive0.TabIndex = 7;
            this.buttonReceive0.TabStop = false;
            this.buttonReceive0.Text = "0 - Shank";
            this.buttonReceive0.UseVisualStyleBackColor = false;
            this.buttonReceive0.Click += new System.EventHandler(this.buttonReceive0_Click);
            this.buttonReceive0.MouseEnter += new System.EventHandler(this.buttonReceive0_MouseEnter);
            this.buttonReceive0.MouseLeave += new System.EventHandler(this.buttonReceive0_MouseLeave);
            // 
            // buttonReceive2
            // 
            this.buttonReceive2.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonReceive2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReceive2.ForeColor = System.Drawing.Color.Black;
            this.buttonReceive2.Location = new System.Drawing.Point(36, 115);
            this.buttonReceive2.Name = "buttonReceive2";
            this.buttonReceive2.Size = new System.Drawing.Size(108, 39);
            this.buttonReceive2.TabIndex = 8;
            this.buttonReceive2.TabStop = false;
            this.buttonReceive2.Text = "2 - Close";
            this.buttonReceive2.UseVisualStyleBackColor = false;
            this.buttonReceive2.Click += new System.EventHandler(this.buttonReceive2_Click);
            this.buttonReceive2.MouseEnter += new System.EventHandler(this.buttonReceive2_MouseEnter);
            this.buttonReceive2.MouseLeave += new System.EventHandler(this.buttonReceive2_MouseLeave);
            // 
            // groupBoxHitting
            // 
            this.groupBoxHitting.BackColor = System.Drawing.Color.LightCoral;
            this.groupBoxHitting.Controls.Add(this.buttonHitError);
            this.groupBoxHitting.Controls.Add(this.buttonHitAttempt);
            this.groupBoxHitting.Controls.Add(this.buttonHitKill);
            this.groupBoxHitting.Font = new System.Drawing.Font("Segoe Print", 21F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxHitting.ForeColor = System.Drawing.Color.White;
            this.groupBoxHitting.Location = new System.Drawing.Point(595, 48);
            this.groupBoxHitting.Name = "groupBoxHitting";
            this.groupBoxHitting.Size = new System.Drawing.Size(156, 184);
            this.groupBoxHitting.TabIndex = 3;
            this.groupBoxHitting.TabStop = false;
            this.groupBoxHitting.Text = "Hitting";
            // 
            // buttonHitError
            // 
            this.buttonHitError.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonHitError.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHitError.ForeColor = System.Drawing.Color.Black;
            this.buttonHitError.Location = new System.Drawing.Point(24, 137);
            this.buttonHitError.Name = "buttonHitError";
            this.buttonHitError.Size = new System.Drawing.Size(108, 39);
            this.buttonHitError.TabIndex = 9;
            this.buttonHitError.TabStop = false;
            this.buttonHitError.Text = "Error";
            this.buttonHitError.UseVisualStyleBackColor = false;
            this.buttonHitError.Click += new System.EventHandler(this.buttonHitError_Click);
            this.buttonHitError.MouseEnter += new System.EventHandler(this.buttonHitError_MouseEnter);
            this.buttonHitError.MouseLeave += new System.EventHandler(this.buttonHitError_MouseLeave);
            // 
            // buttonHitAttempt
            // 
            this.buttonHitAttempt.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonHitAttempt.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHitAttempt.ForeColor = System.Drawing.Color.Black;
            this.buttonHitAttempt.Location = new System.Drawing.Point(24, 47);
            this.buttonHitAttempt.Name = "buttonHitAttempt";
            this.buttonHitAttempt.Size = new System.Drawing.Size(108, 39);
            this.buttonHitAttempt.TabIndex = 7;
            this.buttonHitAttempt.TabStop = false;
            this.buttonHitAttempt.Text = "Attempt";
            this.buttonHitAttempt.UseVisualStyleBackColor = false;
            this.buttonHitAttempt.Click += new System.EventHandler(this.buttonHitAttempt_Click);
            this.buttonHitAttempt.MouseEnter += new System.EventHandler(this.buttonHitAttempt_MouseEnter);
            this.buttonHitAttempt.MouseLeave += new System.EventHandler(this.buttonHitAttempt_MouseLeave);
            // 
            // buttonHitKill
            // 
            this.buttonHitKill.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonHitKill.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHitKill.ForeColor = System.Drawing.Color.Black;
            this.buttonHitKill.Location = new System.Drawing.Point(24, 92);
            this.buttonHitKill.Name = "buttonHitKill";
            this.buttonHitKill.Size = new System.Drawing.Size(108, 39);
            this.buttonHitKill.TabIndex = 8;
            this.buttonHitKill.TabStop = false;
            this.buttonHitKill.Text = "Kill";
            this.buttonHitKill.UseVisualStyleBackColor = false;
            this.buttonHitKill.Click += new System.EventHandler(this.buttonHitKill_Click);
            this.buttonHitKill.MouseEnter += new System.EventHandler(this.buttonHitKill_MouseEnter);
            this.buttonHitKill.MouseLeave += new System.EventHandler(this.buttonHitKill_MouseLeave);
            // 
            // groupBoxSetting
            // 
            this.groupBoxSetting.BackColor = System.Drawing.Color.Orchid;
            this.groupBoxSetting.Controls.Add(this.buttonSetError);
            this.groupBoxSetting.Controls.Add(this.buttonSetAssist);
            this.groupBoxSetting.Controls.Add(this.buttonSetAttempt);
            this.groupBoxSetting.Font = new System.Drawing.Font("Segoe Print", 21F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSetting.ForeColor = System.Drawing.Color.White;
            this.groupBoxSetting.Location = new System.Drawing.Point(320, 265);
            this.groupBoxSetting.Name = "groupBoxSetting";
            this.groupBoxSetting.Size = new System.Drawing.Size(156, 184);
            this.groupBoxSetting.TabIndex = 4;
            this.groupBoxSetting.TabStop = false;
            this.groupBoxSetting.Text = "Setting";
            // 
            // buttonSetError
            // 
            this.buttonSetError.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonSetError.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetError.ForeColor = System.Drawing.Color.Black;
            this.buttonSetError.Location = new System.Drawing.Point(25, 136);
            this.buttonSetError.Name = "buttonSetError";
            this.buttonSetError.Size = new System.Drawing.Size(108, 39);
            this.buttonSetError.TabIndex = 3;
            this.buttonSetError.TabStop = false;
            this.buttonSetError.Text = "Error";
            this.buttonSetError.UseVisualStyleBackColor = false;
            this.buttonSetError.Click += new System.EventHandler(this.buttonSetError_Click);
            this.buttonSetError.MouseEnter += new System.EventHandler(this.buttonSetError_MouseEnter);
            this.buttonSetError.MouseLeave += new System.EventHandler(this.buttonSetError_MouseLeave);
            // 
            // buttonSetAssist
            // 
            this.buttonSetAssist.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonSetAssist.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetAssist.ForeColor = System.Drawing.Color.Black;
            this.buttonSetAssist.Location = new System.Drawing.Point(25, 91);
            this.buttonSetAssist.Name = "buttonSetAssist";
            this.buttonSetAssist.Size = new System.Drawing.Size(108, 39);
            this.buttonSetAssist.TabIndex = 2;
            this.buttonSetAssist.TabStop = false;
            this.buttonSetAssist.Text = "Assist";
            this.buttonSetAssist.UseVisualStyleBackColor = false;
            this.buttonSetAssist.Click += new System.EventHandler(this.buttonSetAssist_Click);
            this.buttonSetAssist.MouseEnter += new System.EventHandler(this.buttonSetAssist_MouseEnter);
            this.buttonSetAssist.MouseLeave += new System.EventHandler(this.buttonSetAssist_MouseLeave);
            // 
            // buttonSetAttempt
            // 
            this.buttonSetAttempt.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonSetAttempt.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetAttempt.ForeColor = System.Drawing.Color.Black;
            this.buttonSetAttempt.Location = new System.Drawing.Point(25, 46);
            this.buttonSetAttempt.Name = "buttonSetAttempt";
            this.buttonSetAttempt.Size = new System.Drawing.Size(108, 39);
            this.buttonSetAttempt.TabIndex = 1;
            this.buttonSetAttempt.TabStop = false;
            this.buttonSetAttempt.Text = "Attempt";
            this.buttonSetAttempt.UseVisualStyleBackColor = false;
            this.buttonSetAttempt.Click += new System.EventHandler(this.buttonSetAttempt_Click);
            this.buttonSetAttempt.MouseEnter += new System.EventHandler(this.buttonSetAttempt_MouseEnter);
            this.buttonSetAttempt.MouseLeave += new System.EventHandler(this.buttonSetAttempt_MouseLeave);
            // 
            // groupBoxBlocking
            // 
            this.groupBoxBlocking.BackColor = System.Drawing.Color.SandyBrown;
            this.groupBoxBlocking.Controls.Add(this.buttonBlockError);
            this.groupBoxBlocking.Controls.Add(this.buttonBlockSolo);
            this.groupBoxBlocking.Controls.Add(this.buttonBlockAssist);
            this.groupBoxBlocking.Font = new System.Drawing.Font("Segoe Print", 21F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBlocking.ForeColor = System.Drawing.Color.White;
            this.groupBoxBlocking.Location = new System.Drawing.Point(531, 265);
            this.groupBoxBlocking.Name = "groupBoxBlocking";
            this.groupBoxBlocking.Size = new System.Drawing.Size(156, 184);
            this.groupBoxBlocking.TabIndex = 5;
            this.groupBoxBlocking.TabStop = false;
            this.groupBoxBlocking.Text = "Blocking";
            // 
            // buttonBlockError
            // 
            this.buttonBlockError.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonBlockError.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBlockError.ForeColor = System.Drawing.Color.Black;
            this.buttonBlockError.Location = new System.Drawing.Point(24, 136);
            this.buttonBlockError.Name = "buttonBlockError";
            this.buttonBlockError.Size = new System.Drawing.Size(108, 39);
            this.buttonBlockError.TabIndex = 9;
            this.buttonBlockError.TabStop = false;
            this.buttonBlockError.Text = "Error";
            this.buttonBlockError.UseVisualStyleBackColor = false;
            this.buttonBlockError.Click += new System.EventHandler(this.buttonBlockError_Click);
            this.buttonBlockError.MouseEnter += new System.EventHandler(this.buttonBlockError_MouseEnter);
            this.buttonBlockError.MouseLeave += new System.EventHandler(this.buttonBlockError_MouseLeave);
            // 
            // buttonBlockSolo
            // 
            this.buttonBlockSolo.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonBlockSolo.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBlockSolo.ForeColor = System.Drawing.Color.Black;
            this.buttonBlockSolo.Location = new System.Drawing.Point(24, 46);
            this.buttonBlockSolo.Name = "buttonBlockSolo";
            this.buttonBlockSolo.Size = new System.Drawing.Size(108, 39);
            this.buttonBlockSolo.TabIndex = 7;
            this.buttonBlockSolo.TabStop = false;
            this.buttonBlockSolo.Text = "Solo";
            this.buttonBlockSolo.UseVisualStyleBackColor = false;
            this.buttonBlockSolo.Click += new System.EventHandler(this.buttonBlockSolo_Click);
            this.buttonBlockSolo.MouseEnter += new System.EventHandler(this.buttonBlockSolo_MouseEnter);
            this.buttonBlockSolo.MouseLeave += new System.EventHandler(this.buttonBlockSolo_MouseLeave);
            // 
            // buttonBlockAssist
            // 
            this.buttonBlockAssist.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonBlockAssist.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBlockAssist.ForeColor = System.Drawing.Color.Black;
            this.buttonBlockAssist.Location = new System.Drawing.Point(24, 91);
            this.buttonBlockAssist.Name = "buttonBlockAssist";
            this.buttonBlockAssist.Size = new System.Drawing.Size(108, 39);
            this.buttonBlockAssist.TabIndex = 8;
            this.buttonBlockAssist.TabStop = false;
            this.buttonBlockAssist.Text = "Assist";
            this.buttonBlockAssist.UseVisualStyleBackColor = false;
            this.buttonBlockAssist.Click += new System.EventHandler(this.buttonBlockAssist_Click);
            this.buttonBlockAssist.MouseEnter += new System.EventHandler(this.buttonBlockAssist_MouseEnter);
            this.buttonBlockAssist.MouseLeave += new System.EventHandler(this.buttonBlockAssist_MouseLeave);
            // 
            // groupBoxDigging
            // 
            this.groupBoxDigging.BackColor = System.Drawing.Color.YellowGreen;
            this.groupBoxDigging.Controls.Add(this.buttonDigError);
            this.groupBoxDigging.Controls.Add(this.buttonDigAttempt);
            this.groupBoxDigging.Font = new System.Drawing.Font("Segoe Print", 21F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDigging.ForeColor = System.Drawing.Color.White;
            this.groupBoxDigging.Location = new System.Drawing.Point(102, 265);
            this.groupBoxDigging.Name = "groupBoxDigging";
            this.groupBoxDigging.Size = new System.Drawing.Size(156, 139);
            this.groupBoxDigging.TabIndex = 6;
            this.groupBoxDigging.TabStop = false;
            this.groupBoxDigging.Text = "Digging";
            // 
            // buttonDigError
            // 
            this.buttonDigError.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonDigError.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDigError.ForeColor = System.Drawing.Color.Black;
            this.buttonDigError.Location = new System.Drawing.Point(24, 91);
            this.buttonDigError.Name = "buttonDigError";
            this.buttonDigError.Size = new System.Drawing.Size(108, 39);
            this.buttonDigError.TabIndex = 2;
            this.buttonDigError.TabStop = false;
            this.buttonDigError.Text = "Error";
            this.buttonDigError.UseVisualStyleBackColor = false;
            this.buttonDigError.Click += new System.EventHandler(this.buttonDigError_Click);
            this.buttonDigError.MouseEnter += new System.EventHandler(this.buttonDigError_MouseEnter);
            this.buttonDigError.MouseLeave += new System.EventHandler(this.buttonDigError_MouseLeave);
            // 
            // buttonDigAttempt
            // 
            this.buttonDigAttempt.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonDigAttempt.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDigAttempt.ForeColor = System.Drawing.Color.Black;
            this.buttonDigAttempt.Location = new System.Drawing.Point(24, 46);
            this.buttonDigAttempt.Name = "buttonDigAttempt";
            this.buttonDigAttempt.Size = new System.Drawing.Size(108, 39);
            this.buttonDigAttempt.TabIndex = 1;
            this.buttonDigAttempt.TabStop = false;
            this.buttonDigAttempt.Text = "Attempt";
            this.buttonDigAttempt.UseVisualStyleBackColor = false;
            this.buttonDigAttempt.Click += new System.EventHandler(this.buttonDigAttempt_Click);
            this.buttonDigAttempt.MouseEnter += new System.EventHandler(this.buttonDigAttempt_MouseEnter);
            this.buttonDigAttempt.MouseLeave += new System.EventHandler(this.buttonDigAttempt_MouseLeave);
            // 
            // labelMatchName
            // 
            this.labelMatchName.AutoSize = true;
            this.labelMatchName.Font = new System.Drawing.Font("Candara", 16F);
            this.labelMatchName.ForeColor = System.Drawing.Color.LemonChiffon;
            this.labelMatchName.Location = new System.Drawing.Point(273, 9);
            this.labelMatchName.Name = "labelMatchName";
            this.labelMatchName.Size = new System.Drawing.Size(230, 27);
            this.labelMatchName.TabIndex = 7;
            this.labelMatchName.Text = "<Current Match Name>";
            // 
            // FormUpdateStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.labelMatchName);
            this.Controls.Add(this.groupBoxDigging);
            this.Controls.Add(this.groupBoxBlocking);
            this.Controls.Add(this.groupBoxSetting);
            this.Controls.Add(this.groupBoxHitting);
            this.Controls.Add(this.groupBoxReceiving);
            this.Controls.Add(this.groupBoxServing);
            this.Controls.Add(this.buttonMainMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormUpdateStats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Volleyball Stats Tracker";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormUpdateStats_FormClosed);
            this.groupBoxServing.ResumeLayout(false);
            this.groupBoxReceiving.ResumeLayout(false);
            this.groupBoxHitting.ResumeLayout(false);
            this.groupBoxSetting.ResumeLayout(false);
            this.groupBoxBlocking.ResumeLayout(false);
            this.groupBoxDigging.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMainMenu;
        private System.Windows.Forms.GroupBox groupBoxServing;
        private System.Windows.Forms.GroupBox groupBoxReceiving;
        private System.Windows.Forms.GroupBox groupBoxHitting;
        private System.Windows.Forms.Button buttonServeAttempt;
        private System.Windows.Forms.GroupBox groupBoxSetting;
        private System.Windows.Forms.GroupBox groupBoxBlocking;
        private System.Windows.Forms.GroupBox groupBoxDigging;
        private System.Windows.Forms.Button buttonServeError;
        private System.Windows.Forms.Button buttonServeAce;
        private System.Windows.Forms.Button buttonDigError;
        private System.Windows.Forms.Button buttonDigAttempt;
        private System.Windows.Forms.Button buttonSetError;
        private System.Windows.Forms.Button buttonSetAssist;
        private System.Windows.Forms.Button buttonSetAttempt;
        private System.Windows.Forms.Button buttonBlockError;
        private System.Windows.Forms.Button buttonBlockSolo;
        private System.Windows.Forms.Button buttonBlockAssist;
        private System.Windows.Forms.Button buttonHitError;
        private System.Windows.Forms.Button buttonHitAttempt;
        private System.Windows.Forms.Button buttonHitKill;
        private System.Windows.Forms.Button buttonReceive1;
        private System.Windows.Forms.Button buttonReceive0;
        private System.Windows.Forms.Button buttonReceive2;
        private System.Windows.Forms.Button buttonReceive3;
        private System.Windows.Forms.Label labelMatchName;

        public string LabelMatchNameText
        {
            set { labelMatchName.Text = value; }    //Write only
        }

        public System.Windows.Forms.Label LabelMatchName
        {
            get { return labelMatchName; }  //Read only
        }
    }
}