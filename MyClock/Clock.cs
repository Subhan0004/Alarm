using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace MyClock
{
    public partial class AlarmApp : Form
    {

        public AlarmApp()
        {
            InitializeComponent();
        }

        private void Clock_Load(object sender, EventArgs e)
        {
            timer_now.Start();
        }

        #region buttonset
        private void btn_set_Click(object sender, EventArgs e)
        {
            timer_alarm.Start();
            if (string.IsNullOrEmpty(cb_snooze.Text))
            {
                MessageBox.Show("Please select the time", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (!rb_alarm1.Checked && !rb_alarm2.Checked)
                MessageBox.Show("Please select melody", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                lbl_status.Visible = true;
                lbl_status.Text = "Status: Alarm is Set!";
            }
        }
        #endregion

        private void timer_now_Tick(object sender, EventArgs e)
        {
            tb_now.Text = DateTime.Now.ToLongTimeString();
        }

        #region timeralarm
        private void timer_alarm_Tick(object sender, EventArgs e)
        {
            if (tb_now.Text == dt_picker.Text)
            {

                timer_alarm.Stop();
                lbl_status.Visible = true;
                lbl_status.Text = "Status: Alarm is On!";
                
                if (rb_alarm1.Checked)
                {
                    Alarm1();
                }
                else if (rb_alarm2.Checked)
                {
                    Alarm2();
                }
            }
        }
        #endregion

        #region waiting
        public static void waiting3_1()
        {
            Melody.Melody1_stop();
            System.Threading.Thread.Sleep(3000);
        }
        public static void waiting3_2()
        {
            Melody.Melody2_stop();
            System.Threading.Thread.Sleep(3000);
        }

        public static void waiting5_1()
        {
            Melody.Melody1_stop();
            System.Threading.Thread.Sleep(5000);
        }
        public static void waiting5_2()
        {
            Melody.Melody2_stop();
            System.Threading.Thread.Sleep(5000);
        }
        public static void waiting7_1()
        {
            Melody.Melody1_stop();
            System.Threading.Thread.Sleep(7000);
        }
        public static void waiting7_2()
        {
            Melody.Melody2_stop();
            System.Threading.Thread.Sleep(7000);
        }
        #endregion

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            timer_alarm.Stop();
            Melody.Melody1_stop();
            Melody.Melody2_stop();
            rb_alarm1.Checked = false;
            rb_alarm2.Checked = false;
            lbl_status.Visible = true;
            lbl_status.Text = "Status: Alarm is Canceled!";
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Alarm 1
        //Alarm1 is for Melody1
        public void Alarm1()
        {
            Melody.Melody1_play();
            string message = "Do you want to close the alarm?";
            string title = "Close Window";
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, button, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Melody.Melody1_stop();
            }
            else
            {
                if (cb_snooze.SelectedIndex == cb_snooze.FindStringExact("3 seconds"))
                {
                    waiting3_1();
                    for (; ; )
                    {
                        Melody.Melody1_play();
                        MessageBoxButtons button1 = MessageBoxButtons.YesNo;
                        DialogResult result1 = MessageBox.Show(message, title, button1, MessageBoxIcon.Question);
                        if (result1 == DialogResult.Yes)
                        {
                            Melody.Melody1_stop();
                            break;
                        }
                        else
                        {
                            waiting3_1();
                        }
                    }
                }
                else if (cb_snooze.SelectedIndex == cb_snooze.FindStringExact("5 seconds"))
                {
                    waiting5_1();
                    for (; ; )
                    {
                        Melody.Melody1_play();
                        MessageBoxButtons button1 = MessageBoxButtons.YesNo;
                        DialogResult result1 = MessageBox.Show(message, title, button1, MessageBoxIcon.Question);
                        if (result1 == DialogResult.Yes)
                        {
                            Melody.Melody1_stop();
                            break;
                        }
                        else
                        {
                            waiting5_1();
                        }
                    }
                }
                else if (cb_snooze.SelectedIndex == cb_snooze.FindStringExact("7 seconds"))
                {
                    waiting7_1();
                    for (; ; )
                    {
                        Melody.Melody1_play();
                        MessageBoxButtons button1 = MessageBoxButtons.YesNo;
                        DialogResult result1 = MessageBox.Show(message, title, button1, MessageBoxIcon.Question);
                        if (result1 == DialogResult.Yes)
                        {
                            Melody.Melody1_stop();
                            break;
                        }
                        else
                        {
                            waiting7_1();
                        }
                    }
                }
            }
        }
        #endregion

        #region Alarm 2
        //Alarm2 is for Melody2
        public void Alarm2()
        {
            //Yes==Dismiss && No=Snooze
            Melody.Melody2_play();
            string message = "Do you want to close the alarm?";
            string title = "Close Window";
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, button, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Melody.Melody2_stop();
            }
            else
            {
                if (cb_snooze.SelectedIndex == cb_snooze.FindStringExact("3 seconds"))
                {
                    waiting3_2();
                    for (; ; )
                    {
                        Melody.Melody2_play();
                        MessageBoxButtons button1 = MessageBoxButtons.YesNo;
                        DialogResult result1 = MessageBox.Show(message, title, button1, MessageBoxIcon.Question);
                        if (result1 == DialogResult.Yes)
                        {
                            Melody.Melody2_stop();
                            break;
                        }
                        else
                        {
                            waiting3_2();
                        }
                    }
                }
                else if (cb_snooze.SelectedIndex == cb_snooze.FindStringExact("5 seconds"))
                {
                    waiting5_2();
                    for (; ; )
                    {
                        Melody.Melody2_play();
                        MessageBoxButtons button1 = MessageBoxButtons.YesNo;
                        DialogResult result1 = MessageBox.Show(message, title, button1, MessageBoxIcon.Question);
                        if (result1 == DialogResult.Yes)
                        {
                            Melody.Melody2_stop();
                            break;
                        }
                        else
                        {
                            waiting5_2();
                        }
                    }
                }
                else if (cb_snooze.SelectedIndex == cb_snooze.FindStringExact("7 seconds"))
                {
                    waiting7_2();
                    for (; ; )
                    {
                        Melody.Melody2_play();
                        MessageBoxButtons button1 = MessageBoxButtons.YesNo;
                        DialogResult result1 = MessageBox.Show(message, title, button1, MessageBoxIcon.Question);
                        if (result1 == DialogResult.Yes)
                        {
                            Melody.Melody2_stop();
                            break;
                        }
                        else
                        {
                            waiting7_2();
                        }
                    }
                }

            }
        }
        #endregion
    }
}

