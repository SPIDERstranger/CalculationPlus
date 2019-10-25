//-----------------------------------------------------------------------
// <copyright file="FormCal.cs" company="none">
//     Copyright (c) Sprocket Enterprises. All rights reserved.
// </copyright>
// <author>Lin jiawei</author>
//-----------------------------------------------------------------------
namespace CalculationPlus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    ///  输入阶段的类型
    /// </summary>
    public enum InputState
    {
        /// <summary>
        /// 开始阶段
        /// </summary>
        Start,

        /// <summary>
        /// 普通数字阶段
        /// </summary>
        Num,

        /// <summary>
        /// 小数点数字阶段
        /// </summary>
        DotNum,

        /// <summary>
        /// 完整数字阶段
        /// </summary>
        FinalNum,

        /// <summary>
        /// 操作符阶段
        /// </summary>
        Operation
    }

    // todo 负数问题，没有负数 ，解决方案，读取 - 作为数字 将 减法化为加法。 
    // todo 数字过长问题

    /// <summary>
    /// 计算器界面逻辑
    /// </summary>
    public partial class FormCal : Form
    {
        /// <summary>
        /// 是否是错误状态
        /// </summary>
        private bool isError = false;

        /// <summary>
        /// 是否是计算出结果
        /// </summary>
        private bool isResult = false;

        /// <summary>
        /// 历史记录长度
        /// </summary>
        private int hisLine = 0;

        /// <summary>
        /// 状态栈
        /// </summary>
        private Stack<InputState> stateStack = new Stack<InputState>();

        /// <summary>
        /// 当前状态
        /// </summary>
        private InputState state = InputState.Start;

        /// <summary>
        /// <see cref="Formula"/> 
        /// </summary>
        public FormCal()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// 自写的初始化
        /// </summary>
        public void Init()
        {
            ClearInputBox();
            ClearHistory();
            UpdateAcBtnText();
        }

        /// <summary>
        /// 等于 = 按键事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void BtnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                if (inputBox.Text.Length == 0)
                {
                    return;
                }

                if (!isResult)
                {
                    Formula.Instance.Read();
                    double result = Formula.Instance.Calculate();
                    AddHistory(inputBox.Text, result);
                    AddInputBoxText("=" + result);
                    isResult = true;
                }
                else
                {
                    SetInputBoxText();
                    isResult = false;
                }
            }
            catch (System.Exception ex)
            {
                isError = true;
                SetInputBoxText("出错");
                Console.WriteLine(ex);
            }
        }

        /// <summary>
        /// AC 按键事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void BtnAC_Click(object sender, EventArgs e)
        {
            if (inputBox.Text.Length == 0)
            { 
                ClearHistory(); 
            }

            ClearInputBox();
            state = InputState.Start;
        }

        /// <summary>
        /// 退格 按键事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void BtnBS_Click(object sender, EventArgs e)
        {
            if (!isResult && !isError)
            {
                BackSpace();
            }
            else
            {
                ClearInputBox();
            }
        }

        /// <summary>
        /// 转换AC和C按键
        /// </summary>
        private void UpdateAcBtnText()
        {
            if (inputBox.Text == string.Empty)
            {
                btnAC.Text = "AC";
            }
            else
            {
                btnAC.Text = "C";
            }
        }

        /// <summary>
        /// 退格功能
        /// </summary>
        private void BackSpace()
        {
            Formula.Instance.BackStr();
            SetInputBoxText(Formula.Instance.ToString());
            if (stateStack.Count > 1)
            {
                stateStack.Pop();
            }

            state = stateStack.Peek();
            Console.WriteLine("pop after : state count " + stateStack.Count + " : " + state);
        }

        /// <summary>
        /// 更新到某个状态
        /// </summary>
        /// <param name="state">状态</param>
        private void UpdateState(InputState state)
        {
            Console.WriteLine("pushStack : " + state);
            this.state = state;
            stateStack.Push(state);
        }

        /// <summary>
        /// 添加历史记录
        /// </summary>
        /// <param name="formula">计算式</param>
        /// <param name="result">计算结果</param>
        private void AddHistory(string formula, double result)
        { // todo 设置长度和长度
            labelHis.Text += formula + " = " + result + "\n";
            hisLine += 1;
            labelHis.Size = new System.Drawing.Size(labelHis.Size.Width, hisLine * 26);
            labelHis.Location = new Point(labelHis.Location.X, labelHis.Location.Y - (26));
            Console.WriteLine(labelHis.Size.ToString() + labelHis.Location.ToString());
            panelHis.AutoScrollMinSize = new Size(0, hisLine * 26);
            panelHis.AutoScrollPosition = new Point(0, hisLine * 26);
        }

        /// <summary>
        /// 清除历史记录
        /// </summary>
        private void ClearHistory()
        {
            hisLine = 0;
            labelHis.Size = new Size(630, 0);
            labelHis.Location = new Point(-308, 168);
            labelHis.Text = string.Empty;
            panelHis.AutoScrollMinSize = new Size(0, 0);
            panelHis.AutoScrollPosition = new Point(0, 0);
            Formula.Instance.Clear();
        }

        /// <summary>
        /// 清除当前状态的记录
        /// </summary>
        private void ClearStateStack()
        {
            stateStack.Clear();
            UpdateState(InputState.Start);
        }

        /// <summary>
        /// 清空输入框
        /// </summary>
        private void ClearInputBox()
        {
            ClearStateStack();
            inputBox.Font = new Font("Microsoft Sans Serif", 36F);
            SetInputBoxText();
            Formula.Instance.Clear();
            UpdateAcBtnText();
        }

        /// <summary>
        /// 设置输入框文字
        /// </summary>
        /// <param name="str">设置的文字</param>
        private void SetInputBoxText(string str = "")
        {
            inputBox.Text = str;
        }

        /// <summary>
        /// 添加输入框文字
        /// </summary>
        /// <param name="str">文字</param>
        /// <returns>是否能够继续输入</returns>
        private bool AddInputBoxText(string str)
        {
            // todo动态调整字体大小 最大 字体 36pt 最小 18pt
            int length = inputBox.Text.Length;

            if (length + str.Length > 46)
            {
                // 无输入或者关闭所有输入
                return false;
            }
            else if (length + str.Length > 11)
            {
                inputBox.Font = new Font("Microsoft Sans Serif", 18F); // 可以更加顺滑的动态调整
            }

            inputBox.Text += str;

            return true;
        }

        /// <summary>
        /// 判断当前输入状态，并更新
        /// </summary>
        /// <param name="str">输入文字</param>
        /// <returns>当前输入是否正确</returns>
        private bool CorrectInput(string str)  // 状态可能有重复，可以优化
        {
            bool result = false;
            switch (state)
            {
                case InputState.Start:
                    if (Formula.IsNumber(str) && str != ".")
                    {
                        result = true;
                        UpdateState(InputState.Num);
                    }
                    else if (Formula.IsSpNumber(str[0]))
                    {
                        result = true;
                        UpdateState(InputState.FinalNum);
                    }
                    else if (Formula.IsFuntion(str))
                    {
                        result = true;
                        UpdateState(InputState.Start);
                    }
                    else if (str == "(")
                    {
                        result = true;
                        UpdateState(InputState.Start);
                    }

                    break;

                case InputState.Num:
                    if (Formula.IsNumber(str))
                    {
                        result = true;
                        if (str == ".")
                        {
                            UpdateState(InputState.DotNum);
                        }
                        else
                        {
                            UpdateState(InputState.Num);
                        }
                    }
                    else if (Formula.IsOperation(str))
                    {
                        result = true;
                        UpdateState(InputState.Operation);
                    }
                    else if (Formula.IsBackOperation(str[0]))
                    {
                        result = true;
                        UpdateState(InputState.FinalNum);
                    }
                    else if (str == ")" && !Formula.CheckBracePair(inputBox.Text))
                    {
                        result = true;
                        UpdateState(InputState.FinalNum);
                    }

                    break;

                case InputState.DotNum:
                    if (Formula.IsNumber(str) && str != ".")
                    {
                        result = true;
                        UpdateState(InputState.DotNum);
                    }
                    else if (Formula.IsOperation(str))
                    {
                        result = true;
                        UpdateState(InputState.Operation);
                    }
                    else if (Formula.IsBackOperation(str[0]))
                    {
                        result = true;
                        UpdateState(InputState.FinalNum);
                    }
                    else if (str == ")" && !Formula.CheckBracePair(inputBox.Text))
                    {
                        result = true;
                        UpdateState(InputState.FinalNum);
                    }

                    break;

                case InputState.FinalNum:
                    if (Formula.IsOperation(str))
                    {
                        result = true;
                        UpdateState(InputState.Operation);
                    }
                    else if (Formula.IsBackOperation(str[0]))
                    {
                        result = true;
                        UpdateState(InputState.FinalNum);
                    }
                    else if (str == ")" && !Formula.CheckBracePair(inputBox.Text)) // 可以事先计算括号数量
                    {
                        result = true;
                        UpdateState(InputState.FinalNum);
                    }

                    break;

                case InputState.Operation:
                    if (Formula.IsNumber(str))
                    {
                        result = true;
                        UpdateState(InputState.Num);
                    }
                    else if (Formula.IsSpNumber(str[0]))
                    {
                        result = true;
                        UpdateState(InputState.FinalNum);
                    }
                    else if (Formula.IsFuntion(str))
                    {
                        result = true;
                        UpdateState(InputState.Start);
                    }
                    else if (str == "(")
                    {
                        result = true;
                        UpdateState(InputState.Start);
                    }

                    break;
            }

            return result;
        }

        /// <summary>
        /// 添加至计算式对象中
        /// </summary>
        /// <param name="ipt">输入</param>
        private void AddToFormula(char ipt)
        {
            AddToFormula(ipt.ToString());
        }

        /// <summary>
        /// 添加至计算式对象中
        /// </summary>
        /// <param name="ipt">输入</param>
        private void AddToFormula(string ipt)
        {
            if (isResult || isError)
            {
                ClearInputBox();
                Formula.Instance.Clear();
                state = InputState.Start;
                isResult = false;
                isError = false;
            }

            if (!CorrectInput(ipt))
            {
                return;
            }

            if (Formula.IsOperation(ipt))
            { // 修改 加进CorrectInput（）
                if (inputBox.Text.Length == 0)
                {
                    ipt = "0" + ipt;
                }
                else if (Formula.IsOperation(inputBox.Text[inputBox.Text.Length - 1]))
                {
                    inputBox.Text.Remove(inputBox.Text.Length - 1);
                    BackSpace();
                    AddToFormula(ipt);
                    return;
                }
            }

            if (AddInputBoxText(ipt))
            {
                Console.WriteLine("stateStackCount:" + stateStack.Count);
                Formula.Instance.AddStr(ipt);
                UpdateAcBtnText();
            }
        }

        /// <summary>
        /// 历史记录滚动事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void PanelHis_Scroll(object sender, ScrollEventArgs e) // debug 用
        {
            Console.WriteLine(e.NewValue);
        }

        #region btn事件
        /// <summary>
        /// 百分号% 按键事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void BtnPrecent_Click(object sender, EventArgs e)
        {
            AddToFormula('%');
        }

        /// <summary>
        /// 除号 ÷按键事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void BtnDivi_Click(object sender, EventArgs e)
        {
            AddToFormula('÷');
        }

        /// <summary>
        /// 乘号×按键事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void BtnMult_Click(object sender, EventArgs e)
        {
            AddToFormula('×');
        }

        /// <summary>
        /// 减号-按键事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void BtnMinus_Click(object sender, EventArgs e)
        {
            AddToFormula('-');
        }

        /// <summary>
        /// 加号+按键事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddToFormula('+');
        }

        /// <summary>
        /// e自然对数按键事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void BtnE_Click(object sender, EventArgs e)
        {
            AddToFormula('e');
        }

        /// <summary>
        /// pi Π按键事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void BtnPi_Click(object sender, EventArgs e)
        {
            AddToFormula('π');
        }

        /// <summary>
        /// 数字0按键事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void Btn0_Click(object sender, EventArgs e)
        {
            AddToFormula('0');
        }

        /// <summary>
        /// 数字1按键事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void Btn1_Click(object sender, EventArgs e)
        {
            AddToFormula('1');
        }

        /// <summary>
        /// 数字2按键事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void Btn2_Click(object sender, EventArgs e)
        {
            AddToFormula('2');
        }

        /// <summary>
        /// 数字3按键事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void Btn3_Click(object sender, EventArgs e)
        {
            AddToFormula('3');
        }

        /// <summary>
        /// 数字4按键事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void Btn4_Click(object sender, EventArgs e)
        {
            AddToFormula('4');
        }

        /// <summary>
        /// 数字5按键事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void Btn5_Click(object sender, EventArgs e)
        {
            AddToFormula('5');
        }

        /// <summary>
        /// 数字6按键事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void Btn6_Click(object sender, EventArgs e)
        {
            AddToFormula('6');
        }

        /// <summary>
        /// 数字7按键事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void Btn7_Click(object sender, EventArgs e)
        {
            AddToFormula('7');
        }

        /// <summary>
        /// 数字8按键事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void Btn8_Click(object sender, EventArgs e)
        {
            AddToFormula('8');
        }

        /// <summary>
        /// 数字9按键事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void Btn9_Click(object sender, EventArgs e)
        {
            AddToFormula('9');
        }

        /// <summary>
        /// 小数点 . 按键事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void BtnDot_Click(object sender, EventArgs e)
        {
            AddToFormula('.');
        }

        /// <summary>
        /// sin按键事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void BtnSin_Click(object sender, EventArgs e)
        {
            AddToFormula("sin(");
        }

        /// <summary>
        /// cos按键事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void BtnCos_Click(object sender, EventArgs e)
        {
            AddToFormula("cos(");
        }

        /// <summary>
        /// tan按键事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void BtnTan_Click(object sender, EventArgs e)
        {
            AddToFormula("tan(");
        }

        /// <summary>
        /// lg按键事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void BtnLg_Click(object sender, EventArgs e)
        {
            AddToFormula("lg(");
        }

        /// <summary>
        /// ln按键事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void BtnLn_Click(object sender, EventArgs e)
        {
            AddToFormula("ln(");
        }

        /// <summary>
        /// 根号按键事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void BtnSqrt_Click(object sender, EventArgs e)
        {
            AddToFormula("√(");
        }

        /// <summary>
        /// 左括号（ 按键事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void BtnLBrace_Click(object sender, EventArgs e)
        {
            AddToFormula('(');
        }

        /// <summary>
        /// 右括号 ）按键事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void BtnRBrace_Click(object sender, EventArgs e)
        {
            AddToFormula(')');
        }

        #endregion
        /// <summary>
        /// 设置按键状态
        /// </summary>
        /// <param name="enable">true 开启，false 关闭</param>
        private void SetInputBtn(bool enable)
        {
            btn0.Enabled = enable;
            btn1.Enabled = enable;
            btn2.Enabled = enable;
            btn3.Enabled = enable;
            btn4.Enabled = enable;
            btn5.Enabled = enable;
            btn6.Enabled = enable;
            btn7.Enabled = enable;
            btn8.Enabled = enable;
            btn9.Enabled = enable;
            btnAdd.Enabled = enable;
            btnMinus.Enabled = enable;
            btnMult.Enabled = enable;
            btnPi.Enabled = enable;
            btnE.Enabled = enable;
            btnDivi.Enabled = enable;
            btnSin.Enabled = enable;
            btnCos.Enabled = enable;
            btnTan.Enabled = enable;
            btnLg.Enabled = enable;
            btnLn.Enabled = enable;
            btnRBrace.Enabled = enable;
            btnLBrace.Enabled = enable;
            btnPrecent.Enabled = enable;
        }
    }
}
