﻿namespace Type_Racer
{
    partial class RaceWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaceWindow));
            userInputTextBox = new TextBox();
            statusStrip1 = new StatusStrip();
            exitButton = new ToolStripStatusLabel();
            resetButton = new ToolStripStatusLabel();
            trackTextBox = new TextBox();
            statusLabel = new Label();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // userInputTextBox
            // 
            userInputTextBox.Font = new Font("Segoe UI", 13F);
            userInputTextBox.Location = new Point(12, 76);
            userInputTextBox.Name = "userInputTextBox";
            userInputTextBox.Size = new Size(595, 31);
            userInputTextBox.TabIndex = 0;
            userInputTextBox.TextChanged += UserInput_TextChanged;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { exitButton, resetButton });
            statusStrip1.Location = new Point(0, 121);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(619, 25);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Segoe UI", 11F);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(33, 20);
            exitButton.Text = "Exit";
            exitButton.Click += exitButton_Click;
            // 
            // resetButton
            // 
            resetButton.Font = new Font("Segoe UI", 10F);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(42, 20);
            resetButton.Text = "Reset";
            resetButton.Click += resetButton_Click;
            // 
            // trackTextBox
            // 
            trackTextBox.Enabled = false;
            trackTextBox.Font = new Font("Segoe UI", 14F);
            trackTextBox.Location = new Point(12, 12);
            trackTextBox.Name = "trackTextBox";
            trackTextBox.Size = new Size(595, 32);
            trackTextBox.TabIndex = 2;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.BackColor = Color.Lime;
            statusLabel.Font = new Font("Segoe UI", 10F);
            statusLabel.Location = new Point(12, 54);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(96, 19);
            statusLabel.TabIndex = 3;
            statusLabel.Text = "Status: ERROR";
            // 
            // RaceWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 146);
            Controls.Add(statusLabel);
            Controls.Add(trackTextBox);
            Controls.Add(statusStrip1);
            Controls.Add(userInputTextBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RaceWindow";
            Text = "Race";
            FormClosing += RaceWindow_FormClosing;
            Load += RaceWindow_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userInputTextBox;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel exitButton;
        private ToolStripStatusLabel resetButton;
        private TextBox trackTextBox;
        private Label statusLabel;
    }
}