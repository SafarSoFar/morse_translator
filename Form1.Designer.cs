﻿namespace morse__GUI
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
            inputTextBox = new TextBox();
            outputTextBox = new TextBox();
            symbolsComboBox = new ComboBox();
            appLabel = new Label();
            inputLabel = new Label();
            outputLabel = new Label();
            comboBoxLabel = new Label();
            translateButton = new Button();
            freqComboBox = new ComboBox();
            freqLabel = new Label();
            lenComboBox = new ComboBox();
            label1 = new Label();
            memeButton = new Label();
            SuspendLayout();
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(60, 168);
            inputTextBox.Multiline = true;
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(389, 98);
            inputTextBox.TabIndex = 0;
            // 
            // outputTextBox
            // 
            outputTextBox.Location = new Point(60, 314);
            outputTextBox.Multiline = true;
            outputTextBox.Name = "outputTextBox";
            outputTextBox.Size = new Size(389, 98);
            outputTextBox.TabIndex = 1;
            // 
            // symbolsComboBox
            // 
            symbolsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            symbolsComboBox.FormattingEnabled = true;
            symbolsComboBox.Items.AddRange(new object[] { "Cyrillic", "Latin" });
            symbolsComboBox.Location = new Point(60, 106);
            symbolsComboBox.Name = "symbolsComboBox";
            symbolsComboBox.Size = new Size(176, 28);
            symbolsComboBox.TabIndex = 2;
            // 
            // appLabel
            // 
            appLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            appLabel.Location = new Point(119, -4);
            appLabel.Name = "appLabel";
            appLabel.Size = new Size(289, 90);
            appLabel.TabIndex = 3;
            appLabel.Text = "Morse Translator";
            appLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // inputLabel
            // 
            inputLabel.AutoSize = true;
            inputLabel.Location = new Point(374, 145);
            inputLabel.Name = "inputLabel";
            inputLabel.Size = new Size(75, 20);
            inputLabel.TabIndex = 4;
            inputLabel.Text = "Input text:";
            // 
            // outputLabel
            // 
            outputLabel.AutoSize = true;
            outputLabel.Location = new Point(391, 291);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(58, 20);
            outputLabel.TabIndex = 5;
            outputLabel.Text = "Output:";
            // 
            // comboBoxLabel
            // 
            comboBoxLabel.AutoSize = true;
            comboBoxLabel.Location = new Point(60, 83);
            comboBoxLabel.Name = "comboBoxLabel";
            comboBoxLabel.Size = new Size(144, 20);
            comboBoxLabel.TabIndex = 6;
            comboBoxLabel.Text = "Choose the symbols:";
            // 
            // translateButton
            // 
            translateButton.Location = new Point(119, 429);
            translateButton.Name = "translateButton";
            translateButton.Size = new Size(278, 38);
            translateButton.TabIndex = 7;
            translateButton.Text = "Translate";
            translateButton.UseVisualStyleBackColor = true;
            translateButton.Click += translateButton_Click;
            // 
            // freqComboBox
            // 
            freqComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            freqComboBox.FormattingEnabled = true;
            freqComboBox.Items.AddRange(new object[] { "500", "600", "700", "800", "900", "1000" });
            freqComboBox.Location = new Point(252, 106);
            freqComboBox.Name = "freqComboBox";
            freqComboBox.Size = new Size(81, 28);
            freqComboBox.TabIndex = 8;
            // 
            // freqLabel
            // 
            freqLabel.AutoSize = true;
            freqLabel.Location = new Point(252, 83);
            freqLabel.Name = "freqLabel";
            freqLabel.Size = new Size(30, 20);
            freqLabel.TabIndex = 9;
            freqLabel.Text = "Hz:";
            // 
            // lenComboBox
            // 
            lenComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            lenComboBox.FormattingEnabled = true;
            lenComboBox.Items.AddRange(new object[] { "80", "90", "100" });
            lenComboBox.Location = new Point(391, 106);
            lenComboBox.Name = "lenComboBox";
            lenComboBox.Size = new Size(81, 28);
            lenComboBox.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(391, 83);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 11;
            label1.Text = "Millisec:";
            // 
            // memeButton
            // 
            memeButton.AutoSize = true;
            memeButton.ForeColor = SystemColors.Control;
            memeButton.Location = new Point(12, 476);
            memeButton.Name = "memeButton";
            memeButton.Size = new Size(79, 20);
            memeButton.TabIndex = 12;
            memeButton.Text = "Easter egg";
            memeButton.Click += memeButton_Click;
            memeButton.MouseEnter += memeButton_MouseEnter;
            memeButton.MouseLeave += memeButton_MouseLeave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 505);
            Controls.Add(memeButton);
            Controls.Add(label1);
            Controls.Add(lenComboBox);
            Controls.Add(freqLabel);
            Controls.Add(freqComboBox);
            Controls.Add(translateButton);
            Controls.Add(comboBoxLabel);
            Controls.Add(outputLabel);
            Controls.Add(inputLabel);
            Controls.Add(appLabel);
            Controls.Add(symbolsComboBox);
            Controls.Add(outputTextBox);
            Controls.Add(inputTextBox);
            Name = "Form1";
            Text = "Morse Translator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputTextBox;
        private TextBox outputTextBox;
        private ComboBox symbolsComboBox;
        private Label appLabel;
        private Label inputLabel;
        private Label outputLabel;
        private Label comboBoxLabel;
        private Button translateButton;
        private ComboBox freqComboBox;
        private Label freqLabel;
        private ComboBox lenComboBox;
        private Label label1;
        private Label memeButton;
    }
}
