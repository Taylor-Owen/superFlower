namespace superflower
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.runningJumpHeight = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.walkingJumpHeight = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.standingJumpHeight = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.startingLives = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.startingCoins = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.stopTimerCheckbox = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.marioNameTextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BubblesCheckbox = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.runningJumpHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.walkingJumpHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standingJumpHeight)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startingLives)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startingCoins)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open SMB Rom...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(135, 13);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(123, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save Changes...";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(335, 279);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.runningJumpHeight);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.walkingJumpHeight);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.standingJumpHeight);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(327, 253);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mario";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // runningJumpHeight
            // 
            this.runningJumpHeight.Enabled = false;
            this.runningJumpHeight.Hexadecimal = true;
            this.runningJumpHeight.Location = new System.Drawing.Point(121, 109);
            this.runningJumpHeight.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.runningJumpHeight.Name = "runningJumpHeight";
            this.runningJumpHeight.Size = new System.Drawing.Size(120, 20);
            this.runningJumpHeight.TabIndex = 6;
            this.runningJumpHeight.ValueChanged += new System.EventHandler(this.runningJumpHeight_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Running Jump Height";
            // 
            // walkingJumpHeight
            // 
            this.walkingJumpHeight.Enabled = false;
            this.walkingJumpHeight.Hexadecimal = true;
            this.walkingJumpHeight.Location = new System.Drawing.Point(121, 72);
            this.walkingJumpHeight.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.walkingJumpHeight.Name = "walkingJumpHeight";
            this.walkingJumpHeight.Size = new System.Drawing.Size(120, 20);
            this.walkingJumpHeight.TabIndex = 4;
            this.walkingJumpHeight.ValueChanged += new System.EventHandler(this.walkingJumpHeight_ValueChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Walking Jump Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "The lower the value, the higher the jump.";
            // 
            // standingJumpHeight
            // 
            this.standingJumpHeight.Enabled = false;
            this.standingJumpHeight.Hexadecimal = true;
            this.standingJumpHeight.Location = new System.Drawing.Point(121, 36);
            this.standingJumpHeight.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.standingJumpHeight.Name = "standingJumpHeight";
            this.standingJumpHeight.Size = new System.Drawing.Size(120, 20);
            this.standingJumpHeight.TabIndex = 1;
            this.standingJumpHeight.ValueChanged += new System.EventHandler(this.standingJumpHeight_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Standing Jump Height";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BubblesCheckbox);
            this.tabPage2.Controls.Add(this.startingLives);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.startingCoins);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.stopTimerCheckbox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(327, 253);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ASM Patches";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // startingLives
            // 
            this.startingLives.Enabled = false;
            this.startingLives.Location = new System.Drawing.Point(86, 57);
            this.startingLives.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.startingLives.Name = "startingLives";
            this.startingLives.Size = new System.Drawing.Size(33, 20);
            this.startingLives.TabIndex = 4;
            this.startingLives.ValueChanged += new System.EventHandler(this.startingLives_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Starting Lives";
            // 
            // startingCoins
            // 
            this.startingCoins.Enabled = false;
            this.startingCoins.Location = new System.Drawing.Point(86, 31);
            this.startingCoins.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.startingCoins.Name = "startingCoins";
            this.startingCoins.Size = new System.Drawing.Size(33, 20);
            this.startingCoins.TabIndex = 2;
            this.startingCoins.ValueChanged += new System.EventHandler(this.startingCoins_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Starting Coins";
            // 
            // stopTimerCheckbox
            // 
            this.stopTimerCheckbox.AutoSize = true;
            this.stopTimerCheckbox.Location = new System.Drawing.Point(7, 7);
            this.stopTimerCheckbox.Name = "stopTimerCheckbox";
            this.stopTimerCheckbox.Size = new System.Drawing.Size(77, 17);
            this.stopTimerCheckbox.TabIndex = 0;
            this.stopTimerCheckbox.Text = "Stop Timer";
            this.stopTimerCheckbox.UseVisualStyleBackColor = true;
            this.stopTimerCheckbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.marioNameTextbox);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(327, 253);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Text";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // marioNameTextbox
            // 
            this.marioNameTextbox.Location = new System.Drawing.Point(56, 7);
            this.marioNameTextbox.MaxLength = 5;
            this.marioNameTextbox.Name = "marioNameTextbox";
            this.marioNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.marioNameTextbox.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "MARIO";
            // 
            // BubblesCheckbox
            // 
            this.BubblesCheckbox.AutoSize = true;
            this.BubblesCheckbox.Location = new System.Drawing.Point(7, 81);
            this.BubblesCheckbox.Name = "BubblesCheckbox";
            this.BubblesCheckbox.Size = new System.Drawing.Size(114, 17);
            this.BubblesCheckbox.TabIndex = 5;
            this.BubblesCheckbox.Text = "Bubbles Anywhere";
            this.BubblesCheckbox.UseVisualStyleBackColor = true;
            this.BubblesCheckbox.CheckedChanged += new System.EventHandler(this.BubblesCheckbox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 507);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "superFlower";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.runningJumpHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.walkingJumpHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standingJumpHeight)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startingLives)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startingCoins)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown runningJumpHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown walkingJumpHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown standingJumpHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox stopTimerCheckbox;
        private System.Windows.Forms.NumericUpDown startingCoins;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown startingLives;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox marioNameTextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox BubblesCheckbox;
    }
}

