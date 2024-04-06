using BUS;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.NET
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        private static NhanVien_BUS nv_bus;
        public Form1()
        {
            InitializeComponent();
        }
        private void tileBar_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            navigationFrame.SelectedPageIndex = tileBarGroupTables.Items.IndexOf(e.Item);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            bool isExist = false;
            //Check QLBHX database existence
            conn.ConnectionString = @"Data Source=.\SQLEXPRESS; Integrated Security=True;";
            try
            {
                using (conn)
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT name from sys.databases", conn))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                string dbName = dr[0].ToString();
                                if (dbName.Contains("QLBHX"))
                                {
                                    isExist = true;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Close connection if opened
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }

            //Create database if not exists
            if(!isExist)
            {

                conn.ConnectionString = @"Data Source=.\SQLEXPRESS;
                          AttachDbFilename=" + Directory.GetCurrentDirectory() + @"\db\QLBHX.mdf;
                          Integrated Security=True;";
                try
                {
                    conn.Open();
                    MessageBox.Show("Connect Success!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    //Close connection if opened
                    if (conn.State != ConnectionState.Closed)
                    {
                        conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Database is already existed");
            }

            //string startPath = Directory.GetCurrentDirectory();
            //MessageBox.Show(startPath);
            nv_bus = new NhanVien_BUS();
            dgvDSNhanVien.DataSource = nv_bus.LayDanhSach();
        }
    }
}