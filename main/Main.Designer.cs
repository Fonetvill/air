
namespace main
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.ViewFlightBtn = new System.Windows.Forms.Button();
            this.RegistrationBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.history = new System.Windows.Forms.Button();
            this.InfBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ticket_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(278, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добро пожаловать ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(654, 13);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(83, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Регистрация";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // ViewFlightBtn
            // 
            this.ViewFlightBtn.Location = new System.Drawing.Point(262, 158);
            this.ViewFlightBtn.Name = "ViewFlightBtn";
            this.ViewFlightBtn.Size = new System.Drawing.Size(240, 56);
            this.ViewFlightBtn.TabIndex = 2;
            this.ViewFlightBtn.Text = "Рейсы";
            this.ViewFlightBtn.UseVisualStyleBackColor = true;
            this.ViewFlightBtn.Click += new System.EventHandler(this.ViewFlightBtn_Click);
            // 
            // RegistrationBtn
            // 
            this.RegistrationBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RegistrationBtn.Location = new System.Drawing.Point(262, 268);
            this.RegistrationBtn.Name = "RegistrationBtn";
            this.RegistrationBtn.Size = new System.Drawing.Size(240, 56);
            this.RegistrationBtn.TabIndex = 3;
            this.RegistrationBtn.Text = "Регистрация на рейс";
            this.RegistrationBtn.UseVisualStyleBackColor = true;
            this.RegistrationBtn.Click += new System.EventHandler(this.RegistrationBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.history);
            this.panel1.Controls.Add(this.InfBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ticket_btn);
            this.panel1.Location = new System.Drawing.Point(626, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 390);
            this.panel1.TabIndex = 8;
            // 
            // history
            // 
            this.history.Location = new System.Drawing.Point(31, 168);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(102, 78);
            this.history.TabIndex = 12;
            this.history.Text = "История полётов";
            this.history.UseVisualStyleBackColor = true;
            this.history.Click += new System.EventHandler(this.history_Click);
            // 
            // InfBtn
            // 
            this.InfBtn.Location = new System.Drawing.Point(31, 252);
            this.InfBtn.Name = "InfBtn";
            this.InfBtn.Size = new System.Drawing.Size(102, 78);
            this.InfBtn.TabIndex = 9;
            this.InfBtn.Text = "Ввод личных данных";
            this.InfBtn.UseVisualStyleBackColor = true;
            this.InfBtn.Click += new System.EventHandler(this.InfBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(27, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 6;
            // 
            // ticket_btn
            // 
            this.ticket_btn.Location = new System.Drawing.Point(31, 83);
            this.ticket_btn.Name = "ticket_btn";
            this.ticket_btn.Size = new System.Drawing.Size(102, 78);
            this.ticket_btn.TabIndex = 9;
            this.ticket_btn.Text = "Билеты";
            this.ticket_btn.UseVisualStyleBackColor = true;
            this.ticket_btn.Click += new System.EventHandler(this.ticket_btn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RegistrationBtn);
            this.Controls.Add(this.ViewFlightBtn);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Основное окно";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button ViewFlightBtn;
        private System.Windows.Forms.Button RegistrationBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ticket_btn;
        private System.Windows.Forms.Button InfBtn;
        private System.Windows.Forms.Button history;
        public System.Windows.Forms.Label label2;
    }
}

