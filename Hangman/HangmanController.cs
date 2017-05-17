using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Hangman
{
    class HangmanController  // This acts as the intermedoary between the forms and data stores. This is where most of the processes are coded
    {
         public string word;
         public List<char> correctLetters = new List<char>();
         string gameWords; /// to hold the current game word library

         public HangmanController()
         { 
         
         }

        public void LoadWordLibraries(ListBox lsb, string Folder, string FileType) // Populates the word library by loading the word files to listbox
        {
            DirectoryInfo dinfo = new DirectoryInfo(Folder);
            FileInfo[] Files = dinfo.GetFiles(FileType);
            foreach (FileInfo file in Files)
            {
                lsb.Items.Add(file.Name);
            }
        }

        public void listWords(ListBox lstBoxWords, ListBox lstBoxWordLibrary,string destinationFolder) // Cleares the word list and reloads it
        {
            lstBoxWords.Items.Clear();
            string[] lines = System.IO.File.ReadAllLines(destinationFolder + "\\" + lstBoxWordLibrary.SelectedItem.ToString());

            foreach (string line in lines)
            {
                lstBoxWords.Items.Add(line);
            }
        }

        public void updateWords(string path, string fileName, ListBox lstBoxWords) // Updates the wordlists and files apon deletion of word or library
        {
            System.IO.File.Delete(path + "\\" + fileName);
            using (StreamWriter sw = File.AppendText(path + "\\" + fileName))
            {
                try
                {
                    foreach (var item in lstBoxWords.Items)
                    {
                        sw.WriteLine(item.ToString());
                        //return true;
                    }
                }
                catch (Exception e)
                {
                    //return false;
                    MessageBox.Show(e.Message);
                    throw;
                }
            }
        }

        public string ReadCustomFile(string destination, ListBox lstBoxWordLibrary, ListBox lstBoxWords) // Add a word library to the game and copy it to game
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            string filename;
            //SaveFileDialog testing = new SaveFileDialog();
            fileDialog.ShowDialog();
            filename = fileDialog.FileName;

            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                lstBoxWords.Items.Add(line);
            }

            lstBoxWordLibrary.Items.Add(System.IO.Path.GetFileName(filename));

            System.IO.File.Copy(filename, destination +"\\" + System.IO.Path.GetFileName(filename), false);
            return lines[0];
        }

        public void deleteWordLibrary(string path, string fileName, ListBox lstBoxWordLibrary, ListBox lstBoxWords) // Methode to delete a word library 
        {
            try
            {
                if (lstBoxWords.SelectedItem == null)
                {
                    if (MessageBox.Show("Are you sure you want to delete the entire word library file?", "Warning",
                                        MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        System.IO.File.Delete(path + "\\" + fileName);
                        lstBoxWordLibrary.Items.Clear();
                    }
                    else
                    {
                        return;
                    }

                }
            }

            catch
            {
                throw;
            }
        }

        public void loadWord(Label lblTest, Label lblWord) // draw the dashes required for the word
        {
            word = PickWord(Hangman.gameWords).ToUpper();
            string temp = "Test Value : " + word;
            lblTest.Text = temp;


            string wordLine = "";

            for (int x = 0; x < word.Length; x++)
            {
                wordLine += "_ ";
            }
            lblWord.Text = wordLine;
        }

        public void updateWord(Label lblWord)  // Updates the lblWord to Show the correctly guessed letters 
        {
            string wordLine = "";
            for (int x = 0; x < this.word.Length; x++) 
            {
                //string capitalLetter =.to;
                if (correctLetters.Contains(this.word.ElementAt(x))) 
                {
                    wordLine += this.word.ElementAt(x); 
                }
                else
                {
                    wordLine += "_ ";
                }
            }
            lblWord.Text = wordLine;
        }

        public static string PickWord(string Word) // Picks a word from the file 
        {
            //OpenFileDialog fileDialog = new OpenFileDialog();

            string[] lines = System.IO.File.ReadAllLines("WordLibrary\\"+Word); // This is the current actual game Word Library

            Random rnd = new Random();
            int randomNumber = rnd.Next(0, lines.Length);

            return lines[randomNumber];

        }
    }
}
