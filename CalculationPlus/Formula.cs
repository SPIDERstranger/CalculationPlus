//-----------------------------------------------------------------------
// <copyright file="Formula.cs" company="none">
//     Copyright (c) Sprocket Enterprises. All rights reserved.
// </copyright>
// <author>Lin jiawei</author>
//-----------------------------------------------------------------------
namespace CalculationPlus
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // todo 可以考虑使用decimal

    /// <summary>
    /// 运算符优先级
    /// </summary>
    public enum OpLv
    {
        /// <summary>
        /// 无
        /// </summary>
        None = 0,

        /// <summary>
        ///  + - 的优先级
        /// </summary>
        Small = 1,

        /// <summary>
        ///  × ÷ 的优先级
        /// </summary>
        Middle = 2,

        /// <summary>
        /// 幂运算规则优先级
        /// </summary>
        Large = 3,
    }

    /// <summary>
    /// 操作符类型
    /// </summary>
    public enum OpType
    {
        /// <summary>
        /// 无
        /// </summary>
        None = 0,

        /// <summary>
        /// 一元运算符
        /// </summary>
        Unary = 1,

        /// <summary>
        /// 二元运算符
        /// </summary>
        Binary = 2,

        /// <summary>
        /// 三元运算符
        /// </summary>
        Ternary = 3
    }

    /// <summary>
    /// 计算式类
    /// </summary>
    public class Formula
    {
        /// <summary>
        /// formula单例
        /// </summary>
        private static Formula instance;

        /// <summary>
        /// 录入时暂存的列表
        /// </summary>
        private List<string> formulaStr = new List<string>();

        /// <summary>
        /// char列表，暂存
        /// </summary>
        private List<char> formulaChar = new List<char>(); // todo 可以考虑使用局部变量

        /// <summary>
        /// 数字栈
        /// </summary>
        private Stack<double> numStack = new Stack<double>();

        /// <summary>
        /// 操作符栈
        /// </summary>
        private Stack<string> operatStack = new Stack<string>();

        /// <summary>
        /// Gets  formula单例
        /// </summary>
        public static Formula Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Formula();
                }

                return instance;
            }
        }

        #region 静态方法
        /// <summary>
        /// 阶乘函数
        /// </summary>
        /// <param name="t">num</param>
        /// <returns>阶乘结果</returns>
        public static double Factorial(double t) // todo 添加阶乘方法
        {
            return 1;
        }

        /// <summary>
        /// 计算两个数字
        /// </summary>
        /// <param name="a">数字1</param>
        /// <param name="b">数字2</param>
        /// <param name="op">操作</param>
        /// <returns>计算结果</returns>
        public static double Operate(double a, double b, string op)
        {
            double result = 0;
            switch (op)
            {
                case "+":
                    result = a + b;
                    break;

                case "-":
                    result = a - b;
                    break;

                case "×":
                    result = a * b;
                    break;

                case "÷":
                    result = a / b;
                    break;
            }

            return result;
        }

        /// <summary>
        /// 判断是否是后置的运算符
        /// </summary>
        /// <param name="a">char</param>
        /// <returns>判断结果</returns>
        public static bool IsBackOperation(char a)
        {
            return a == '%' || a == '!';
        }

        /// <summary>
        /// 判断是否是数字
        /// </summary>
        /// <param name="a">char</param>
        /// <returns>判断结果</returns>
        public static bool IsNumber(char a)
        {
            return a >= '0' && (a <= '9' || a == '.');
        }

        /// <summary>
        /// 判断是否是数字
        /// </summary>
        /// <param name="a">str</param>
        /// <returns>判断结果</returns>
        public static bool IsNumber(string a)
        {
            foreach (var item in a.ToCharArray())
            {
                if (!IsNumber(item))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// 判断是否是e或Π
        /// </summary>
        /// <param name="a">char</param>
        /// <returns>判断结果</returns>
        public static bool IsSpNumber(char a)
        {
            return a == 'e' || a == 'π';
        }

        /// <summary>
        /// 将特殊数字转成double类型
        /// </summary>
        /// <param name="a">char</param>
        /// <returns>结果</returns>
        public static double SpNumberToDouble(char a)
        {
            if (a == 'e')
            {
                return Math.E;
            }

            if (a == 'π')
            {
                return Math.PI;
            }

            return 0;
        }

        /// <summary>
        /// 判断是否是操作符
        /// </summary>
        /// <param name="a">char</param>
        /// <returns>判断结果</returns>
        public static bool IsOperation(char a)
        {
            return a == '+' || a == '-' || a == '×' || a == '÷';
        }

        /// <summary>
        /// 判断是否是运算符
        /// </summary>
        /// <param name="a">str</param>
        /// <returns>判断结果</returns>
        public static bool IsOperation(string a)
        {
            return IsOperation(a[0]);
        }

        /// <summary>
        /// 判断是否是函数
        /// </summary>
        /// <param name="a">函数char</param>
        /// <returns>判断结果</returns>
        public static bool IsFuntion(char a)
        {
            return a == 's' || a == 'c' || a == 't' || a == 'l' || a == '√';
        }

        /// <summary>
        /// 判断是否是函数
        /// </summary>
        /// <param name="a">string</param>
        /// <returns>判断结果</returns>
        public static bool IsFuntion(string a)
        {
            return a.Contains("sin") || a.Contains("cos") || a.Contains("tan") || a.Contains("lg") || a.Contains("ln") || a.Contains("√");
        }

        /// <summary>
        /// 运算函数
        /// </summary>
        /// <param name="n">需要计算数字</param>
        /// <param name="a">函数</param>
        /// <returns>计算结果</returns>
        public static double Function(double n, string a)
        {
            double result = 0;
            switch (a)
            {
                case "sin":
                    result = Math.Sin(n);
                    break;
                case "cos":
                    result = Math.Cos(n);
                    break;
                case "tan":
                    result = Math.Tan(n);
                    break;
                case "lg":
                    result = Math.Log10(n);
                    break;
                case "ln":
                    result = Math.Log(n);
                    break;
                case "√":
                    result = Math.Sqrt(n);
                    break;
            }

            return result;
        }

        /// <summary>
        /// 判断是否是配对的括号
        /// </summary>
        /// <param name="list">列表</param>
        /// <returns>判断结果</returns>
        public static bool CheckBracePair(List<char> list)
        {
            int numL = 0;
            int numR = 0;
            foreach (var item in list)
            {
                if (item == '(')
                {
                    numL++;
                }
                else if (item == ')')
                {
                    numR++;
                }
            }

            return numR == numL;
        }

        /// <summary>
        /// 判断是否是配对的括号
        /// </summary>
        /// <param name="a">str</param>
        /// <returns>判断结果</returns>
        public static bool CheckBracePair(string a)
        {
            return CheckBracePair(a.ToList());
        }

        /// <summary>
        /// 判断操作符的优先级
        /// </summary>
        /// <param name="op">操作符</param>
        /// <returns>优先级</returns>
        public static OpLv GetOprationLevel(string op)
        {
            OpLv lv;
            switch (op)
            {
                case "+":
                    lv = OpLv.Small;
                    break;
                case "-":
                    lv = OpLv.Small;
                    break;
                case "×":
                    lv = OpLv.Middle;
                    break;
                case "÷":
                    lv = OpLv.Middle;
                    break;
                case "^":
                    lv = OpLv.Large;
                    break;
                default:
                    lv = OpLv.None;
                    break;
            }

            return lv;
        }
        #endregion

        /// <summary>
        /// 清理当前对象状态
        /// </summary>
        public void Clear()
        {
            formulaStr.Clear();
            formulaChar.Clear();
            numStack.Clear();
            operatStack.Clear();
        }

        /// <summary>
        /// 添加char进入formulastr栈
        /// </summary>
        /// <param name="a">char</param>
        public void AddStr(char a)
        {
            formulaStr.Add(a.ToString());
        }

        /// <summary>
        /// 添加str进入formulastr栈
        /// </summary>
        /// <param name="a">str</param>
        public void AddStr(string a)
        {
            formulaStr.Add(a);
        }

        /// <summary>
        /// 退格
        /// </summary>
        /// <returns>删除的str</returns>
        public string BackStr()
        {
            if (formulaStr.Count > 0)
            {
                string back = formulaStr[formulaStr.Count - 1];
                formulaStr.RemoveAt(formulaStr.Count - 1);
                return back;
            }

            return null;
        }

        /// <summary>
        /// 覆写tostring
        /// </summary>
        /// <returns>返回输入到formula的字符串</returns>
        public override string ToString()
        {
            return string.Join(string.Empty, formulaStr);
        }

        /// <summary>
        /// 获取最后输入的按钮
        /// </summary>
        /// <returns>最后的按钮</returns>
        public string GetTop()
        {
            if (formulaStr.Count > 0)
            {
                return formulaStr[formulaStr.Count - 1];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 读取计算式的记录，并等待执行计算
        /// </summary>
        public void Read()
        {
            try
            {
                formulaChar = string.Join(string.Empty, formulaStr).ToCharArray().ToList();

                if (!CheckBracePair(formulaChar))
                {
                    throw new Exception("括号数量不匹配");
                }

                Console.WriteLine(formulaChar.ToString());
                for (int i = 0; i < formulaChar.Count; i++)
                {
                    string temp = string.Empty;
                    if (IsNumber(formulaChar[i]))
                    {
                        while (i < formulaChar.Count && IsNumber(formulaChar[i]))
                        {
                            temp += formulaChar[i++];
                        }

                        i--;
                        if (temp[temp.Length - 1] == '.')
                        {
                            temp += '0';
                        }

                        double t = Convert.ToDouble(temp);

                        numStack.Push(t);
                        Console.WriteLine(t);
                    }
                    else if (IsSpNumber(formulaChar[i]))
                    {
                        numStack.Push(SpNumberToDouble(formulaChar[i]));
                    }
                    else if (IsOperation(formulaChar[i]))
                    { // 判断上一个符号的优先级 
                        if (operatStack.Count > 0 && GetOprationLevel(formulaChar[i].ToString()) <= GetOprationLevel(operatStack.Peek()))
                        {
                            double tp;
                            double n2 = numStack.Pop();
                            double n1 = numStack.Pop();
                            string op = operatStack.Pop();
                            tp = Operate(n1, n2, op);
                            numStack.Push(tp);
                            operatStack.Push(formulaChar[i].ToString());
                        }
                        else
                        {
                            operatStack.Push(formulaChar[i].ToString());
                        }
                    }
                    else if (IsBackOperation(formulaChar[i]))
                    {
                        if (formulaChar[i] == '%')
                        {
                            double t = numStack.Pop();
                            t *= 0.01;
                            numStack.Push(t);
                        }
                        else if (formulaChar[i] == '!')
                        {
                            double t = numStack.Pop();
                            t = Factorial(t);
                            numStack.Push(t);
                        }
                    }
                    else
                    { // sin cos tan 根号  lg ln  括号
                        { // todo 修改代码，优化
                            if (formulaChar[i] == 's' || formulaChar[i] == 'c' || formulaChar[i] == 't')
                            {
                                string t = formulaChar[i++].ToString() + formulaChar[i++].ToString() + formulaChar[i++].ToString();
                                operatStack.Push(t);
                            }
                            else if (formulaChar[i] == 'l')
                            {
                                string t = formulaChar[i++].ToString() + formulaChar[i++].ToString();
                                operatStack.Push(t);
                            }
                            else if (formulaChar[i] == '√')
                            {
                                operatStack.Push(formulaChar[i++].ToString());
                            }
                        }

                        if (formulaChar[i] == '(')
                        {
                            operatStack.Push(formulaChar[i].ToString());
                        }
                        else if (formulaChar[i] == ')')
                        {
                            while (operatStack.Peek() != "(")
                            { // todo 操作重复次数过多 ,需要优化
                                string op = operatStack.Pop();
                                double tp;
                                double n2 = numStack.Pop();
                                double n1 = numStack.Pop();
                                tp = Operate(n1, n2, op);
                                numStack.Push(tp);
                            }

                            operatStack.Pop();
                            if (operatStack.Count != 0 && IsFuntion(operatStack.Peek()))
                            {
                                double t = numStack.Pop();
                                string op = operatStack.Pop();
                                t = Function(t, op);
                                numStack.Push(t);
                            }
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 计算式读取后执行计算
        /// </summary>
        /// <returns>计算式的结果</returns>
        public double Calculate()
        {
            try
            {
                while (numStack.Count > 1)
                {
                    // 判断是否为运算符
                    double tp;
                    double n2 = numStack.Pop();
                    double n1 = numStack.Pop();
                    string op = operatStack.Pop();
                    tp = Operate(n1, n2, op);
                    numStack.Push(tp);
                }

                return numStack.Pop();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 获取在列表中某个char的数量
        /// </summary>
        /// <param name="a">char</param>
        /// <param name="list">查找的列表</param>
        /// <returns>数量</returns>
        private int GetCharNumInList(char a, List<char> list)
        {
            int num = 0;
            foreach (var item in list)
            {
                if (item == a)
                {
                    num++;
                }
            }

            return num;
        }
    }
}