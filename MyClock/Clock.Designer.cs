
namespace MyClock
{
    partial class AlarmApp
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_snooze = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_status = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_ml = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rb_alarm2 = new System.Windows.Forms.RadioButton();
            this.rb_alarm1 = new System.Windows.Forms.RadioButton();
            this.btn_exit = new System.Windows.Forms.Button();
            this.dt_picker = new System.Windows.Forms.DateTimePicker();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_set = new System.Windows.Forms.Button();
            this.lblalarm = new System.Windows.Forms.Label();
            this.lblnow = new System.Windows.Forms.Label();
            this.tb_now = new System.Windows.Forms.TextBox();
            this.timer_alarm = new System.Windows.Forms.Timer(this.components);
            this.timer_now = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cornsilk;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.cb_snooze);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lbl_ml);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.dt_picker);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_set);
            this.panel1.Controls.Add(this.lblalarm);
            this.panel1.Controls.Add(this.lblnow);
            this.panel1.Controls.Add(this.tb_now);
            this.panel1.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(221, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 429);
            this.panel1.TabIndex = 0;
            // 
            // cb_snooze
            // 
            this.cb_snooze.FormattingEnabled = true;
            this.cb_snooze.Items.AddRange(new object[] {
            "3 seconds",
            "5 seconds",
            "7 seconds"});
            this.cb_snooze.Location = new System.Drawing.Point(161, 228);
            this.cb_snooze.Name = "cb_snooze";
            this.cb_snooze.Size = new System.Drawing.Size(200, 29);
            this.cb_snooze.TabIndex = 15;
            this.cb_snooze.Text = "3 seconds";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Snooze:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel4.Controls.Add(this.lbl_status);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 397);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(567, 32);
            this.panel4.TabIndex = 13;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(6, 0);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(198, 22);
            this.lbl_status.TabIndex = 6;
            this.lbl_status.Text = "Status: Alarm is not Set.";
            this.lbl_status.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(567, 26);
            this.panel3.TabIndex = 12;
            // 
            // lbl_ml
            // 
            this.lbl_ml.AutoSize = true;
            this.lbl_ml.Location = new System.Drawing.Point(54, 127);
            this.lbl_ml.Name = "lbl_ml";
            this.lbl_ml.Size = new System.Drawing.Size(76, 22);
            this.lbl_ml.TabIndex = 11;
            this.lbl_ml.Text = "Melody:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rb_alarm2);
            this.panel2.Controls.Add(this.rb_alarm1);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(161, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 86);
            this.panel2.TabIndex = 10;
            // 
            // rb_alarm2
            // 
            this.rb_alarm2.AutoSize = true;
            this.rb_alarm2.Location = new System.Drawing.Point(19, 34);
            this.rb_alarm2.Name = "rb_alarm2";
            this.rb_alarm2.Size = new System.Drawing.Size(107, 26);
            this.rb_alarm2.TabIndex = 1;
            this.rb_alarm2.TabStop = true;
            this.rb_alarm2.Text = "Melody 2";
            this.rb_alarm2.UseVisualStyleBackColor = true;
            // 
            // rb_alarm1
            // 
            this.rb_alarm1.AutoSize = true;
            this.rb_alarm1.Location = new System.Drawing.Point(19, 4);
            this.rb_alarm1.Name = "rb_alarm1";
            this.rb_alarm1.Size = new System.Drawing.Size(107, 26);
            this.rb_alarm1.TabIndex = 0;
            this.rb_alarm1.TabStop = true;
            this.rb_alarm1.Text = "Melody 1";
            this.rb_alarm1.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Location = new System.Drawing.Point(409, 108);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(85, 31);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // dt_picker
            // 
            this.dt_picker.CalendarTitleBackColor = System.Drawing.SystemColors.Control;
            this.dt_picker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dt_picker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dt_picker.Location = new System.Drawing.Point(161, 74);
            this.dt_picker.Name = "dt_picker";
            this.dt_picker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dt_picker.ShowCheckBox = true;
            this.dt_picker.ShowUpDown = true;
            this.dt_picker.Size = new System.Drawing.Size(200, 29);
            this.dt_picker.TabIndex = 1;
            this.dt_picker.Value = new System.DateTime(2021, 3, 29, 17, 58, 0, 0);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Location = new System.Drawing.Point(409, 67);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(85, 35);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_set
            // 
            this.btn_set.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_set.FlatAppearance.BorderSize = 0;
            this.btn_set.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_set.Location = new System.Drawing.Point(409, 28);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(85, 35);
            this.btn_set.TabIndex = 7;
            this.btn_set.Text = "Set";
            this.btn_set.UseVisualStyleBackColor = true;
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // lblalarm
            // 
            this.lblalarm.AutoSize = true;
            this.lblalarm.Location = new System.Drawing.Point(20, 80);
            this.lblalarm.Name = "lblalarm";
            this.lblalarm.Size = new System.Drawing.Size(110, 22);
            this.lblalarm.TabIndex = 3;
            this.lblalarm.Text = "Alarm Time:";
            // 
            // lblnow
            // 
            this.lblnow.AutoSize = true;
            this.lblnow.Location = new System.Drawing.Point(6, 41);
            this.lblnow.Name = "lblnow";
            this.lblnow.Size = new System.Drawing.Size(124, 22);
            this.lblnow.TabIndex = 1;
            this.lblnow.Text = "Current Time:";
            // 
            // tb_now
            // 
            this.tb_now.BackColor = System.Drawing.SystemColors.Control;
            this.tb_now.Location = new System.Drawing.Point(161, 34);
            this.tb_now.Name = "tb_now";
            this.tb_now.ReadOnly = true;
            this.tb_now.Size = new System.Drawing.Size(200, 29);
            this.tb_now.TabIndex = 0;
            this.tb_now.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer_alarm
            // 
            this.timer_alarm.Tick += new System.EventHandler(this.timer_alarm_Tick);
            // 
            // timer_now
            // 
            this.timer_now.Tick += new System.EventHandler(this.timer_now_Tick);
            // 
            // AlarmApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(995, 592);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "AlarmApp";
            this.Text = "AlarmApp";
            this.Load += new System.EventHandler(this.Clock_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblalarm;
        private System.Windows.Forms.Label lblnow;
        private System.Windows.Forms.TextBox tb_now;
        private System.Windows.Forms.Button btn_set;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Timer timer_alarm;
        private System.Windows.Forms.Timer timer_now;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.DateTimePicker dt_picker;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rb_alarm2;
        private System.Windows.Forms.RadioButton rb_alarm1;
        private System.Windows.Forms.Label lbl_ml;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_snooze;
    }
}

