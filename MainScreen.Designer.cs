using System.Windows.Forms;

namespace PoiSaveManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GameSave0TextBox = new System.Windows.Forms.TextBox();
            this.GameSave1TextBox = new System.Windows.Forms.TextBox();
            this.GameSave2TextBox = new System.Windows.Forms.TextBox();
            this.Save0Label = new System.Windows.Forms.Label();
            this.Save1Label = new System.Windows.Forms.Label();
            this.Save2Label = new System.Windows.Forms.Label();
            this.MoveSave1Button = new System.Windows.Forms.Button();
            this.MoveSave2Button = new System.Windows.Forms.Button();
            this.MoveSave3Button = new System.Windows.Forms.Button();
            this.MainGameSaveGroupBox = new System.Windows.Forms.GroupBox();
            this.ClearSave2Button = new System.Windows.Forms.Button();
            this.ClearSave1Button = new System.Windows.Forms.Button();
            this.ClearSave0Button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RenameSaveButton = new System.Windows.Forms.Button();
            this.ClearBackupLocationButton = new System.Windows.Forms.Button();
            this.DeleteSaveButton = new System.Windows.Forms.Button();
            this.RefreshListBoxButton = new System.Windows.Forms.Button();
            this.BackupSavesListBox = new System.Windows.Forms.ListBox();
            this.SetSave1Button = new System.Windows.Forms.Button();
            this.SetSave2Button = new System.Windows.Forms.Button();
            this.SetSave0Button = new System.Windows.Forms.Button();
            this.BackupSaveLocationTextBox = new System.Windows.Forms.TextBox();
            this.BackupSaveLocationLabel = new System.Windows.Forms.Label();
            this.BackupSaveLocationButton = new System.Windows.Forms.Button();
            this.ReplaceGameSavesButton = new System.Windows.Forms.Button();
            this.GameSaveLocationButton = new System.Windows.Forms.Button();
            this.BackupGameSavesButton = new System.Windows.Forms.Button();
            this.MainGameSaveGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameSave0TextBox
            // 
            this.GameSave0TextBox.Enabled = false;
            this.GameSave0TextBox.Location = new System.Drawing.Point(56, 13);
            this.GameSave0TextBox.Name = "GameSave0TextBox";
            this.GameSave0TextBox.Size = new System.Drawing.Size(176, 20);
            this.GameSave0TextBox.TabIndex = 1;
            // 
            // GameSave1TextBox
            // 
            this.GameSave1TextBox.Enabled = false;
            this.GameSave1TextBox.Location = new System.Drawing.Point(56, 39);
            this.GameSave1TextBox.Name = "GameSave1TextBox";
            this.GameSave1TextBox.Size = new System.Drawing.Size(176, 20);
            this.GameSave1TextBox.TabIndex = 1;
            // 
            // GameSave2TextBox
            // 
            this.GameSave2TextBox.Enabled = false;
            this.GameSave2TextBox.Location = new System.Drawing.Point(56, 65);
            this.GameSave2TextBox.Name = "GameSave2TextBox";
            this.GameSave2TextBox.Size = new System.Drawing.Size(176, 20);
            this.GameSave2TextBox.TabIndex = 1;
            // 
            // Save0Label
            // 
            this.Save0Label.AutoSize = true;
            this.Save0Label.Location = new System.Drawing.Point(6, 16);
            this.Save0Label.Name = "Save0Label";
            this.Save0Label.Size = new System.Drawing.Size(44, 13);
            this.Save0Label.TabIndex = 2;
            this.Save0Label.Text = "Save 1:";
            // 
            // Save1Label
            // 
            this.Save1Label.AutoSize = true;
            this.Save1Label.Location = new System.Drawing.Point(6, 42);
            this.Save1Label.Name = "Save1Label";
            this.Save1Label.Size = new System.Drawing.Size(44, 13);
            this.Save1Label.TabIndex = 3;
            this.Save1Label.Text = "Save 2:";
            // 
            // Save2Label
            // 
            this.Save2Label.AutoSize = true;
            this.Save2Label.Location = new System.Drawing.Point(6, 68);
            this.Save2Label.Name = "Save2Label";
            this.Save2Label.Size = new System.Drawing.Size(44, 13);
            this.Save2Label.TabIndex = 4;
            this.Save2Label.Text = "Save 3:";
            // 
            // MoveSave1Button
            // 
            this.MoveSave1Button.Location = new System.Drawing.Point(290, 13);
            this.MoveSave1Button.Name = "MoveSave1Button";
            this.MoveSave1Button.Size = new System.Drawing.Size(23, 20);
            this.MoveSave1Button.TabIndex = 5;
            this.MoveSave1Button.Text = ">";
            this.MoveSave1Button.UseVisualStyleBackColor = true;
            this.MoveSave1Button.Click += new System.EventHandler(this.MoveSave1Button_Click);
            // 
            // MoveSave2Button
            // 
            this.MoveSave2Button.Location = new System.Drawing.Point(290, 39);
            this.MoveSave2Button.Name = "MoveSave2Button";
            this.MoveSave2Button.Size = new System.Drawing.Size(23, 20);
            this.MoveSave2Button.TabIndex = 6;
            this.MoveSave2Button.Text = ">";
            this.MoveSave2Button.UseVisualStyleBackColor = true;
            this.MoveSave2Button.Click += new System.EventHandler(this.MoveSave2Button_Click);
            // 
            // MoveSave3Button
            // 
            this.MoveSave3Button.Location = new System.Drawing.Point(290, 65);
            this.MoveSave3Button.Name = "MoveSave3Button";
            this.MoveSave3Button.Size = new System.Drawing.Size(23, 20);
            this.MoveSave3Button.TabIndex = 7;
            this.MoveSave3Button.Text = ">";
            this.MoveSave3Button.UseVisualStyleBackColor = true;
            this.MoveSave3Button.Click += new System.EventHandler(this.MoveSave3Button_Click);
            // 
            // MainGameSaveGroupBox
            // 
            this.MainGameSaveGroupBox.Controls.Add(this.Save0Label);
            this.MainGameSaveGroupBox.Controls.Add(this.Save2Label);
            this.MainGameSaveGroupBox.Controls.Add(this.ClearSave2Button);
            this.MainGameSaveGroupBox.Controls.Add(this.MoveSave3Button);
            this.MainGameSaveGroupBox.Controls.Add(this.GameSave0TextBox);
            this.MainGameSaveGroupBox.Controls.Add(this.ClearSave1Button);
            this.MainGameSaveGroupBox.Controls.Add(this.MoveSave2Button);
            this.MainGameSaveGroupBox.Controls.Add(this.GameSave2TextBox);
            this.MainGameSaveGroupBox.Controls.Add(this.ClearSave0Button);
            this.MainGameSaveGroupBox.Controls.Add(this.MoveSave1Button);
            this.MainGameSaveGroupBox.Controls.Add(this.Save1Label);
            this.MainGameSaveGroupBox.Controls.Add(this.GameSave1TextBox);
            this.MainGameSaveGroupBox.Location = new System.Drawing.Point(12, 12);
            this.MainGameSaveGroupBox.Name = "MainGameSaveGroupBox";
            this.MainGameSaveGroupBox.Size = new System.Drawing.Size(319, 93);
            this.MainGameSaveGroupBox.TabIndex = 8;
            this.MainGameSaveGroupBox.TabStop = false;
            this.MainGameSaveGroupBox.Text = "Game Saves";
            // 
            // ClearSave2Button
            // 
            this.ClearSave2Button.Location = new System.Drawing.Point(238, 65);
            this.ClearSave2Button.Name = "ClearSave2Button";
            this.ClearSave2Button.Size = new System.Drawing.Size(46, 20);
            this.ClearSave2Button.TabIndex = 7;
            this.ClearSave2Button.Text = "Clear";
            this.ClearSave2Button.UseVisualStyleBackColor = true;
            this.ClearSave2Button.Click += new System.EventHandler(this.ClearSave2Button_Click);
            // 
            // ClearSave1Button
            // 
            this.ClearSave1Button.Location = new System.Drawing.Point(238, 39);
            this.ClearSave1Button.Name = "ClearSave1Button";
            this.ClearSave1Button.Size = new System.Drawing.Size(46, 20);
            this.ClearSave1Button.TabIndex = 6;
            this.ClearSave1Button.Text = "Clear";
            this.ClearSave1Button.UseVisualStyleBackColor = true;
            this.ClearSave1Button.Click += new System.EventHandler(this.ClearSave1Button_Click);
            // 
            // ClearSave0Button
            // 
            this.ClearSave0Button.Location = new System.Drawing.Point(238, 13);
            this.ClearSave0Button.Name = "ClearSave0Button";
            this.ClearSave0Button.Size = new System.Drawing.Size(46, 20);
            this.ClearSave0Button.TabIndex = 5;
            this.ClearSave0Button.Text = "Clear";
            this.ClearSave0Button.UseVisualStyleBackColor = true;
            this.ClearSave0Button.Click += new System.EventHandler(this.ClearSave0Button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RenameSaveButton);
            this.groupBox1.Controls.Add(this.ClearBackupLocationButton);
            this.groupBox1.Controls.Add(this.DeleteSaveButton);
            this.groupBox1.Controls.Add(this.RefreshListBoxButton);
            this.groupBox1.Controls.Add(this.BackupSavesListBox);
            this.groupBox1.Controls.Add(this.SetSave1Button);
            this.groupBox1.Controls.Add(this.SetSave2Button);
            this.groupBox1.Controls.Add(this.SetSave0Button);
            this.groupBox1.Controls.Add(this.BackupSaveLocationTextBox);
            this.groupBox1.Controls.Add(this.BackupSaveLocationLabel);
            this.groupBox1.Controls.Add(this.BackupSaveLocationButton);
            this.groupBox1.Location = new System.Drawing.Point(338, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 147);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Backup Saves";
            // 
            // RenameSaveButton
            // 
            this.RenameSaveButton.Location = new System.Drawing.Point(280, 91);
            this.RenameSaveButton.Name = "RenameSaveButton";
            this.RenameSaveButton.Size = new System.Drawing.Size(88, 23);
            this.RenameSaveButton.TabIndex = 16;
            this.RenameSaveButton.Text = "Rename Save";
            this.RenameSaveButton.UseVisualStyleBackColor = true;
            this.RenameSaveButton.Click += new System.EventHandler(this.RenameSaveButton_Click);
            // 
            // ClearBackupLocationButton
            // 
            this.ClearBackupLocationButton.Location = new System.Drawing.Point(279, 121);
            this.ClearBackupLocationButton.Name = "ClearBackupLocationButton";
            this.ClearBackupLocationButton.Size = new System.Drawing.Size(89, 20);
            this.ClearBackupLocationButton.TabIndex = 15;
            this.ClearBackupLocationButton.Text = "Clear";
            this.ClearBackupLocationButton.UseVisualStyleBackColor = true;
            this.ClearBackupLocationButton.Click += new System.EventHandler(this.ClearBackupLocationButton_Click);
            // 
            // DeleteSaveButton
            // 
            this.DeleteSaveButton.Location = new System.Drawing.Point(279, 51);
            this.DeleteSaveButton.Name = "DeleteSaveButton";
            this.DeleteSaveButton.Size = new System.Drawing.Size(89, 31);
            this.DeleteSaveButton.TabIndex = 14;
            this.DeleteSaveButton.Text = "Delete Save";
            this.DeleteSaveButton.UseVisualStyleBackColor = true;
            this.DeleteSaveButton.Click += new System.EventHandler(this.DeleteSaveButton_Click);
            // 
            // RefreshListBoxButton
            // 
            this.RefreshListBoxButton.Location = new System.Drawing.Point(279, 13);
            this.RefreshListBoxButton.Name = "RefreshListBoxButton";
            this.RefreshListBoxButton.Size = new System.Drawing.Size(89, 31);
            this.RefreshListBoxButton.TabIndex = 13;
            this.RefreshListBoxButton.Text = "Refresh";
            this.RefreshListBoxButton.UseVisualStyleBackColor = true;
            this.RefreshListBoxButton.Click += new System.EventHandler(this.RefreshListBoxButton_Click);
            // 
            // BackupSavesListBox
            // 
            this.BackupSavesListBox.FormattingEnabled = true;
            this.BackupSavesListBox.Location = new System.Drawing.Point(6, 13);
            this.BackupSavesListBox.Name = "BackupSavesListBox";
            this.BackupSavesListBox.Size = new System.Drawing.Size(267, 69);
            this.BackupSavesListBox.TabIndex = 12;
            // 
            // SetSave1Button
            // 
            this.SetSave1Button.Location = new System.Drawing.Point(105, 91);
            this.SetSave1Button.Name = "SetSave1Button";
            this.SetSave1Button.Size = new System.Drawing.Size(75, 23);
            this.SetSave1Button.TabIndex = 6;
            this.SetSave1Button.Text = "Set Save 2";
            this.SetSave1Button.UseVisualStyleBackColor = true;
            this.SetSave1Button.Click += new System.EventHandler(this.SetSave1Button_Click);
            // 
            // SetSave2Button
            // 
            this.SetSave2Button.Location = new System.Drawing.Point(198, 91);
            this.SetSave2Button.Name = "SetSave2Button";
            this.SetSave2Button.Size = new System.Drawing.Size(75, 23);
            this.SetSave2Button.TabIndex = 5;
            this.SetSave2Button.Text = "Set Save 3";
            this.SetSave2Button.UseVisualStyleBackColor = true;
            this.SetSave2Button.Click += new System.EventHandler(this.SetSave2Button_Click);
            // 
            // SetSave0Button
            // 
            this.SetSave0Button.Location = new System.Drawing.Point(6, 91);
            this.SetSave0Button.Name = "SetSave0Button";
            this.SetSave0Button.Size = new System.Drawing.Size(75, 23);
            this.SetSave0Button.TabIndex = 4;
            this.SetSave0Button.Text = "Set Save 1";
            this.SetSave0Button.UseVisualStyleBackColor = true;
            this.SetSave0Button.Click += new System.EventHandler(this.SetSave0Button_Click);
            // 
            // BackupSaveLocationTextBox
            // 
            this.BackupSaveLocationTextBox.Enabled = false;
            this.BackupSaveLocationTextBox.Location = new System.Drawing.Point(132, 121);
            this.BackupSaveLocationTextBox.Name = "BackupSaveLocationTextBox";
            this.BackupSaveLocationTextBox.Size = new System.Drawing.Size(111, 20);
            this.BackupSaveLocationTextBox.TabIndex = 3;
            // 
            // BackupSaveLocationLabel
            // 
            this.BackupSaveLocationLabel.AutoSize = true;
            this.BackupSaveLocationLabel.Location = new System.Drawing.Point(7, 124);
            this.BackupSaveLocationLabel.Name = "BackupSaveLocationLabel";
            this.BackupSaveLocationLabel.Size = new System.Drawing.Size(119, 13);
            this.BackupSaveLocationLabel.TabIndex = 2;
            this.BackupSaveLocationLabel.Text = "Backup Save Location:";
            // 
            // BackupSaveLocationButton
            // 
            this.BackupSaveLocationButton.Location = new System.Drawing.Point(249, 121);
            this.BackupSaveLocationButton.Name = "BackupSaveLocationButton";
            this.BackupSaveLocationButton.Size = new System.Drawing.Size(24, 20);
            this.BackupSaveLocationButton.TabIndex = 1;
            this.BackupSaveLocationButton.Text = "...";
            this.BackupSaveLocationButton.UseVisualStyleBackColor = true;
            this.BackupSaveLocationButton.Click += new System.EventHandler(this.BackupSaveLocationButton_Click);
            // 
            // ReplaceGameSavesButton
            // 
            this.ReplaceGameSavesButton.Location = new System.Drawing.Point(12, 111);
            this.ReplaceGameSavesButton.Name = "ReplaceGameSavesButton";
            this.ReplaceGameSavesButton.Size = new System.Drawing.Size(157, 23);
            this.ReplaceGameSavesButton.TabIndex = 10;
            this.ReplaceGameSavesButton.Text = "Replace Game Saves";
            this.ReplaceGameSavesButton.UseVisualStyleBackColor = true;
            this.ReplaceGameSavesButton.Click += new System.EventHandler(this.ReplaceGameSavesButton_Click);
            // 
            // GameSaveLocationButton
            // 
            this.GameSaveLocationButton.Location = new System.Drawing.Point(12, 136);
            this.GameSaveLocationButton.Name = "GameSaveLocationButton";
            this.GameSaveLocationButton.Size = new System.Drawing.Size(157, 23);
            this.GameSaveLocationButton.TabIndex = 11;
            this.GameSaveLocationButton.Text = "Open Game Save Location";
            this.GameSaveLocationButton.UseVisualStyleBackColor = true;
            this.GameSaveLocationButton.Click += new System.EventHandler(this.GameSaveLocationButton_Click);
            // 
            // BackupGameSavesButton
            // 
            this.BackupGameSavesButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BackupGameSavesButton.Location = new System.Drawing.Point(176, 112);
            this.BackupGameSavesButton.Name = "BackupGameSavesButton";
            this.BackupGameSavesButton.Size = new System.Drawing.Size(155, 47);
            this.BackupGameSavesButton.TabIndex = 12;
            this.BackupGameSavesButton.Text = "BACK UP GAME SAVES";
            this.BackupGameSavesButton.UseVisualStyleBackColor = true;
            this.BackupGameSavesButton.Click += new System.EventHandler(this.BackupGameSavesButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 169);
            this.Controls.Add(this.BackupGameSavesButton);
            this.Controls.Add(this.GameSaveLocationButton);
            this.Controls.Add(this.ReplaceGameSavesButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MainGameSaveGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Poi Save Manager (BETA)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainGameSaveGroupBox.ResumeLayout(false);
            this.MainGameSaveGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox GameSave0TextBox;
        private System.Windows.Forms.TextBox GameSave1TextBox;
        private System.Windows.Forms.TextBox GameSave2TextBox;
        private System.Windows.Forms.Label Save0Label;
        private System.Windows.Forms.Label Save1Label;
        private System.Windows.Forms.Label Save2Label;
        private System.Windows.Forms.Button MoveSave1Button;
        private System.Windows.Forms.Button MoveSave2Button;
        private System.Windows.Forms.Button MoveSave3Button;
        private System.Windows.Forms.GroupBox MainGameSaveGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox BackupSaveLocationTextBox;
        private System.Windows.Forms.Label BackupSaveLocationLabel;
        private System.Windows.Forms.Button BackupSaveLocationButton;
        private System.Windows.Forms.Button ReplaceGameSavesButton;
        private System.Windows.Forms.Button SetSave1Button;
        private System.Windows.Forms.Button SetSave2Button;
        private System.Windows.Forms.Button SetSave0Button;
        private System.Windows.Forms.Button GameSaveLocationButton;
        private System.Windows.Forms.ListBox BackupSavesListBox;
        private System.Windows.Forms.Button BackupGameSavesButton;
        private System.Windows.Forms.Button RefreshListBoxButton;
        private System.Windows.Forms.Button DeleteSaveButton;
        private Button ClearBackupLocationButton;
        private Button ClearSave2Button;
        private Button ClearSave1Button;
        private Button ClearSave0Button;
        private Button RenameSaveButton;
    }
}

