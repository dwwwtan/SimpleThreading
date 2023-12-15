namespace SimpleThreading
{
    partial class Threading
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
            btnGoMultiThread = new Button();
            textBox1 = new TextBox();
            panel1 = new Panel();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnGoSingleThread = new Button();
            lblCounter = new Label();
            btnReset = new Button();
            lblMultiThreadCount = new Label();
            lblSingleThreadCount = new Label();
            SuspendLayout();
            // 
            // btnGoMultiThread
            // 
            btnGoMultiThread.Location = new Point(20, 255);
            btnGoMultiThread.Margin = new Padding(4, 5, 4, 5);
            btnGoMultiThread.Name = "btnGoMultiThread";
            btnGoMultiThread.Size = new Size(416, 35);
            btnGoMultiThread.TabIndex = 0;
            btnGoMultiThread.Text = "Multi-Threading";
            btnGoMultiThread.UseVisualStyleBackColor = true;
            btnGoMultiThread.Click += btnGoMultiThread_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(154, 18);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 27);
            textBox1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Location = new Point(20, 300);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(416, 598);
            panel1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(154, 58);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(165, 27);
            textBox2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 21);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 5;
            label1.Text = "Count to:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 61);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 6;
            label2.Text = "Delay time:";
            // 
            // btnGoSingleThread
            // 
            btnGoSingleThread.Location = new Point(20, 107);
            btnGoSingleThread.Margin = new Padding(4, 5, 4, 5);
            btnGoSingleThread.Name = "btnGoSingleThread";
            btnGoSingleThread.Size = new Size(416, 35);
            btnGoSingleThread.TabIndex = 7;
            btnGoSingleThread.Text = "Single-Threading";
            btnGoSingleThread.UseVisualStyleBackColor = true;
            btnGoSingleThread.Click += btnGoSingleThread_Click;
            // 
            // lblCounter
            // 
            lblCounter.AutoSize = true;
            lblCounter.Location = new Point(167, 147);
            lblCounter.Margin = new Padding(4, 0, 4, 0);
            lblCounter.Name = "lblCounter";
            lblCounter.Size = new Size(110, 20);
            lblCounter.TabIndex = 8;
            lblCounter.Text = "[MY COUNTER]";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(351, 32);
            btnReset.Margin = new Padding(4, 5, 4, 5);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(67, 35);
            btnReset.TabIndex = 9;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // lblMultiThreadCount
            // 
            lblMultiThreadCount.AutoSize = true;
            lblMultiThreadCount.Location = new Point(20, 212);
            lblMultiThreadCount.Margin = new Padding(4, 0, 4, 0);
            lblMultiThreadCount.Name = "lblMultiThreadCount";
            lblMultiThreadCount.Size = new Size(129, 20);
            lblMultiThreadCount.TabIndex = 11;
            lblMultiThreadCount.Text = "Task done (Multi): ";
            // 
            // lblSingleThreadCount
            // 
            lblSingleThreadCount.AutoSize = true;
            lblSingleThreadCount.Location = new Point(20, 180);
            lblSingleThreadCount.Margin = new Padding(4, 0, 4, 0);
            lblSingleThreadCount.Name = "lblSingleThreadCount";
            lblSingleThreadCount.Size = new Size(136, 20);
            lblSingleThreadCount.TabIndex = 12;
            lblSingleThreadCount.Text = "Task done (Single): ";
            // 
            // Threading
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 917);
            Controls.Add(lblSingleThreadCount);
            Controls.Add(lblMultiThreadCount);
            Controls.Add(btnReset);
            Controls.Add(lblCounter);
            Controls.Add(btnGoSingleThread);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Controls.Add(btnGoMultiThread);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Threading";
            Text = "Threading";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        Button btnGoMultiThread;
        private TextBox textBox1;
        private Panel panel1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button btnGoSingleThread;
        private Label lblCounter;
        private Button btnReset;
        private Label lblMultiThreadCount;
        private Label lblSingleThreadCount;
    }
}