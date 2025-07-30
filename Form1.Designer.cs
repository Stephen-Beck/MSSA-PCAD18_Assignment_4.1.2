namespace Assignment_4._1._2
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
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnDivide = new Button();
            btnMultiply = new Button();
            btnSubtract = new Button();
            btnAdd = new Button();
            btnEquals = new Button();
            btn3 = new Button();
            btn6 = new Button();
            btn9 = new Button();
            btnDot = new Button();
            btn2 = new Button();
            btn5 = new Button();
            btn8 = new Button();
            btn0 = new Button();
            btn1 = new Button();
            btn4 = new Button();
            btn7 = new Button();
            btnClear = new Button();
            btnBackspace = new Button();
            txtDisplay = new TextBox();
            label1 = new Label();
            btnClearError = new Button();
            btnToggleNegative = new Button();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.BackColor = Color.Gray;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(74, 6);
            label5.Name = "label5";
            label5.Size = new Size(31, 41);
            label5.TabIndex = 43;
            // 
            // label3
            // 
            label3.BackColor = Color.Gray;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(43, 6);
            label3.Name = "label3";
            label3.Size = new Size(31, 41);
            label3.TabIndex = 42;
            // 
            // label2
            // 
            label2.BackColor = Color.Gray;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 6);
            label2.Name = "label2";
            label2.Size = new Size(31, 41);
            label2.TabIndex = 41;
            // 
            // btnDivide
            // 
            btnDivide.Enabled = false;
            btnDivide.FlatStyle = FlatStyle.Popup;
            btnDivide.Font = new Font("Lucida Console", 14.25F);
            btnDivide.Location = new Point(180, 115);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(50, 50);
            btnDivide.TabIndex = 40;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.FlatStyle = FlatStyle.Popup;
            btnMultiply.Font = new Font("Lucida Console", 14.25F);
            btnMultiply.Location = new Point(180, 171);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(50, 50);
            btnMultiply.TabIndex = 39;
            btnMultiply.Text = "×";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.FlatStyle = FlatStyle.Popup;
            btnSubtract.Font = new Font("Lucida Console", 14.25F);
            btnSubtract.Location = new Point(180, 227);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(50, 50);
            btnSubtract.TabIndex = 38;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnAdd
            // 
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Lucida Console", 14.25F);
            btnAdd.Location = new Point(180, 283);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(50, 50);
            btnAdd.TabIndex = 37;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEquals
            // 
            btnEquals.FlatStyle = FlatStyle.Popup;
            btnEquals.Font = new Font("Lucida Console", 14.25F);
            btnEquals.Location = new Point(180, 339);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(50, 50);
            btnEquals.TabIndex = 36;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // btn3
            // 
            btn3.FlatStyle = FlatStyle.Popup;
            btn3.Font = new Font("Lucida Console", 14.25F);
            btn3.Location = new Point(124, 283);
            btn3.Name = "btn3";
            btn3.Size = new Size(50, 50);
            btn3.TabIndex = 35;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += Number_Click;
            // 
            // btn6
            // 
            btn6.FlatStyle = FlatStyle.Popup;
            btn6.Font = new Font("Lucida Console", 14.25F);
            btn6.Location = new Point(124, 226);
            btn6.Name = "btn6";
            btn6.Size = new Size(50, 50);
            btn6.TabIndex = 34;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += Number_Click;
            // 
            // btn9
            // 
            btn9.FlatStyle = FlatStyle.Popup;
            btn9.Font = new Font("Lucida Console", 14.25F);
            btn9.Location = new Point(124, 171);
            btn9.Name = "btn9";
            btn9.Size = new Size(50, 50);
            btn9.TabIndex = 33;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += Number_Click;
            // 
            // btnDot
            // 
            btnDot.FlatStyle = FlatStyle.Popup;
            btnDot.Font = new Font("Lucida Console", 14.25F);
            btnDot.Location = new Point(124, 339);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(50, 50);
            btnDot.TabIndex = 32;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += Number_Click;
            // 
            // btn2
            // 
            btn2.FlatStyle = FlatStyle.Popup;
            btn2.Font = new Font("Lucida Console", 14.25F);
            btn2.Location = new Point(68, 283);
            btn2.Name = "btn2";
            btn2.Size = new Size(50, 50);
            btn2.TabIndex = 31;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += Number_Click;
            // 
            // btn5
            // 
            btn5.FlatStyle = FlatStyle.Popup;
            btn5.Font = new Font("Lucida Console", 14.25F);
            btn5.Location = new Point(68, 226);
            btn5.Name = "btn5";
            btn5.Size = new Size(50, 50);
            btn5.TabIndex = 30;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += Number_Click;
            // 
            // btn8
            // 
            btn8.FlatStyle = FlatStyle.Popup;
            btn8.Font = new Font("Lucida Console", 14.25F);
            btn8.Location = new Point(68, 171);
            btn8.Name = "btn8";
            btn8.Size = new Size(50, 50);
            btn8.TabIndex = 29;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += Number_Click;
            // 
            // btn0
            // 
            btn0.FlatStyle = FlatStyle.Popup;
            btn0.Font = new Font("Lucida Console", 14.25F);
            btn0.Location = new Point(68, 339);
            btn0.Name = "btn0";
            btn0.Size = new Size(50, 50);
            btn0.TabIndex = 28;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += Number_Click;
            // 
            // btn1
            // 
            btn1.FlatStyle = FlatStyle.Popup;
            btn1.Font = new Font("Lucida Console", 14.25F);
            btn1.Location = new Point(12, 283);
            btn1.Name = "btn1";
            btn1.Size = new Size(50, 50);
            btn1.TabIndex = 27;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += Number_Click;
            // 
            // btn4
            // 
            btn4.FlatStyle = FlatStyle.Popup;
            btn4.Font = new Font("Lucida Console", 14.25F);
            btn4.Location = new Point(12, 226);
            btn4.Name = "btn4";
            btn4.Size = new Size(50, 50);
            btn4.TabIndex = 26;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += Number_Click;
            // 
            // btn7
            // 
            btn7.FlatStyle = FlatStyle.Popup;
            btn7.Font = new Font("Lucida Console", 14.25F);
            btn7.Location = new Point(12, 171);
            btn7.Name = "btn7";
            btn7.Size = new Size(50, 50);
            btn7.TabIndex = 25;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += Number_Click;
            // 
            // btnClear
            // 
            btnClear.FlatStyle = FlatStyle.Popup;
            btnClear.Font = new Font("Lucida Console", 14.25F);
            btnClear.Location = new Point(12, 115);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(50, 50);
            btnClear.TabIndex = 24;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnBackspace
            // 
            btnBackspace.FlatStyle = FlatStyle.Popup;
            btnBackspace.Font = new Font("Lucida Console", 14.25F);
            btnBackspace.Location = new Point(124, 115);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new Size(50, 50);
            btnBackspace.TabIndex = 44;
            btnBackspace.Text = "⌫";
            btnBackspace.UseVisualStyleBackColor = true;
            btnBackspace.Click += btnBackspace_Click;
            // 
            // txtDisplay
            // 
            txtDisplay.BackColor = Color.White;
            txtDisplay.BorderStyle = BorderStyle.None;
            txtDisplay.Font = new Font("Lucida Console", 11F);
            txtDisplay.ForeColor = Color.Black;
            txtDisplay.Location = new Point(14, 64);
            txtDisplay.MaxLength = 13;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(216, 15);
            txtDisplay.TabIndex = 45;
            txtDisplay.TabStop = false;
            txtDisplay.Text = "Cannot divide by zero.";
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(12, 52);
            label1.Name = "label1";
            label1.Size = new Size(218, 50);
            label1.TabIndex = 46;
            // 
            // btnClearError
            // 
            btnClearError.FlatStyle = FlatStyle.Popup;
            btnClearError.Font = new Font("Lucida Console", 14.25F);
            btnClearError.Location = new Point(68, 115);
            btnClearError.Name = "btnClearError";
            btnClearError.Size = new Size(50, 50);
            btnClearError.TabIndex = 47;
            btnClearError.Text = "CE";
            btnClearError.UseVisualStyleBackColor = true;
            btnClearError.Click += btnClearError_Click;
            // 
            // btnToggleNegative
            // 
            btnToggleNegative.FlatStyle = FlatStyle.Popup;
            btnToggleNegative.Font = new Font("Lucida Console", 14.25F);
            btnToggleNegative.Location = new Point(12, 339);
            btnToggleNegative.Name = "btnToggleNegative";
            btnToggleNegative.Size = new Size(50, 50);
            btnToggleNegative.TabIndex = 48;
            btnToggleNegative.Text = "±";
            btnToggleNegative.UseVisualStyleBackColor = true;
            btnToggleNegative.Click += btnToggleNegative_Click;
            // 
            // label4
            // 
            label4.BackColor = Color.Gray;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(167, 6);
            label4.Name = "label4";
            label4.Size = new Size(31, 41);
            label4.TabIndex = 51;
            // 
            // label6
            // 
            label6.BackColor = Color.Gray;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(136, 6);
            label6.Name = "label6";
            label6.Size = new Size(31, 41);
            label6.TabIndex = 50;
            // 
            // label7
            // 
            label7.BackColor = Color.Gray;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(105, 6);
            label7.Name = "label7";
            label7.Size = new Size(31, 41);
            label7.TabIndex = 49;
            // 
            // label8
            // 
            label8.BackColor = Color.Gray;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.ForeColor = Color.Black;
            label8.Location = new Point(198, 6);
            label8.Name = "label8";
            label8.Size = new Size(31, 41);
            label8.TabIndex = 52;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(242, 401);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(btnToggleNegative);
            Controls.Add(btnClearError);
            Controls.Add(btnBackspace);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btnSubtract);
            Controls.Add(btnAdd);
            Controls.Add(btnEquals);
            Controls.Add(btn3);
            Controls.Add(btn6);
            Controls.Add(btn9);
            Controls.Add(btnDot);
            Controls.Add(btn2);
            Controls.Add(btn5);
            Controls.Add(btn8);
            Controls.Add(btn0);
            Controls.Add(btn1);
            Controls.Add(btn4);
            Controls.Add(btn7);
            Controls.Add(btnClear);
            Controls.Add(txtDisplay);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Label label3;
        private Label label2;
        private Button btnDivide;
        private Button btnMultiply;
        private Button btnSubtract;
        private Button btnAdd;
        private Button btnEquals;
        private Button btn3;
        private Button btn6;
        private Button btn9;
        private Button btnDot;
        private Button btn2;
        private Button btn5;
        private Button btn8;
        private Button btn0;
        private Button btn1;
        private Button btn4;
        private Button btn7;
        private Button btnClear;
        private Label displayLabel;
        private Button btnBackspace;
        private TextBox txtDisplay;
        private Label label1;
        private Button btnClearError;
        private Button btnToggleNegative;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}
