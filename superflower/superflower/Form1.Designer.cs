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
            this.BubblesCheckbox = new System.Windows.Forms.CheckBox();
            this.startingLives = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.startingCoins = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.stopTimerCheckbox = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.quest3TextBox = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.quest2TextBox = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.questTextBox = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.quest4TextBox = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.butprincessTextBox = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.thankyouluigiTextBox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.thankyoumarioTextBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.butprincess2TextBox = new System.Windows.Forms.TextBox();
            this.topTextBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.playertwoTextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.playeroneTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.copyrightTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.luigiTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.warpzoneTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.gameoverTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.timeupTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.worldBlackScreenTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.worldTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.marioNameTextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
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
            this.tabControl1.Enabled = false;
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
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.quest3TextBox);
            this.tabPage3.Controls.Add(this.label26);
            this.tabPage3.Controls.Add(this.quest2TextBox);
            this.tabPage3.Controls.Add(this.label25);
            this.tabPage3.Controls.Add(this.questTextBox);
            this.tabPage3.Controls.Add(this.label24);
            this.tabPage3.Controls.Add(this.quest4TextBox);
            this.tabPage3.Controls.Add(this.label23);
            this.tabPage3.Controls.Add(this.butprincessTextBox);
            this.tabPage3.Controls.Add(this.label22);
            this.tabPage3.Controls.Add(this.thankyouluigiTextBox);
            this.tabPage3.Controls.Add(this.label21);
            this.tabPage3.Controls.Add(this.thankyoumarioTextBox);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.butprincess2TextBox);
            this.tabPage3.Controls.Add(this.topTextBox);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.playertwoTextBox);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.playeroneTextBox);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.copyrightTextBox);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.luigiTextBox);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.warpzoneTextBox);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.gameoverTextBox);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.timeupTextBox);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.worldBlackScreenTextBox);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.timeTextBox);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.worldTextBox);
            this.tabPage3.Controls.Add(this.label8);
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
            // quest3TextBox
            // 
            this.quest3TextBox.Location = new System.Drawing.Point(105, 453);
            this.quest3TextBox.MaxLength = 13;
            this.quest3TextBox.Name = "quest3TextBox";
            this.quest3TextBox.Size = new System.Drawing.Size(100, 20);
            this.quest3TextBox.TabIndex = 39;
            this.quest3TextBox.Tag = "PUSH BUTTON B";
            this.quest3TextBox.Text = "PUSH BUTTON B";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(4, 456);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(95, 13);
            this.label26.TabIndex = 38;
            this.label26.Text = "PUSH BUTTON B";
            // 
            // quest2TextBox
            // 
            this.quest2TextBox.Location = new System.Drawing.Point(197, 430);
            this.quest2TextBox.MaxLength = 27;
            this.quest2TextBox.Name = "quest2TextBox";
            this.quest2TextBox.Size = new System.Drawing.Size(100, 20);
            this.quest2TextBox.TabIndex = 37;
            this.quest2TextBox.Tag = "WE PRESENT YOU A NEW QUEST.";
            this.quest2TextBox.Text = "WE PRESENT YOU A NEW QUEST.";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(4, 434);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(187, 13);
            this.label25.TabIndex = 36;
            this.label25.Text = "WE PRESENT YOU A NEW QUEST.";
            // 
            // questTextBox
            // 
            this.questTextBox.Location = new System.Drawing.Point(135, 404);
            this.questTextBox.MaxLength = 19;
            this.questTextBox.Name = "questTextBox";
            this.questTextBox.Size = new System.Drawing.Size(100, 20);
            this.questTextBox.TabIndex = 35;
            this.questTextBox.Tag = "YOUR QUEST IS OVER.";
            this.questTextBox.Text = "YOUR QUEST IS OVER.";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(4, 409);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(127, 13);
            this.label24.TabIndex = 34;
            this.label24.Text = "YOUR QUEST IS OVER.";
            // 
            // quest4TextBox
            // 
            this.quest4TextBox.Location = new System.Drawing.Point(130, 479);
            this.quest4TextBox.MaxLength = 17;
            this.quest4TextBox.Name = "quest4TextBox";
            this.quest4TextBox.Size = new System.Drawing.Size(100, 20);
            this.quest4TextBox.TabIndex = 33;
            this.quest4TextBox.Tag = "TO SELECT A WORLD";
            this.quest4TextBox.Text = "TO SELECT A WORLD";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(4, 482);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(120, 13);
            this.label23.TabIndex = 32;
            this.label23.Text = "TO SELECT A WORLD";
            // 
            // butprincessTextBox
            // 
            this.butprincessTextBox.Location = new System.Drawing.Point(150, 356);
            this.butprincessTextBox.MaxLength = 22;
            this.butprincessTextBox.Name = "butprincessTextBox";
            this.butprincessTextBox.Size = new System.Drawing.Size(100, 20);
            this.butprincessTextBox.TabIndex = 31;
            this.butprincessTextBox.Tag = "BUT OUR PRINCESS IS IN";
            this.butprincessTextBox.Text = "BUT OUR PRINCESS IS IN";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(4, 360);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(140, 13);
            this.label22.TabIndex = 30;
            this.label22.Text = "BUT OUR PRINCESS IS IN";
            // 
            // thankyouluigiTextBox
            // 
            this.thankyouluigiTextBox.Location = new System.Drawing.Point(114, 330);
            this.thankyouluigiTextBox.MaxLength = 16;
            this.thankyouluigiTextBox.Name = "thankyouluigiTextBox";
            this.thankyouluigiTextBox.Size = new System.Drawing.Size(100, 20);
            this.thankyouluigiTextBox.TabIndex = 29;
            this.thankyouluigiTextBox.Tag = "THANK YOU LUIGI!";
            this.thankyouluigiTextBox.Text = "THANK YOU LUIGI!";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(4, 334);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(104, 13);
            this.label21.TabIndex = 28;
            this.label21.Text = "THANK YOU LUIGI!";
            // 
            // thankyoumarioTextBox
            // 
            this.thankyoumarioTextBox.Location = new System.Drawing.Point(118, 305);
            this.thankyoumarioTextBox.MaxLength = 16;
            this.thankyoumarioTextBox.Name = "thankyoumarioTextBox";
            this.thankyoumarioTextBox.Size = new System.Drawing.Size(100, 20);
            this.thankyoumarioTextBox.TabIndex = 27;
            this.thankyoumarioTextBox.Tag = "THANK YOU MARIO!";
            this.thankyoumarioTextBox.Text = "THANK YOU MARIO!";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(4, 308);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(111, 13);
            this.label20.TabIndex = 26;
            this.label20.Text = "THANK YOU MARIO!";
            // 
            // butprincess2TextBox
            // 
            this.butprincess2TextBox.Location = new System.Drawing.Point(114, 382);
            this.butprincess2TextBox.MaxLength = 15;
            this.butprincess2TextBox.Name = "butprincess2TextBox";
            this.butprincess2TextBox.Size = new System.Drawing.Size(100, 20);
            this.butprincess2TextBox.TabIndex = 25;
            this.butprincess2TextBox.Tag = "ANOTHER CASTLE!";
            this.butprincess2TextBox.Text = "ANOTHER CASTLE!";
            // 
            // topTextBox
            // 
            this.topTextBox.Location = new System.Drawing.Point(45, 265);
            this.topTextBox.MaxLength = 4;
            this.topTextBox.Name = "topTextBox";
            this.topTextBox.Size = new System.Drawing.Size(100, 20);
            this.topTextBox.TabIndex = 23;
            this.topTextBox.Tag = "TOP-";
            this.topTextBox.Text = "TOP-";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 269);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 13);
            this.label18.TabIndex = 22;
            this.label18.Text = "TOP-";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(4, 386);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(107, 13);
            this.label19.TabIndex = 24;
            this.label19.Text = "ANOTHER CASTLE!";
            // 
            // playertwoTextBox
            // 
            this.playertwoTextBox.Location = new System.Drawing.Point(105, 239);
            this.playertwoTextBox.MaxLength = 13;
            this.playertwoTextBox.Name = "playertwoTextBox";
            this.playertwoTextBox.Size = new System.Drawing.Size(100, 20);
            this.playertwoTextBox.TabIndex = 21;
            this.playertwoTextBox.Tag = "2 PLAYER GAME";
            this.playertwoTextBox.Text = "2 PLAYER GAME";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 243);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 13);
            this.label17.TabIndex = 20;
            this.label17.Text = "2 PLAYER GAME";
            // 
            // playeroneTextBox
            // 
            this.playeroneTextBox.Location = new System.Drawing.Point(105, 215);
            this.playeroneTextBox.MaxLength = 13;
            this.playeroneTextBox.Name = "playeroneTextBox";
            this.playeroneTextBox.Size = new System.Drawing.Size(100, 20);
            this.playeroneTextBox.TabIndex = 19;
            this.playeroneTextBox.Tag = "1 PLAYER GAME";
            this.playeroneTextBox.Text = "1 PLAYER GAME";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 219);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "1 PLAYER GAME";
            // 
            // copyrightTextBox
            // 
            this.copyrightTextBox.Location = new System.Drawing.Point(114, 189);
            this.copyrightTextBox.MaxLength = 14;
            this.copyrightTextBox.Name = "copyrightTextBox";
            this.copyrightTextBox.Size = new System.Drawing.Size(100, 20);
            this.copyrightTextBox.TabIndex = 17;
            this.copyrightTextBox.Tag = "©1985 NINTENDO";
            this.copyrightTextBox.Text = "©1985 NINTENDO";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 193);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "C 1985 NINTENDO";
            // 
            // luigiTextBox
            // 
            this.luigiTextBox.Location = new System.Drawing.Point(48, 163);
            this.luigiTextBox.MaxLength = 5;
            this.luigiTextBox.Name = "luigiTextBox";
            this.luigiTextBox.Size = new System.Drawing.Size(100, 20);
            this.luigiTextBox.TabIndex = 15;
            this.luigiTextBox.Tag = "LUIGI";
            this.luigiTextBox.Text = "LUIGI";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 167);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "LUIGI";
            // 
            // warpzoneTextBox
            // 
            this.warpzoneTextBox.Location = new System.Drawing.Point(183, 138);
            this.warpzoneTextBox.MaxLength = 21;
            this.warpzoneTextBox.Name = "warpzoneTextBox";
            this.warpzoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.warpzoneTextBox.TabIndex = 13;
            this.warpzoneTextBox.Tag = "WELCOME TO WARP ZONE!";
            this.warpzoneTextBox.Text = "WELCOME TO WARP ZONE!";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 141);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(174, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "WELCOME TO THE WARP ZONE";
            // 
            // gameoverTextBox
            // 
            this.gameoverTextBox.Location = new System.Drawing.Point(79, 111);
            this.gameoverTextBox.MaxLength = 9;
            this.gameoverTextBox.Name = "gameoverTextBox";
            this.gameoverTextBox.Size = new System.Drawing.Size(100, 20);
            this.gameoverTextBox.TabIndex = 11;
            this.gameoverTextBox.Tag = "GAME OVER";
            this.gameoverTextBox.Text = "GAME OVER";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "GAME OVER";
            // 
            // timeupTextBox
            // 
            this.timeupTextBox.Location = new System.Drawing.Point(56, 85);
            this.timeupTextBox.MaxLength = 7;
            this.timeupTextBox.Name = "timeupTextBox";
            this.timeupTextBox.Size = new System.Drawing.Size(100, 20);
            this.timeupTextBox.TabIndex = 9;
            this.timeupTextBox.Tag = "TIME UP";
            this.timeupTextBox.Text = "TIME UP";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "TIME UP";
            // 
            // worldBlackScreenTextBox
            // 
            this.worldBlackScreenTextBox.Location = new System.Drawing.Point(183, 284);
            this.worldBlackScreenTextBox.MaxLength = 5;
            this.worldBlackScreenTextBox.Name = "worldBlackScreenTextBox";
            this.worldBlackScreenTextBox.Size = new System.Drawing.Size(100, 20);
            this.worldBlackScreenTextBox.TabIndex = 7;
            this.worldBlackScreenTextBox.Tag = "WORLD";
            this.worldBlackScreenTextBox.Text = "WORLD";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "WORLD (Shown in black screens)";
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(56, 59);
            this.timeTextBox.MaxLength = 4;
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(100, 20);
            this.timeTextBox.TabIndex = 5;
            this.timeTextBox.Tag = "TIME";
            this.timeTextBox.Text = "TIME";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "TIME";
            // 
            // worldTextBox
            // 
            this.worldTextBox.Location = new System.Drawing.Point(56, 33);
            this.worldTextBox.MaxLength = 5;
            this.worldTextBox.Name = "worldTextBox";
            this.worldTextBox.Size = new System.Drawing.Size(100, 20);
            this.worldTextBox.TabIndex = 3;
            this.worldTextBox.Tag = "WORLD";
            this.worldTextBox.Text = "WORLD";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "WORLD";
            // 
            // marioNameTextbox
            // 
            this.marioNameTextbox.Location = new System.Drawing.Point(56, 7);
            this.marioNameTextbox.MaxLength = 5;
            this.marioNameTextbox.Name = "marioNameTextbox";
            this.marioNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.marioNameTextbox.TabIndex = 1;
            this.marioNameTextbox.Tag = "MARIO";
            this.marioNameTextbox.Text = "MARIO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "MARIO";
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
            this.Padding = new System.Windows.Forms.Padding(3);
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
        private System.Windows.Forms.TextBox topTextBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox playertwoTextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox playeroneTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox copyrightTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox luigiTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox warpzoneTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox gameoverTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox timeupTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox worldBlackScreenTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox worldTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox butprincess2TextBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox quest3TextBox;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox quest2TextBox;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox questTextBox;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox quest4TextBox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox butprincessTextBox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox thankyouluigiTextBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox thankyoumarioTextBox;
        private System.Windows.Forms.Label label20;
    }
}

