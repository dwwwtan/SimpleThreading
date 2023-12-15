namespace SimpleThreading
{
    partial class FileTransfer
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
            btnOK = new Button();
            btnCancel = new Button();
            txtDestination = new TextBox();
            txtSource = new TextBox();
            lblSourceFile = new Label();
            lblDestinationFile = new Label();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.Location = new Point(230, 227);
            btnOK.Margin = new Padding(4, 5, 4, 5);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(67, 35);
            btnOK.TabIndex = 10;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(305, 227);
            btnCancel.Margin = new Padding(4, 5, 4, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(67, 35);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtDestination
            // 
            txtDestination.Location = new Point(140, 190);
            txtDestination.Margin = new Padding(4, 5, 4, 5);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(232, 27);
            txtDestination.TabIndex = 12;
            // 
            // txtSource
            // 
            txtSource.Location = new Point(140, 124);
            txtSource.Margin = new Padding(4, 5, 4, 5);
            txtSource.Name = "txtSource";
            txtSource.Size = new Size(232, 27);
            txtSource.TabIndex = 13;
            // 
            // lblSourceFile
            // 
            lblSourceFile.AutoSize = true;
            lblSourceFile.Location = new Point(112, 99);
            lblSourceFile.Margin = new Padding(4, 0, 4, 0);
            lblSourceFile.Name = "lblSourceFile";
            lblSourceFile.Size = new Size(84, 20);
            lblSourceFile.TabIndex = 14;
            lblSourceFile.Text = "Source File:";
            // 
            // lblDestinationFile
            // 
            lblDestinationFile.AutoSize = true;
            lblDestinationFile.Location = new Point(112, 165);
            lblDestinationFile.Margin = new Padding(4, 0, 4, 0);
            lblDestinationFile.Name = "lblDestinationFile";
            lblDestinationFile.Size = new Size(115, 20);
            lblDestinationFile.TabIndex = 15;
            lblDestinationFile.Text = "Destination File:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Gill Sans Ultra Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(64, 36);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(408, 31);
            lblTitle.TabIndex = 16;
            lblTitle.Text = "File Transfer Using THREAD";
            // 
            // FileTransfer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 365);
            Controls.Add(lblTitle);
            Controls.Add(lblDestinationFile);
            Controls.Add(lblSourceFile);
            Controls.Add(txtSource);
            Controls.Add(txtDestination);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Name = "FileTransfer";
            Text = "FileTransfer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOK;
        private Button btnCancel;
        private TextBox txtDestination;
        private TextBox txtSource;
        private Label lblSourceFile;
        private Label lblDestinationFile;
        private Label lblTitle;
    }
}