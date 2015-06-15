using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;

namespace KTXML
{
    /*
     *     class DSNV_XL
    {
        XmlDocument doc = new XmlDocument();//tạo đối tượng tài liệu xml mới
        string tentep = @"C:\Users\SEXY_GIRL\Documents\Visual Studio 2010\Projects\KTXML\KTXML\KTXML\dsnhanvien.xml";
        public void Them(DSNV_TT nv)// hàm thêm nhân viên
        {
            doc.Load(tentep);//hiển thị
            XmlElement goc = doc.DocumentElement;// tạo đối tượng thuộc tính xml -goc 
            XmlNode nhan_vien = doc.CreateElement("nhanvien");//nốt nhân viên -với thuộc tính  mã nhân viên
            XmlAttribute ma_nv = doc.CreateAttribute("manv");
            ma_nv.InnerText = nv.Manv;
            nhan_vien.Attributes.Append(ma_nv);
            XmlNode ho_ten = doc.CreateElement("hoten");
            ho_ten.InnerText = nv.Hoten;
            nhan_vien.AppendChild(ho_ten);
            XmlNode dia_chi = doc.CreateElement("diachi");
            dia_chi.InnerText = nv.Diachi;
            nhan_vien.AppendChild(dia_chi);
            goc.AppendChild(nhan_vien);
            doc.Save(tentep);

        }
        public void HienDaTaGr(DataGridView dg)
        {
            dg.Rows.Clear();
            doc.Load(tentep);
            XmlNodeList DS = doc.SelectNodes("/ds/nhanvien");
                int sd=0;
            dg.ColumnCount=3;
            dg.Rows.Add();
            foreach (XmlNode node in DS)
            {
                    XmlNode ma_nv = node.SelectSingleNode("@manv");
                    dg.Rows[sd].Cells[0].Value=ma_nv.InnerText.ToString();
                    XmlNode ho_ten = node.SelectSingleNode("hoten");
                    dg.Rows[sd].Cells[1].Value = ho_ten.InnerText.ToString();
                    XmlNode dia_chi = node.SelectSingleNode("diachi");
                    dg.Rows[sd].Cells[2].Value = dia_chi.InnerText.ToString();
                    dg.Rows.Add();
                    sd++;

            }

        }
        public void sua(DSNV_TT nv)
        {
            doc.Load(tentep);
            XmlElement goc = doc.DocumentElement;
            XmlNode cu = goc.SelectSingleNode("/ds/nhanvien[@manv='" + nv.Manv + "']");
            XmlNode moi = doc.CreateElement("nhanvien");
            XmlAttribute ma_nv = doc.CreateAttribute("manv");
            ma_nv.InnerText = nv.Manv;
            moi.Attributes.Append(ma_nv);
            XmlNode ho_ten = doc.CreateElement("hoten");
            ho_ten.InnerText = nv.Hoten;
            moi.AppendChild(ho_ten);
            XmlNode dia_chi = doc.CreateElement("diachi");
            dia_chi.InnerText = nv.Diachi;
            moi.AppendChild(dia_chi);
            goc.ReplaceChild(moi,cu);
            doc.Save(tentep);
        }
        public void xoa(DSNV_TT nv)
        {
            doc.Load(tentep);
            XmlNode goc = doc.DocumentElement;
            XmlNode cu = goc.SelectSingleNode("/ds/nhanvien[@manv='" + nv.Manv + "']");
            goc.RemoveChild(cu);
            doc.Save(tentep);
        }

    }
     
    class DSNV_TT
    {
        string manv, hoten, diachi;
        public string Manv
        {
            get { return manv; }
            set { manv = value; }
        }
        public string Hoten
        {
            get { return hoten; }
            set { hoten = value; }
        }
        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }
    }
    class DSNV_XL
    {
        XmlDocument doc = new XmlDocument();
        string tentep = @"C:\Users\SEXY_GIRL\Desktop\KTXML\KTXML\KTXML\dsnhanvien.xml";
        public void HienDaTaGr(DataGridView dg)
        {
            dg.Rows.Clear();
            doc.Load(tentep);
            XmlNodeList DS = doc.SelectNodes("/ds/nhanvien");

            int sd = 0;
            dg.ColumnCount = 3;
            dg.Rows.Add();

            foreach (XmlNode node in DS)
            {
                XmlNode ma_nv = node.SelectSingleNode("@manv");
                dg.Rows[sd].Cells[0].Value = ma_nv.InnerText.ToString();
                XmlNode ho_ten = node.SelectSingleNode("hoten");
                dg.Rows[sd].Cells[1].Value = ho_ten.InnerText.ToString();
                XmlNode dia_chi = node.SelectSingleNode("diachi");
                dg.Rows[sd].Cells[2].Value = dia_chi.InnerText.ToString();
                sd++;
                dg.Rows.Add();

            }

        }
        public void Them(DSNV_TT nv)
        {
            XmlElement goc = doc.DocumentElement;
            XmlElement nhan_vien = doc.CreateElement("nhanvien");
            XmlAttribute ma_nv = doc.CreateAttribute("manv");
            ma_nv.InnerText = nv.Manv;
            nhan_vien.Attributes.Append(ma_nv);

            XmlElement ho_ten = doc.CreateElement("hoten");
            ho_ten.InnerText = nv.Hoten;
            nhan_vien.AppendChild(ho_ten);

            XmlElement dia_chi = doc.CreateElement("diachi");
            dia_chi.InnerText = nv.Diachi;
            nhan_vien.AppendChild(dia_chi);

            goc.AppendChild(nhan_vien);
            doc.Save(tentep);
        }
        public void Xoa(DSNV_TT nv)
        {
            doc.Load(tentep);
            XmlNode goc = doc.DocumentElement;
            XmlNode cu = goc.SelectSingleNode("/ds/nhanvien[@manv='" + nv.Manv + "']");
            goc.RemoveChild(cu);
            doc.Save(tentep);
        }
        public void Tim(DataGridView dg,string idkt)
        
        {
            dg.Rows.Clear();
            doc.Load(tentep);
            XmlNodeList ds =doc.SelectNodes("/ds/nhanvien[@manv='"+idkt+"']");
            dg.ColumnCount = 3;
            int sd=0;
            dg.Rows.Add();

            foreach (XmlNode node in ds)
            {
                XmlNode ma_nv = node.SelectSingleNode("@manv");
                dg.Rows[sd].Cells[0].Value = ma_nv.InnerText.ToString();
                XmlNode ho_ten = node.SelectSingleNode("hoten");
                dg.Rows[sd].Cells[1].Value = ho_ten.InnerText.ToString();
                XmlNode dia_chi = node.SelectSingleNode("diachi");
                dg.Rows[sd].Cells[2].Value = dia_chi.InnerText.ToString();
                sd++;
                dg.Rows.Add();

            }


 
        }

    }
     * 
    class DSNV_TT
    {
        string manv, hoten, diachi;
        public string Manv
        {
            get { return manv; }
            set { manv = value; }
        }
        public string Hoten
        {
            get { return hoten; }
            set { hoten = value; }
        }
        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }

    }
    class DSNV_XL
    {
        XmlDocument doc = new XmlDocument();
        string tentep = @"C:\Users\SEXY_GIRL\Desktop\KTXML\KTXML\KTXML\dsnhanvien.xml";
        public void HienDaTaGr(DataGridView dg)
        {
            dg.Rows.Clear();
            doc.Load(tentep);
            XmlNodeList DS = doc.SelectNodes("/ds/nhanvien");

            int sd = 0;
            dg.ColumnCount = 3;
            dg.Rows.Add();

            foreach (XmlNode node in DS)
            {
                XmlNode ma_nv = node.SelectSingleNode("@manv");
                dg.Rows[sd].Cells[0].Value = ma_nv.InnerText.ToString();
                XmlNode ho_ten = node.SelectSingleNode("hoten");
                dg.Rows[sd].Cells[1].Value = ho_ten.InnerText.ToString();
                XmlNode dia_chi = node.SelectSingleNode("diachi");
                dg.Rows[sd].Cells[2].Value = dia_chi.InnerText.ToString();

                sd++;
                dg.Rows.Add();
            }
        }
        public void Them(DSNV_TT nv)
        {
            XmlElement goc = doc.DocumentElement;

            XmlElement nhan_vien = doc.CreateElement("nhanvien");
            XmlAttribute ma_nv = doc.CreateAttribute("manv");
            ma_nv.InnerText = nv.Manv;
            nhan_vien.Attributes.Append(ma_nv);

            XmlElement ho_ten = doc.CreateElement("hoten");
            ho_ten.InnerText = nv.Hoten;
            nhan_vien.AppendChild(ho_ten);

            XmlElement dia_chi = doc.CreateElement("diachi");
            dia_chi.InnerText = nv.Diachi;
            nhan_vien.AppendChild(dia_chi);

            goc.AppendChild(nhan_vien);
            doc.Save(tentep);
        }
        public void Xoa(DSNV_TT nv)
        {
            doc.Load(tentep);
            XmlNode goc = doc.DocumentElement;
            XmlNode cu = goc.SelectSingleNode("/ds/nhanvien[@manv='" + nv.Manv + "']");
            goc.RemoveChild(cu);
            doc.Save(tentep);
        }
        public void Tim(DataGridView dg,string idkt)
        {
            dg.Rows.Clear();
            doc.Load(tentep);
            XmlNodeList DS = doc.SelectNodes("/ds/nhanvien[@manv='"+ idkt+ "']");

            int sd = 0;
            dg.ColumnCount = 3;
            dg.Rows.Add();

            foreach (XmlNode node in DS)
            {
                XmlNode ma_nv = node.SelectSingleNode("@manv");
                dg.Rows[sd].Cells[0].Value = ma_nv.InnerText.ToString();
                XmlNode ho_ten = node.SelectSingleNode("hoten");
                dg.Rows[sd].Cells[1].Value = ho_ten.InnerText.ToString();
                XmlNode dia_chi = node.SelectSingleNode("diachi");
                dg.Rows[sd].Cells[2].Value = dia_chi.InnerText.ToString();

                sd++;
                dg.Rows.Add();
            }
        }
    }*/
    class DSNV_TT
    {
        string manv, hoten, diachi;
        public string Manv
        {
            get { return manv; }
            set { manv=value;}
        }
        public string Hoten
        {
            get { return hoten; }
            set{hoten=value;}
        }
        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }
    }
    class DSNV_XL
    {
        XmlDocument doc = new XmlDocument();
        string tentep = @"C:\Users\SEXY_GIRL\Desktop\KTXML\KTXML\KTXML\dsnhanvien.xml";
        public void HienDaTaGr(DataGridView dg)
        {
            dg.Rows.Clear();
            doc.Load(tentep);
            XmlNodeList DS = doc.SelectNodes("/ds/nhanvien");

            int sd = 0;
            dg.ColumnCount = 3;
            dg.Rows.Add();

            foreach (XmlNode node in DS)
            {
                XmlNode ma_nv = node.SelectSingleNode("@manv");
                dg.Rows[sd].Cells[0].Value = ma_nv.InnerText.ToString();
                XmlNode ho_ten = node.SelectSingleNode("hoten");
                dg.Rows[sd].Cells[1].Value = ho_ten.InnerText.ToString();
                XmlNode dia_chi = node.SelectSingleNode("diachi");
                dg.Rows[sd].Cells[2].Value = dia_chi.InnerText.ToString();
                sd++;
                dg.Rows.Add();
            }
        }
        public void Them(DSNV_TT nv)
        {
            XmlElement goc = doc.DocumentElement;

            XmlElement nhan_vien = doc.CreateElement("nhanvien");
            XmlAttribute ma_nv = doc.CreateAttribute("manv");
            ma_nv.InnerText = nv.Manv;
            nhan_vien.Attributes.Append(ma_nv);

            XmlElement ho_ten = doc.CreateElement("hoten");
            ho_ten.InnerText = nv.Hoten;
            nhan_vien.AppendChild(ho_ten);

            XmlElement dia_chi = doc.CreateElement("diachi");
            dia_chi.InnerText = nv.Diachi;
            nhan_vien.AppendChild(dia_chi);

            goc.AppendChild(nhan_vien);
            doc.Save(tentep);
 
        }
        public void xoa(DSNV_TT nv)
        {
            XmlNode goc = doc.DocumentElement;
            XmlNode cu=doc.SelectSingleNode("/ds/nhanvien[@manv='"+nv.Manv+"']");
            goc.RemoveChild(cu);
            doc.Save(tentep);
        }
        public void tim(DataGridView dg, string idkt)
        {
            dg.Rows.Clear();
            doc.Load(tentep);
            XmlNodeList ds = doc.SelectNodes("/ds/nhanvien[@manv='" + idkt + "']");

            int sd=0;
            dg.ColumnCount = 3;
            dg.Rows.Add();

            foreach (XmlNode node in ds)
            {
                XmlNode ma_nv = node.SelectSingleNode("@manv");
                dg.Rows[sd].Cells[0].Value = ma_nv.InnerText.ToString();
                XmlNode ho_ten = node.SelectSingleNode("hoten");
                dg.Rows[sd].Cells[1].Value = ho_ten.InnerText.ToString();
                XmlNode dia_chi = node.SelectSingleNode("diachi");
                dg.Rows[sd].Cells[2].Value = dia_chi.InnerText.ToString();
                sd++;
                dg.Rows.Add();
 
            }
        }

    }


}
