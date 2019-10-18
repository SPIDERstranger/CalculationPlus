using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//todo 可以考虑使用decimal
/// <summary>
/// 运算符优先级
/// </summary>
public enum OpLv
{
    None = 0,
    Small = 1,//+ -
    Middle = 2,// × ÷
    Large = 3,//pow
}
public enum OpType
{
    None = 0,
    Unary = 1,
    Binary = 2,
    Ternary = 3
}

public class Formula
{
    private static Formula instance;
    public static Formula Instance
    {
        get
        {
            if (instance == null)
                instance = new Formula();
            return instance;
        }
    }
    private List<string> formulaStr = new List<string>();
    private List<char> formulaChar = new List<char>();// todo 可以考虑使用局部变量
    private Stack<double> numStack = new Stack<double>();
    private Stack<string> operatStack = new Stack<string>();

    public void Clear()
    {
        formulaStr.Clear();
        formulaChar.Clear();
        numStack.Clear();
        operatStack.Clear();
    }
    public void AddStr(char a)
    {
        formulaStr.Add(a.ToString());
    }
    public void AddStr(string a)
    {
        formulaStr.Add(a);
    }
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
    public override string ToString()
    {
        return String.Join("", formulaStr);
    }
    public string getTop()
    {
        return formulaStr[formulaStr.Count - 1];
    }

    private int GetCharNumInList(char a, List<char> list)
    {
        int num = 0;
        foreach (var item in list)
        {
            if (item == a)
                num++;
        }
        return num;
    }

    public void Read()
    {
        try
        {
            formulaChar = String.Join("", formulaStr).ToCharArray().ToList();
            if (!CheckBracePair(formulaChar))
                throw new Exception("括号数量不匹配");
            Console.WriteLine(formulaChar.ToString());
            for (int i = 0; i < formulaChar.Count; i++)
            {
                string temp = "";
                if (IsNumber(formulaChar[i]))
                {
                    while (i < formulaChar.Count && IsNumber(formulaChar[i]))
                    {
                        temp += formulaChar[i++];
                    }
                    i--;
                    if (temp[temp.Length - 1] == '.')
                        temp += '0';
                    double t = Convert.ToDouble(temp);

                    numStack.Push(t);
                    Console.WriteLine(t);

                }
                else if (IsSpNumber(formulaChar[i]))
                {
                    numStack.Push(SpNumberToDouble(formulaChar[i]));
                }
                else if (IsOperation(formulaChar[i]))
                {//判断上一个符号的优先级 
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
                else if (IsBackOperation(formulaChar[i])) {
                    if(formulaChar[i]=='%')
                    {
                        double t = numStack.Pop();
                        t *= 0.01;
                        numStack.Push(t);
                    }
                    else if(formulaChar[i] == '!')
                    {
                        double t = numStack.Pop();
                        t= Factorial(t);
                        numStack.Push(t);
                    }
                }
                else // sin cos tan 根号  lg ln  括号
                {
                    {//todo 修改代码，优化
                        if (formulaChar[i] == 's'||formulaChar[i] == 'c'|| formulaChar[i] == 't')
                        {
                            string t = formulaChar[i++].ToString()+ formulaChar[i++].ToString() + formulaChar[i++].ToString();
                            operatStack.Push(t);
                        }
                        else if(formulaChar[i] =='l')
                        {
                            string t = formulaChar[i++].ToString() + formulaChar[i++].ToString();
                            operatStack.Push(t);
                        }else if(formulaChar[i] == '√')
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
                        {//todo 操作重复次数过多 ,需要优化
                            string op = operatStack.Pop();
                            double tp;
                            double n2 = numStack.Pop();
                            double n1 = numStack.Pop();
                            tp = Operate(n1, n2, op);
                            numStack.Push(tp);
                        }
                        operatStack.Pop();
                        if(operatStack.Count !=0&&IsFuntion(operatStack.Peek()))
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
    public double Calculate()
    {
        try
        {
            while (numStack.Count > 1)
            {
                //判断是否为运算符
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



    #region 静态方法
    public static double Factorial(double t)//todo 添加阶乘方法
    {
        return 1;
    }
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
    public static bool IsBackOperation(char a)
    {
        return a=='%'||a=='!';
    }
    public static bool IsNumber(char a)
    {
        return a >= '0' && a <= '9' || a == '.';
    }
    public static bool IsNumber(string a)
    {
        foreach (var item in a.ToCharArray())
        {
            if (!IsNumber(item))
                return false;
        }
        return true;
    }
    public static bool IsSpNumber(char a)
    {
        return a == 'e' || a == 'π';
    }
    public static double SpNumberToDouble(char a)
    {
        if (a == 'e')
            return Math.E;
        if (a == 'π')
            return Math.PI;
        return 0;
    }
    public static bool IsOperation(char a)
    {
        return a == '+' || a == '-' || a == '×' || a == '÷';
    }
    public static bool IsOperation(string a)
    {
        return IsOperation(a[0]);
    }
    public static bool IsFuntion(char a)
    {
        return a=='s'||a=='c'||a=='t'||a=='l'||a== '√';
    }
    public static bool IsFuntion(string a)
    {
        return a.Contains("sin") || a.Contains("cos") || a.Contains("tan") || a.Contains("lg") || a.Contains("ln")||a.Contains("√");
    }
    public static double Function(double n,string a)
    {
        double result = 0;
        switch(a)
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
    public static bool CheckBracePair(List<char> list)
    {
        int numL = 0;
        int numR = 0;
        foreach (var item in list)
        {
            if (item == '(')
                numL++;
            else if (item == ')')
                numR++;
        }
        return numR == numL;
    }
    public static bool CheckBracePair(string a)
    {
        return CheckBracePair(a.ToList());
    }
    public static OpLv GetOprationLevel(string op)
    {
        OpLv lv = OpLv.None;
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
    
}

