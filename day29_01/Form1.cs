using System;
using System.Data;
using System.Data.SqlClient; //서버연결
using System.Windows.Forms;

namespace day29_01
{
    public partial class Form1 : Form
    {

        SqlConnection conn = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_ACCESS_Click(object sender, EventArgs e)
        {
            //서버 연결
            String ConnectionString;
            ConnectionString = "server=.\\CSHARPSEVER;" + "database=" + TXT_DB_NAME + ";" + "user id=" + TXT_ID + ";" + "pwd=" + TXT_PWD + ";";
            if(conn!= null) conn.Dispose();
            conn = new SqlConnection(ConnectionString);
            /*
            conn = new SqlConnection();
            conn.ConnectionString = "server=.\\CSHARPSEVER;" + "database=" + TXT_DB_NAME + ";" + "user id=" + TXT_ID + ";" + "pwd=" + TXT_PWD + ";";
            */

            if (conn != null) TXT_SERVER_STAT.Text = "연결되었습니다";
            else TXT_SERVER_STAT.Text = "해제되었습니다";
        }

        private void BTN_DB_OPEN_Click(object sender, EventArgs e)
        {
            conn.Open();
            if(conn.State == ConnectionState.Open)
            {
                MessageBox.Show("DB를 열었습니다.");
            }
            else
            {
                MessageBox.Show("DB를 찾을 수 없습니다.");
            }
        }

        private void BTN_DB_CLOSE_Click(object sender, EventArgs e)
        {
            conn.Close();
            if (conn.State == ConnectionState.Closed)
            {
                MessageBox.Show("DB를 열었습니다.");
            }
            else
            {
                MessageBox.Show("DB를 찾을 수 없습니다.");
            }
        }

        private void BTN_SERVER_CLOSE_Click(object sender, EventArgs e)
        {
            conn.Dispose();
            TXT_SERVER_STAT.Text = "해제";
            MessageBox.Show("해제되었습니다");
        }
    }
}
