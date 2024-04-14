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
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.NET
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        private static NhanVien_BUS nv_bus = new NhanVien_BUS();
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
            ////Get local host name and IP
            //string hostName = Dns.GetHostName();
            //string IP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            ////MessageBox.Show(IP);

            //SqlConnection conn = new SqlConnection();
            //bool isExist = false;
            ////Check QLBHX database existence
            //conn.ConnectionString = @"Data Source="+IP+ @"\SQLEXPRESS; Network Library=DBMSSOCN; Integrated Security=True;";
            //try
            //{
            //    using (conn)
            //    {
            //        conn.Open();
            //        using (SqlCommand cmd = new SqlCommand("SELECT name from sys.databases", conn))
            //        {
            //            using (SqlDataReader dr = cmd.ExecuteReader())
            //            {
            //                while (dr.Read())
            //                {
            //                    string dbName = dr[0].ToString();
            //                    if (dbName.Contains("QLBHX"))
            //                    {
            //                        isExist = true;
            //                        break;
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    //Close connection if opened
            //    if (conn.State != ConnectionState.Closed)
            //    {
            //        conn.Close();
            //    }
            //}

            ////Create database if not exists
            //if (!isExist)
            //{

            //    conn.ConnectionString = @"Data Source="+IP+@"\SQLEXPRESS;
            //                            AttachDbFilename=" + Directory.GetCurrentDirectory() + @"\db\QLBHX.mdf;
            //                            Integrated Security=True;
            //                            User Instance=True;";
            //    try
            //    {
            //        conn.Open();
            //        MessageBox.Show("Connect Success!");
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //    finally
            //    {
            //        //Close connection if opened
            //        if (conn.State != ConnectionState.Closed)
            //        {
            //            conn.Close();
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Database is already existed");
            //}
            //nv_bus = new NhanVien_BUS();
            try
            {
                dgvDSNhanVien.DataSource = nv_bus.LayDanhSach();
            }catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Thông báo lỗi !");
            }
        }
    }
}