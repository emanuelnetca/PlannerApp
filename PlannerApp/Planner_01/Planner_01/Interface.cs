/**************************************************************************
 *                                                                        *
 *  File:        interface.cs                                             *
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
using Planner_01.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;


namespace Planner_01
{
    /// <summary>
    /// Clasa de interfata, de aici se controleaza intreaga aplicatie
    /// </summary>
    public partial class Interface : Form
    {

        private Button _currentButton;
        private Random _randomColor;
        private int _tempIndex;
        private Form _activeForm;


        /// <summary>
        /// Contructor
        /// </summary>
        public Interface()
        {
            InitializeComponent();
            _randomColor = new Random();
            closeCurrentButton.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
             
        }
        /// <summary>
        /// 2 dll-uri folosite pentru a schimba pozitia aplicatiei pe ecran
        /// </summary>
        [DllImport("user32.DLL", EntryPoint="ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        /// <summary>
        /// Metoda ce selecteaza culoarea interfatei random dintr-o lista de culori
        /// </summary>
        /// <returns>Returneaza culoarea</returns>
        private Color SelectThemeColor()
        {
            int index = _randomColor.Next(ThemeColor.colorList.Count);
            while (_tempIndex == index)
            {
                index = _randomColor.Next(ThemeColor.colorList.Count);
            }
            _tempIndex = index;
            string color = ThemeColor.colorList[index];
            return ColorTranslator.FromHtml(color);
        }
        /// <summary>
        /// Metoda ce schimba colarea din spatele butonului pentru a semnaliza ca acesta este selectat
        /// </summary>
        /// <param name="btnSender">Butonul selectat</param>
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (_currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    _currentButton = (Button)btnSender;
                    _currentButton.BackColor = color;
                    _currentButton.ForeColor = Color.White;
                    _currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    closeCurrentButton.Visible = true;
                }
            }
        }
        /// <summary>
        /// Metoda ce deselecteaza butoanele din meniu
        /// </summary>
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        /// <summary>
        /// Metoda ce deschide un alt form intr-un panou din form-ul curent
        /// </summary>
        /// <param name="childForm">Forum-ul ce v-a fi deschis</param>
        /// <param name="btnSender">Butonul ce a apelat aceasta functie</param>
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (_activeForm != null)
            {
                _activeForm.Close();
            }
            ActivateButton(btnSender);
            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(childForm);
            this.panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            menuTitle.Text = childForm.Text;
        }
        /// <summary>
        /// Metoda ce gestioneaza butonul 1. Afiseaza Calendarul.
        /// </summary>
        /// <param name="sender">Obiectul de unde este apelata metoda</param>
        /// <param name="e">Detalii despre eveniment-ul respectiv</param>
        private void menuButton1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormCalendar(), sender);
        }
        /// <summary>
        /// Metoda ce gestioneaza butonul 2. Afiseaza Help.
        /// </summary>
        /// <param name="sender">Obiectul de unde este apelata metoda</param>
        /// <param name="e">Detalii despre eveniment-ul respectiv</param>
        private void menuButton2_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "PlannerApp_User_Manual.chm");
        }
        /// <summary>
        /// Metoda ce gestioneaza butonul 4. Afiseaza About.
        /// </summary>
        /// <param name="sender">Obiectul de unde este apelata metoda</param>
        /// <param name="e">Detalii despre eveniment-ul respectiv</param>
        private void menuButton4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.About(), sender);
        }
        /// <summary>
        /// Metoda ce gestioneaza butonul 5. Inchide aplicatia.
        /// </summary>
        /// <param name="sender">Obiectul de unde este apelata metoda</param>
        /// <param name="e">Detalii despre eveniment-ul respectiv</param>
        private void menuButton5_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Aplicatie ce inchide forum-urile deschise si revine la starea initiala
        /// </summary>
        private void Reset()
        {
            DisableButton();
            menuTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            _currentButton = null;
            closeCurrentButton.Visible = false;
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
        /// Metoda ce readuce aplicatia la stadiul initial
        /// </summary>
        /// <param name="sender">Obiectul de unde este apelata metoda</param>
        /// <param name="e">Detalii despre eveniment-ul respectiv</param>
        private void closeCurrentButton_Click(object sender, EventArgs e)
        {
            if (_activeForm != null)
            {
                _activeForm.Close();
            }
            Reset();
        }
        /// <summary>
        /// Metoda ce inchide aplicatia
        /// </summary>
        /// <param name="sender">Obiectul de unde este apelata metoda</param>
        /// <param name="e">Detalii despre eveniment-ul respectiv</param>
        private void closeAppButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Metoda ce minimizeaza aplicatia
        /// </summary>
        /// <param name="sender">Obiectul de unde este apelata metoda</param>
        /// <param name="e">Detalii despre eveniment-ul respectiv</param>
        private void minimizeAppButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// Metoda ce gestioneaza timer-ul de pe forum-ul principal
        /// </summary>
        /// <param name="sender">Obiectul de unde este apelata metoda</param>
        /// <param name="e">Detalii despre eveniment-ul respectiv</param>
        private void Title_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToLongDateString();
        }
        /// <summary>
        /// Metoda ce updateaza timer-ul
        /// </summary>
        /// <param name="sender">Obiectul de unde este apelata metoda</param>
        /// <param name="e">Detalii despre eveniment-ul respectiv</param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }
}
