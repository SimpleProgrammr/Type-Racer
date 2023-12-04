namespace Type_Racer
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
            CompletedWordsLabel = new Label();
            errorsLabel = new Label();
            timeLabel = new Label();
            statsCouter = new System.ComponentModel.BackgroundWorker();
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
            userInputTextBox.KeyDown += userInputTextBox_KeyDown;
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
            statusLabel.Size = new Size(126, 19);
            statusLabel.TabIndex = 3;
            statusLabel.Text = "Status: Start typing";
            // 
            // CompletedWordsLabel
            // 
            CompletedWordsLabel.AutoSize = true;
            CompletedWordsLabel.Font = new Font("Segoe UI", 10F);
            CompletedWordsLabel.Location = new Point(166, 54);
            CompletedWordsLabel.Name = "CompletedWordsLabel";
            CompletedWordsLabel.Size = new Size(132, 19);
            CompletedWordsLabel.TabIndex = 4;
            CompletedWordsLabel.Text = "Completed words: 0";
            // 
            // errorsLabel
            // 
            errorsLabel.AutoSize = true;
            errorsLabel.Font = new Font("Segoe UI", 10F);
            errorsLabel.Location = new Point(360, 54);
            errorsLabel.Name = "errorsLabel";
            errorsLabel.Size = new Size(82, 19);
            errorsLabel.TabIndex = 5;
            errorsLabel.Text = "Mistakes:  0";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Segoe UI", 10F);
            timeLabel.Location = new Point(500, 54);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(63, 19);
            timeLabel.TabIndex = 6;
            timeLabel.Text = "Time: 0 s";
            // 
            // statsCouter
            // 
            statsCouter.WorkerReportsProgress = true;
            statsCouter.WorkerSupportsCancellation = true;
            statsCouter.DoWork += statsCouter_DoWork;
            statsCouter.ProgressChanged += statsCouter_ProgressChanged;
            // 
            // RaceWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 146);
            Controls.Add(timeLabel);
            Controls.Add(errorsLabel);
            Controls.Add(CompletedWordsLabel);
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
        private Label CompletedWordsLabel;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label errorsLabel;
        private Label timeLabel;
        private System.ComponentModel.BackgroundWorker statsCouter;
    }
}