using System;
using System.Data;
using DTO;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_Sach : DBConnect
    {
        public DataTable laySach()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT S.ID, TENSACH, TACGIA, T.TEN, NAMXUATBAN, NHAXUATBAN, TRIGIA, TINHTRANG, SOLUONG FROM SACH S, THELOAI T", _conn);
            DataTable dtsach = new DataTable();
            da.Fill(dtsach);
            return dtsach;
        }

        public bool themSach(DTO_SACH book)
        {
            try
            {
                // Mở kết nối
                _conn.Open();

                // Query string 
                string SQL = $"INSERT INTO sach (id, TenSach, TacGia, id_TheLoai, NamXuatBan, NhaXuatBan, TriGia, TinhTrang, SoLuong) " +
                             $"VALUES ({book.ID}, '{book.TENSACH}', '{book.TACGIA}', {book.ID_THELOAI}, {book.NAMXUATBAN}, '{book.NHAXUATBAN}', {book.TRIGIA}, '{book.TINHTRANG}', {book.SOLUONG})";
                // Command 
                MySqlCommand cmd = new MySqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch{}
            finally
            {
                // Đóng kết nối
                _conn.Close();
            }
            return false;
        }

        public bool xoaSach(int Sach_ID)
        {
            try
            {
                // Mở kết nối
                _conn.Open();
                // Query string
                string SQL = $"DELETE FROM sach WHERE id = {Sach_ID}";
                // Command
                MySqlCommand cmd = new MySqlCommand(SQL, _conn);
                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch{}
            finally
            {
                // Đóng kết nối
                _conn.Close();
            }
            return false;
        }

        public bool suaSach(DTO_SACH book)
        {
            try
            {
                // Mở kết nối
                _conn.Open();

                // Query string
                string SQL = $"UPDATE sach " +
                             $"SET TenSach = '{book.TENSACH}', TacGia = '{book.TACGIA}', " +
                             $"id_TheLoai = {book.ID_THELOAI}, NamXuatBan = {book.NAMXUATBAN}, NhaXuatBan = '{book.NHAXUATBAN}', TriGia = {book.TRIGIA}," +
                             $" TinhTrang = '{book.TINHTRANG}', SoLuong = 0 " +
                             $"WHERE ID = { book.ID }";

                // Command
                MySqlCommand cmd = new MySqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch{}
            finally
            {
                // Đóng kết nối
                _conn.Close();
            }
            return false;
        }
        public bool nhapSach()
        {
            return false;
        }

        public bool suaTinhTrangSach(int idsach, string statussach)
        {
            try
            {
                _conn.Open();

                string sql = string.Format("UPDATE SACH SET TINHTRANG = '{0}', UPDATED_AT = '{1}' WHERE ID = {2}",
                    statussach, DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"), idsach);

                MySqlCommand cmd = new MySqlCommand(sql, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                _conn.Close();
            }

            return false;
        }

        public DataTable laySach(string infosach)
        {
            try
            {
                _conn.Open();

                string sql = string.Format("SELECT S.ID, TENSACH, TACGIA, TL.TEN, TINHTRANG, TRIGIA," +
                    " NHAXUATBAN, NAMXUATBAN, SOLUONG, S.CREATED_AT, S.UPDATED_AT FROM SACH S, THELOAI TL " +
                    "WHERE S.ID_THELOAI = TL.ID AND (TENSACH LIKE '%{0}%' OR TL.TEN LIKE '%{0}%' OR S.ID = '{0}')", infosach);
                MySqlDataAdapter sda = new MySqlDataAdapter(sql, _conn);
                DataTable dtsach = new DataTable();

                sda.Fill(dtsach);

                if (dtsach.Rows.Count > 0)
                {
                    return dtsach;
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

        public DataTable laySachVaTheLoai()
        {
            try
            {
                _conn.Open();

                string sql = string.Format("SELECT S.ID, TENSACH, TACGIA, TL.TEN, TINHTRANG, TRIGIA," +
                    " NHAXUATBAN, NAMXUATBAN, SOLUONG, S.CREATED_AT, S.UPDATED_AT FROM SACH S, THELOAI TL " +
                    "WHERE S.ID_THELOAI = TL.ID");
                MySqlDataAdapter sda = new MySqlDataAdapter(sql, _conn);
                DataTable dtsach = new DataTable();

                sda.Fill(dtsach);

                if (dtsach.Rows.Count > 0)
                {
                    return dtsach;
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
        public DataTable timSach(String ThongTinSach)
        {
            try
            {
                _conn.Open();
                string sql = $"select s.id, s.TenSach, s.TacGia, s.id_TheLoai, s.NamXuatBan, s.NhaXuatBan, s.TriGia, s.TinhTrang, s.SoLuong, s.created_at, s.updated_at from sach s join theloai tl where s.id_TheLoai=tl.id && ( tl.Ten like'%{ThongTinSach}%' || s.TenSach like '%{ThongTinSach}%' || s.id ='{ThongTinSach}') ;";
                MySqlDataAdapter sda = new MySqlDataAdapter(sql, _conn);
                DataTable dtsach = new DataTable();

                sda.Fill(dtsach);

                if (dtsach.Rows.Count > 0)
                {
                    return dtsach;
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