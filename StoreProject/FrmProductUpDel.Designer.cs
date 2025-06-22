namespace StoreProject
{
    partial class FrmProductUpDel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductUpDel));
            this.label1 = new System.Windows.Forms.Label();
            this.tbProName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbProPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbProUnit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcbProImage = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.rdoProStatusOn = new System.Windows.Forms.RadioButton();
            this.rdoProStatusOff = new System.Windows.Forms.RadioButton();
            this.nudProQuan = new System.Windows.Forms.NumericUpDown();
            this.btProUpdate = new System.Windows.Forms.Button();
            this.btProDelete = new System.Windows.Forms.Button();
            this.tbProId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProQuan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "แก้ไข/ลบสินค้า";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbProName
            // 
            this.tbProName.Location = new System.Drawing.Point(138, 309);
            this.tbProName.Name = "tbProName";
            this.tbProName.Size = new System.Drawing.Size(213, 20);
            this.tbProName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(32, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "ชื่อสินค้า";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbProPrice
            // 
            this.tbProPrice.Location = new System.Drawing.Point(138, 341);
            this.tbProPrice.Name = "tbProPrice";
            this.tbProPrice.Size = new System.Drawing.Size(213, 20);
            this.tbProPrice.TabIndex = 7;
            this.tbProPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbProPrice_KeyPress);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(32, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "ราคาสินค้า";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(32, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "จำนวนสินค้า";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbProUnit
            // 
            this.tbProUnit.Location = new System.Drawing.Point(138, 409);
            this.tbProUnit.Name = "tbProUnit";
            this.tbProUnit.Size = new System.Drawing.Size(213, 20);
            this.tbProUnit.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(32, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "หน่วยสินค้า";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(32, 440);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "สถานะสินค้า";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pcbProImage);
            this.panel1.Location = new System.Drawing.Point(106, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 186);
            this.panel1.TabIndex = 16;
            // 
            // pcbProImage
            // 
            this.pcbProImage.Location = new System.Drawing.Point(15, 12);
            this.pcbProImage.Name = "pcbProImage";
            this.pcbProImage.Size = new System.Drawing.Size(168, 159);
            this.pcbProImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbProImage.TabIndex = 0;
            this.pcbProImage.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(313, 243);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(29, 22);
            this.button3.TabIndex = 17;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // rdoProStatusOn
            // 
            this.rdoProStatusOn.AutoSize = true;
            this.rdoProStatusOn.Checked = true;
            this.rdoProStatusOn.Location = new System.Drawing.Point(157, 446);
            this.rdoProStatusOn.Name = "rdoProStatusOn";
            this.rdoProStatusOn.Size = new System.Drawing.Size(70, 17);
            this.rdoProStatusOn.TabIndex = 18;
            this.rdoProStatusOn.TabStop = true;
            this.rdoProStatusOn.Text = "พร้อมขาย";
            this.rdoProStatusOn.UseVisualStyleBackColor = true;
            // 
            // rdoProStatusOff
            // 
            this.rdoProStatusOff.AutoSize = true;
            this.rdoProStatusOff.Location = new System.Drawing.Point(248, 446);
            this.rdoProStatusOff.Name = "rdoProStatusOff";
            this.rdoProStatusOff.Size = new System.Drawing.Size(83, 17);
            this.rdoProStatusOff.TabIndex = 19;
            this.rdoProStatusOff.Text = "ไม่พร้อมขาย";
            this.rdoProStatusOff.UseVisualStyleBackColor = true;
            // 
            // nudProQuan
            // 
            this.nudProQuan.Location = new System.Drawing.Point(138, 377);
            this.nudProQuan.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudProQuan.Name = "nudProQuan";
            this.nudProQuan.Size = new System.Drawing.Size(213, 20);
            this.nudProQuan.TabIndex = 20;
            // 
            // btProUpdate
            // 
            this.btProUpdate.Image = global::StoreProject.Properties.Resources.update;
            this.btProUpdate.Location = new System.Drawing.Point(232, 480);
            this.btProUpdate.Name = "btProUpdate";
            this.btProUpdate.Size = new System.Drawing.Size(129, 37);
            this.btProUpdate.TabIndex = 15;
            this.btProUpdate.Text = "บันทึกแก้ไขสินค้า";
            this.btProUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btProUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btProUpdate.UseVisualStyleBackColor = true;
            this.btProUpdate.Click += new System.EventHandler(this.btProUpdate_Click);
            // 
            // btProDelete
            // 
            this.btProDelete.Image = global::StoreProject.Properties.Resources.delete;
            this.btProDelete.Location = new System.Drawing.Point(83, 480);
            this.btProDelete.Name = "btProDelete";
            this.btProDelete.Size = new System.Drawing.Size(129, 37);
            this.btProDelete.TabIndex = 14;
            this.btProDelete.Text = "ลบสินค้า";
            this.btProDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btProDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btProDelete.UseVisualStyleBackColor = true;
            this.btProDelete.Click += new System.EventHandler(this.btProDelete_Click);
            // 
            // tbProId
            // 
            this.tbProId.Location = new System.Drawing.Point(138, 283);
            this.tbProId.Name = "tbProId";
            this.tbProId.Size = new System.Drawing.Size(213, 20);
            this.tbProId.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(32, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "รหัสสินค้า";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmProductUpDel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 523);
            this.Controls.Add(this.tbProId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudProQuan);
            this.Controls.Add(this.rdoProStatusOff);
            this.Controls.Add(this.rdoProStatusOn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btProUpdate);
            this.Controls.Add(this.btProDelete);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbProUnit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbProPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbProName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmProductUpDel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "แก้ไข/ลบสินค้า - บริหารจัดการข้อมูลสินค้า";
            this.Load += new System.EventHandler(this.FrmProductUpDel_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbProImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProQuan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbProName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbProPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbProUnit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btProDelete;
        private System.Windows.Forms.Button btProUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcbProImage;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton rdoProStatusOn;
        private System.Windows.Forms.RadioButton rdoProStatusOff;
        private System.Windows.Forms.NumericUpDown nudProQuan;
        private System.Windows.Forms.TextBox tbProId;
        private System.Windows.Forms.Label label2;
    }
}

