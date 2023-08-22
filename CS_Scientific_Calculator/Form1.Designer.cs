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
            btnBS = new Button();
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
            btnSq = new Button();
            btnx2 = new Button();
            btnSinh = new Button();
            btnSin = new Button();
            btnDec = new Button();
            btnx3 = new Button();
            btnCosh = new Button();
            btnCos = new Button();
            btnBin = new Button();
            btn1x = new Button();
            btnTanh = new Button();
            btnTan = new Button();
            btnHex = new Button();
            btnlnx = new Button();
            btnExp = new Button();
            btnMod = new Button();
            btnOct = new Button();
            btnPer = new Button();
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
            // btnBS
            // 
            btnBS.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnBS.Location = new Point(12, 68);
            btnBS.Name = "btnBS";
            btnBS.Size = new Size(75, 80);
            btnBS.TabIndex = 1;
            btnBS.Text = "⌫";
            btnBS.UseVisualStyleBackColor = true;
            btnBS.Click += btnBS_Click;
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
            btnPi.Click += btnPi_Click;
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
            btnLog.Click += btnLog_Click;
            // 
            // btnSq
            // 
            btnSq.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnSq.Location = new Point(520, 68);
            btnSq.Name = "btnSq";
            btnSq.Size = new Size(75, 80);
            btnSq.TabIndex = 4;
            btnSq.Text = "Sqrt";
            btnSq.UseVisualStyleBackColor = true;
            btnSq.Click += btnSq_Click;
            // 
            // btnx2
            // 
            btnx2.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnx2.Location = new Point(601, 68);
            btnx2.Name = "btnx2";
            btnx2.Size = new Size(75, 80);
            btnx2.TabIndex = 4;
            btnx2.Text = "x²";
            btnx2.UseVisualStyleBackColor = true;
            btnx2.Click += btnx2_Click;
            // 
            // btnSinh
            // 
            btnSinh.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnSinh.Location = new Point(358, 154);
            btnSinh.Name = "btnSinh";
            btnSinh.Size = new Size(75, 80);
            btnSinh.TabIndex = 4;
            btnSinh.Text = "Sinh";
            btnSinh.UseVisualStyleBackColor = true;
            btnSinh.Click += btnSinh_Click;
            // 
            // btnSin
            // 
            btnSin.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnSin.Location = new Point(439, 154);
            btnSin.Name = "btnSin";
            btnSin.Size = new Size(75, 80);
            btnSin.TabIndex = 4;
            btnSin.Text = "Sin";
            btnSin.UseVisualStyleBackColor = true;
            btnSin.Click += btnSin_Click;
            // 
            // btnDec
            // 
            btnDec.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnDec.Location = new Point(520, 154);
            btnDec.Name = "btnDec";
            btnDec.Size = new Size(75, 80);
            btnDec.TabIndex = 4;
            btnDec.Text = "Dec";
            btnDec.UseVisualStyleBackColor = true;
            btnDec.Click += btnPM_Click;
            // 
            // btnx3
            // 
            btnx3.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnx3.Location = new Point(601, 154);
            btnx3.Name = "btnx3";
            btnx3.Size = new Size(75, 80);
            btnx3.TabIndex = 4;
            btnx3.Text = "x³";
            btnx3.UseVisualStyleBackColor = true;
            btnx3.Click += btnx_Click;
            // 
            // btnCosh
            // 
            btnCosh.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCosh.Location = new Point(358, 240);
            btnCosh.Name = "btnCosh";
            btnCosh.Size = new Size(75, 80);
            btnCosh.TabIndex = 4;
            btnCosh.Text = "Cosh";
            btnCosh.UseVisualStyleBackColor = true;
            btnCosh.Click += btnCosh_Click;
            // 
            // btnCos
            // 
            btnCos.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnCos.Location = new Point(439, 240);
            btnCos.Name = "btnCos";
            btnCos.Size = new Size(75, 80);
            btnCos.TabIndex = 4;
            btnCos.Text = "Cos";
            btnCos.UseVisualStyleBackColor = true;
            btnCos.Click += btnCos_Click;
            // 
            // btnBin
            // 
            btnBin.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnBin.Location = new Point(520, 240);
            btnBin.Name = "btnBin";
            btnBin.Size = new Size(75, 80);
            btnBin.TabIndex = 4;
            btnBin.Text = "Bin";
            btnBin.UseVisualStyleBackColor = true;
            btnBin.Click += btnPM_Click;
            // 
            // btn1x
            // 
            btn1x.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn1x.Location = new Point(601, 240);
            btn1x.Name = "btn1x";
            btn1x.Size = new Size(75, 80);
            btn1x.TabIndex = 4;
            btn1x.Text = "1/x";
            btn1x.UseVisualStyleBackColor = true;
            btn1x.Click += btn1x_Click;
            // 
            // btnTanh
            // 
            btnTanh.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnTanh.Location = new Point(358, 326);
            btnTanh.Name = "btnTanh";
            btnTanh.Size = new Size(75, 80);
            btnTanh.TabIndex = 4;
            btnTanh.Text = "Tanh";
            btnTanh.UseVisualStyleBackColor = true;
            btnTanh.Click += btnTanh_Click;
            // 
            // btnTan
            // 
            btnTan.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnTan.Location = new Point(439, 326);
            btnTan.Name = "btnTan";
            btnTan.Size = new Size(75, 80);
            btnTan.TabIndex = 4;
            btnTan.Text = "Tan";
            btnTan.UseVisualStyleBackColor = true;
            btnTan.Click += btnTan_Click;
            // 
            // btnHex
            // 
            btnHex.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnHex.Location = new Point(520, 326);
            btnHex.Name = "btnHex";
            btnHex.Size = new Size(75, 80);
            btnHex.TabIndex = 4;
            btnHex.Text = "Hex";
            btnHex.UseVisualStyleBackColor = true;
            btnHex.Click += btnPM_Click;
            // 
            // btnlnx
            // 
            btnlnx.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnlnx.Location = new Point(601, 326);
            btnlnx.Name = "btnlnx";
            btnlnx.Size = new Size(75, 80);
            btnlnx.TabIndex = 4;
            btnlnx.Text = "ln x";
            btnlnx.UseVisualStyleBackColor = true;
            btnlnx.Click += btnlnx_Click;
            // 
            // btnExp
            // 
            btnExp.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnExp.Location = new Point(358, 412);
            btnExp.Name = "btnExp";
            btnExp.Size = new Size(75, 80);
            btnExp.TabIndex = 4;
            btnExp.Text = "Exp";
            btnExp.UseVisualStyleBackColor = true;
            btnExp.Click += numberOper;
            // 
            // btnMod
            // 
            btnMod.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnMod.Location = new Point(439, 412);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(75, 80);
            btnMod.TabIndex = 4;
            btnMod.Text = "Mod";
            btnMod.UseVisualStyleBackColor = true;
            btnMod.Click += numberOper;
            // 
            // btnOct
            // 
            btnOct.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnOct.Location = new Point(520, 412);
            btnOct.Name = "btnOct";
            btnOct.Size = new Size(75, 80);
            btnOct.TabIndex = 4;
            btnOct.Text = "Oct";
            btnOct.UseVisualStyleBackColor = true;
            btnOct.Click += btnPM_Click;
            // 
            // btnPer
            // 
            btnPer.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnPer.Location = new Point(601, 412);
            btnPer.Name = "btnPer";
            btnPer.Size = new Size(75, 80);
            btnPer.TabIndex = 4;
            btnPer.Text = "%";
            btnPer.UseVisualStyleBackColor = true;
            btnPer.Click += btnPer_Click;
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
            Controls.Add(btnPer);
            Controls.Add(btnlnx);
            Controls.Add(btn1x);
            Controls.Add(btnx3);
            Controls.Add(btnx2);
            Controls.Add(btnOct);
            Controls.Add(btnHex);
            Controls.Add(btnBin);
            Controls.Add(btnDec);
            Controls.Add(btnSq);
            Controls.Add(btnMod);
            Controls.Add(btnTan);
            Controls.Add(btnCos);
            Controls.Add(btnSin);
            Controls.Add(btnLog);
            Controls.Add(btnExp);
            Controls.Add(btnTanh);
            Controls.Add(btnCosh);
            Controls.Add(btnSinh);
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
            Controls.Add(btnBS);
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
        private Button btnBS;
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
        private Button btnSq;
        private Button btnx2;
        private Button btnSinh;
        private Button btnSin;
        private Button btnDec;
        private Button btnx3;
        private Button btnCosh;
        private Button btnCos;
        private Button btnBin;
        private Button btn1x;
        private Button btnTanh;
        private Button btnTan;
        private Button btnHex;
        private Button btnlnx;
        private Button btnExp;
        private Button btnMod;
        private Button btnOct;
        private Button btnPer;
    }
}