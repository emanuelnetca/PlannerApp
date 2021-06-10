/**************************************************************************
 *                                                                        *
 *  File:        FormAppointmentData.cs                                   *
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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseConnection;
using MySqlConnector;

namespace Planner_01.Forms
{
    /// <summary>
    /// Clasa ce gestioneaza o ora dintr-o zi
    /// </summary>
    public partial class FormAppointmentData : Form
    {
        private Database _db = Database.Instance;
        private MySqlDataAdapter _adapter = new MySqlDataAdapter();
        private DataTable _table = new DataTable();
        private string _taskDate = "";
        private string _taskHour = "";
        private string _taskTitle = "";
        private string _taskNotes = "";
        private string _taskIdeas = "";
        private string _taskTodo = "";

        /// <summary>
        /// 2 dll-uri folosite pentru a schimba pozitia aplicatiei pe ecran
        /// </summary>
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        /// <summary>
        /// Constructorul
        /// </summary>
        public FormAppointmentData()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Constructorul cu argumente
        /// </summary>
        /// <param name="taskDate"></param>
        /// <param name="taskHour"></param>
        /// <param name="taskTitle"></param>
        /// <param name="taskNotes"></param>
        /// <param name="taskIdeas"></param>
        /// <param name="taskTodo"></param>
        public FormAppointmentData(string taskDate, string taskHour, string taskTitle, string taskNotes, string taskIdeas, string taskTodo)
        {
            InitializeComponent();
            _taskDate = taskDate;
            _taskHour = taskHour;
            _taskTitle = taskTitle;
            _taskNotes = taskNotes;
            _taskIdeas = taskIdeas;
            _taskTodo = taskTodo;
            UpdateFormData();
            mainPanel.BackColor = ThemeColor.PrimaryColor;
            labelDate.BackColor= ThemeColor.SecondaryColor;
            labelDate.ForeColor = Color.White;
            buttonSubmit.BackColor = ThemeColor.PrimaryColor;
            buttonSubmit.ForeColor = Color.White;
        }
        /// <summary>
        /// Metoda ce updateaza text box-urile din interfata
        /// </summary>
        private void UpdateFormData()
        {
            labelDate.Text = _taskDate + " -- " + _taskHour;
            textBoxTitle.Text = _taskTitle;
            richTextBoxIdeas.Text = _taskIdeas;
            richTextBoxNotes.Text = _taskNotes;
            richTextBoxTodo.Text = _taskTodo;
        }
        /// <summary>
        /// Metoda ce permite user-ului sa miste fereastra pe ecran
        /// </summary>
        /// <param name="sender">Obiectul de unde este apelata metoda</param>
        /// <param name="e">Detalii despre eveniment-ul respectiv</param>
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string[] array = _taskDate.Split('-');
            try
            {
                MySqlCommand command = new MySqlCommand("REPLACE INTO tasks(TaskDate, TaskHour, TaskTitle, TaskNotes, TaskIdeas, TaskToDo) VALUES('" + array[2].ToString() + "-" + array[0].ToString() + "-" + array[1].ToString() + $"', '{_taskHour}', '{textBoxTitle.Text}', '{richTextBoxNotes.Text}', '{richTextBoxIdeas.Text}', '{richTextBoxTodo.Text}')", _db.getConnection());

                _adapter.SelectCommand = command;
                _adapter.Fill(_table);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        /// <summary>
        /// Metoda ce permite user-ului sa miste fereastra pe ecran
        /// </summary>
        /// <param name="sender">Obiectul de unde este apelata metoda</param>
        /// <param name="e">Detalii despre eveniment-ul respectiv</param>
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        /// <summary>
        /// Metoda ce inchide aplicatia
        /// </summary>
        /// <param name="sender">Obiectul de unde este apelata metoda</param>
        /// <param name="e">Detalii despre eveniment-ul respectiv</param>
        private void closeAppButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
