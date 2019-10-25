//-----------------------------------------------------------------------
// <copyright file="FormCal.Designer.cs" company="none">
//     Copyright (c) Sprocket Enterprises. All rights reserved.
// </copyright>
// <author>Lin jiawei</author>
//-----------------------------------------------------------------------
namespace CalculationPlus
{
    /// <summary>
    /// 计算器界面
    /// </summary>
   public partial class FormCal
    {
        /// <summary>
        /// sin按键
        /// </summary>
        private System.Windows.Forms.Button btnSin;

        /// <summary>
        /// add按键
        /// </summary>
        private System.Windows.Forms.Button btnAdd;

        /// <summary>
        /// 3按键
        /// </summary>
        private System.Windows.Forms.Button btn3;

        /// <summary>
        /// 2按键
        /// </summary>
        private System.Windows.Forms.Button btn2;

        /// <summary>
        /// 1按键
        /// </summary>
        private System.Windows.Forms.Button btn1;

        /// <summary>
        /// cos按键
        /// </summary>
        private System.Windows.Forms.Button btnCos;

        /// <summary>
        /// minus按键
        /// </summary>
        private System.Windows.Forms.Button btnMinus;

        /// <summary>
        /// 6按键
        /// </summary>
        private System.Windows.Forms.Button btn6;

        /// <summary>
        /// 5按键
        /// </summary>
        private System.Windows.Forms.Button btn5;

        /// <summary>
        /// 4按键
        /// </summary>
        private System.Windows.Forms.Button btn4;

        /// <summary>
        /// tan按键
        /// </summary>
        private System.Windows.Forms.Button btnTan;

        /// <summary>
        /// mult按键
        /// </summary>
        private System.Windows.Forms.Button btnMult;

        /// <summary>
        /// 9按键
        /// </summary>
        private System.Windows.Forms.Button btn9;

        /// <summary>
        /// 8按键
        /// </summary>
        private System.Windows.Forms.Button btn8;

        /// <summary>
        /// 7按键
        /// </summary>
        private System.Windows.Forms.Button btn7;

        /// <summary>
        /// E
        /// </summary>
        private System.Windows.Forms.Button btnE;

        /// <summary>
        /// equal按键
        /// </summary>
        private System.Windows.Forms.Button btnEqual;

        /// <summary>
        /// dot按键
        /// </summary>
        private System.Windows.Forms.Button btnDot;

        /// <summary>
        /// 0按键
        /// </summary>
        private System.Windows.Forms.Button btn0;

        /// <summary>
        /// divi按键
        /// </summary>
        private System.Windows.Forms.Button btnDivi;

        /// <summary>
        /// precent按键
        /// </summary>
        private System.Windows.Forms.Button btnPrecent;

        /// <summary>
        /// bs按键
        /// </summary>
        private System.Windows.Forms.Button btnBS;

        /// <summary>
        /// ac按键
        /// </summary>
        private System.Windows.Forms.Button btnAC;

        /// <summary>
        /// pi按键
        /// </summary>
        private System.Windows.Forms.Button btnPi;

        /// <summary>
        /// sqrt按键
        /// </summary>
        private System.Windows.Forms.Button btnSqrt;

        /// <summary>
        /// lg按键
        /// </summary>
        private System.Windows.Forms.Button btnLg;

        /// <summary>
        /// ln按键
        /// </summary>
        private System.Windows.Forms.Button btnLn;

        /// <summary>
        /// rightBrace按键
        /// </summary>
        private System.Windows.Forms.Button btnRBrace;

        /// <summary>
        /// leftBrace按键
        /// </summary>
        private System.Windows.Forms.Button btnLBrace;

        /// <summary>
        /// 历史记录列表容器
        /// </summary>
        private System.Windows.Forms.Panel panelHis;

        /// <summary>
        /// 历史记录列表
        /// </summary>
        private System.Windows.Forms.Label labelHis;

        /// <summary>
        /// 输入框
        /// </summary>
        private System.Windows.Forms.Label inputBox;

        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCal));
            this.btnSin = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDivi = new System.Windows.Forms.Button();
            this.btnPrecent = new System.Windows.Forms.Button();
            this.btnBS = new System.Windows.Forms.Button();
            this.btnAC = new System.Windows.Forms.Button();
            this.btnPi = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnLg = new System.Windows.Forms.Button();
            this.btnLn = new System.Windows.Forms.Button();
            this.btnRBrace = new System.Windows.Forms.Button();
            this.btnLBrace = new System.Windows.Forms.Button();
            this.panelHis = new System.Windows.Forms.Panel();
            this.labelHis = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.Label();
            this.panelHis.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSin
            // 
            this.btnSin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnSin.CausesValidation = false;
            this.btnSin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.btnSin.FlatAppearance.BorderSize = 0;
            this.btnSin.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnSin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnSin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnSin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(125)))), ((int)(((byte)(130)))));
            this.btnSin.Location = new System.Drawing.Point(0, 517);
            this.btnSin.Margin = new System.Windows.Forms.Padding(0);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(69, 51);
            this.btnSin.TabIndex = 0;
            this.btnSin.Text = "sin";
            this.btnSin.UseVisualStyleBackColor = false;
            this.btnSin.Click += new System.EventHandler(this.BtnSin_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.CausesValidation = false;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(81)))), ((int)(((byte)(87)))));
            this.btnAdd.Location = new System.Drawing.Point(280, 465);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(69, 51);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "＋";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.White;
            this.btn3.CausesValidation = false;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("黑体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(81)))), ((int)(((byte)(87)))));
            this.btn3.Location = new System.Drawing.Point(210, 465);
            this.btn3.Margin = new System.Windows.Forms.Padding(0);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(69, 51);
            this.btn3.TabIndex = 12;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.White;
            this.btn2.CausesValidation = false;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("黑体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(81)))), ((int)(((byte)(87)))));
            this.btn2.Location = new System.Drawing.Point(140, 465);
            this.btn2.Margin = new System.Windows.Forms.Padding(0);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(69, 51);
            this.btn2.TabIndex = 11;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.White;
            this.btn1.CausesValidation = false;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("黑体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(81)))), ((int)(((byte)(87)))));
            this.btn1.Location = new System.Drawing.Point(70, 465);
            this.btn1.Margin = new System.Windows.Forms.Padding(0);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(69, 51);
            this.btn1.TabIndex = 10;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // btnCos
            // 
            this.btnCos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnCos.CausesValidation = false;
            this.btnCos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.btnCos.FlatAppearance.BorderSize = 0;
            this.btnCos.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnCos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnCos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnCos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(125)))), ((int)(((byte)(130)))));
            this.btnCos.Location = new System.Drawing.Point(0, 465);
            this.btnCos.Margin = new System.Windows.Forms.Padding(0);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(69, 51);
            this.btnCos.TabIndex = 9;
            this.btnCos.Text = "cos";
            this.btnCos.UseVisualStyleBackColor = false;
            this.btnCos.Click += new System.EventHandler(this.BtnCos_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.White;
            this.btnMinus.CausesValidation = false;
            this.btnMinus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.btnMinus.FlatAppearance.BorderSize = 0;
            this.btnMinus.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnMinus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMinus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(81)))), ((int)(((byte)(87)))));
            this.btnMinus.Location = new System.Drawing.Point(280, 413);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(69, 51);
            this.btnMinus.TabIndex = 18;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.BtnMinus_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.White;
            this.btn6.CausesValidation = false;
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("黑体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(81)))), ((int)(((byte)(87)))));
            this.btn6.Location = new System.Drawing.Point(210, 413);
            this.btn6.Margin = new System.Windows.Forms.Padding(0);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(69, 51);
            this.btn6.TabIndex = 17;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.White;
            this.btn5.CausesValidation = false;
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("黑体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(81)))), ((int)(((byte)(87)))));
            this.btn5.Location = new System.Drawing.Point(140, 413);
            this.btn5.Margin = new System.Windows.Forms.Padding(0);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(69, 51);
            this.btn5.TabIndex = 16;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.White;
            this.btn4.CausesValidation = false;
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("黑体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(81)))), ((int)(((byte)(87)))));
            this.btn4.Location = new System.Drawing.Point(70, 413);
            this.btn4.Margin = new System.Windows.Forms.Padding(0);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(69, 51);
            this.btn4.TabIndex = 15;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // btnTan
            // 
            this.btnTan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnTan.CausesValidation = false;
            this.btnTan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.btnTan.FlatAppearance.BorderSize = 0;
            this.btnTan.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnTan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnTan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnTan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(125)))), ((int)(((byte)(130)))));
            this.btnTan.Location = new System.Drawing.Point(0, 413);
            this.btnTan.Margin = new System.Windows.Forms.Padding(0);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(69, 51);
            this.btnTan.TabIndex = 14;
            this.btnTan.Text = "tan";
            this.btnTan.UseVisualStyleBackColor = false;
            this.btnTan.Click += new System.EventHandler(this.BtnTan_Click);
            // 
            // btnMult
            // 
            this.btnMult.BackColor = System.Drawing.Color.White;
            this.btnMult.CausesValidation = false;
            this.btnMult.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.btnMult.FlatAppearance.BorderSize = 0;
            this.btnMult.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnMult.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMult.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(81)))), ((int)(((byte)(87)))));
            this.btnMult.Location = new System.Drawing.Point(280, 361);
            this.btnMult.Margin = new System.Windows.Forms.Padding(0);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(69, 51);
            this.btnMult.TabIndex = 23;
            this.btnMult.Text = "×";
            this.btnMult.UseVisualStyleBackColor = false;
            this.btnMult.Click += new System.EventHandler(this.BtnMult_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.White;
            this.btn9.CausesValidation = false;
            this.btn9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("黑体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(81)))), ((int)(((byte)(87)))));
            this.btn9.Location = new System.Drawing.Point(210, 361);
            this.btn9.Margin = new System.Windows.Forms.Padding(0);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(69, 51);
            this.btn9.TabIndex = 22;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.White;
            this.btn8.CausesValidation = false;
            this.btn8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("黑体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(81)))), ((int)(((byte)(87)))));
            this.btn8.Location = new System.Drawing.Point(140, 361);
            this.btn8.Margin = new System.Windows.Forms.Padding(0);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(69, 51);
            this.btn8.TabIndex = 21;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.White;
            this.btn7.CausesValidation = false;
            this.btn7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("黑体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(81)))), ((int)(((byte)(87)))));
            this.btn7.Location = new System.Drawing.Point(70, 361);
            this.btn7.Margin = new System.Windows.Forms.Padding(0);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(69, 51);
            this.btn7.TabIndex = 20;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // btnE
            // 
            this.btnE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnE.CausesValidation = false;
            this.btnE.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.btnE.FlatAppearance.BorderSize = 0;
            this.btnE.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(125)))), ((int)(((byte)(130)))));
            this.btnE.Location = new System.Drawing.Point(0, 309);
            this.btnE.Margin = new System.Windows.Forms.Padding(0);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(69, 51);
            this.btnE.TabIndex = 24;
            this.btnE.Text = "e";
            this.btnE.UseVisualStyleBackColor = false;
            this.btnE.Click += new System.EventHandler(this.BtnE_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(119)))), ((int)(((byte)(48)))));
            this.btnEqual.CausesValidation = false;
            this.btnEqual.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.btnEqual.FlatAppearance.BorderSize = 0;
            this.btnEqual.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnEqual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(109)))), ((int)(((byte)(38)))));
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEqual.Font = new System.Drawing.Font("黑体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEqual.ForeColor = System.Drawing.Color.White;
            this.btnEqual.Location = new System.Drawing.Point(280, 517);
            this.btnEqual.Margin = new System.Windows.Forms.Padding(0);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(69, 51);
            this.btnEqual.TabIndex = 32;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.BtnEqual_Click);
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.Color.White;
            this.btnDot.CausesValidation = false;
            this.btnDot.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.btnDot.FlatAppearance.BorderSize = 0;
            this.btnDot.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnDot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDot.Font = new System.Drawing.Font("黑体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(81)))), ((int)(((byte)(87)))));
            this.btnDot.Location = new System.Drawing.Point(210, 517);
            this.btnDot.Margin = new System.Windows.Forms.Padding(0);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(69, 51);
            this.btnDot.TabIndex = 31;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.Click += new System.EventHandler(this.BtnDot_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.White;
            this.btn0.CausesValidation = false;
            this.btn0.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("黑体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(81)))), ((int)(((byte)(87)))));
            this.btn0.Location = new System.Drawing.Point(70, 517);
            this.btn0.Margin = new System.Windows.Forms.Padding(0);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(139, 51);
            this.btn0.TabIndex = 29;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.Btn0_Click);
            // 
            // btnDivi
            // 
            this.btnDivi.BackColor = System.Drawing.Color.White;
            this.btnDivi.CausesValidation = false;
            this.btnDivi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.btnDivi.FlatAppearance.BorderSize = 0;
            this.btnDivi.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnDivi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDivi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivi.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDivi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(81)))), ((int)(((byte)(87)))));
            this.btnDivi.Location = new System.Drawing.Point(280, 309);
            this.btnDivi.Margin = new System.Windows.Forms.Padding(0);
            this.btnDivi.Name = "btnDivi";
            this.btnDivi.Size = new System.Drawing.Size(69, 51);
            this.btnDivi.TabIndex = 36;
            this.btnDivi.Text = "÷";
            this.btnDivi.UseVisualStyleBackColor = false;
            this.btnDivi.Click += new System.EventHandler(this.BtnDivi_Click);
            // 
            // btnPrecent
            // 
            this.btnPrecent.BackColor = System.Drawing.Color.White;
            this.btnPrecent.CausesValidation = false;
            this.btnPrecent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.btnPrecent.FlatAppearance.BorderSize = 0;
            this.btnPrecent.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnPrecent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPrecent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrecent.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPrecent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(81)))), ((int)(((byte)(87)))));
            this.btnPrecent.Location = new System.Drawing.Point(210, 309);
            this.btnPrecent.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrecent.Name = "btnPrecent";
            this.btnPrecent.Size = new System.Drawing.Size(69, 51);
            this.btnPrecent.TabIndex = 35;
            this.btnPrecent.Text = "％";
            this.btnPrecent.UseVisualStyleBackColor = false;
            this.btnPrecent.Click += new System.EventHandler(this.BtnPrecent_Click);
            // 
            // btnBS
            // 
            this.btnBS.BackColor = System.Drawing.Color.White;
            this.btnBS.CausesValidation = false;
            this.btnBS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.btnBS.FlatAppearance.BorderSize = 0;
            this.btnBS.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnBS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBS.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(81)))), ((int)(((byte)(87)))));
            this.btnBS.Location = new System.Drawing.Point(140, 309);
            this.btnBS.Margin = new System.Windows.Forms.Padding(0);
            this.btnBS.Name = "btnBS";
            this.btnBS.Size = new System.Drawing.Size(69, 51);
            this.btnBS.TabIndex = 34;
            this.btnBS.Text = "←";
            this.btnBS.UseVisualStyleBackColor = false;
            this.btnBS.Click += new System.EventHandler(this.BtnBS_Click);
            // 
            // btnAC
            // 
            this.btnAC.BackColor = System.Drawing.Color.White;
            this.btnAC.CausesValidation = false;
            this.btnAC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.btnAC.FlatAppearance.BorderSize = 0;
            this.btnAC.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnAC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAC.Font = new System.Drawing.Font("等线", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(119)))), ((int)(((byte)(48)))));
            this.btnAC.Location = new System.Drawing.Point(70, 309);
            this.btnAC.Margin = new System.Windows.Forms.Padding(0);
            this.btnAC.Name = "btnAC";
            this.btnAC.Size = new System.Drawing.Size(69, 51);
            this.btnAC.TabIndex = 33;
            this.btnAC.Text = "AC";
            this.btnAC.UseVisualStyleBackColor = false;
            this.btnAC.Click += new System.EventHandler(this.BtnAC_Click);
            // 
            // btnPi
            // 
            this.btnPi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnPi.CausesValidation = false;
            this.btnPi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.btnPi.FlatAppearance.BorderSize = 0;
            this.btnPi.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnPi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnPi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPi.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(125)))), ((int)(((byte)(130)))));
            this.btnPi.Location = new System.Drawing.Point(0, 361);
            this.btnPi.Margin = new System.Windows.Forms.Padding(0);
            this.btnPi.Name = "btnPi";
            this.btnPi.Size = new System.Drawing.Size(69, 51);
            this.btnPi.TabIndex = 37;
            this.btnPi.Text = "π";
            this.btnPi.UseVisualStyleBackColor = false;
            this.btnPi.Click += new System.EventHandler(this.BtnPi_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnSqrt.CausesValidation = false;
            this.btnSqrt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.btnSqrt.FlatAppearance.BorderSize = 0;
            this.btnSqrt.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnSqrt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnSqrt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqrt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(125)))), ((int)(((byte)(130)))));
            this.btnSqrt.Location = new System.Drawing.Point(0, 257);
            this.btnSqrt.Margin = new System.Windows.Forms.Padding(0);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(69, 51);
            this.btnSqrt.TabIndex = 38;
            this.btnSqrt.Text = "√X";
            this.btnSqrt.UseVisualStyleBackColor = false;
            this.btnSqrt.Click += new System.EventHandler(this.BtnSqrt_Click);
            // 
            // btnLg
            // 
            this.btnLg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnLg.CausesValidation = false;
            this.btnLg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.btnLg.FlatAppearance.BorderSize = 0;
            this.btnLg.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnLg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnLg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(125)))), ((int)(((byte)(130)))));
            this.btnLg.Location = new System.Drawing.Point(70, 257);
            this.btnLg.Margin = new System.Windows.Forms.Padding(0);
            this.btnLg.Name = "btnLg";
            this.btnLg.Size = new System.Drawing.Size(69, 51);
            this.btnLg.TabIndex = 39;
            this.btnLg.Text = "lg";
            this.btnLg.UseVisualStyleBackColor = false;
            this.btnLg.Click += new System.EventHandler(this.BtnLg_Click);
            // 
            // btnLn
            // 
            this.btnLn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnLn.CausesValidation = false;
            this.btnLn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.btnLn.FlatAppearance.BorderSize = 0;
            this.btnLn.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnLn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnLn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(125)))), ((int)(((byte)(130)))));
            this.btnLn.Location = new System.Drawing.Point(140, 257);
            this.btnLn.Margin = new System.Windows.Forms.Padding(0);
            this.btnLn.Name = "btnLn";
            this.btnLn.Size = new System.Drawing.Size(69, 51);
            this.btnLn.TabIndex = 40;
            this.btnLn.Text = "ln";
            this.btnLn.UseVisualStyleBackColor = false;
            this.btnLn.Click += new System.EventHandler(this.BtnLn_Click);
            // 
            // btnRBrace
            // 
            this.btnRBrace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnRBrace.CausesValidation = false;
            this.btnRBrace.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.btnRBrace.FlatAppearance.BorderSize = 0;
            this.btnRBrace.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnRBrace.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnRBrace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRBrace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRBrace.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRBrace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(125)))), ((int)(((byte)(130)))));
            this.btnRBrace.Location = new System.Drawing.Point(280, 257);
            this.btnRBrace.Margin = new System.Windows.Forms.Padding(0);
            this.btnRBrace.Name = "btnRBrace";
            this.btnRBrace.Size = new System.Drawing.Size(69, 51);
            this.btnRBrace.TabIndex = 41;
            this.btnRBrace.Text = ")";
            this.btnRBrace.UseVisualStyleBackColor = false;
            this.btnRBrace.Click += new System.EventHandler(this.BtnRBrace_Click);
            // 
            // btnLBrace
            // 
            this.btnLBrace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnLBrace.CausesValidation = false;
            this.btnLBrace.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.btnLBrace.FlatAppearance.BorderSize = 0;
            this.btnLBrace.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnLBrace.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnLBrace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLBrace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLBrace.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLBrace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(125)))), ((int)(((byte)(130)))));
            this.btnLBrace.Location = new System.Drawing.Point(210, 257);
            this.btnLBrace.Margin = new System.Windows.Forms.Padding(0);
            this.btnLBrace.Name = "btnLBrace";
            this.btnLBrace.Size = new System.Drawing.Size(69, 51);
            this.btnLBrace.TabIndex = 42;
            this.btnLBrace.Text = "(";
            this.btnLBrace.UseVisualStyleBackColor = false;
            this.btnLBrace.Click += new System.EventHandler(this.BtnLBrace_Click);
            // 
            // panelHis
            // 
            this.panelHis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHis.AutoScroll = true;
            this.panelHis.AutoScrollMinSize = new System.Drawing.Size(0, 20);
            this.panelHis.Controls.Add(this.labelHis);
            this.panelHis.Location = new System.Drawing.Point(14, 21);
            this.panelHis.Name = "panelHis";
            this.panelHis.Size = new System.Drawing.Size(323, 168);
            this.panelHis.TabIndex = 44;
            this.panelHis.Scroll += new System.Windows.Forms.ScrollEventHandler(this.PanelHis_Scroll);
            // 
            // labelHis
            // 
            this.labelHis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHis.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelHis.Location = new System.Drawing.Point(-308, 142);
            this.labelHis.Name = "labelHis";
            this.labelHis.Size = new System.Drawing.Size(630, 26);
            this.labelHis.TabIndex = 0;
            this.labelHis.Text = "888888888888888888888888888888888888888888888888888";
            this.labelHis.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // inputBox
            // 
            this.inputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.inputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.inputBox.ForeColor = System.Drawing.Color.Black;
            this.inputBox.Location = new System.Drawing.Point(12, 192);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(322, 67);
            this.inputBox.TabIndex = 1;
            this.inputBox.Text = "1234+578765*12341234+sin(45*87)-√5";
            this.inputBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormCal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(352, 571);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.panelHis);
            this.Controls.Add(this.btnLBrace);
            this.Controls.Add(this.btnRBrace);
            this.Controls.Add(this.btnLn);
            this.Controls.Add(this.btnLg);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnPi);
            this.Controls.Add(this.btnDivi);
            this.Controls.Add(this.btnPrecent);
            this.Controls.Add(this.btnBS);
            this.Controls.Add(this.btnAC);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnTan);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btnSin);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(125)))), ((int)(((byte)(130)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormCal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "工程计算器";
            this.panelHis.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion
    }
}