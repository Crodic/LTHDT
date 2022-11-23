using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class CNhanVien
    {
        private string m_manv, m_tennv;
        private DateTime m_ngaysinh;
        private bool m_gt;
        private double m_giolam;
        private double m_tangca;

        public string Manv { get => m_manv; set => m_manv = value; }
        public string Tennv { get => m_tennv; set => m_tennv = value; }
        public bool Gt { get => m_gt; set => m_gt = value; }
        public DateTime Ngaysinh { get => m_ngaysinh; set => m_ngaysinh = value; }
        public double Giolam { get => m_giolam; set => m_giolam = value; }
        public double Tangca { get => m_tangca; set => m_tangca = value; }

        public double LuongNV
        {
            get { return m_giolam * 250000 + m_tangca * 25000; }
        }
        public CNhanVien()
        {
            m_manv = "";
            m_tennv = "";
            m_ngaysinh = DateTime.Now;
            m_gt = true;
            m_giolam = 0;
            m_tangca = 0;
        }

        public CNhanVien(string ma,string ten,DateTime ngaysinh,bool gt,double giolam,double tangca)
        {
            m_manv = ma;
            m_tennv = ten;
            m_ngaysinh = ngaysinh;
            m_gt = gt;
            m_giolam = giolam;
            m_tangca = tangca;
        }

    }
}
