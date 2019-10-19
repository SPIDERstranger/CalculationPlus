using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculationPlus;
namespace CalculationPlus
{

    public enum InputState
    {
        Start,
        Num,
        DotNum,
        FinalNum,
        Operation,
    }





    // todo 负数问题，没有负数 ，解决方案，读取 - 作为数字 将 减法化为加法。 
    // todo 数字过长问题
    public partial class FormCal : Form
    {
        private bool isError = false;
        private bool isResult = false;
        private int hisLine = 0;
        private Stack<InputState> stateStack = new Stack<InputState>();
        private InputState state = InputState.Start;

        public FormCal()
        {
            InitializeComponent();
            Init();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                if (inputBox.Text.Length == 0)
                    return;
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
        private void btnAC_Click(object sender, EventArgs e)
        {
            if (inputBox.Text.Length == 0)
                ClearHistory();
            ClearInputBox();
            state = InputState.Start;
        }
        private void btnBS_Click(object sender, EventArgs e)
        {
            if (!isResult && !isError)
                BackSpace();
            else
                ClearInputBox();

        }

        public void Init()
        {
            ClearInputBox();
            ClearHistory();
            UpdateAcBtnText();
        }
        private void UpdateAcBtnText()
        {
            if (inputBox.Text == "")
                btnAC.Text = "AC";
            else
                btnAC.Text = "C";
        }
        private void BackSpace()
        {
            Formula.Instance.BackStr();
            SetInputBoxText(Formula.Instance.ToString());
            //if (stateStack.Count > 1)
            //{
            //    stateStack.Pop();
            //    state = stateStack.Peek();
            //}
            //else
            //{
            //    state = InputState.Start;
            //}
            if(stateStack.Count>1)
                stateStack.Pop();
            state  = stateStack.Peek();
            Console.WriteLine("pop after : state count "+stateStack.Count +" : "+ state);
        }
        private void UpdateState(InputState state)
        {
            Console.WriteLine("pushStack : " + state);
            this.state = state;
            stateStack.Push(state);
        }
        private void AddHistory(string formula, double result)
        {//todo 设置长度和长度
            labelHis.Text += formula + " = " + result + "\n";
            hisLine += 1;
            labelHis.Size = new System.Drawing.Size(labelHis.Size.Width, hisLine * 26);
            labelHis.Location = new Point(labelHis.Location.X, labelHis.Location.Y - (26));
            Console.WriteLine(labelHis.Size.ToString() + labelHis.Location.ToString());
            panelHis.AutoScrollMinSize = new Size(0, hisLine * 26);
            panelHis.AutoScrollPosition = new Point(0, hisLine * 26);
        }
        private void ClearHistory()
        {
            labelHis.Size = new Size(630, 0);
            labelHis.Location = new Point(-308, 168);
            labelHis.Text = "";
            panelHis.AutoScrollMinSize = new Size(0, 0);
            panelHis.AutoScrollPosition = new Point(0, 0);
            Formula.Instance.Clear();
        }
        private void ClearStateStack()
        {
            stateStack.Clear();
            UpdateState(InputState.Start);
        }
        private void ClearInputBox()
        {
            ClearStateStack();
            inputBox.Font = new Font("Microsoft Sans Serif", 36F);
            SetInputBoxText();
            Formula.Instance.Clear();
            UpdateAcBtnText();
        }
        private void SetInputBoxText(string str = "")
        {
            inputBox.Text = str;
        }
        private bool AddInputBoxText(string str)
        {
            // todo动态调整字体大小 最大 字体 36pt 最小 18pt
            int length = inputBox.Text.Length;

            if (length + str.Length > 46)
            {
                //无输入或者关闭所有输入
                return false;
            }
            else if (length + str.Length > 11)
            {
                inputBox.Font = new Font("Microsoft Sans Serif", 18F);//可以更加顺滑的动态调整
            }
            inputBox.Text += str;

            return true;
        }
        private bool CorrectInput(string str)  //状态可能有重复，可以优化
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
                            UpdateState(InputState.DotNum);
                        else
                            UpdateState(InputState.Num);
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



        private void AddToFormula(char ipt)
        {
            AddToFormula(ipt.ToString());
        }
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
                return;
            if (Formula.IsOperation(ipt)) // 修改 加进CorrectInput（）
            {
                if (inputBox.Text.Length == 0)
                    ipt = "0" + ipt;
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

        private void panelHis_Scroll(object sender, ScrollEventArgs e)//debug 用
        {
            Console.WriteLine(e.NewValue);
        }

        #region btn事件

        private void btnPrecent_Click(object sender, EventArgs e)
        {
            AddToFormula('%');
        }

        private void btnDivi_Click(object sender, EventArgs e)
        {
            AddToFormula('÷');
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            AddToFormula('×');
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            AddToFormula('-');
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddToFormula('+');
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            AddToFormula('e');
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            AddToFormula('π');
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            AddToFormula('0');
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            AddToFormula('1');
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            AddToFormula('2');
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            AddToFormula('3');
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            AddToFormula('4');
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            AddToFormula('5');
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            AddToFormula('6');
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            AddToFormula('7');
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            AddToFormula('8');
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            AddToFormula('9');
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            AddToFormula('.');
        }
        private void btnSin_Click(object sender, EventArgs e)
        {
            AddToFormula("sin(");
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            AddToFormula("cos(");
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            AddToFormula("tan(");
        }

        private void btnLg_Click(object sender, EventArgs e)
        {
            AddToFormula("lg(");
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            AddToFormula("ln(");
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            AddToFormula("√(");
        }

        private void btnLBrace_Click(object sender, EventArgs e)
        {
            AddToFormula('(');

        }

        private void btnRBrace_Click(object sender, EventArgs e)
        {
            AddToFormula(')');

        }

        #endregion
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
