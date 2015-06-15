using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KTXML
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            DSNV_TT nhanvien = new DSNV_TT();
            nhanvien.Manv = txt_ma.Text;
            nhanvien.Hoten = txt_ten.Text;
            nhanvien.Diachi = txt_dc.Text;
            xl.Them(nhanvien);
            Form1_Load(sender, e);

        }

        private void btnsua_Click(object sender, EventArgs e)
        {

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DSNV_TT nhanvien = new DSNV_TT();
            nhanvien.Manv = txt_ma.Text;
            nhanvien.Hoten = txt_ten.Text;
            nhanvien.Diachi = txt_dc.Text;
            xl.xoa(nhanvien);
            txt_dc.Text = txt_ma.Text = txt_ten.Text = "";
            Form1_Load(sender, e);

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {

        }

        private void btntim_Click(object sender, EventArgs e)
        {
            string timid = txt_ma.Text.ToString();
            xl.tim(datanhanvien, timid);

        }

        private void datanhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datanhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            d = e.RowIndex;
            txt_ma.Text = datanhanvien.Rows[d].Cells[0].Value.ToString();
            txt_ten.Text = datanhanvien.Rows[d].Cells[1].Value.ToString();
            txt_dc.Text = datanhanvien.Rows[d].Cells[2].Value.ToString();
            Form1_Load(sender, e);
        }
        DSNV_XL xl = new DSNV_XL();
        int d;
        private void Form1_Load(object sender, EventArgs e)
        {
            xl.HienDaTaGr(datanhanvien);
        }

        private void btnnhap_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\admin\Desktop\THI XML - Copy\KTXML2(DOM+CSS)\KTXML\KTXML\thuvien1.xml";
            System.Diagnostics.Process.Start("Explorer.exe", path);
        }
        

        
    }
}
