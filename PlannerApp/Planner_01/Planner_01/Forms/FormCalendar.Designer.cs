
namespace Planner_01.Forms
{
    partial class FormCalendar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelMonthAndYearCalendar = new System.Windows.Forms.Label();
            this.panelNextPreviousButtons = new System.Windows.Forms.Panel();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonToday = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.panelDaysName = new System.Windows.Forms.Panel();
            this.labelSaturday = new System.Windows.Forms.Label();
            this.labelFriday = new System.Windows.Forms.Label();
            this.labelThursday = new System.Windows.Forms.Label();
            this.labelWednesday = new System.Windows.Forms.Label();
            this.labelTuesday = new System.Windows.Forms.Label();
            this.labelMonday = new System.Windows.Forms.Label();
            this.labelSunday = new System.Windows.Forms.Label();
            this.flowLayoutPanelDays = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTop.SuspendLayout();
            this.panelNextPreviousButtons.SuspendLayout();
            this.panelDaysName.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.labelMonthAndYearCalendar);
            this.panelTop.Controls.Add(this.panelNextPreviousButtons);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1033, 42);
            this.panelTop.TabIndex = 0;
            // 
            // labelMonthAndYearCalendar
            // 
            this.labelMonthAndYearCalendar.AutoSize = true;
            this.labelMonthAndYearCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonthAndYearCalendar.Location = new System.Drawing.Point(3, 9);
            this.labelMonthAndYearCalendar.Name = "labelMonthAndYearCalendar";
            this.labelMonthAndYearCalendar.Size = new System.Drawing.Size(149, 25);
            this.labelMonthAndYearCalendar.TabIndex = 1;
            this.labelMonthAndYearCalendar.Text = "January, 2021";
            // 
            // panelNextPreviousButtons
            // 
            this.panelNextPreviousButtons.Controls.Add(this.buttonNext);
            this.panelNextPreviousButtons.Controls.Add(this.buttonToday);
            this.panelNextPreviousButtons.Controls.Add(this.buttonPrevious);
            this.panelNextPreviousButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelNextPreviousButtons.Location = new System.Drawing.Point(802, 0);
            this.panelNextPreviousButtons.Name = "panelNextPreviousButtons";
            this.panelNextPreviousButtons.Size = new System.Drawing.Size(231, 42);
            this.panelNextPreviousButtons.TabIndex = 0;
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Location = new System.Drawing.Point(159, 12);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(35, 23);
            this.buttonNext.TabIndex = 4;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonToday
            // 
            this.buttonToday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToday.Location = new System.Drawing.Point(89, 12);
            this.buttonToday.Name = "buttonToday";
            this.buttonToday.Size = new System.Drawing.Size(64, 23);
            this.buttonToday.TabIndex = 3;
            this.buttonToday.Text = "Today";
            this.buttonToday.UseVisualStyleBackColor = true;
            this.buttonToday.Click += new System.EventHandler(this.buttonToday_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrevious.Location = new System.Drawing.Point(48, 12);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(35, 23);
            this.buttonPrevious.TabIndex = 2;
            this.buttonPrevious.Text = "<";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // panelDaysName
            // 
            this.panelDaysName.Controls.Add(this.labelSaturday);
            this.panelDaysName.Controls.Add(this.labelFriday);
            this.panelDaysName.Controls.Add(this.labelThursday);
            this.panelDaysName.Controls.Add(this.labelWednesday);
            this.panelDaysName.Controls.Add(this.labelTuesday);
            this.panelDaysName.Controls.Add(this.labelMonday);
            this.panelDaysName.Controls.Add(this.labelSunday);
            this.panelDaysName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDaysName.Location = new System.Drawing.Point(0, 42);
            this.panelDaysName.Name = "panelDaysName";
            this.panelDaysName.Size = new System.Drawing.Size(1033, 35);
            this.panelDaysName.TabIndex = 1;
            // 
            // labelSaturday
            // 
            this.labelSaturday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSaturday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelSaturday.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaturday.Location = new System.Drawing.Point(883, 0);
            this.labelSaturday.Name = "labelSaturday";
            this.labelSaturday.Size = new System.Drawing.Size(140, 35);
            this.labelSaturday.TabIndex = 6;
            this.labelSaturday.Text = "Saturday";
            this.labelSaturday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFriday
            // 
            this.labelFriday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFriday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelFriday.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriday.Location = new System.Drawing.Point(737, 0);
            this.labelFriday.Name = "labelFriday";
            this.labelFriday.Size = new System.Drawing.Size(140, 35);
            this.labelFriday.TabIndex = 5;
            this.labelFriday.Text = "Friday";
            this.labelFriday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelThursday
            // 
            this.labelThursday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelThursday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelThursday.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThursday.Location = new System.Drawing.Point(591, 0);
            this.labelThursday.Name = "labelThursday";
            this.labelThursday.Size = new System.Drawing.Size(140, 35);
            this.labelThursday.TabIndex = 4;
            this.labelThursday.Text = "Thursday";
            this.labelThursday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWednesday
            // 
            this.labelWednesday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelWednesday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelWednesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWednesday.Location = new System.Drawing.Point(445, 0);
            this.labelWednesday.Name = "labelWednesday";
            this.labelWednesday.Size = new System.Drawing.Size(140, 35);
            this.labelWednesday.TabIndex = 3;
            this.labelWednesday.Text = "Wednesday";
            this.labelWednesday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTuesday
            // 
            this.labelTuesday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTuesday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelTuesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTuesday.Location = new System.Drawing.Point(299, 0);
            this.labelTuesday.Name = "labelTuesday";
            this.labelTuesday.Size = new System.Drawing.Size(140, 35);
            this.labelTuesday.TabIndex = 2;
            this.labelTuesday.Text = "Tuesday";
            this.labelTuesday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMonday
            // 
            this.labelMonday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMonday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelMonday.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonday.Location = new System.Drawing.Point(153, 0);
            this.labelMonday.Name = "labelMonday";
            this.labelMonday.Size = new System.Drawing.Size(140, 35);
            this.labelMonday.TabIndex = 1;
            this.labelMonday.Text = "Monday";
            this.labelMonday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSunday
            // 
            this.labelSunday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSunday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelSunday.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSunday.Location = new System.Drawing.Point(7, 0);
            this.labelSunday.Name = "labelSunday";
            this.labelSunday.Size = new System.Drawing.Size(140, 35);
            this.labelSunday.TabIndex = 0;
            this.labelSunday.Text = "Sunday";
            this.labelSunday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanelDays
            // 
            this.flowLayoutPanelDays.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelDays.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelDays.Location = new System.Drawing.Point(0, 77);
            this.flowLayoutPanelDays.Name = "flowLayoutPanelDays";
            this.flowLayoutPanelDays.Size = new System.Drawing.Size(1033, 521);
            this.flowLayoutPanelDays.TabIndex = 2;
            // 
            // FormCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 598);
            this.Controls.Add(this.flowLayoutPanelDays);
            this.Controls.Add(this.panelDaysName);
            this.Controls.Add(this.panelTop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCalendar";
            this.Load += new System.EventHandler(this.FormCalendar_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelNextPreviousButtons.ResumeLayout(false);
            this.panelDaysName.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelMonthAndYearCalendar;
        private System.Windows.Forms.Panel panelNextPreviousButtons;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonToday;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Panel panelDaysName;
        private System.Windows.Forms.Label labelSaturday;
        private System.Windows.Forms.Label labelFriday;
        private System.Windows.Forms.Label labelThursday;
        private System.Windows.Forms.Label labelWednesday;
        private System.Windows.Forms.Label labelTuesday;
        private System.Windows.Forms.Label labelMonday;
        private System.Windows.Forms.Label labelSunday;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDays;
    }
}