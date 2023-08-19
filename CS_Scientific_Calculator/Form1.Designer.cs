namespace CS_Scientific_Calculator
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
            txtResult = new TextBox();
            button1 = new Button();
            btnClearEntry = new Button();
            btnClear = new Button();
            btnPM = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnAdd = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnSub = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnMult = new Button();
            btn0 = new Button();
            btnDot = new Button();
            btnEquals = new Button();
            btnDiv = new Button();
            SuspendLayout();
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtResult.Location = new Point(12, 26);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(318, 36);
            txtResult.TabIndex = 0;
            txtResult.Text = "0";
            txtResult.TextAlign = HorizontalAlignment.Right;
            txtResult.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 68);
            button1.Name = "button1";
            button1.Size = new Size(75, 80);
            button1.TabIndex = 1;
            button1.Text = "⌫";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnClearEntry
            // 
            btnClearEntry.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClearEntry.Location = new Point(93, 68);
            btnClearEntry.Name = "btnClearEntry";
            btnClearEntry.Size = new Size(75, 80);
            btnClearEntry.TabIndex = 2;
            btnClearEntry.Text = "CE";
            btnClearEntry.UseVisualStyleBackColor = true;
            btnClearEntry.Click += btnClearEntry_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(174, 68);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 80);
            btnClear.TabIndex = 3;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnPM
            // 
            btnPM.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPM.Location = new Point(255, 68);
            btnPM.Name = "btnPM";
            btnPM.Size = new Size(75, 80);
            btnPM.TabIndex = 4;
            btnPM.Text = "±";
            btnPM.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            btn7.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn7.Location = new Point(12, 154);
            btn7.Name = "btn7";
            btn7.Size = new Size(75, 80);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += EnterNumbers;
            // 
            // btn8
            // 
            btn8.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn8.Location = new Point(93, 154);
            btn8.Name = "btn8";
            btn8.Size = new Size(75, 80);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += EnterNumbers;
            // 
            // btn9
            // 
            btn9.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn9.Location = new Point(174, 154);
            btn9.Name = "btn9";
            btn9.Size = new Size(75, 80);
            btn9.TabIndex = 3;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += EnterNumbers;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(255, 154);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 80);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += numberOper;
            // 
            // btn4
            // 
            btn4.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn4.Location = new Point(12, 240);
            btn4.Name = "btn4";
            btn4.Size = new Size(75, 80);
            btn4.TabIndex = 1;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += EnterNumbers;
            // 
            // btn5
            // 
            btn5.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.Location = new Point(93, 240);
            btn5.Name = "btn5";
            btn5.Size = new Size(75, 80);
            btn5.TabIndex = 2;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += EnterNumbers;
            // 
            // btn6
            // 
            btn6.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn6.Location = new Point(174, 240);
            btn6.Name = "btn6";
            btn6.Size = new Size(75, 80);
            btn6.TabIndex = 3;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += EnterNumbers;
            // 
            // btnSub
            // 
            btnSub.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSub.Location = new Point(255, 240);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(75, 80);
            btnSub.TabIndex = 4;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += numberOper;
            // 
            // btn1
            // 
            btn1.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.Location = new Point(12, 326);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 80);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += EnterNumbers;
            // 
            // btn2
            // 
            btn2.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.Location = new Point(93, 326);
            btn2.Name = "btn2";
            btn2.Size = new Size(75, 80);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += EnterNumbers;
            // 
            // btn3
            // 
            btn3.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.Location = new Point(174, 326);
            btn3.Name = "btn3";
            btn3.Size = new Size(75, 80);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += EnterNumbers;
            // 
            // btnMult
            // 
            btnMult.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMult.Location = new Point(255, 326);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(75, 80);
            btnMult.TabIndex = 4;
            btnMult.Text = "*";
            btnMult.UseVisualStyleBackColor = true;
            btnMult.Click += numberOper;
            // 
            // btn0
            // 
            btn0.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn0.Location = new Point(12, 412);
            btn0.Name = "btn0";
            btn0.Size = new Size(75, 80);
            btn0.TabIndex = 1;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += EnterNumbers;
            // 
            // btnDot
            // 
            btnDot.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDot.Location = new Point(93, 412);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(75, 80);
            btnDot.TabIndex = 2;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += EnterNumbers;
            // 
            // btnEquals
            // 
            btnEquals.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEquals.Location = new Point(174, 412);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(75, 80);
            btnEquals.TabIndex = 3;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnDiv
            // 
            btnDiv.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDiv.Location = new Point(255, 412);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(75, 80);
            btnDiv.TabIndex = 4;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += numberOper;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 508);
            Controls.Add(btnDiv);
            Controls.Add(btnMult);
            Controls.Add(btnSub);
            Controls.Add(btnAdd);
            Controls.Add(btnPM);
            Controls.Add(btnEquals);
            Controls.Add(btn3);
            Controls.Add(btn6);
            Controls.Add(btn9);
            Controls.Add(btnClear);
            Controls.Add(btnDot);
            Controls.Add(btn2);
            Controls.Add(btn5);
            Controls.Add(btn8);
            Controls.Add(btnClearEntry);
            Controls.Add(btn0);
            Controls.Add(btn1);
            Controls.Add(btn4);
            Controls.Add(btn7);
            Controls.Add(button1);
            Controls.Add(txtResult);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResult;
        private Button button1;
        private Button btnClearEntry;
        private Button btnClear;
        private Button btnPM;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnAdd;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnSub;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnMult;
        private Button btn0;
        private Button btnDot;
        private Button btnEquals;
        private Button btnDiv;
    }
}