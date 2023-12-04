namespace Type_Racer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            startButton = new Button();
            label1 = new Label();
            wordsNumber = new NumericUpDown();
            languageSetting = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            errorRateLabel = new Label();
            WordsSpeed = new Label();
            WordsSpeedOptions = new ComboBox();
            lastTimeLabel = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)wordsNumber).BeginInit();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.Font = new Font("Segoe UI", 14F);
            startButton.Location = new Point(159, 54);
            startButton.Name = "startButton";
            startButton.Size = new Size(129, 48);
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
            wordsNumber.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            wordsNumber.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            wordsNumber.Name = "wordsNumber";
            wordsNumber.Size = new Size(120, 23);
            wordsNumber.TabIndex = 2;
            wordsNumber.Value = new decimal(new int[] { 30, 0, 0, 0 });
            wordsNumber.KeyDown += wordsNumber_KeyDown;
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
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.Location = new Point(303, 4);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 5;
            label3.Text = "Statistics";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(300, 28);
            label4.Name = "label4";
            label4.Size = new Size(70, 19);
            label4.TabIndex = 6;
            label4.Text = "Error rate:";
            // 
            // errorRateLabel
            // 
            errorRateLabel.AutoSize = true;
            errorRateLabel.Font = new Font("Segoe UI", 10F);
            errorRateLabel.Location = new Point(369, 27);
            errorRateLabel.Name = "errorRateLabel";
            errorRateLabel.Size = new Size(28, 19);
            errorRateLabel.TabIndex = 7;
            errorRateLabel.Text = "0%";
            // 
            // WordsSpeed
            // 
            WordsSpeed.AutoSize = true;
            WordsSpeed.Font = new Font("Segoe UI", 10F);
            WordsSpeed.Location = new Point(376, 57);
            WordsSpeed.Name = "WordsSpeed";
            WordsSpeed.Size = new Size(17, 19);
            WordsSpeed.TabIndex = 9;
            WordsSpeed.Text = "0";
            // 
            // WordsSpeedOptions
            // 
            WordsSpeedOptions.AutoCompleteCustomSource.AddRange(new string[] { "WPM", "WPS" });
            WordsSpeedOptions.FormattingEnabled = true;
            WordsSpeedOptions.Items.AddRange(new object[] { "WPM", "WPS", "CPM", "CPS" });
            WordsSpeedOptions.Location = new Point(300, 55);
            WordsSpeedOptions.Name = "WordsSpeedOptions";
            WordsSpeedOptions.Size = new Size(70, 23);
            WordsSpeedOptions.TabIndex = 10;
            WordsSpeedOptions.SelectedIndexChanged += WordsSpeedOptions_SelectedIndexChanged;
            // 
            // lastTimeLabel
            // 
            lastTimeLabel.AutoSize = true;
            lastTimeLabel.Font = new Font("Segoe UI", 10F);
            lastTimeLabel.Location = new Point(201, 27);
            lastTimeLabel.Name = "lastTimeLabel";
            lastTimeLabel.Size = new Size(27, 19);
            lastTimeLabel.TabIndex = 11;
            lastTimeLabel.Text = "0 s";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.Location = new Point(159, 6);
            label5.Name = "label5";
            label5.Size = new Size(129, 21);
            label5.TabIndex = 12;
            label5.Text = "Last Game Time:";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 113);
            Controls.Add(label5);
            Controls.Add(lastTimeLabel);
            Controls.Add(WordsSpeedOptions);
            Controls.Add(WordsSpeed);
            Controls.Add(errorRateLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(languageSetting);
            Controls.Add(wordsNumber);
            Controls.Add(label1);
            Controls.Add(startButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainWindow";
            Text = "Type Racer";
            Load += MainWindow_Load;
            ((System.ComponentModel.ISupportInitialize)wordsNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startButton;
        private Label label1;
        private ComboBox languageSetting;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label errorRateLabel;
        private Label WordsSpeed;
        private ComboBox WordsSpeedOptions;
        public NumericUpDown wordsNumber;
        private Label lastTimeLabel;
        private Label label5;
    }
}
