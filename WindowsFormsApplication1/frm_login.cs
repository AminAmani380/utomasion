using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using WindowsFormsApplication1.Admin_panel;


namespace WindowsFormsApplication1
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void labelX2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelX3_Click(object sender, EventArgs e)
        {

        }

        private void مذ_Click(object sender, EventArgs e)
        {

        }

        private void labelX4_Click(object sender, EventArgs e)
        {

        }

        private void labelX4_Click_1(object sender, EventArgs e)
        {

        }

        private void labelX3_Click_1(object sender, EventArgs e)
        {

        }

        private void labelX5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxX2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            if(txt_username.Text == "admin" && txt_password.Text == "1")
            {
                this.Close();

                
            }
            else
            {
                MessageBox.Show("کاربری یافت نشد");
            }



        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            //show date
            System.Globalization.Calendar PC = new System.Globalization.PersianCalendar();
            lbl_date.Text = (PC.GetYear(DateTime.Now) + " / " + PC.GetMonth(DateTime.Now) + " / " + PC.GetDayOfMonth(DateTime.Now));


            //show IP
            string computerName = System.Environment.MachineName;
            string IP = "";
            object IPHostEntity = "";
            IPHostEntry ipe = Dns.GetHostByName(computerName);
            IPAddress[] IpAdress = ipe.AddressList;
            lbl_ip.Text = IpAdress[0].ToString();




            //show time
            timer1_Tick(sender,e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;

            lbl_clock.Text = DateTime.Now.Hour + " : " + DateTime.Now.Minute + " : " + DateTime.Now.Second;
            lbl_clock.Refresh(); 
        }

        private void rdb_user_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
