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
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.runningJumpHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.walkingJumpHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standingJumpHeight)).BeginInit();
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(327, 253);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
    }
}

