﻿namespace Type_Racer
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            startButton = new Button();
            label1 = new Label();
            wordsNumber = new NumericUpDown();
            languageSetting = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            WordsSpeedOptions = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)wordsNumber).BeginInit();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.Font = new Font("Segoe UI", 14F);
            startButton.Location = new Point(158, 28);
            startButton.Name = "startButton";
            startButton.Size = new Size(109, 48);
            startButton.TabIndex = 0;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += StartButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 9);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 1;
            label1.Text = "Avaiable Languages";
            // 
            // wordsNumber
            // 
            wordsNumber.Location = new Point(12, 79);
            wordsNumber.Name = "wordsNumber";
            wordsNumber.Size = new Size(120, 23);
            wordsNumber.TabIndex = 2;
            // 
            // languageSetting
            // 
            languageSetting.FormattingEnabled = true;
            languageSetting.Location = new Point(12, 27);
            languageSetting.Name = "languageSetting";
            languageSetting.Size = new Size(121, 23);
            languageSetting.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 61);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 4;
            label2.Text = "Number of words";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(344, 9);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 5;
            label3.Text = "Statistics";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(300, 27);
            label4.Name = "label4";
            label4.Size = new Size(70, 19);
            label4.TabIndex = 6;
            label4.Text = "Error rate:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(376, 28);
            label5.Name = "label5";
            label5.Size = new Size(28, 19);
            label5.TabIndex = 7;
            label5.Text = "0%";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(376, 59);
            label6.Name = "label6";
            label6.Size = new Size(17, 19);
            label6.TabIndex = 9;
            label6.Text = "0";
            // 
            // WordsSpeedOptions
            // 
            WordsSpeedOptions.AutoCompleteCustomSource.AddRange(new string[] { "CMP", "CPS" });
            WordsSpeedOptions.FormattingEnabled = true;
            WordsSpeedOptions.Location = new Point(300, 55);
            WordsSpeedOptions.Name = "WordsSpeedOptions";
            WordsSpeedOptions.Size = new Size(70, 23);
            WordsSpeedOptions.TabIndex = 10;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 113);
            Controls.Add(WordsSpeedOptions);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(languageSetting);
            Controls.Add(wordsNumber);
            Controls.Add(label1);
            Controls.Add(startButton);
            MaximizeBox = false;
            Name = "MainWindow";
            ShowIcon = false;
            Text = "Type Racer";
            ((System.ComponentModel.ISupportInitialize)wordsNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startButton;
        private Label label1;
        private NumericUpDown wordsNumber;
        private ComboBox languageSetting;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox WordsSpeedOptions;
    }
}