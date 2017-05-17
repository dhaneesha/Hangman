using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace Hangman  // The mail menu for the control where user will start the game
{
    
    public partial class Hangman : UserControl
    {
        private Game gameScreen;
        private WordManager wordScreen;
        public static string gameWords;
        HangmanController hc = new HangmanController();

        public Hangman()
        {
            InitializeComponent();
        }

        private void btnAddCustomFile_Click(object sender, EventArgs e) // Runs the Word manager window
        {
            try
            {
                if (wordScreen == null || wordScreen.IsDisposed)
                {
                    if (gameScreen == null || gameScreen.IsDisposed )
                    {
                        wordScreen = new WordManager(this);
                    }
                    else
                    {

                        MessageBox.Show("Please Close the Game Window Before Opening Word Manager ");
                        gameScreen.BringToFront();
                        return;
                       
                    }
                }
                wordScreen.BringToFront();
                wordScreen.Show();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }          
        }

        
        private void btnStart_Click(object sender, EventArgs e) 
        {

            try
            {
                if (gameScreen == null || gameScreen.IsDisposed)
                {
                    if (wordScreen == null || wordScreen.IsDisposed)
                    {
                        gameScreen = new Game();
                    }
                    else 
                    {
                        MessageBox.Show("Please Close the Word Manager Window Before Running Game");
                        wordScreen.BringToFront();
                        return;
                    }
                }
                gameScreen.BringToFront();
                gameScreen.Show();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Hangman_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show(e.KeyChar.ToString());
        }

        private void lstSelectWords_SelectedValueChanged(object sender, EventArgs e)
        {
            gameWords = lstSelectWords.SelectedItem.ToString();
        }

        private void Hangman_Load(object sender, EventArgs e)
        {
            gameScreen = new Game(); // Initaiting the gameScreeen to  access destinationFolder
            hc.LoadWordLibraries(lstSelectWords, gameScreen.destinationFolder, "*.txt");
            gameWords = "Word.txt";
            gameScreen = null; //discarding to gameScreen avoid open window vallidation problems

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lstSelectWords.Items.Clear();
            gameScreen = new Game(); // Initaiting the gameScreeen to  access destinationFolder
            hc.LoadWordLibraries(lstSelectWords, gameScreen.destinationFolder, "*.txt");
            gameWords = "Word.txt";
            gameScreen = null; //discarding to gameScreen avoid open window vallidation problems
        }

    }
}
