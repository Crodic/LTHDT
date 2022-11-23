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
            nv.Giolam = txtSNLV.;
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


    }
}
