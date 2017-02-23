using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoiSaveManager
{
    public partial class Form1 : Form
    {
        private string[] gameSaves;
        private string[] originalSaves;

        private int amountOfSaves;

        private string backupSaveLocation;
        private string originalSaveLocation;
        private string originalSaveName;

        public Form1()
        {
            amountOfSaves = 3;

            gameSaves = new string[amountOfSaves];
            originalSaves = new string[amountOfSaves];
            backupSaveLocation = "";
            originalSaveLocation = @"C:\Users\" + System.Security.Principal.WindowsIdentity.GetCurrent().Name.Split('\\')[1] + @"\AppData\LocalLow\PolyKid\Poi\";
            originalSaveName = "poi-save-X.dat";

            InitializeComponent();

            GetGameSaves();
        }

        private void GetGameSaves()
        {
            for (int i = 0; i < amountOfSaves; i++)
            {
                originalSaves[i] = originalSaveLocation + originalSaveName.Replace('X', Char.Parse(i.ToString()));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string userSettingPath = Properties.Settings.Default["BackupLocation"].ToString();
            if (!String.IsNullOrWhiteSpace(userSettingPath))
            {
                BackupSaveLocationTextBox.Text = userSettingPath;
                backupSaveLocation = userSettingPath;
            }
            else
            {
                BackupSaveLocationButton_Click(sender, e); //Have user pick a location
            }
            RefreshListBox();
        }

        private void Form1_FormClosing(object sender, EventArgs e)
        {
            Properties.Settings.Default["BackupLocation"] = backupSaveLocation;

            Properties.Settings.Default.Save();
        }

        private void BackupSaveLocationButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialogBox = new FolderBrowserDialog();
            dialogBox.Description = "Please highlight your Poi backup save directory.";
            if (dialogBox.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                BackupSaveLocationTextBox.Text = dialogBox.SelectedPath;
            }

            this.backupSaveLocation = dialogBox.SelectedPath + @"\";

            if (!String.IsNullOrWhiteSpace(dialogBox.SelectedPath))
            {
                RefreshListBox();
            }
        }

        private void RefreshListBox()
        {
            if (String.IsNullOrWhiteSpace(backupSaveLocation))
            {
                MessageBox.Show("Please select a backup location first!");
                return;
            }

            if(!Directory.Exists(BackupSaveLocationTextBox.Text))
            {
                BackupSaveLocationTextBox.Text = String.Empty;
                Properties.Settings.Default["BackupLocation"] = String.Empty;
                Properties.Settings.Default.Save();
                return;
            }

            BackupSavesListBox.Items.Clear();

            string backupSaves = BackupSaveLocationTextBox.Text;

            string[] files = Directory.GetFiles(backupSaves, "*.dat");

            foreach (string file in files)
            {
                var temp = file.Split('\\');
                BackupSavesListBox.Items.Add(temp[temp.Length - 1]);
            }
        }

        private void SetSave0Button_Click(object sender, EventArgs e)
        {
            if (BackupSavesListBox.SelectedItem == null)
            {
                return;
            }

            GameSave0TextBox.Text = SetSave(0);            
        }

        private void SetSave1Button_Click(object sender, EventArgs e)
        {
            if (BackupSavesListBox.SelectedItem == null)
            {
                return;
            }

            GameSave1TextBox.Text = SetSave(1);
        }

        private void SetSave2Button_Click(object sender, EventArgs e)
        {
            if (BackupSavesListBox.SelectedItem == null)
            {
                return;
            }

            GameSave2TextBox.Text = SetSave(2);
        }

        private string SetSave(int index)
        {
            string selectedSave = BackupSavesListBox.SelectedItem.ToString();
            gameSaves[index] = backupSaveLocation + selectedSave;

            return selectedSave;
        }

        private void ReplaceGameSavesButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(backupSaveLocation))
            {
                MessageBox.Show("Please select a backup location first!");
                return;
            }

            DialogResult dialogBox = MessageBox.Show("Are you sure you want to over-write your game saves?\n" +
                "Your current saves will be backed up to your current backup folder.", "Warning", MessageBoxButtons.YesNo);

            switch (dialogBox)
            {
                case DialogResult.No:
                    return;
                    break;
                case DialogResult.Yes:
                    BackupGameSaves();
                    RefreshListBox();
                    ReplaceSaves();
                    break;
                default:
                    break;
            }
        }

        private void ReplaceSaves()
        {
            try
            {
                for (int i = 0; i < amountOfSaves; i++)
                {
                    if (!String.IsNullOrWhiteSpace(gameSaves[i]))
                    {
                        if (File.Exists(originalSaves[i]))
                        {
                            File.Delete(originalSaves[i]);
                        }
                        File.Copy(gameSaves[i], originalSaveLocation + originalSaveName.Replace('X', Char.Parse(i.ToString())));
                    }
                }
            }
            catch (Exception e)
            {
                PrintStackTrace(e);
            }
        }

        private void BackupGameSavesButton_Click(object sender, EventArgs e)
        {
            BackupGameSaves();
        }

        private void BackupGameSaves()
        {
            if (String.IsNullOrWhiteSpace(backupSaveLocation))
            {
                MessageBox.Show("Please select a backup location first!");
                return;
            }
            string saveName = "";
            string originalName = "";
            for (int k = 0; k < amountOfSaves; k++)
            {
                if (!String.IsNullOrWhiteSpace(gameSaves[k]))
                {
                    originalName = originalSaveLocation + originalSaveName.Replace('X', Char.Parse(k.ToString()));
                    if (File.Exists(originalName))
                    {
                        saveName = backupSaveLocation + GetFormattedDate() + "." + originalSaveName.Replace('X', Char.Parse(k.ToString()));
                        File.Copy(originalName, saveName);
                    }
                }
            }
                

            RefreshListBox();
        }

        private string GetFormattedDate()
        {
            return Regex.Replace(DateTime.Now.ToString().Replace(':', '.').Replace('/', '.'), @"\s+", ".");
        }

        private void PrintStackTrace(Exception ex)
        {
            File.WriteAllLines(Directory.GetCurrentDirectory() + "error" + GetFormattedDate() + ".log", new string[] { ex.StackTrace });
        }

        private void MoveSave1Button_Click(object sender, EventArgs e)
        {
            MoveSaveX(0);
        }

        private void MoveSave2Button_Click(object sender, EventArgs e)
        {
            MoveSaveX(1);
        }

        private void MoveSave3Button_Click(object sender, EventArgs e)
        {
            MoveSaveX(2);
        }

        private void MoveSaveX(int index)
        {
            if (String.IsNullOrWhiteSpace(backupSaveLocation))
            {
                MessageBox.Show("Please select a backup location first!");
                return;
            }

            if(!File.Exists(originalSaves[index]))
            {
                MessageBox.Show("You do not have a save in slot " + index);
                return;
            }

            else
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox("Please give a name to your save file.\n" +
                "Leave name blank for an auto-generated save name.", "Save Name", "", -1, -1);

                if (String.IsNullOrWhiteSpace(input))
                {
                    input = GetFormattedDate() + "." + originalSaveName.Replace('X', Char.Parse(index.ToString()));
                }
                File.Copy(originalSaves[index], backupSaveLocation + input + ".dat");
            }

            RefreshListBox();
        }

        private void RefreshListBoxButton_Click(object sender, EventArgs e)
        {
            RefreshListBox();
        }

        private void DeleteSaveButton_Click(object sender, EventArgs e)
        {
            string saveToDelete = BackupSavesListBox.SelectedItem.ToString();

            if (File.Exists(backupSaveLocation + saveToDelete))
            {
                if (String.IsNullOrWhiteSpace(backupSaveLocation))
                {
                    MessageBox.Show("Please select a backup location first!");
                    return;
                }

                if(BackupSavesListBox.SelectedItem == null)
                {
                    return;
                }

                DialogResult dialogBox = MessageBox.Show("Are you sure you want to over-write your game saves?\n" +
                    "Your save will be moved to the Recycle Bin.", "Warning", MessageBoxButtons.YesNo);

                switch (dialogBox)
                {
                    case DialogResult.No:
                        return;
                        break;
                    case DialogResult.Yes:
                        FileSystem.DeleteFile(backupSaveLocation + saveToDelete, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                        RefreshListBox();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("That file does not exist.");
            }
        }

        private void ClearBackupLocationButton_Click(object sender, EventArgs e)
        {
            BackupSaveLocationTextBox.Text = string.Empty;
            backupSaveLocation = string.Empty;

            BackupSavesListBox.Items.Clear();
        }

        private void ClearSave0Button_Click(object sender, EventArgs e)
        {
            GameSave0TextBox.Text = string.Empty;
            gameSaves[0] = string.Empty;
        }

        private void ClearSave1Button_Click(object sender, EventArgs e)
        {
            GameSave1TextBox.Text = string.Empty;
            gameSaves[1] = string.Empty;
        }

        private void ClearSave2Button_Click(object sender, EventArgs e)
        {
            GameSave2TextBox.Text = string.Empty;
            gameSaves[2] = string.Empty;
        }

        private void RenameSaveButton_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Please give a name to your save file.\n", 
                "Save Name", "", -1, -1);

            if (!String.IsNullOrWhiteSpace(input))
            {
                File.Copy(backupSaveLocation + BackupSavesListBox.SelectedItem.ToString(), backupSaveLocation + input + ".dat");
                File.Delete(backupSaveLocation + BackupSavesListBox.SelectedItem.ToString());
            }

            RefreshListBox();
        }

        private void GameSaveLocationButton_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", originalSaveLocation);
        }
    }
}
