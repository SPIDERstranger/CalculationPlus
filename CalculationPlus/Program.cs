//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="none">
//     Copyright (c) Sprocket Enterprises. All rights reserved.
// </copyright>
// <author>Lin jiawei</author>
//-----------------------------------------------------------------------
namespace CalculationPlus
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// 程序入口
    /// </summary>
   public static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormCal formCal = new FormCal();
            Application.Run(formCal);
        }
    }
}
