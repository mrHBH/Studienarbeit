namespace ZungenmousePOC
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
            this.Frame = new System.Windows.Forms.PictureBox();
            this.Pointer = new System.Windows.Forms.PictureBox();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.ConnectSerial = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ComPortCombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Frame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pointer)).BeginInit();
            this.SuspendLayout();
            // 
            // Frame
            // 
            this.Frame.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Frame.Location = new System.Drawing.Point(0, 0);
            this.Frame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Frame.Name = "Frame";
            this.Frame.Size = new System.Drawing.Size(640, 480);
            this.Frame.TabIndex = 0;
            this.Frame.TabStop = false;
            // 
            // Pointer
            // 
            this.Pointer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Pointer.Location = new System.Drawing.Point(0, 0);
            this.Pointer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Pointer.Name = "Pointer";
            this.Pointer.Size = new System.Drawing.Size(21, 22);
            this.Pointer.TabIndex = 1;
            this.Pointer.TabStop = false;
            // 
            // LogTextBox
            // 
            this.LogTextBox.Location = new System.Drawing.Point(0, 488);
            this.LogTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.Size = new System.Drawing.Size(644, 88);
            this.LogTextBox.TabIndex = 3;
            // 
            // ConnectSerial
            // 
            this.ConnectSerial.Location = new System.Drawing.Point(770, 488);
            this.ConnectSerial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConnectSerial.Name = "ConnectSerial";
            this.ConnectSerial.Size = new System.Drawing.Size(83, 28);
            this.ConnectSerial.TabIndex = 4;
            this.ConnectSerial.Text = "Connect";
            this.ConnectSerial.UseVisualStyleBackColor = true;
            this.ConnectSerial.Click += new System.EventHandler(this.ConnectSerial_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(647, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gesture: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(723, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Idle";
            // 
            // ComPortCombo
            // 
            this.ComPortCombo.FormattingEnabled = true;
            this.ComPortCombo.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9"});
            this.ComPortCombo.Location = new System.Drawing.Point(650, 488);
            this.ComPortCombo.Name = "ComPortCombo";
            this.ComPortCombo.Size = new System.Drawing.Size(114, 24);
            this.ComPortCombo.TabIndex = 7;
            this.ComPortCombo.Text = "COM3";
            this.ComPortCombo.SelectedIndexChanged += new System.EventHandler(this.ComPortCombo_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 578);
            this.Controls.Add(this.ComPortCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConnectSerial);
            this.Controls.Add(this.LogTextBox);
            this.Controls.Add(this.Pointer);
            this.Controls.Add(this.Frame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI proof of Concept";
            ((System.ComponentModel.ISupportInitialize)(this.Frame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pointer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Frame;
        private System.Windows.Forms.PictureBox Pointer;
        private System.Windows.Forms.TextBox LogTextBox;
        private System.Windows.Forms.Button ConnectSerial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComPortCombo;
    }
}

