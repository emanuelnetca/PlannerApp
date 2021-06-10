/**************************************************************************
 *                                                                        *
 *  File:        FormCalendar.cs                                          *
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
using System.Text;
using System.Windows.Forms;

namespace Planner_01.Forms
{
    /// <summary>
    /// Clasa ce gestioneaza calendarul
    /// </summary>
    public partial class FormCalendar : Form
    {
        private DateTime _currentDate;
        /// <summary>
        /// Contructorul
        /// </summary>
        public FormCalendar()
        {
            InitializeComponent();

            _currentDate = DateTime.Today;


            //labelMonthAndYearCalendar.Text = $"{GetTheLastDayOfMonth()}";
        }
        /// <summary>
        /// Metoda ce returneaza prima zi a lunii
        /// </summary>
        /// <returns>Prima zi a lunii</returns>
        private int GetFirstDayOfMonth()
        {
            DateTime firstDayOfMonth = new DateTime(_currentDate.Year, _currentDate.Month, 1);
            return (int)(firstDayOfMonth.DayOfWeek + 1);
        }
        /// <summary>
        /// Metoda ce returneaza ultima zi a lunii
        /// </summary>
        /// <returns>Ultima zi a lunii</returns>
        private int GetTheLastDayOfMonth()
        {
            DateTime lastDayOfMonth = new DateTime(_currentDate.Year, _currentDate.Month, DateTime.DaysInMonth(_currentDate.Year, _currentDate.Month));
            return (int)(lastDayOfMonth.DayOfWeek + 1);
        }
        /// <summary>
        /// Metoda ce updateaza calendarul in functie de luna aleasa
        /// </summary>
        private void UpdateCalendarFormData()
        {
            flowLayoutPanelDays.Controls.Clear();

            labelMonthAndYearCalendar.Text = _currentDate.ToString("MMMM, yyyy");

            int dayNumber = DateTime.DaysInMonth(_currentDate.Year, _currentDate.Month);
            int firstDayOfMonth = GetFirstDayOfMonth();
            for (int i = 1; i < dayNumber + firstDayOfMonth + (7 - GetTheLastDayOfMonth()); ++i)
            {
                FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
                // dolar da eroare in altova
                flowLayoutPanel.Name = $"flowLayoutPanelDay{i - firstDayOfMonth + 1}";
                flowLayoutPanel.Width = 140;

                if (i >= firstDayOfMonth && i < dayNumber + firstDayOfMonth)
                {
                    flowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

                    Label label = new Label();
                    label.Name = $"label{flowLayoutPanel.Name}";
                    label.Text = $"{i - firstDayOfMonth + 1}";
                    label.Width = 130;
                    label.TextAlign = ContentAlignment.MiddleRight;
                    label.Font = new Font("Microsoft Sans Serif", 12);
                    flowLayoutPanel.Controls.Add(label);

                    Label labelDate = new Label();
                    labelDate.Name = $"labelDate{flowLayoutPanel.Name}";
                    labelDate.Text = $"{_currentDate.Month}/{i - firstDayOfMonth + 1}/{_currentDate.Year}";
                    labelDate.Visible = false;
                    flowLayoutPanel.Controls.Add(labelDate);
                  
                    flowLayoutPanel.Click += delegate
                    {
                        try {
                            Appointment appointment = new Appointment($"{labelDate.Text}");
                            appointment.ShowDialog();
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show("Nu se poate face conexiunea la baza de date");
                        }
                    };
               

                }
                flowLayoutPanelDays.Controls.Add(flowLayoutPanel);
                if (DateTime.Now.Day ==  i - firstDayOfMonth + 1 && DateTime.Now.Month == _currentDate.Month)
                {
                    flowLayoutPanel.BackColor = ThemeColor.PrimaryColor;
                    flowLayoutPanel.ForeColor = Color.White;
                }

            }
        }
        /// <summary>
        /// Metoda ce se peleaza la incarcarea forum-ului
        /// </summary>
        /// <param name="sender">Obiectul de unde este apelata metoda</param>
        /// <param name="e">Detalii despre eveniment-ul respectiv</param>
        private void FormCalendar_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        /// <summary>
        /// Metoda ce gestioneaza culorile forum-ului
        /// </summary>
        private void LoadTheme()
        {
            buttonToday.ForeColor = Color.White;
            buttonToday.BackColor = ThemeColor.PrimaryColor;
            buttonToday.FlatAppearance.BorderColor = ThemeColor.PrimaryColor;

            buttonPrevious.ForeColor = Color.White;
            buttonPrevious.BackColor = ThemeColor.SecondaryColor;
            buttonPrevious.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

            buttonNext.ForeColor = Color.White;
            buttonNext.BackColor = ThemeColor.SecondaryColor;
            buttonNext.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;


            labelSunday.ForeColor = Color.White;
            labelSunday.BackColor= ThemeColor.PrimaryColor;
            labelMonday.ForeColor = Color.White;
            labelMonday.BackColor = ThemeColor.SecondaryColor;
            labelTuesday.ForeColor = Color.White;
            labelTuesday.BackColor = ThemeColor.PrimaryColor;
            labelWednesday.ForeColor = Color.White;
            labelWednesday.BackColor = ThemeColor.SecondaryColor;
            labelThursday.ForeColor = Color.White;
            labelThursday.BackColor = ThemeColor.PrimaryColor;
            labelFriday.ForeColor = Color.White;
            labelFriday.BackColor = ThemeColor.SecondaryColor;
            labelSaturday.ForeColor = Color.White;
            labelSaturday.BackColor = ThemeColor.PrimaryColor; //->>Culori Label

            UpdateCalendarFormData();
        }
        /// <summary>
        /// Metoda cemodifica luna afisata cu cea precedenta lunii curente
        /// </summary>
        /// <param name="sender">Obiectul de unde este apelata metoda</param>
        /// <param name="e">Detalii despre eveniment-ul respectiv</param>
        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            _currentDate = _currentDate.AddMonths(-1);
            UpdateCalendarFormData();
        }
        /// <summary>
        /// Metoda cemodifica luna afisata cu cea urmatoare lunii curente
        /// </summary>
        /// <param name="sender">Obiectul de unde este apelata metoda</param>
        /// <param name="e">Detalii despre eveniment-ul respectiv</param>
        private void buttonNext_Click(object sender, EventArgs e)
        {
            _currentDate = _currentDate.AddMonths(1);
            UpdateCalendarFormData();
        }
        /// <summary>
        /// Metoda ce afiseaza calendarul din luna curenta
        /// </summary>
        /// <param name="sender">Obiectul de unde este apelata metoda</param>
        /// <param name="e">Detalii despre eveniment-ul respectiv</param>
        private void buttonToday_Click(object sender, EventArgs e)
        {
            _currentDate = DateTime.Today;
            UpdateCalendarFormData();
        }
    }
}
