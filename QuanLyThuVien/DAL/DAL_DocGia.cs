using System;
using System.Data;
using DTO;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_DocGia : DBConnect
    {
        /*Get toàn bộ Độc giả*/
        public DataTable layDocGia()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM DOCGIA", _conn);
            DataTable dtdocgia = new DataTable();
            da.Fill(dtdocgia);
            return dtdocgia;
        }

        /*Thêm độc giả*/
        public bool themDocGia(DTO_DOCGIA reader)
        {
            try
            {
                // Ket noi
                _conn.Open();

                var tabledocgia = "docgia";
                // Query string - vì mình để TV_ID là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                string SQL = $"INSERT INTO {tabledocgia} (id, HoVaTen, SoDT, GioiTinh, DiaChi, NgaySinh, LoaiDocGia, Email, NgayLapThe, TongNo) " +
                             $"VALUES ({reader.ID}, '{reader.HOVATEN}', '{reader.SODT}', '{reader.GIOITINH}', '{reader.DIACHI}', '{reader.NGAYSINH}', '{reader.LOAIDOCGIA}', '{reader.EMAIL}', '{reader.NGAYLAPTHE}', 0)";

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                MySqlCommand cmd = new MySqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }
            return false;
        }

        /*Xóa thành viên*/
        public bool xoaDocGia(int DocGia_ID)
        {
            try
            {
                // Ket noi
                _conn.Open();
                var tabledocgia = "docgia";
                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = $"DELETE FROM {tabledocgia} WHERE id = {DocGia_ID}";

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                MySqlCommand cmd = new MySqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }

        /*Sửa độc giả*/
        public bool suaDocGia(DTO_DOCGIA reader)
        {
            try
            {
                // Ket noi
                _conn.Open();

                var tabledocgia = "docgia";
                // Query string - vì mình để TV_ID là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                string SQL = $"UPDATE {tabledocgia} " +
                             $"SET HoVaTen = '{reader.HOVATEN}', SoDT = '{reader.SODT}', LoaiDocGia = '{reader.LOAIDOCGIA}', NgayLapThe = '{reader.NGAYLAPTHE}', DiaChi = '{reader.DIACHI}', NgaySinh = '{reader.NGAYSINH}', Email = '{reader.EMAIL}' " +
                             $"WHERE ID = { reader.ID }";

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                MySqlCommand cmd = new MySqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }
            return false;
        }

        public DTO_DOCGIA layDocGia(int iddocgia)
        {
            try
            {
                _conn.Open();

                string sql = string.Format("SELECT * FROM DOCGIA WHERE ID = {0}", iddocgia);
                MySqlDataAdapter sda = new MySqlDataAdapter(sql, _conn);
                DataTable dtnhanvien = new DataTable();

                sda.Fill(dtnhanvien);

                if (dtnhanvien.Rows.Count > 0)
                {
                    DTO_DOCGIA dtodocgia = new DTO_DOCGIA();

                    dtodocgia.ID = iddocgia;
                    dtodocgia.HOVATEN = dtnhanvien.Rows[0]["HoVaTen"].ToString();
                    dtodocgia.GIOITINH = dtnhanvien.Rows[0]["GioiTinh"].ToString();
                    dtodocgia.SODT = dtnhanvien.Rows[0]["SoDT"].ToString();
                    dtodocgia.LOAIDOCGIA = dtnhanvien.Rows[0]["LoaiDocGia"].ToString();
                    dtodocgia.NGAYSINH = dtnhanvien.Rows[0]["NgaySinh"].ToString();
                    dtodocgia.DIACHI = dtnhanvien.Rows[0]["DiaChi"].ToString();
                    dtodocgia.EMAIL = dtnhanvien.Rows[0]["Email"].ToString();
                    //dtodocgia.NGAYLAPTHE = dtnhanvien.Rows[0]["NgayLapThe"].ToString();
                    dtodocgia.TONGNO = Int32.Parse(dtnhanvien.Rows[0]["TongNo"].ToString());

                    return dtodocgia;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                _conn.Close();
            }

            return null;
        }
        public DataTable timDocGia(string ThongTinDoc)
        {
            try
            {
                _conn.Open();
                string sql = $"select * from docgia where id='{ThongTinDoc}' || HoVaTen like '%{ThongTinDoc}%' || SoDT='%{ThongTinDoc}%'";
                MySqlDataAdapter sda = new MySqlDataAdapter(sql, _conn);
                DataTable dtDocGia = new DataTable();

                sda.Fill(dtDocGia);

                if (dtDocGia.Rows.Count > 0)
                {
                    return dtDocGia;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                _conn.Close();
            }

            return null;
        }
    }
    
}