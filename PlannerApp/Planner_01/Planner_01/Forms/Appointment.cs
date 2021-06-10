/**************************************************************************
 *                                                                        *
 *  File:        Appointment.cs                                           *
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
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using DatabaseConnection;
using MySqlConnector;

namespace Planner_01.Forms
{
    /// <summary>
    /// Clasa ce gestioneaza planul pe o zi. De aici se poate accesa si modifica planul pe orice ora din zi. 
    /// </summary>
    public partial class Appointment : Form
    {
        private Database _db = Database.Instance;
        private MySqlDataAdapter _adapter = new MySqlDataAdapter();
        private DataTable _table = new DataTable();
        private string _taskDate = "";
        /// <summary>
        /// 2 dll-uri folosite pentru a schimba pozitia aplicatiei pe ecran
        /// </summary>
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        /// <summary>
        /// Constructorul simplu
        /// </summary>
        public Appointment()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Constructorul
        /// </summary>
        /// <param name="taskDate">Data pe care se lucreaza</param>
        public Appointment(string taskDate)
        {
            InitializeComponent();
            _taskDate = taskDate;
            mainPanel.BackColor= ThemeColor.SecondaryColor;
        }
        /// <summary>
        /// Metoda ce afiseaza orele si denumirea task-urilor din ele daca exista
        /// </summary>
        private void UpdateFromData()
        {
            flowLayoutPanelTasksForToday.Controls.Clear();

            for (int i = 0; i < 24; ++i)
            {
                FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();

                // dolar da eroare in altova
                flowLayoutPanel.Name = $"flowLayoutPanelTaskHour{i}";
                flowLayoutPanel.Width = 60;
                flowLayoutPanel.Height = 20;

                Label label = new Label();
                label.Name = $"label{flowLayoutPanel.Name}";
                if (i < 10)
                {
                    label.Text = $"0{i}:00";
                    label.ForeColor = Color.White;
                    if (i % 2 == 0)
                        label.BackColor = ThemeColor.PrimaryColor;
                    else
                        label.BackColor = ThemeColor.SecondaryColor;
                }
                else
                {
                    label.Text = $"{i}:00";
                    label.ForeColor = Color.White;
                    if (i%2==0)
                        label.BackColor = ThemeColor.PrimaryColor;
                    else
                        label.BackColor = ThemeColor.SecondaryColor;

                }
                label.Width = 60;
                label.Height = 18;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Font = new Font("Microsoft Sans Serif", 8);
                flowLayoutPanel.Controls.Add(label);

                string notes = "";
                string ideas = "";
                string todo = "";

                TextBox textBox = new TextBox();
                textBox.Name = $"textBox{flowLayoutPanel.Name}";
                textBox.Text = FindTheTask(i, ref notes, ref ideas, ref todo);
                textBox.TextAlign = HorizontalAlignment.Left;
                textBox.Font = new Font("Microsoft Sans Serif", 8);
                textBox.Width = 445;
                textBox.Click += delegate
                {
                    FormAppointmentData appointmentData = new FormAppointmentData(_taskDate.Replace("/", "-"), label.Text, textBox.Text, notes, ideas, todo);
                    appointmentData.ShowDialog();

                };

                flowLayoutPanelTasksForToday.Controls.Add(flowLayoutPanel);
                flowLayoutPanelTasksForToday.Controls.Add(textBox);
            }

        }
        /// <summary>
        /// Metoda ce incarca datele pentru o anumita ora din baza de date
        /// </summary>
        /// <param name="hour"></param>
        /// <param name="notes"></param>
        /// <param name="ideas"></param>
        /// <param name="todo"></param>
        /// <returns>Returneaza datele din ora respectiva sau nimic in caz contrar</returns>
        private string FindTheTask(int hour, ref string notes, ref string ideas, ref string todo)
        {
            string stringHour;
            if (hour < 10)
            {
                stringHour = "0" + hour.ToString();
            }
            else
            {
                stringHour = hour.ToString();
            }
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM tasks", _db.getConnection());

                _adapter.SelectCommand = cmd;
                _adapter.Fill(_table);

                for (int i = 0; i < _table.Rows.Count; ++i)
                {
                    if (stringHour == _table.Rows[i][1].ToString().Substring(0, 2) && _table.Rows[i][0].ToString().Substring(0, _taskDate.Length) == _taskDate)
                    {

                        // labelHourSql.Text = _table.Rows[i][2].ToString().Substring(0, 2);
                        notes = _table.Rows[i][3].ToString();
                        ideas = _table.Rows[i][4].ToString();
                        todo = _table.Rows[i][5].ToString();
                        return _table.Rows[i][2].ToString();
                    }
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            return "----------";
        }
        /// <summary>
        /// Metoda ce se executa la pornirea forum-ului
        /// </summary>
        /// <param name="sender">Obiectul de unde este apelata metoda</param>
        /// <param name="e">Detalii despre eveniment-ul respectiv</param>
        private void Appointment_Load(object sender, EventArgs e)
        {
            UpdateFromData();
        }
        /// <summary>
        /// Metoda ce inchide aplicatia
        /// </summary>
        /// <param name="sender">Obiectul de unde este apelata metoda</param>
        /// <param name="e">Detalii despre eveniment-ul respectiv</param>
        private void closeAppButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
