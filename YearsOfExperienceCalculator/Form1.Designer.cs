namespace YearsOfExperienceCalculator
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
            numboxYear = new NumericUpDown();
            numboxMonth = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblTotal = new Label();
            btnCalculate = new Button();
            btnTotal = new Button();
            rtxtbxHistory = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)numboxYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numboxMonth).BeginInit();
            SuspendLayout();
            // 
            // numboxYear
            // 
            numboxYear.Location = new Point(46, 66);
            numboxYear.Name = "numboxYear";
            numboxYear.Size = new Size(120, 23);
            numboxYear.TabIndex = 0;
            // 
            // numboxMonth
            // 
            numboxMonth.Location = new Point(173, 66);
            numboxMonth.Name = "numboxMonth";
            numboxMonth.Size = new Size(120, 23);
            numboxMonth.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 48);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 2;
            label1.Text = "Year";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(173, 48);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 3;
            label2.Text = "Month";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 266);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 4;
            label3.Text = "Total";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.Location = new Point(46, 281);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(24, 30);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "0";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(311, 66);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Ok";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnTotal
            // 
            btnTotal.Location = new Point(46, 211);
            btnTotal.Name = "btnTotal";
            btnTotal.Size = new Size(340, 43);
            btnTotal.TabIndex = 7;
            btnTotal.Text = "Calculate";
            btnTotal.UseVisualStyleBackColor = true;
            btnTotal.Click += btnTotal_Click;
            // 
            // rtxtbxHistory
            // 
            rtxtbxHistory.Location = new Point(46, 95);
            rtxtbxHistory.Name = "rtxtbxHistory";
            rtxtbxHistory.ReadOnly = true;
            rtxtbxHistory.Size = new Size(340, 96);
            rtxtbxHistory.TabIndex = 8;
            rtxtbxHistory.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtxtbxHistory);
            Controls.Add(btnTotal);
            Controls.Add(btnCalculate);
            Controls.Add(lblTotal);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numboxMonth);
            Controls.Add(numboxYear);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numboxYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)numboxMonth).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numboxYear;
        private NumericUpDown numboxMonth;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblTotal;
        private Button btnCalculate;
        private Button btnTotal;
        private RichTextBox rtxtbxHistory;
    }
}
