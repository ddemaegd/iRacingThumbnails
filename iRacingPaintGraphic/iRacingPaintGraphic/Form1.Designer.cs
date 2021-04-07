
namespace iRacingPaintGraphic
{
    partial class Form1
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
            this.RunButton = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.PaintFileTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveFileTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CarDropDown = new System.Windows.Forms.ComboBox();
            this.PaintFileButton = new System.Windows.Forms.Button();
            this.SaveFileButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(624, 98);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(101, 40);
            this.RunButton.TabIndex = 0;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMessage.Location = new System.Drawing.Point(624, 169);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 30);
            this.lblMessage.TabIndex = 1;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // PaintFileTextBox
            // 
            this.PaintFileTextBox.Location = new System.Drawing.Point(502, 11);
            this.PaintFileTextBox.Name = "PaintFileTextBox";
            this.PaintFileTextBox.Size = new System.Drawing.Size(181, 23);
            this.PaintFileTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(322, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Paint File Directory:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(322, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Save File Directory:";
            // 
            // SaveFileTextBox
            // 
            this.SaveFileTextBox.Location = new System.Drawing.Point(502, 49);
            this.SaveFileTextBox.Name = "SaveFileTextBox";
            this.SaveFileTextBox.Size = new System.Drawing.Size(181, 23);
            this.SaveFileTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(19, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Car:";
            // 
            // CarDropDown
            // 
            this.CarDropDown.FormattingEnabled = true;
            this.CarDropDown.Location = new System.Drawing.Point(73, 13);
            this.CarDropDown.Name = "CarDropDown";
            this.CarDropDown.Size = new System.Drawing.Size(240, 23);
            this.CarDropDown.TabIndex = 7;
            // 
            // PaintFileButton
            // 
            this.PaintFileButton.Location = new System.Drawing.Point(689, 11);
            this.PaintFileButton.Name = "PaintFileButton";
            this.PaintFileButton.Size = new System.Drawing.Size(36, 23);
            this.PaintFileButton.TabIndex = 8;
            this.PaintFileButton.Text = "...";
            this.PaintFileButton.UseVisualStyleBackColor = true;
            this.PaintFileButton.Click += new System.EventHandler(this.PaintFileButton_Click);
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.Location = new System.Drawing.Point(689, 49);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(36, 23);
            this.SaveFileButton.TabIndex = 9;
            this.SaveFileButton.Text = "...";
            this.SaveFileButton.UseVisualStyleBackColor = true;
            this.SaveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // folderBrowserDialog2
            // 
            this.folderBrowserDialog2.HelpRequest += new System.EventHandler(this.folderBrowserDialog2_HelpRequest);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 217);
            this.Controls.Add(this.SaveFileButton);
            this.Controls.Add(this.PaintFileButton);
            this.Controls.Add(this.CarDropDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SaveFileTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PaintFileTextBox);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.RunButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    #endregion

    private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox PaintFileTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SaveFileTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CarDropDown;
        private System.Windows.Forms.Button PaintFileButton;
        private System.Windows.Forms.Button SaveFileButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
    }
}

