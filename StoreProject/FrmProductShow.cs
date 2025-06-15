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

namespace StoreProject
{
    public partial class FrmProductShow : Form
    {
        public FrmProductShow()
        {
            InitializeComponent();
        }
        //เมธอดแปลง Binnary เป็น รูป
        private Image convertByteArrayToImage(byte[] byteArrayIn)
        {
            if (byteArrayIn == null || byteArrayIn.Length == 0)
            {
                return null;
            }
            try
            {
                using (MemoryStream ms = new MemoryStream(byteArrayIn))
                {
                    return Image.FromStream(ms);
                }
            }
            catch (ArgumentException ex)
            {
                // อาจเกิดขึ้นถ้า byte array ไม่ใช่ข้อมูลรูปภาพที่ถูกต้อง
                Console.WriteLine("Error converting byte array to image: " + ex.Message);
                return null;
            }
        }
        private void getAllProductToLV()
        {
            //Connect String เพื่อติดต่อไปยังฐานข้อมูล
            string connectionString = @"Server=DESKTOP-9U4FO0V\SQLEXPRESS;Database=store_db;Trusted_Connection=True;";

            //สร้าง Connection ไปยังฐานข้อมูล
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    string strSQL = "SELECT proId, proName, proPrice, proQuan, proUnit, proStatus, proImage FROM [store_db].[dbo].[product_tb]";

                    using(SqlDataAdapter dataAdapter = new SqlDataAdapter(strSQL, sqlConnection))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        lvAllProduct.Items.Clear();
                        lvAllProduct.Columns.Clear();
                        lvAllProduct.FullRowSelect = true;
                        lvAllProduct.View = View.Details;

                        if (lvAllProduct.SmallImageList == null)
                        {
                            lvAllProduct.SmallImageList = new ImageList();
                            lvAllProduct.SmallImageList.ImageSize = new Size(50, 50);
                            lvAllProduct.SmallImageList.ColorDepth = ColorDepth.Depth32Bit;
                        }
                        lvAllProduct.SmallImageList.Images.Clear();

                        lvAllProduct.Columns.Add("รูปภาพ", 100, HorizontalAlignment.Left);
                        lvAllProduct.Columns.Add("รหัสสินค้า", 100, HorizontalAlignment.Left);
                        lvAllProduct.Columns.Add("ชื่อสินค้า", 240, HorizontalAlignment.Left);
                        lvAllProduct.Columns.Add("ราคา", 70, HorizontalAlignment.Right);
                        lvAllProduct.Columns.Add("จำนวน", 70, HorizontalAlignment.Left);
                        lvAllProduct.Columns.Add("หน่วย", 70, HorizontalAlignment.Left);
                        lvAllProduct.Columns.Add("สถานะ", 90, HorizontalAlignment.Left);

                        foreach (DataRow dataRow in dataTable.Rows)
                        {
                            ListViewItem item = new ListViewItem();
                            Image proImage = null;
                            if (dataRow["proImage"] != DBNull.Value) 
                            {
                                byte[] imgByte = (byte[])dataRow["proImage"];
                                proImage = convertByteArrayToImage(imgByte);
                            }
                            else
                            {
                                item.ImageIndex = -1;
                            }
                            item.SubItems.Add(dataRow["proId"].ToString());
                            item.SubItems.Add(dataRow["proName"].ToString());
                            item.SubItems.Add(dataRow["proPrice"].ToString());
                            item.SubItems.Add(dataRow["proQuan"].ToString());
                            item.SubItems.Add(dataRow["proUnit"].ToString());
                            item.SubItems.Add(dataRow["proStatus"].ToString());

                            lvAllProduct.Items.Add(item);
                        }

                    }
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("พบข้อผิดพลาด กรุณาลองใหม่ หรือติดต่อ IT : " + ex.Message);
                }
            
            }
        }
        private void FrmProductShow_Load(object sender, EventArgs e)
        {
            //ให้ไปดึงข้อมูลจาก product_tb มาแสดงที่ ListView
            getAllProductToLV();
        }
    }
}
