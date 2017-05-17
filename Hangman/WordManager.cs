using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Hangman  // User can make changes to the game word library here
{
    public partial class WordManager : Form
    {
        Game gm = new Game();
        HangmanController hangControll = new HangmanController();

        public WordManager(Hangman gmMenu)
        {
            InitializeComponent();
        }
        
        private void WordManager_Load(object sender, EventArgs e)
        {
            hangControll.LoadWordLibraries(lstBoxWordLibrary, gm.destinationFolder, "*.txt");
        }
     
        private void btnAddLib_Click(object sender, EventArgs e)
        {
            try
            {               
               hangControll.ReadCustomFile(gm.destinationFolder, lstBoxWordLibrary,lstBoxWords);//ICE
               MessageBox.Show("File Library added successfully");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstBoxWordLibrary_SelectedValueChanged(object sender, EventArgs e)
        {
            lstBoxWords.Items.Clear();
            string[] lines = System.IO.File.ReadAllLines(gm.destinationFolder+"\\"+ lstBoxWordLibrary.SelectedItem.ToString());

            foreach (string line in lines)
            {
                lstBoxWords.Items.Add(line);
            }
            hangControll.listWords(lstBoxWords,lstBoxWordLibrary,gm.destinationFolder); // ICE
        }

        private bool addWord(string path,string fileName,string word)
        {   
            using (StreamWriter sw = File.AppendText(path + "\\"+fileName))
            {
                try
                { 
                    sw.WriteLine(word);
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                    throw;               
                }
            }	       
        }

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtWord.Text, @"^[a-zA-Z]+$"))
            {
                if (lstBoxWordLibrary.SelectedItem != null)
                {
                    if ((txtWord.Text != "") || (txtWord.Text != "Enter Word Here") || (txtWord.Text != "Word Added"))
                    {
                        if (addWord(gm.destinationFolder, lstBoxWordLibrary.SelectedItem.ToString(), txtWord.Text.ToUpper()))
                        {
                            txtWord.Text = "Word Added";
                            txtWord.BackColor = Color.LightGreen;
                            hangControll.listWords(lstBoxWords, lstBoxWordLibrary,gm.destinationFolder); // ICE
                        }
                        else
                        {
                            txtWord.BackColor = Color.LightSalmon;
                        }
                    }
                }
                else
                {
                    txtWord.BackColor = Color.LightSalmon;
                    MessageBox.Show("Please Select A Library to Add to");
                }
            }

            else
            {
                txtWord.BackColor = Color.LightSalmon;
                MessageBox.Show("Only Letters are accepted. No Spaces or Numbers");                
            }
        }

        private void txtWord_MouseClick(object sender, MouseEventArgs e)
        {
            txtWord.SelectionStart = 0;
            txtWord.SelectionLength = txtWord.Text.Length;
            txtWord.BackColor = Color.White;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstBoxWords.SelectedItem == null) // If a word isnt selected from the word list then the system will prompt to delete the word library
                {
                    if(lstBoxWordLibrary.SelectedItem.ToString()!="Word.txt")
                    {
                        hangControll.deleteWordLibrary(gm.destinationFolder, lstBoxWordLibrary.SelectedItem.ToString(), lstBoxWordLibrary, lstBoxWords);
                        lstBoxWordLibrary.Items.Clear();
                        lstBoxWords.Items.Clear();
                        hangControll.LoadWordLibraries(lstBoxWordLibrary, gm.destinationFolder, "*.txt"); // ICE
                        txtWord.Text = "Deleted";
                        txtWord.BackColor = Color.White;
                    }
                    else
                    {
                        MessageBox.Show("'Word.txt' is the defauld word library and you cant delete it !");
                    }
                }

                else // If a word is seleected from the word list then the selected word will be deleted
                {
                    //try
                    // {
                    if (lstBoxWords.Items.Count > 5)
                    {
                        lstBoxWords.Items.Remove(lstBoxWords.SelectedItem);
                        hangControll.updateWords(gm.destinationFolder, lstBoxWordLibrary.SelectedItem.ToString(), lstBoxWords); //ICE
                        txtWord.Text = "Deleted";
                        txtWord.BackColor = Color.White;
                    }
                    else
                    {
                        MessageBox.Show("Sorry You May Not Delete The Last 5 Words");
                    }
                    //}

                    //catch (Exception ex)
                    //{
                    //     MessageBox.Show(ex.Message);
                    // }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
	
    }
}
