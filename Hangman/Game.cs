using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Hangman;

namespace Hangman
{
    public partial class Game : Form  // This is the actual game window where the user will guess letters and see win lose
    {
        char[] letters = new char[26];
        
        int letterCount = 0;
        //string word;
        int tries = 0; // Number of wrong attempts
       // public string destination = @"F:\New Zealand\Unitec Course Material\ISCG7421 APD\Assignment\Hangman Backup\Hangman\Hangman\bin\Debug\WordLibrary\";
        public string destinationFolder { get; set; }
        HangmanController hangController;

        public Game()
        {
            InitializeComponent();
            this.destinationFolder = @"WordLibrary";
            hangController = new HangmanController();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            try
            {
                hangController.loadWord(lblTest, lblWord); //ICE
                pctBox.ImageLocation = "Images\\hangman0.jpg";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }

        private void btnNew_Click(object sender, EventArgs e)
        {
            hangController.loadWord(lblTest, lblWord); //ICE
            hangController.correctLetters=new List<char>();
            letterCount = 0;
            letters = new char[26];
            lblTriedKeys.Text = "";
            tries = 0;
            pctBox.ImageLocation = "Images\\hangman0.jpg";
        }

        

        private void Game_KeyPress(object sender, KeyPressEventArgs e) // Check the letter inputs and updates the status ow word
        {
            if (char.IsLetter(e.KeyChar))
            {                          
                if (letterCount < 26)
                {
                    if (!letters.Contains(e.KeyChar))
                    {
                        letterCount++;               // Variable to keep track of the number of letters tried
                        string triedKeys = "";       // Variable to display tried letters
                        letters[letterCount - 1] = e.KeyChar;
                        for (int x = 0; x < letterCount; x++)
                        {
                            triedKeys = triedKeys + letters[x].ToString().ToUpper() + "    ";
                        }

                        lblTriedKeys.Text = triedKeys;

                        if (checkLetter(e))
                        {
                            lblTest2.Text = "Correct Guess";
                            lblTest2.ForeColor = System.Drawing.Color.Green;
                            hangController.correctLetters.Add(Char.ToUpper(e.KeyChar));
                            hangController.updateWord(lblWord);

                            if (lblWord.Text == hangController.word)
                            {
                                MessageBox.Show("Hooray !!!, You won :)");
                            }
                        }

                        else
                        {
                            lblTest2.ForeColor = System.Drawing.Color.Red;
                            lblTest2.Text = "Wrong Guess";

                            if (tries < 7)
                            {
                                tries++;
                                string locationString = "Images\\hangman" + tries.ToString() + ".jpg";
                                pctBox.ImageLocation = locationString;
                                //pctBox.Refresh();       
                            }

                            if (tries >= 7)
                            { 
                                MessageBox.Show("Tough Luck. You Lose ");
                            }

                        }
                    }

                    else
                    { MessageBox.Show("Letter Already Tried"); }

                }

                else 
                { 
                    MessageBox.Show("Array Full"); 
                }
                
            }
            else
            {                
                lblTest.Text = e.KeyChar.ToString();
                MessageBox.Show("Only Letters are Accepted");
            }  
        }

        private bool checkLetter( KeyPressEventArgs e) // checks if the guessed letter is correct or not
        {
            if (hangController.word.Contains(e.KeyChar.ToString().ToUpper()))
            {
                return true;
            }

            else 
            {
                return false;
            }
        }
    }
}
