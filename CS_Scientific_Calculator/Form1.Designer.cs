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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            standardToolStripMenuItem = new ToolStripMenuItem();
            scientificToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            btnPi = new Button();
            btnLog = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            button21 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtResult.Location = new Point(12, 26);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(664, 36);
            txtResult.TabIndex = 0;
            txtResult.Text = "0";
            txtResult.TextAlign = HorizontalAlignment.Right;
            txtResult.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 68);
            button1.Name = "button1";
            button1.Size = new Size(75, 80);
            button1.TabIndex = 1;
            button1.Text = "⌫";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnBS_Click;
            // 
            // btnClearEntry
            // 
            btnClearEntry.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
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
            btnClear.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
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
            btnPM.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnPM.Location = new Point(255, 68);
            btnPM.Name = "btnPM";
            btnPM.Size = new Size(75, 80);
            btnPM.TabIndex = 4;
            btnPM.Text = "±";
            btnPM.UseVisualStyleBackColor = true;
            btnPM.Click += btnPM_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
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
            btn8.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
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
            btn9.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
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
            btnAdd.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
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
            btn4.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
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
            btn5.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
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
            btn6.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
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
            btnSub.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
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
            btn1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
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
            btn2.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
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
            btn3.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
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
            btnMult.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
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
            btn0.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
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
            btnDot.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
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
            btnEquals.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
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
            btnDiv.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnDiv.Location = new Point(255, 412);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(75, 80);
            btnDiv.TabIndex = 4;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += numberOper;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(699, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { standardToolStripMenuItem, scientificToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // standardToolStripMenuItem
            // 
            standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            standardToolStripMenuItem.Size = new Size(123, 22);
            standardToolStripMenuItem.Text = "Standard";
            standardToolStripMenuItem.Click += standardToolStripMenuItem_Click;
            // 
            // scientificToolStripMenuItem
            // 
            scientificToolStripMenuItem.Name = "scientificToolStripMenuItem";
            scientificToolStripMenuItem.Size = new Size(123, 22);
            scientificToolStripMenuItem.Text = "Scientific";
            scientificToolStripMenuItem.Click += scientificToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(123, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // btnPi
            // 
            btnPi.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnPi.Location = new Point(358, 68);
            btnPi.Name = "btnPi";
            btnPi.Size = new Size(75, 80);
            btnPi.TabIndex = 4;
            btnPi.Text = "π";
            btnPi.UseVisualStyleBackColor = true;
            btnPi.Click += btnPM_Click;
            // 
            // btnLog
            // 
            btnLog.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnLog.Location = new Point(439, 68);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(75, 80);
            btnLog.TabIndex = 4;
            btnLog.Text = "Log";
            btnLog.UseVisualStyleBackColor = true;
            btnLog.Click += btnPM_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(520, 68);
            button4.Name = "button4";
            button4.Size = new Size(75, 80);
            button4.TabIndex = 4;
            button4.Text = "Sqrt";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnPM_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(601, 68);
            button5.Name = "button5";
            button5.Size = new Size(75, 80);
            button5.TabIndex = 4;
            button5.Text = "X²";
            button5.UseVisualStyleBackColor = true;
            button5.Click += btnPM_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(358, 154);
            button6.Name = "button6";
            button6.Size = new Size(75, 80);
            button6.TabIndex = 4;
            button6.Text = "Sinh";
            button6.UseVisualStyleBackColor = true;
            button6.Click += btnPM_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(439, 154);
            button7.Name = "button7";
            button7.Size = new Size(75, 80);
            button7.TabIndex = 4;
            button7.Text = "Sin";
            button7.UseVisualStyleBackColor = true;
            button7.Click += btnPM_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(520, 154);
            button8.Name = "button8";
            button8.Size = new Size(75, 80);
            button8.TabIndex = 4;
            button8.Text = "Dec";
            button8.UseVisualStyleBackColor = true;
            button8.Click += btnPM_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(601, 154);
            button9.Name = "button9";
            button9.Size = new Size(75, 80);
            button9.TabIndex = 4;
            button9.Text = "±";
            button9.UseVisualStyleBackColor = true;
            button9.Click += btnPM_Click;
            // 
            // button10
            // 
            button10.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button10.Location = new Point(358, 240);
            button10.Name = "button10";
            button10.Size = new Size(75, 80);
            button10.TabIndex = 4;
            button10.Text = "Cosh";
            button10.UseVisualStyleBackColor = true;
            button10.Click += btnPM_Click;
            // 
            // button11
            // 
            button11.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button11.Location = new Point(439, 240);
            button11.Name = "button11";
            button11.Size = new Size(75, 80);
            button11.TabIndex = 4;
            button11.Text = "Cos";
            button11.UseVisualStyleBackColor = true;
            button11.Click += btnPM_Click;
            // 
            // button12
            // 
            button12.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button12.Location = new Point(520, 240);
            button12.Name = "button12";
            button12.Size = new Size(75, 80);
            button12.TabIndex = 4;
            button12.Text = "Bin";
            button12.UseVisualStyleBackColor = true;
            button12.Click += btnPM_Click;
            // 
            // button13
            // 
            button13.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button13.Location = new Point(601, 240);
            button13.Name = "button13";
            button13.Size = new Size(75, 80);
            button13.TabIndex = 4;
            button13.Text = "±";
            button13.UseVisualStyleBackColor = true;
            button13.Click += btnPM_Click;
            // 
            // button14
            // 
            button14.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button14.Location = new Point(358, 326);
            button14.Name = "button14";
            button14.Size = new Size(75, 80);
            button14.TabIndex = 4;
            button14.Text = "Tanh";
            button14.UseVisualStyleBackColor = true;
            button14.Click += btnPM_Click;
            // 
            // button15
            // 
            button15.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button15.Location = new Point(439, 326);
            button15.Name = "button15";
            button15.Size = new Size(75, 80);
            button15.TabIndex = 4;
            button15.Text = "Tan";
            button15.UseVisualStyleBackColor = true;
            button15.Click += btnPM_Click;
            // 
            // button16
            // 
            button16.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button16.Location = new Point(520, 326);
            button16.Name = "button16";
            button16.Size = new Size(75, 80);
            button16.TabIndex = 4;
            button16.Text = "Hex";
            button16.UseVisualStyleBackColor = true;
            button16.Click += btnPM_Click;
            // 
            // button17
            // 
            button17.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button17.Location = new Point(601, 326);
            button17.Name = "button17";
            button17.Size = new Size(75, 80);
            button17.TabIndex = 4;
            button17.Text = "ln x";
            button17.UseVisualStyleBackColor = true;
            button17.Click += btnPM_Click;
            // 
            // button18
            // 
            button18.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button18.Location = new Point(358, 412);
            button18.Name = "button18";
            button18.Size = new Size(75, 80);
            button18.TabIndex = 4;
            button18.Text = "Exp";
            button18.UseVisualStyleBackColor = true;
            button18.Click += btnPM_Click;
            // 
            // button19
            // 
            button19.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button19.Location = new Point(439, 412);
            button19.Name = "button19";
            button19.Size = new Size(75, 80);
            button19.TabIndex = 4;
            button19.Text = "Mod";
            button19.UseVisualStyleBackColor = true;
            button19.Click += btnPM_Click;
            // 
            // button20
            // 
            button20.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button20.Location = new Point(520, 412);
            button20.Name = "button20";
            button20.Size = new Size(75, 80);
            button20.TabIndex = 4;
            button20.Text = "Oct";
            button20.UseVisualStyleBackColor = true;
            button20.Click += btnPM_Click;
            // 
            // button21
            // 
            button21.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button21.Location = new Point(601, 412);
            button21.Name = "button21";
            button21.Size = new Size(75, 80);
            button21.TabIndex = 4;
            button21.Text = "%";
            button21.UseVisualStyleBackColor = true;
            button21.Click += btnPM_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 508);
            Controls.Add(btnDiv);
            Controls.Add(btnMult);
            Controls.Add(btnSub);
            Controls.Add(btnAdd);
            Controls.Add(button21);
            Controls.Add(button17);
            Controls.Add(button13);
            Controls.Add(button9);
            Controls.Add(button5);
            Controls.Add(button20);
            Controls.Add(button16);
            Controls.Add(button12);
            Controls.Add(button8);
            Controls.Add(button4);
            Controls.Add(button19);
            Controls.Add(button15);
            Controls.Add(button11);
            Controls.Add(button7);
            Controls.Add(btnLog);
            Controls.Add(button18);
            Controls.Add(button14);
            Controls.Add(button10);
            Controls.Add(button6);
            Controls.Add(btnPi);
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
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem standardToolStripMenuItem;
        private ToolStripMenuItem scientificToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Button btnPi;
        private Button btnLog;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button button21;
    }
}