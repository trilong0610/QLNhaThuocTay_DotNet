namespace BanThuocTay
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.dataSetQLNhaThuoc = new BanThuocTay.DataSetQLNhaThuoc();
            this.tHUOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tHUOCTableAdapter = new BanThuocTay.DataSetQLNhaThuocTableAdapters.THUOCTableAdapter();
            this.tableAdapterManager = new BanThuocTay.DataSetQLNhaThuocTableAdapters.TableAdapterManager();
            this.lOAITHUOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOAITHUOCTableAdapter = new BanThuocTay.DataSetQLNhaThuocTableAdapters.LOAITHUOCTableAdapter();
            this.qUANLY_NHATHUOCTAYDataSet = new BanThuocTay.QUANLY_NHATHUOCTAYDataSet();
            this.lOAITHUOCBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lOAITHUOCTableAdapter1 = new BanThuocTay.QUANLY_NHATHUOCTAYDataSetTableAdapters.LOAITHUOCTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_taophieu = new System.Windows.Forms.Button();
            this.date_ngayban = new System.Windows.Forms.DateTimePicker();
            this.cbo_manv = new System.Windows.Forms.ComboBox();
            this.cbo_makh = new System.Windows.Forms.ComboBox();
            this.txt_mahd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txt_giaban = new System.Windows.Forms.TextBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.cbo_mathuoc = new System.Windows.Forms.ComboBox();
            this.cbo_mahd = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dav_hoadon = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_Inhoadon = new System.Windows.Forms.Button();
            this.txt_Tongtien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dav_cthdb = new System.Windows.Forms.DataGridView();
            this.txt_dvt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQLNhaThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHUOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAITHUOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLY_NHATHUOCTAYDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAITHUOCBindingSource1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dav_hoadon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dav_cthdb)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetQLNhaThuoc
            // 
            this.dataSetQLNhaThuoc.DataSetName = "DataSetQLNhaThuoc";
            this.dataSetQLNhaThuoc.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tHUOCBindingSource
            // 
            this.tHUOCBindingSource.DataMember = "THUOC";
            this.tHUOCBindingSource.DataSource = this.dataSetQLNhaThuoc;
            // 
            // tHUOCTableAdapter
            // 
            this.tHUOCTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHITIETHOADON_BANTableAdapter = null;
            this.tableAdapterManager.CHITIETHOADON_NHAPTableAdapter = null;
            this.tableAdapterManager.HOADON_BANTableAdapter = null;
            this.tableAdapterManager.HOADON_NHAPTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.LOAIBENHTableAdapter = null;
            this.tableAdapterManager.LOAITHUOCTableAdapter = null;
            this.tableAdapterManager.NHACUNGCAPTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.NUOCSANXUATTableAdapter = null;
            this.tableAdapterManager.THUOCTableAdapter = this.tHUOCTableAdapter;
            this.tableAdapterManager.UpdateOrder = BanThuocTay.DataSetQLNhaThuocTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lOAITHUOCBindingSource
            // 
            this.lOAITHUOCBindingSource.DataMember = "LOAITHUOC";
            this.lOAITHUOCBindingSource.DataSource = this.dataSetQLNhaThuoc;
            // 
            // lOAITHUOCTableAdapter
            // 
            this.lOAITHUOCTableAdapter.ClearBeforeFill = true;
            // 
            // qUANLY_NHATHUOCTAYDataSet
            // 
            this.qUANLY_NHATHUOCTAYDataSet.DataSetName = "QUANLY_NHATHUOCTAYDataSet";
            this.qUANLY_NHATHUOCTAYDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOAITHUOCBindingSource1
            // 
            this.lOAITHUOCBindingSource1.DataMember = "LOAITHUOC";
            this.lOAITHUOCBindingSource1.DataSource = this.qUANLY_NHATHUOCTAYDataSet;
            // 
            // lOAITHUOCTableAdapter1
            // 
            this.lOAITHUOCTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(421, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tạo Hoá Đơn Bán Thuốc";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox4.Controls.Add(this.btn_Sua);
            this.groupBox4.Controls.Add(this.btn_Xoa);
            this.groupBox4.Controls.Add(this.btn_taophieu);
            this.groupBox4.Controls.Add(this.date_ngayban);
            this.groupBox4.Controls.Add(this.cbo_manv);
            this.groupBox4.Controls.Add(this.cbo_makh);
            this.groupBox4.Controls.Add(this.txt_mahd);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(824, 85);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(623, 280);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hoá Đơn";
            // 
            // btn_Sua
            // 
            this.btn_Sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sua.Image")));
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.Location = new System.Drawing.Point(491, 102);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(121, 62);
            this.btn_Sua.TabIndex = 13;
            this.btn_Sua.Text = "Thay đổi";
            this.btn_Sua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.Image")));
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(491, 172);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(121, 62);
            this.btn_Xoa.TabIndex = 12;
            this.btn_Xoa.Text = "Xóa phiếu";
            this.btn_Xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_taophieu
            // 
            this.btn_taophieu.Image = ((System.Drawing.Image)(resources.GetObject("btn_taophieu.Image")));
            this.btn_taophieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_taophieu.Location = new System.Drawing.Point(491, 34);
            this.btn_taophieu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_taophieu.Name = "btn_taophieu";
            this.btn_taophieu.Size = new System.Drawing.Size(121, 60);
            this.btn_taophieu.TabIndex = 11;
            this.btn_taophieu.Text = "Tạo phiếu ";
            this.btn_taophieu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_taophieu.UseVisualStyleBackColor = true;
            // 
            // date_ngayban
            // 
            this.date_ngayban.Location = new System.Drawing.Point(152, 142);
            this.date_ngayban.Margin = new System.Windows.Forms.Padding(4);
            this.date_ngayban.Name = "date_ngayban";
            this.date_ngayban.Size = new System.Drawing.Size(331, 22);
            this.date_ngayban.TabIndex = 9;
            // 
            // cbo_manv
            // 
            this.cbo_manv.FormattingEnabled = true;
            this.cbo_manv.Location = new System.Drawing.Point(152, 182);
            this.cbo_manv.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_manv.Name = "cbo_manv";
            this.cbo_manv.Size = new System.Drawing.Size(331, 24);
            this.cbo_manv.TabIndex = 8;
            // 
            // cbo_makh
            // 
            this.cbo_makh.FormattingEnabled = true;
            this.cbo_makh.Location = new System.Drawing.Point(152, 103);
            this.cbo_makh.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_makh.Name = "cbo_makh";
            this.cbo_makh.Size = new System.Drawing.Size(329, 24);
            this.cbo_makh.TabIndex = 7;
            // 
            // txt_mahd
            // 
            this.txt_mahd.Location = new System.Drawing.Point(152, 53);
            this.txt_mahd.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mahd.Name = "txt_mahd";
            this.txt_mahd.Size = new System.Drawing.Size(328, 22);
            this.txt_mahd.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 185);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Nhân viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 147);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ngày bán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã hóa đơn";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox5.Controls.Add(this.txt_dvt);
            this.groupBox5.Controls.Add(this.txt_giaban);
            this.groupBox5.Controls.Add(this.txt_soluong);
            this.groupBox5.Controls.Add(this.cbo_mathuoc);
            this.groupBox5.Controls.Add(this.cbo_mahd);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(824, 373);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(623, 278);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chi Tiết Hoá Đơn";
            // 
            // txt_giaban
            // 
            this.txt_giaban.Location = new System.Drawing.Point(135, 224);
            this.txt_giaban.Margin = new System.Windows.Forms.Padding(4);
            this.txt_giaban.Name = "txt_giaban";
            this.txt_giaban.ReadOnly = true;
            this.txt_giaban.Size = new System.Drawing.Size(332, 22);
            this.txt_giaban.TabIndex = 20;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(136, 179);
            this.txt_soluong.Margin = new System.Windows.Forms.Padding(4);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(328, 22);
            this.txt_soluong.TabIndex = 19;
            // 
            // cbo_mathuoc
            // 
            this.cbo_mathuoc.FormattingEnabled = true;
            this.cbo_mathuoc.Location = new System.Drawing.Point(136, 85);
            this.cbo_mathuoc.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_mathuoc.Name = "cbo_mathuoc";
            this.cbo_mathuoc.Size = new System.Drawing.Size(328, 24);
            this.cbo_mathuoc.TabIndex = 17;
            // 
            // cbo_mahd
            // 
            this.cbo_mahd.FormattingEnabled = true;
            this.cbo_mahd.Location = new System.Drawing.Point(136, 40);
            this.cbo_mahd.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_mahd.Name = "cbo_mahd";
            this.cbo_mahd.Size = new System.Drawing.Size(328, 24);
            this.cbo_mahd.TabIndex = 16;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(491, 117);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 58);
            this.button3.TabIndex = 14;
            this.button3.Text = "Sửa mục";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(491, 196);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 53);
            this.button2.TabIndex = 13;
            this.button2.Text = "Xóa mục";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(488, 40);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 57);
            this.button1.TabIndex = 12;
            this.button1.Text = "Thêm mục";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(57, 227);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 17);
            this.label13.TabIndex = 5;
            this.label13.Text = "Giá bán";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(53, 182);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "Số lượng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(42, 140);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "Đơn vị tính";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(63, 88);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Thuốc";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 43);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Mã hóa đơn";
            // 
            // dav_hoadon
            // 
            this.dav_hoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dav_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dav_hoadon.Location = new System.Drawing.Point(7, 22);
            this.dav_hoadon.Margin = new System.Windows.Forms.Padding(4);
            this.dav_hoadon.Name = "dav_hoadon";
            this.dav_hoadon.Size = new System.Drawing.Size(784, 258);
            this.dav_hoadon.TabIndex = 15;
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(798, 670);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(149, 38);
            this.button4.TabIndex = 27;
            this.button4.Text = "Thoát khỏi";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btn_Inhoadon
            // 
            this.btn_Inhoadon.Image = ((System.Drawing.Image)(resources.GetObject("btn_Inhoadon.Image")));
            this.btn_Inhoadon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Inhoadon.Location = new System.Drawing.Point(619, 670);
            this.btn_Inhoadon.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Inhoadon.Name = "btn_Inhoadon";
            this.btn_Inhoadon.Size = new System.Drawing.Size(157, 38);
            this.btn_Inhoadon.TabIndex = 26;
            this.btn_Inhoadon.Text = "In hóa đơn";
            this.btn_Inhoadon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Inhoadon.UseVisualStyleBackColor = true;
            // 
            // txt_Tongtien
            // 
            this.txt_Tongtien.Location = new System.Drawing.Point(142, 674);
            this.txt_Tongtien.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Tongtien.Name = "txt_Tongtien";
            this.txt_Tongtien.ReadOnly = true;
            this.txt_Tongtien.Size = new System.Drawing.Size(448, 22);
            this.txt_Tongtien.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 670);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 26);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tổng tiền";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.dav_hoadon);
            this.groupBox1.Location = new System.Drawing.Point(12, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 287);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Hoá Đơn";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.dav_cthdb);
            this.groupBox2.Location = new System.Drawing.Point(13, 378);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(804, 287);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Chi Tiết Hoá Đơn";
            // 
            // dav_cthdb
            // 
            this.dav_cthdb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dav_cthdb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dav_cthdb.Location = new System.Drawing.Point(7, 22);
            this.dav_cthdb.Margin = new System.Windows.Forms.Padding(4);
            this.dav_cthdb.Name = "dav_cthdb";
            this.dav_cthdb.Size = new System.Drawing.Size(790, 258);
            this.dav_cthdb.TabIndex = 15;
            // 
            // txt_dvt
            // 
            this.txt_dvt.Location = new System.Drawing.Point(136, 137);
            this.txt_dvt.Margin = new System.Windows.Forms.Padding(4);
            this.txt_dvt.Name = "txt_dvt";
            this.txt_dvt.ReadOnly = true;
            this.txt_dvt.Size = new System.Drawing.Size(328, 22);
            this.txt_dvt.TabIndex = 21;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 720);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_Inhoadon);
            this.Controls.Add(this.txt_Tongtien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQLNhaThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHUOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAITHUOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLY_NHATHUOCTAYDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAITHUOCBindingSource1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dav_hoadon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dav_cthdb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSetQLNhaThuoc dataSetQLNhaThuoc;
        private System.Windows.Forms.BindingSource tHUOCBindingSource;
        private DataSetQLNhaThuocTableAdapters.THUOCTableAdapter tHUOCTableAdapter;
        private DataSetQLNhaThuocTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource lOAITHUOCBindingSource;
        private DataSetQLNhaThuocTableAdapters.LOAITHUOCTableAdapter lOAITHUOCTableAdapter;
        private QUANLY_NHATHUOCTAYDataSet qUANLY_NHATHUOCTAYDataSet;
        private System.Windows.Forms.BindingSource lOAITHUOCBindingSource1;
        private QUANLY_NHATHUOCTAYDataSetTableAdapters.LOAITHUOCTableAdapter lOAITHUOCTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_taophieu;
        private System.Windows.Forms.DateTimePicker date_ngayban;
        private System.Windows.Forms.ComboBox cbo_manv;
        private System.Windows.Forms.ComboBox cbo_makh;
        private System.Windows.Forms.TextBox txt_mahd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txt_giaban;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.ComboBox cbo_mathuoc;
        private System.Windows.Forms.ComboBox cbo_mahd;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dav_hoadon;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_Inhoadon;
        private System.Windows.Forms.TextBox txt_Tongtien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dav_cthdb;
        private System.Windows.Forms.TextBox txt_dvt;
    }
}

