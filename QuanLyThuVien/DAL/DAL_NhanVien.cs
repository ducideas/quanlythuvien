using System;
using System.Data;
using DTO;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_NhanVien : DBConnect
    {
        public string layMaNhanVien(string username, string pass)
        {
            string id = "";
            try
            {
                // Ket noi
                _conn.Open();
                var tablenhanvien = "nhanvien";
                MySqlCommand cmd = new MySqlCommand($"SELECT * FROM {tablenhanvien} WHERE username ='" + username + "' and password='" + pass + "'", _conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id = dr["id"].ToString();
                    }
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
            return id;
        }

        public bool themNhanVien(DTO_NHANVIEN dtonhanvien)
        {
            try
            {
                _conn.Open();

                string sql = string.Format("INSERT INTO NHANVIEN (USERNAME, PASSWORD, HOVATEN, GIOITINH," +
                    " SODT, NGAYSINH, DIACHI, EMAIL, NGAYVAOLAM, CHUCVU) " +
                    "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}')",
                    dtonhanvien.USERNAME, dtonhanvien.PASSWORD, dtonhanvien.HOVATEN, dtonhanvien.GIOITINH, dtonhanvien.SODT,
                    dtonhanvien.NGAYSINH, dtonhanvien.DIACHI, dtonhanvien.EMAIL, dtonhanvien.NGAYVAOLAM, dtonhanvien.CHUCVU);

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

        public bool suaNhanVien(DTO_NHANVIEN dtonhanvien)
        {
            try
            {
                _conn.Open();

                string sql = string.Format("UPDATE NHANVIEN SET HOVATEN = '{0}', GIOITINH = '{1}'," +
                    " SODT = '{2}', NGAYSINH = '{3}', DIACHI = '{4}', EMAIL = '{5}', NGAYVAOLAM = '{6}'," +
                    " CHUCVU = '{7}', PASSWORD = '{8}' WHERE ID = {9}", dtonhanvien.HOVATEN,
                    dtonhanvien.GIOITINH, dtonhanvien.SODT, dtonhanvien.NGAYSINH, dtonhanvien.DIACHI, dtonhanvien.EMAIL,
                    dtonhanvien.NGAYVAOLAM, dtonhanvien.CHUCVU, dtonhanvien.PASSWORD, dtonhanvien.ID);

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

        public bool xoaNhanVien(int idnhanvien)
        {
            try
            {
                _conn.Open();

                string sql = string.Format("DELETE FROM NHANVIEN WHERE ID = {0}", idnhanvien);

                MySqlCommand cmd = new MySqlCommand(sql, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Đã xóa nhân viên");
                    return true;
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

            return false;
        }

        public DTO_NHANVIEN layNhanVien(int idnhanvien)
        {
            try
            {
                _conn.Open();

                string sql = string.Format("SELECT * FROM NHANVIEN WHERE ID = {0}", idnhanvien);
                MySqlDataAdapter sda = new MySqlDataAdapter(sql, _conn);
                DataTable dtnhanvien = new DataTable();

                sda.Fill(dtnhanvien);

                if (dtnhanvien.Rows.Count > 0)
                {
                    DTO_NHANVIEN dtonhanvien = new DTO_NHANVIEN();

                    dtonhanvien.ID = idnhanvien;
                    dtonhanvien.USERNAME = dtnhanvien.Rows[0]["username"].ToString();
                    dtonhanvien.PASSWORD = dtnhanvien.Rows[0]["password"].ToString();
                    dtonhanvien.HOVATEN = dtnhanvien.Rows[0]["HoVaTen"].ToString();
                    dtonhanvien.GIOITINH = dtnhanvien.Rows[0]["GioiTinh"].ToString();
                    dtonhanvien.SODT = dtnhanvien.Rows[0]["SoDT"].ToString();
                    dtonhanvien.NGAYSINH = dtnhanvien.Rows[0]["NgaySinh"].ToString();
                    dtonhanvien.EMAIL = dtnhanvien.Rows[0]["Email"].ToString();
                    dtonhanvien.NGAYVAOLAM = dtnhanvien.Rows[0]["NgayVaoLam"].ToString();
                    dtonhanvien.CHUCVU = dtnhanvien.Rows[0]["ChucVu"].ToString();

                    return dtonhanvien;
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

        public DataTable layNhanVien()
        {
            try
            {
                string sql = string.Format("SELECT * FROM NHANVIEN");
                MySqlDataAdapter sda = new MySqlDataAdapter(sql, _conn);
                DataTable dtnhanvien = new DataTable();

                sda.Fill(dtnhanvien);

                return dtnhanvien;

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
