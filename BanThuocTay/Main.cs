using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanThuocTay
{
    public partial class Main : Form
    {
        KhachHang kh = new KhachHang();
        NhanVien nv = new NhanVien();
        HoaDonBan hdb = new HoaDonBan();
        LoaiThuoc lt = new LoaiThuoc();
        Thuoc thuoc = new Thuoc();
        CTHoaDonBan cthdb = new CTHoaDonBan();
        public Main()
        {
            InitializeComponent();
        }

        private void tHUOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tHUOCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetQLNhaThuoc);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // lLoad ma Khach Hang
            cbo_makh.ResetText();
            cbo_makh.DataSource = kh.LoadKH();
            cbo_makh.DisplayMember = "HOTENKH";
            cbo_makh.ValueMember = "MAKH";

            // lLoad ma Nhan Vien
            cbo_manv.ResetText();
            cbo_manv.DataSource = nv.LoadNV();
            cbo_manv.DisplayMember = "HOTENNV";
            cbo_manv.ValueMember = "MANV";

            // lLoad ma Hoa Don Ban
            cbo_mahd.ResetText();
            cbo_mahd.DataSource = hdb.LoadHDB();
            cbo_mahd.DisplayMember = "MAHDB";
            cbo_mahd.ValueMember = "MAHDB";

            // lLoad ma thuoc
            cbo_mathuoc.ResetText();
            cbo_mathuoc.DataSource = thuoc.LoadThuoc();
            cbo_mathuoc.DisplayMember = "TENTHUOC";
            cbo_mathuoc.ValueMember = "MATHUOC";

            // lLoad ma thuoc
            cbo_mathuoc.ResetText();
            cbo_mathuoc.DataSource = thuoc.LoadThuoc();
            cbo_mathuoc.DisplayMember = "TENTHUOC";
            cbo_mathuoc.ValueMember = "MATHUOC";

            // lLoad Hoa don
            dav_hoadon.DataSource = hdb.LoadHDB();
            // lLoad CT Hoa don
            dav_cthdb.DataSource = cthdb.LoadCTHDB();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
