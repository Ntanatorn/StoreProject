using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreProject
{
    public partial class FrmProductUpDel : Form
    {
        private int proId;
        byte[] proImage;

        public FrmProductUpDel(int proId)
        {
            InitializeComponent();
            this.proId = proId;

            // คุณอาจโหลดข้อมูลสินค้าด้วย proId ตรงนี้เลยก็ได้ เช่น:
            // loadProductById(proId);
        }
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
        private void FrmProductUpDel_Load(object sender, EventArgs e)
        {
            //Connect String เพื่อติดต่อไปยังฐานข้อมูล
            string connectionString = @"Server=DESKTOP-9U4FO0V\SQLEXPRESS;Database=store_db;Trusted_Connection=True;";

            //สร้าง Connection ไปยังฐานข้อมูล
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    string strSQL = "SELECT proId, proName, proPrice, proQuan, proUnit, proStatus, proImage FROM [store_db].[dbo].[product_tb] " + 
                                    "where proId = @proId";

                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(strSQL, sqlConnection))
                    {
                        dataAdapter.SelectCommand.Parameters.AddWithValue("@proId", proId);

                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        
                        DataRow row = dataTable.Rows[0];

                        tbProId.Text = row["proId"].ToString();
                        tbProName.Text = row["proName"].ToString();
                        tbProPrice.Text = Convert.ToDecimal(row["proPrice"]).ToString("0.00");
                        nudProQuan.Value = Convert.ToDecimal(row["proQuan"]);
                        tbProUnit.Text = row["proUnit"].ToString();

                        if (row["proStatus"].ToString() == "พร้อมขาย")
                        {
                            rdoProStatusOn.Checked = true;
                        }
                        else
                        {
                            rdoProStatusOff.Checked = true;
                        }

                        if (row["proImage"] == DBNull.Value)
                        {
                            pcbProImage.Image = null;
                            proImage = null; // เผื่อไว้ ถ้าไม่มีรูป
                        }
                        else
                        {
                            byte[] imageBytes = (byte[])row["proImage"];
                            pcbProImage.Image = convertByteArrayToImage(imageBytes);
                            proImage = imageBytes; // ✅ สำคัญมาก! ทำให้ proImage ไม่เป็น null
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("พบข้อผิดพลาด กรุณาลองใหม่ หรือติดต่อ IT : " + ex.Message);
                }
            }
        }

        private void tbProPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.' || ((TextBox)sender).Text.Contains('.')))
            {
                e.Handled = true;
            }
        }

        private void btProDelete_Click(object sender, EventArgs e)
        {
            //Connect String เพื่อติดต่อไปยังฐานข้อมูล
            string connectionString = @"Server=DESKTOP-9U4FO0V\SQLEXPRESS;Database=store_db;Trusted_Connection=True;";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();

                    SqlTransaction sqlTransaction = sqlConnection.BeginTransaction();

                    string strSql = "delete from product_tb where proId = @proId";

                    using (SqlCommand sqlCommand = new SqlCommand(strSql, sqlConnection, sqlTransaction))
                    {
        
                        sqlCommand.Parameters.Add("@proId", SqlDbType.Int).Value = int.Parse(tbProId.Text);
                        
                        sqlCommand.ExecuteNonQuery();
                        sqlTransaction.Commit();
                        MessageBox.Show("ลบเรียบร้อยแล้ว", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("พบข้อผิดพลาด กรุณาลองใหม่ หรือติดต่อ IT : " + ex.Message);
                }
            }

        }

        private void showWarningMSG(string msg)
        {
            MessageBox.Show(msg, "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        private void btProUpdate_Click(object sender, EventArgs e)
        {
            if (proImage == null)
            {
                showWarningMSG("เลือกรูปด้วย");
            }
            else if (tbProName.Text.Length == 0)
            {
                showWarningMSG("ป้อนชื่อสินค้าด้วย");
            }
            else if (tbProPrice.Text.Length == 0)
            {
                showWarningMSG("ป้อนราคาสินค้าด้วย");
            }
            else if (int.Parse(nudProQuan.Value.ToString()) <= 0)
            {
                showWarningMSG("จำนวนสินค้าต้องมากกว่า 0");
            }
            else if (tbProUnit.Text.Length == 0)
            {
                showWarningMSG("ป้อนหน่วยสินค้าด้วย");
            }
            else
            {
                //Connect String เพื่อติดต่อไปยังฐานข้อมูล
                string connectionString = @"Server=DESKTOP-9U4FO0V\SQLEXPRESS;Database=store_db;Trusted_Connection=True;";

                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    try
                    {
                        sqlConnection.Open();

                        SqlTransaction sqlTransaction = sqlConnection.BeginTransaction();

                        string strSql = "UPDATE product_tb SET " +
                                        "proName = @proName, " +
                                        "proPrice = @proPrice, " +
                                        "proQuan = @proQuan, " +
                                        "proUnit = @proUnit, " +
                                        "proStatus = @proStatus, " +
                                        "proImage = @proImage, " +
                                        "updateAt = @updateAt " +
                                        "WHERE proId = @proId";

                        using (SqlCommand sqlCommand = new SqlCommand(strSql, sqlConnection, sqlTransaction))
                        {
                            sqlCommand.Parameters.Add("@proName", SqlDbType.NVarChar, 300).Value = tbProName.Text;
                            sqlCommand.Parameters.Add("@proPrice", SqlDbType.Decimal).Value = decimal.Parse(tbProPrice.Text);
                            sqlCommand.Parameters.Add("@proQuan", SqlDbType.Int).Value = (int)nudProQuan.Value;
                            sqlCommand.Parameters.Add("@proUnit", SqlDbType.NVarChar, 50).Value = tbProUnit.Text;
                            sqlCommand.Parameters.Add("@proStatus", SqlDbType.NVarChar, 50).Value =
                                rdoProStatusOn.Checked ? "พร้อมขาย" : "ไม่พร้อมขาย";
                            sqlCommand.Parameters.Add("@proImage", SqlDbType.Image).Value = proImage;
                            sqlCommand.Parameters.Add("@updateAt", SqlDbType.Date).Value = DateTime.Now.Date;

                            // ต้องไม่ลืมตรงนี้!
                            sqlCommand.Parameters.Add("@proId", SqlDbType.Int).Value = proId;

                            sqlCommand.ExecuteNonQuery();
                            sqlTransaction.Commit();
                            MessageBox.Show("อัปเดตข้อมูลเรียบร้อยแล้ว", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("พบข้อผิดพลาด กรุณาลองใหม่ หรือติดต่อ IT : " + ex.Message);
                    }
                }
            }
        }
        private byte[] convertImageToByteArray(Image image, ImageFormat imageFormat)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, imageFormat);
                return ms.ToArray();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Filter = "Image Files (*.jpg;*.png;)|*.jpg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pcbProImage.Image = Image.FromFile(openFileDialog.FileName);

                if (pcbProImage.Image.RawFormat == ImageFormat.Jpeg)
                {
                    proImage = convertImageToByteArray(pcbProImage.Image, ImageFormat.Jpeg);
                }
                else
                {
                    proImage = convertImageToByteArray(pcbProImage.Image, ImageFormat.Png);
                }
            }
        }
    }
}
