namespace SimpleThreading
{
    partial class MainForm
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
            btnThreading = new Button();
            btnFileTransfer = new Button();
            SuspendLayout();
            // 
            // btnThreading
            // 
            btnThreading.Location = new Point(217, 110);
            btnThreading.Margin = new Padding(4, 5, 4, 5);
            btnThreading.Name = "btnThreading";
            btnThreading.Size = new Size(131, 80);
            btnThreading.TabIndex = 0;
            btnThreading.Text = "Threading";
            btnThreading.UseVisualStyleBackColor = true;
            btnThreading.Click += btnThreading_Click;
            // 
            // btnFileTransfer
            // 
            btnFileTransfer.Location = new Point(217, 231);
            btnFileTransfer.Margin = new Padding(4, 5, 4, 5);
            btnFileTransfer.Name = "btnFileTransfer";
            btnFileTransfer.Size = new Size(131, 80);
            btnFileTransfer.TabIndex = 1;
            btnFileTransfer.Text = "File Tranfer Using Thread";
            btnFileTransfer.UseVisualStyleBackColor = true;
            btnFileTransfer.Click += btnFileTransfer_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 451);
            Controls.Add(btnFileTransfer);
            Controls.Add(btnThreading);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainForm";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnThreading;
        private Button btnFileTransfer;
    }
}