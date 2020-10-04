using System;
using System.Windows.Forms;

namespace PwdGen
{
    public partial class MainWin : Form
    {
        public MainWin()
        {
            InitializeComponent();
            PwdButton.Text = GeneratePwd();
        }

        private string GeneratePwd()
        {
            Random fixRand = new Random();
            int SignsCount = 0;
            int i, NextSign;
            string Password = "",AvailSymb="";
            if (CapLetters.Checked == true)
            {
                SignsCount += 26; AvailSymb="ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            }
            if (SmLetters.Checked == true)
            {
                SignsCount += 26; AvailSymb+="abcdefghijklmnopqrstuvwxyz";
            }
            if (Numbers.Checked == true)
            {
                SignsCount += 10; AvailSymb+="0123456789";
            }
            if (SpecSigns.Checked == true)
            {
                SignsCount += 10; AvailSymb += "!@#$%&_-+=";
            }
            for (i = 0; i < PwdLenght.Value; i++)
            {
                NextSign = Convert.ToByte((double)(SignsCount-1) * fixRand.NextDouble());
                Password+=AvailSymb[NextSign];
            }
            return Password;
        }

        private void CheckBox_Clicked(object sender, EventArgs e)
        {
              if (sender == CapLetters && CapLetters.Checked == false)
            {
                if (SmLetters.Checked==false && Numbers.Checked==false && SpecSigns.Checked==false) CapLetters.Checked = true;
            }
            if (sender == SmLetters && SmLetters.Checked == false)
            {
                if (CapLetters.Checked == false && Numbers.Checked == false && SpecSigns.Checked == false) SmLetters.Checked = true;
            }
            if (sender == Numbers && Numbers.Checked == false)
            {
                if (CapLetters.Checked == false && SmLetters.Checked == false && SpecSigns.Checked == false) Numbers.Checked = true;
            }
            if (sender == SpecSigns && SpecSigns.Checked == false)
            {
                if (CapLetters.Checked == false && SmLetters.Checked == false && Numbers.Checked == false) SpecSigns.Checked = true;
            }
            PwdButton.Text = GeneratePwd();
        }

        private void Lenght_Changed(object sender, EventArgs e)
        {
            PwdButton.Text = GeneratePwd();
        }

        private void PwdButton_Click(object sender, EventArgs e)
        {
            PwdButton.Text = GeneratePwd();
        }

        private void CopyClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(PwdButton.Text);
        }
    }
}