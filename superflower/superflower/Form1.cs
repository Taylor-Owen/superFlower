using System;
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
                byte[] tempBytes = { };

                tempBytes = Text2Hex(marioNameTextbox.Text);
                for (int i=0;i<tempBytes.Length;i++)
                    workingRom.data[Constants.Offsets.textMario + i] = tempBytes[i];

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

            startingCoins.Value = workingRom.data[Constants.Offsets.startingCoinsCount];
            startingCoins.Enabled = true;

            startingLives.Value = workingRom.data[Constants.Offsets.startingLivesCount]+1; //Game logic dictates that 0 = 1, 1 = 2.
            startingLives.Enabled = true;

            if (StopTimerApplied())
                stopTimerCheckbox.Checked = true;
            else
                stopTimerCheckbox.Checked = false;

            saveButton.Enabled = true;

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
                if (workingRom.data[Constants.Offsets.timerDecreaseLogic + i] != 0xEA)
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

            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] array = alphabet.ToCharArray();

            string numbers = "0123456789";
            char[] numArray = numbers.ToCharArray();

            byte[] payload = new byte[tmp.Length];

            for (int i = 0; i < tmp.Length; i++)
            {
                if (tmp[i] == '!')
                    payload[i] = Constants.Letters.Exclamation;

                if (tmp[i] == '©')
                    payload[i] = Constants.Letters.Copyright;

                if (tmp[i] == '-')
                    payload[i] = Constants.Letters.Minus;

                if (Array.IndexOf(array, tmp[i]) != -1)
                    payload[i] = (byte)(Array.IndexOf(array, tmp[i]) + 0x0A);

                if (Array.IndexOf(numArray, tmp[i]) != -1)
                    payload[i] = (byte)(Array.IndexOf(numArray, tmp[i]));


            }
                
            return payload;
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
            marioNameTextbox.Text = Regex.Replace(marioNameTextbox.Text, "[^0-9a-zA-Z©!-]+", "");
            marioNameTextbox.Text = marioNameTextbox.Text.ToUpper();
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
    }
}
