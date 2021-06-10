/**************************************************************************
 *                                                                        *
 *  File:        Program.cs                                               *
 *  Copyright:   (c) 2021, Bojoga Andrei,                                 *
 *                         Balauta Laurnetiu-Stefan,                      *
 *                         Bejenariu Razvan-Marius,                       *
 *                         Netca Emanuel-Codrin                           *
 *  E-mail:      @student.tuiasi.ro                                       *
 *  Website:     N/A                                                      *
 *  Description: PlannerApp provides a planning application that offers   *
 *               its users a personal and enriching way of optimizing     *
 *               their time. The user can make plans according to their   *
 *               personal program on a daily basis, easy to track and     *
 *               in depth.                                                *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Planner_01
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Interface());
        }
    }
}
