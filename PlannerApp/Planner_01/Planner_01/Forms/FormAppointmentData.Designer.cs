
namespace Planner_01.Forms
{
    partial class FormAppointmentData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAppointmentData));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelDate = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelNotes = new System.Windows.Forms.Label();
            this.richTextBoxNotes = new System.Windows.Forms.RichTextBox();
            this.labelIdeas = new System.Windows.Forms.Label();
            this.richTextBoxIdeas = new System.Windows.Forms.RichTextBox();
            this.labelTodo = new System.Windows.Forms.Label();
            this.richTextBoxTodo = new System.Windows.Forms.RichTextBox();
            this.panelRigthAppointments = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.closeAppButton = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelRigthAppointments.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.labelDate);
            this.flowLayoutPanel1.Controls.Add(this.textBoxTitle);
            this.flowLayoutPanel1.Controls.Add(this.labelNotes);
            this.flowLayoutPanel1.Controls.Add(this.richTextBoxNotes);
            this.flowLayoutPanel1.Controls.Add(this.labelIdeas);
            this.flowLayoutPanel1.Controls.Add(this.richTextBoxIdeas);
            this.flowLayoutPanel1.Controls.Add(this.labelTodo);
            this.flowLayoutPanel1.Controls.Add(this.richTextBoxTodo);
            this.flowLayoutPanel1.Controls.Add(this.panelRigthAppointments);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 39);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(518, 626);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // labelDate
            // 
            this.labelDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(3, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(129, 23);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "label1";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(138, 3);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(372, 20);
            this.textBoxTitle.TabIndex = 14;
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.Location = new System.Drawing.Point(3, 26);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(35, 13);
            this.labelNotes.TabIndex = 7;
            this.labelNotes.Text = "Notes";
            // 
            // richTextBoxNotes
            // 
            this.richTextBoxNotes.Location = new System.Drawing.Point(44, 29);
            this.richTextBoxNotes.Name = "richTextBoxNotes";
            this.richTextBoxNotes.Size = new System.Drawing.Size(468, 173);
            this.richTextBoxNotes.TabIndex = 8;
            this.richTextBoxNotes.Text = "";
            // 
            // labelIdeas
            // 
            this.labelIdeas.AutoSize = true;
            this.labelIdeas.Location = new System.Drawing.Point(3, 205);
            this.labelIdeas.Name = "labelIdeas";
            this.labelIdeas.Size = new System.Drawing.Size(33, 13);
            this.labelIdeas.TabIndex = 9;
            this.labelIdeas.Text = "Ideas";
            // 
            // richTextBoxIdeas
            // 
            this.richTextBoxIdeas.Location = new System.Drawing.Point(42, 208);
            this.richTextBoxIdeas.Name = "richTextBoxIdeas";
            this.richTextBoxIdeas.Size = new System.Drawing.Size(468, 173);
            this.richTextBoxIdeas.TabIndex = 10;
            this.richTextBoxIdeas.Text = "";
            // 
            // labelTodo
            // 
            this.labelTodo.AutoSize = true;
            this.labelTodo.Location = new System.Drawing.Point(3, 384);
            this.labelTodo.Name = "labelTodo";
            this.labelTodo.Size = new System.Drawing.Size(35, 13);
            this.labelTodo.TabIndex = 11;
            this.labelTodo.Text = "To do";
            // 
            // richTextBoxTodo
            // 
            this.richTextBoxTodo.Location = new System.Drawing.Point(44, 387);
            this.richTextBoxTodo.Name = "richTextBoxTodo";
            this.richTextBoxTodo.Size = new System.Drawing.Size(468, 173);
            this.richTextBoxTodo.TabIndex = 12;
            this.richTextBoxTodo.Text = "";
            // 
            // panelRigthAppointments
            // 
            this.panelRigthAppointments.Controls.Add(this.buttonSubmit);
            this.panelRigthAppointments.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelRigthAppointments.Location = new System.Drawing.Point(3, 566);
            this.panelRigthAppointments.Name = "panelRigthAppointments";
            this.panelRigthAppointments.Size = new System.Drawing.Size(518, 59);
            this.panelRigthAppointments.TabIndex = 13;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.mainPanel.Controls.Add(this.closeAppButton);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(518, 37);
            this.mainPanel.TabIndex = 2;
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // closeAppButton
            // 
            this.closeAppButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeAppButton.FlatAppearance.BorderSize = 0;
            this.closeAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeAppButton.Image = ((System.Drawing.Image)(resources.GetObject("closeAppButton.Image")));
            this.closeAppButton.Location = new System.Drawing.Point(463, 0);
            this.closeAppButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeAppButton.Name = "closeAppButton";
            this.closeAppButton.Size = new System.Drawing.Size(55, 37);
            this.closeAppButton.TabIndex = 3;
            this.closeAppButton.UseVisualStyleBackColor = true;
            this.closeAppButton.Click += new System.EventHandler(this.closeAppButton_Click_1);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmit.Location = new System.Drawing.Point(227, 14);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(64, 25);
            this.buttonSubmit.TabIndex = 4;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // FormAppointmentData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 665);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAppointmentData";
            this.Text = "FormAppointmentData";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panelRigthAppointments.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.RichTextBox richTextBoxNotes;
        private System.Windows.Forms.Label labelIdeas;
        private System.Windows.Forms.RichTextBox richTextBoxIdeas;
        private System.Windows.Forms.Label labelTodo;
        private System.Windows.Forms.RichTextBox richTextBoxTodo;
        private System.Windows.Forms.Panel panelRigthAppointments;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button closeAppButton;
        private System.Windows.Forms.Button buttonSubmit;
    }
}