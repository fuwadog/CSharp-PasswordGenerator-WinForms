namespace PasswordGenerator
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            generateBTN = new Button();
            label3 = new Label();
            lengthTXT = new TextBox();
            outputTXT = new TextBox();
            copyBTN = new Button();
            strengthBar = new ProgressBar();
            label4 = new Label();
            clearBTN = new Button();
            copyTMR = new System.Windows.Forms.Timer(components);
            strLBL = new Label();
            numberCHK = new CheckBox();
            lowerCHK = new CheckBox();
            upperCHK = new CheckBox();
            symbolCHK = new CheckBox();
            notifyLBL = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(280, 40);
            label1.TabIndex = 0;
            label1.Text = "Password Generator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(12, 88);
            label2.Name = "label2";
            label2.Size = new Size(142, 21);
            label2.TabIndex = 1;
            label2.Text = "Password Length :";
            // 
            // generateBTN
            // 
            generateBTN.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold);
            generateBTN.Location = new Point(53, 339);
            generateBTN.Name = "generateBTN";
            generateBTN.Size = new Size(101, 38);
            generateBTN.TabIndex = 6;
            generateBTN.Text = "Generate";
            generateBTN.UseVisualStyleBackColor = true;
            generateBTN.Click += generateBTN_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(12, 415);
            label3.Name = "label3";
            label3.Size = new Size(87, 21);
            label3.TabIndex = 7;
            label3.Text = "Password :";
            // 
            // lengthTXT
            // 
            lengthTXT.Location = new Point(151, 88);
            lengthTXT.Name = "lengthTXT";
            lengthTXT.Size = new Size(98, 27);
            lengthTXT.TabIndex = 8;
            // 
            // outputTXT
            // 
            outputTXT.Location = new Point(98, 415);
            outputTXT.Name = "outputTXT";
            outputTXT.Size = new Size(286, 27);
            outputTXT.TabIndex = 9;
            // 
            // copyBTN
            // 
            copyBTN.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold);
            copyBTN.Location = new Point(160, 339);
            copyBTN.Name = "copyBTN";
            copyBTN.Size = new Size(101, 38);
            copyBTN.TabIndex = 10;
            copyBTN.Text = "Copy";
            copyBTN.UseVisualStyleBackColor = true;
            copyBTN.Click += copyBTN_Click;
            // 
            // strengthBar
            // 
            strengthBar.Location = new Point(98, 483);
            strengthBar.Name = "strengthBar";
            strengthBar.Size = new Size(286, 23);
            strengthBar.TabIndex = 12;
            strengthBar.Click += strengthBar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(12, 483);
            label4.Name = "label4";
            label4.Size = new Size(82, 21);
            label4.TabIndex = 13;
            label4.Text = "Strength :";
            // 
            // clearBTN
            // 
            clearBTN.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold);
            clearBTN.Location = new Point(267, 339);
            clearBTN.Name = "clearBTN";
            clearBTN.Size = new Size(101, 38);
            clearBTN.TabIndex = 14;
            clearBTN.Text = "Clear";
            clearBTN.UseVisualStyleBackColor = true;
            clearBTN.Click += clearBTN_Click;
            // 
            // copyTMR
            // 
            copyTMR.Interval = 1200;
            copyTMR.Tick += copyTMR_Tick;
            // 
            // strLBL
            // 
            strLBL.AutoSize = true;
            strLBL.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold);
            strLBL.Location = new Point(151, 509);
            strLBL.Name = "strLBL";
            strLBL.Size = new Size(14, 21);
            strLBL.TabIndex = 15;
            strLBL.Text = " ";
            // 
            // numberCHK
            // 
            numberCHK.AutoSize = true;
            numberCHK.Location = new Point(213, 56);
            numberCHK.Name = "numberCHK";
            numberCHK.Size = new Size(94, 25);
            numberCHK.TabIndex = 4;
            numberCHK.Text = "Numbers";
            numberCHK.UseVisualStyleBackColor = true;
            numberCHK.CheckedChanged += numberCHK_CheckedChanged;
            // 
            // lowerCHK
            // 
            lowerCHK.AutoSize = true;
            lowerCHK.Location = new Point(28, 106);
            lowerCHK.Name = "lowerCHK";
            lowerCHK.Size = new Size(102, 25);
            lowerCHK.TabIndex = 3;
            lowerCHK.Text = "Lowercase";
            lowerCHK.UseVisualStyleBackColor = true;
            lowerCHK.CheckedChanged += lowerCHK_CheckedChanged;
            // 
            // upperCHK
            // 
            upperCHK.AutoSize = true;
            upperCHK.Location = new Point(28, 56);
            upperCHK.Name = "upperCHK";
            upperCHK.Size = new Size(102, 25);
            upperCHK.TabIndex = 2;
            upperCHK.Text = "Uppercase";
            upperCHK.UseVisualStyleBackColor = true;
            upperCHK.CheckedChanged += upperCHK_CheckedChanged;
            // 
            // symbolCHK
            // 
            symbolCHK.AutoSize = true;
            symbolCHK.Location = new Point(213, 106);
            symbolCHK.Name = "symbolCHK";
            symbolCHK.Size = new Size(89, 25);
            symbolCHK.TabIndex = 5;
            symbolCHK.Text = "Symbols";
            symbolCHK.UseVisualStyleBackColor = true;
            symbolCHK.CheckedChanged += symbolCHK_CheckedChanged;
            // 
            // notifyLBL
            // 
            notifyLBL.AutoSize = true;
            notifyLBL.Font = new Font("Yu Gothic UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            notifyLBL.ForeColor = Color.FromArgb(0, 64, 0);
            notifyLBL.Location = new Point(119, 144);
            notifyLBL.Name = "notifyLBL";
            notifyLBL.Size = new Size(118, 40);
            notifyLBL.TabIndex = 6;
            notifyLBL.Text = "Copied!";
            notifyLBL.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(notifyLBL);
            groupBox1.Controls.Add(symbolCHK);
            groupBox1.Controls.Add(upperCHK);
            groupBox1.Controls.Add(lowerCHK);
            groupBox1.Controls.Add(numberCHK);
            groupBox1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 136);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(372, 197);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(396, 572);
            Controls.Add(strLBL);
            Controls.Add(clearBTN);
            Controls.Add(label4);
            Controls.Add(strengthBar);
            Controls.Add(groupBox1);
            Controls.Add(copyBTN);
            Controls.Add(outputTXT);
            Controls.Add(lengthTXT);
            Controls.Add(label3);
            Controls.Add(generateBTN);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button generateBTN;
        private Label label3;
        private TextBox lengthTXT;
        private TextBox outputTXT;
        private Button copyBTN;
        private ProgressBar strengthBar;
        private Label label4;
        private Button clearBTN;
        private System.Windows.Forms.Timer copyTMR;
        private Label strLBL;
        private CheckBox numberCHK;
        private CheckBox lowerCHK;
        private CheckBox upperCHK;
        private CheckBox symbolCHK;
        private Label notifyLBL;
        private GroupBox groupBox1;
    }
}
