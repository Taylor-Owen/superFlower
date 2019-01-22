﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace superflower
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            marioNameTextbox.Leave += marioNameTextbox_Leave;
            worldTextBox.Leave += worldTextBox_Leave;
            timeupTextBox.Leave += timeupTextBox_Leave;
            timeTextBox.Leave += timeTextBox_Leave;
            luigiTextBox.Leave += luigiTextBox_Leave;
            copyrightTextBox.Leave += copyrightTextBox_Leave;
            playeroneTextBox.Leave += playeroneTextBox_Leave;
            playertwoTextBox.Leave += playertwoTextBox_Leave;
            worldBlackScreenTextBox.Leave += worldBlackScreenTextBox_Leave;
            gameoverTextBox.Leave += gameoverTextBox_Leave;
            warpzoneTextBox.Leave += warpzoneTextBox_Leave;
            thankyoumarioTextBox.Leave += thankyoumarioTextBox_Leave;
            thankyouluigiTextBox.Leave += thankyouluigiTextBox_Leave;
            butprincessTextBox.Leave += butprincessTextBox_Leave;
            butprincess2TextBox.Leave += butprincess2TextBox_Leave;
            questTextBox.Leave += questTextBox_Leave;
            quest2TextBox.Leave += quest2TextBox_Leave;
            quest3TextBox.Leave += quest3TextBox_Leave;
            quest4TextBox.Leave += quest4TextBox_Leave;
        }

        /*
         * 
         *  Open and Load Super Mario Bros ROM function. 
         * 
         */


        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Super Mario Bros ROM|*.nes";
            openFileDialog1.Title = "Select a ROM";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (workingRom.openRomCheck(openFileDialog1.FileName) == false) //Do we fail the test?
                    MessageBox.Show("File Invalid: Unable to load");
                else //We passed. Load it.
                {
                    workingRom.filePath = openFileDialog1.FileName;
                    workingRom.fileName = openFileDialog1.SafeFileName;
                    workingRom.romLoaded = true;
                    workingRom.data = System.IO.File.ReadAllBytes(openFileDialog1.FileName);

                    this.Text = "Superflower - Loaded "+workingRom.fileName;

                    if (PopulateOffsets())
                    {
                        MessageBox.Show("ROM loaded!");
                    }
                }
            }



        }

        SMBRom workingRom = new SMBRom();

        /*
         * 
         *  Save changes to Super Mario Bros ROM function. 
         * 
         */

        private void button2_Click(object sender, EventArgs e)
        {
            if (!workingRom.romLoaded)
                return;

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Super Mario Bros ROM|*.nes";
            saveFileDialog1.Title = "Select a Location";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                InsertTextToRom(marioNameTextbox, Constants.Offsets.textMario);
                InsertTextToRom(worldTextBox, Constants.Offsets.textWorld);
                InsertTextToRom(timeTextBox, Constants.Offsets.textTime);
                InsertTextToRom(timeupTextBox, Constants.Offsets.textTimeUp);
                InsertTextToRom(gameoverTextBox, Constants.Offsets.textGameOver);
                InsertTextToRom(warpzoneTextBox, Constants.Offsets.textWarpZone);
                InsertTextToRom(luigiTextBox, Constants.Offsets.textLuigi);
                InsertTextToRom(playeroneTextBox, Constants.Offsets.textOnePlayer);
                InsertTextToRom(playertwoTextBox, Constants.Offsets.textTwoPlayer);
                InsertTextToRom(copyrightTextBox, Constants.Offsets.textNintendo);
                InsertTextToRom(worldBlackScreenTextBox, Constants.Offsets.textWorld2);
                InsertTextToRom(thankyoumarioTextBox, Constants.Offsets.textThankYouMario);
                InsertTextToRom(thankyouluigiTextBox, Constants.Offsets.textThankYouLuigi);
                InsertTextToRom(butprincessTextBox, Constants.Offsets.textThankYouButOurPrincess);
                InsertTextToRom(butprincess2TextBox, Constants.Offsets.textThankYouButOurPrincess2);
                InsertTextToRom(questTextBox, Constants.Offsets.textYourQuestIsOver);
                InsertTextToRom(quest2TextBox, Constants.Offsets.textYourQuestIsOver2);
                InsertTextToRom(quest3TextBox, Constants.Offsets.textYourQuestIsOver3);
                InsertTextToRom(quest4TextBox, Constants.Offsets.textYourQuestIsOver4);


                System.IO.File.WriteAllBytes(saveFileDialog1.FileName, workingRom.data);
                MessageBox.Show("File Saved!");
            }
        }

         /*
         * 
         *  Populate all the lists of fun things to do.
         * 
         */

        private bool PopulateOffsets()
        {
            standingJumpHeight.Value = workingRom.data[Constants.Offsets.standingJump];
            standingJumpHeight.Enabled = true;

            walkingJumpHeight.Value = workingRom.data[Constants.Offsets.walkingJump];
            walkingJumpHeight.Enabled = true;

            runningJumpHeight.Value = workingRom.data[Constants.Offsets.runningJump];
            runningJumpHeight.Enabled = true;

            leftRunSpeed.Value = workingRom.data[Constants.Offsets.runLeftSpeed];
            leftRunSpeed.Enabled = true;

            runRightSpeed.Value = workingRom.data[Constants.Offsets.runRightSpeed];
            runRightSpeed.Enabled = true;

            walkLeftSpeed.Value = workingRom.data[Constants.Offsets.walkLeftSpeed];
            walkLeftSpeed.Enabled = true;

            walkRightSpeed.Value = workingRom.data[Constants.Offsets.walkRightSpeed];
            walkRightSpeed.Enabled = true;

            startingCoins.Value = workingRom.data[Constants.Offsets.startingCoinsCount];
            startingCoins.Enabled = true;

            startingLives.Value = workingRom.data[Constants.Offsets.startingLivesCount]+1; //Game logic dictates that 0 = 1, 1 = 2.
            startingLives.Enabled = true;

            if (StopTimerApplied())
                stopTimerCheckbox.Checked = true;
            else
                stopTimerCheckbox.Checked = false;

            if (HardModeApplied())
                hardmodeCheckBox.Checked = true;
            else
                hardmodeCheckBox.Checked = false;

            //Enable last sections
            saveButton.Enabled = true;
            tabControl1.Enabled = true;

            return true;
        }

        /*
        * 
        *  Check to see if the Stop Timer ASM has been applied
        * 
        */

        private bool StopTimerApplied()
        {
            for (int i = 0; i < 3; i++)
                if (workingRom.data[Constants.Offsets.timerDecreaseLogic + i] != Constants.Opcodes.NOP)
                    return false;

            return true;
        }

        /*
        * 
        *  Check to see if the Hard Mode ASM has been applied
        * 
        */

        private bool HardModeApplied()
        {
            for (int i = 0; i < Constants.Offsets.enableHardMode.Length; i++)
                if (workingRom.data[Constants.Offsets.hardModeCheck + i] == Constants.Offsets.disableHardMode[i])
                    return false;

            return true;
        }

        /*
        * 
        *  Change Text to HEX Data
        * 
        */

        private byte[] Text2Hex(string tmp)
        {
            if (tmp.Length < 1)
                return null;

            string alphabet = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] array = alphabet.ToCharArray();

            byte[] payload = new byte[tmp.Length];

            for (int i = 0; i < tmp.Length; i++)
            {
                if (tmp[i] == '!')
                    payload[i] = Constants.Letters.Exclamation;
                else if (tmp[i] == '©')
                    payload[i] = Constants.Letters.Copyright;
                else if (tmp[i] == '-')
                    payload[i] = Constants.Letters.Minus;
                else if (tmp[i] == ' ')
                    payload[i] = Constants.Letters.Space;
                else if (tmp[i] == '.')
                    payload[i] = Constants.Letters.Period;
                else if (Array.IndexOf(array, tmp[i]) != -1)
                    payload[i] = (byte)(Array.IndexOf(array, tmp[i]));
                else
                    payload[i] = Constants.Letters.Space;


            }
                
            return payload;
        }

        /*
        * 
        *  Prepare text to scrub and prepare for saving to rom
        * 
        */

        private string PrepareText(string tmp)
        {
            tmp = Regex.Replace(tmp, "[^0-9a-zA-Z©.!\\-\\s]+$", "");
            tmp = tmp.ToUpper();
            return tmp;
        }

        private void InsertTextToRom(TextBox text, int offset)
        {
            if ((string)text.Tag == text.Text)
                return;

            byte[] tempBytes = { };

            tempBytes = Text2Hex(text.Text);
            for (int i = 0; i < tempBytes.Length; i++)
                workingRom.data[offset + i] = tempBytes[i];
        }

        private void standingJumpHeight_ValueChanged(object sender, EventArgs e)
        {
            workingRom.data[Constants.Offsets.standingJump] = (byte)standingJumpHeight.Value;
        }

        private void walkingJumpHeight_ValueChanged_1(object sender, EventArgs e)
        {
            workingRom.data[Constants.Offsets.walkingJump] = (byte)walkingJumpHeight.Value;
        }

        private void runningJumpHeight_ValueChanged(object sender, EventArgs e)
        {

            workingRom.data[Constants.Offsets.runningJump] = (byte)runningJumpHeight.Value;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (stopTimerCheckbox.Checked)
            {
                for (int i=0;i<Constants.Offsets.timerCode.Length;i++)
                    workingRom.data[Constants.Offsets.timerDecreaseLogic+i] = Constants.Opcodes.NOP;
            }
            else if (!stopTimerCheckbox.Checked)
            {
                for (int i = 0; i < Constants.Offsets.timerCode.Length; i++)
                    workingRom.data[Constants.Offsets.timerDecreaseLogic + i] = Constants.Offsets.timerCode[i];
            }
        }

        private void startingLives_ValueChanged(object sender, EventArgs e)
        {
            workingRom.data[Constants.Offsets.startingLivesCount] = (byte)(startingLives.Value - 1);
        }

        private void startingCoins_ValueChanged(object sender, EventArgs e)
        {
            workingRom.data[Constants.Offsets.startingCoinsCount] = (byte)startingCoins.Value;
        }

        private void marioNameTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void marioNameTextbox_Leave(object sender, EventArgs e)
        {
            marioNameTextbox.Text = PrepareText(marioNameTextbox.Text);
        }

        private void BubblesCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (BubblesCheckbox.Checked)
            {
                for (int i = 0; i < Constants.Offsets.bubbleCode.Length; i++)
                    workingRom.data[Constants.Offsets.bubbleBranch + i] = Constants.Opcodes.NOP;
            }
            else if (!BubblesCheckbox.Checked)
            {
                for (int i=0; i < Constants.Offsets.bubbleCode.Length; i++)
                    workingRom.data[Constants.Offsets.bubbleBranch + i] = Constants.Offsets.bubbleCode[i];
            }
        }

        private void worldTextBox_Leave(object sender, EventArgs e)
        {
            worldTextBox.Text = PrepareText(worldTextBox.Text);
        }

        private void timeTextBox_Leave(object sender, EventArgs e)
        {
            timeTextBox.Text = PrepareText(timeTextBox.Text);
        }

        private void timeupTextBox_Leave(object sender, EventArgs e)
        {
            timeupTextBox.Text = PrepareText(timeupTextBox.Text);
        }

        private void gameoverTextBox_Leave(object sender, EventArgs e)
        {
            gameoverTextBox.Text = PrepareText(gameoverTextBox.Text);
        }

        private void warpzoneTextBox_Leave(object sender, EventArgs e)
        {
            warpzoneTextBox.Text = PrepareText(warpzoneTextBox.Text);
        }

        private void luigiTextBox_Leave(object sender, EventArgs e)
        {
            luigiTextBox.Text = PrepareText(luigiTextBox.Text);
        }

        private void playeroneTextBox_Leave(object sender, EventArgs e)
        {
            playeroneTextBox.Text = PrepareText(playeroneTextBox.Text);
        }

        private void playertwoTextBox_Leave(object sender, EventArgs e)
        {
            playertwoTextBox.Text = PrepareText(playertwoTextBox.Text);
        }

        private void copyrightTextBox_Leave(object sender, EventArgs e)
        {
            copyrightTextBox.Text = PrepareText(copyrightTextBox.Text);
        }

        private void worldBlackScreenTextBox_Leave(object sender, EventArgs e)
        {
            worldBlackScreenTextBox.Text = PrepareText(worldBlackScreenTextBox.Text);
        }
        private void thankyoumarioTextBox_Leave(object sender, EventArgs e)
        {
            thankyoumarioTextBox.Text = PrepareText(thankyoumarioTextBox.Text);
        }
        private void thankyouluigiTextBox_Leave(object sender, EventArgs e)
        {
            thankyouluigiTextBox.Text = PrepareText(thankyouluigiTextBox.Text);
        }
        private void butprincessTextBox_Leave(object sender, EventArgs e)
        {
            butprincessTextBox.Text = PrepareText(butprincessTextBox.Text);
        }
        private void butprincess2TextBox_Leave(object sender, EventArgs e)
        {
            butprincess2TextBox.Text = PrepareText(butprincess2TextBox.Text);
        }
        private void questTextBox_Leave(object sender, EventArgs e)
        {
            questTextBox.Text = PrepareText(questTextBox.Text);
        }
        private void quest2TextBox_Leave(object sender, EventArgs e)
        {
            quest2TextBox.Text = PrepareText(quest2TextBox.Text);
        }
        private void quest3TextBox_Leave(object sender, EventArgs e)
        {
            quest3TextBox.Text = PrepareText(quest3TextBox.Text);
        }
        private void quest4TextBox_Leave(object sender, EventArgs e)
        {
            quest4TextBox.Text = PrepareText(quest4TextBox.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                workingRom.data[Constants.Offsets.overworldSky] = (byte)comboBox1.SelectedIndex;
        }

        private void underworldComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            workingRom.data[Constants.Offsets.undergroundSky] = (byte)underworldComboBox.SelectedIndex;
        }

        private void underwaterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            workingRom.data[Constants.Offsets.underwaterSky] = (byte)underwaterComboBox.SelectedIndex;
        }

        private void dungeonComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            workingRom.data[Constants.Offsets.dungeonSky] = (byte)dungeonComboBox.SelectedIndex;
        }

        private void nighttimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            workingRom.data[Constants.Offsets.nighttimeSky] = (byte)nighttimeComboBox.SelectedIndex;
        }

        private void winterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            workingRom.data[Constants.Offsets.winterDaySky] = (byte)winterComboBox.SelectedIndex;
        }

        private void winternightComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            workingRom.data[Constants.Offsets.winterNightSky] = (byte)winternightComboBox.SelectedIndex;
        }

        private void sixthreeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            workingRom.data[Constants.Offsets.sixdashthreeSky] = (byte)sixthreeComboBox.SelectedIndex;
        }

        private void hardmodeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (hardmodeCheckBox.Checked) {
                for (int i = 0; i < Constants.Offsets.enableHardMode.Length; i++) 
                    workingRom.data[Constants.Offsets.hardModeCheck + i] = Constants.Offsets.enableHardMode[i];
                
            }
            else if (!hardmodeCheckBox.Checked) {
                for (int i = 0; i < Constants.Offsets.disableHardMode.Length; i++) 
                    workingRom.data[Constants.Offsets.hardModeCheck + i] = Constants.Offsets.disableHardMode[i];
                
            }
        }

        private void leftRunSpeed_ValueChanged(object sender, EventArgs e)
        {
            workingRom.data[Constants.Offsets.runLeftSpeed] = (byte)leftRunSpeed.Value;
        }

        private void runRightSpeed_ValueChanged(object sender, EventArgs e)
        {
            workingRom.data[Constants.Offsets.runRightSpeed] = (byte)runRightSpeed.Value;
        }

        private void walkLeftSpeed_ValueChanged(object sender, EventArgs e)
        {
            workingRom.data[Constants.Offsets.walkLeftSpeed] = (byte)walkLeftSpeed.Value;
        }

        private void walkRightSpeed_ValueChanged(object sender, EventArgs e)
        {
            workingRom.data[Constants.Offsets.walkRightSpeed] = (byte)walkRightSpeed.Value;
        }
    }
}
