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
            textBox1 = new TextBox();
            statusStrip1 = new StatusStrip();
            exitButton = new ToolStripStatusLabel();
            resetButton = new ToolStripStatusLabel();
            textBox2 = new TextBox();
            label1 = new Label();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13F);
            textBox1.Location = new Point(12, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(477, 31);
            textBox1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { exitButton, resetButton });
            statusStrip1.Location = new Point(0, 121);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(501, 25);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Segoe UI", 11F);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(33, 20);
            exitButton.Text = "Exit";
            // 
            // resetButton
            // 
            resetButton.Font = new Font("Segoe UI", 10F);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(42, 20);
            resetButton.Text = "Reset";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Font = new Font("Segoe UI", 14F);
            textBox2.Location = new Point(12, 12);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(477, 32);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Red;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(12, 54);
            label1.Name = "label1";
            label1.Size = new Size(96, 19);
            label1.TabIndex = 3;
            label1.Text = "Status: ERROR";
            // 
            // RaceWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 146);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(statusStrip1);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RaceWindow";
            Text = "Race";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel exitButton;
        private ToolStripStatusLabel resetButton;
        private TextBox textBox2;
        private Label label1;
    }
}