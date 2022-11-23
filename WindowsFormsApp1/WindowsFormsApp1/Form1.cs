using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Dictionary<string, CNhanVien> dsNV;
        private void HienThiDSNhanVien()
        {
            dgvNV.DataSource = dsNV.Values.ToList();
        }
        private CNhanVien timNV(string ma)
        {
            try
            {
                return dsNV[ma];
            }
            catch
            {
                return null;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            CNhanVien nv = new CNhanVien();
            nv.Manv = txtMa.Text;
            nv.Tennv = txtTen.Text;
            nv.Gt = rbNam.Checked;
            nv.Ngaysinh = dtpNS.Value;
            nv.Giolam = Convert.ToDouble(txtSNLV.Text.ToString());
            nv.Tangca= Convert.ToDouble(txtSGTC.Text.ToString());
            if (timNV(nv.Manv) == null)
            {
                dsNV.Add(nv.Manv, nv);
                HienThiDSNhanVien();
            }
            else
                MessageBox.Show("Ma nv" + nv.Manv + "da ton tai.Khong the them");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dsNV = new Dictionary<string, CNhanVien>();
            HienThiDSNhanVien();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void dgvNV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.Text = dgvNV.Rows[e.RowIndex].Cells["Manv"].Value.ToString();
            txtTen.Text= dgvNV.Rows[e.RowIndex].Cells["Tennv"].Value.ToString();
            bool gt = (bool)dgvNV.Rows[e.RowIndex].Cells["Gt"].Value;
            if (gt == true) rbNam.Checked = true;
            else
                rbNu.Checked = true;
            dtpNS.Value = Convert.ToDateTime(dgvNV.Rows[e.RowIndex].Cells["Ngaysinh"].Value);
            txtSNLV.Text= dgvNV.Rows[e.RowIndex].Cells["Giolam"].Value.ToString();
            txtSGTC.Text = dgvNV.Rows[e.RowIndex].Cells["Tangca"].Value.ToString();
            txtLuong.Text= dgvNV.Rows[e.RowIndex].Cells["LuongNV"].Value.ToString();
        }
    }
}
