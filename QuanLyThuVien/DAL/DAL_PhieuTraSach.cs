using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_PhieuTraSach : DBConnect
    {
        public int themPhieuTraSach(DTO_TRASACH dtophieuts)
        {
            try
            {
                _conn.Open();

                string sqlthem = "", sqllay = "";
                    
                sqlthem = string.Format("INSERT INTO TRASACH (ID_USER, NGAYTRA, SONGAYTRE," +
                    " TIENTRE, TIENBOITHUONG, TIENTHUESACH, TONGTIEN, CREATED_AT)" +
                    " VALUES( {0}, '{1}', {2}, {3}, {4}, {5}, {6}, '{7}' )", dtophieuts.ID_USER,
                    dtophieuts.NGAYTRA, dtophieuts.SONGAYTRE, dtophieuts.TIENTRE, dtophieuts.TIENBOITHUONG,
                    dtophieuts.TIENTHUESACH, dtophieuts.TONGTIEN, dtophieuts.CREATED_AT.ToString("yyyy-MM-dd hh:mm:ss"));

                MySqlCommand cmdthem = new MySqlCommand(sqlthem, _conn);

                if (cmdthem.ExecuteNonQuery() > 0)
                {
                    sqllay = string.Format("SELECT ID FROM TRASACH WHERE ID_USER = {0} AND CREATED_AT = '{1}'",
                        dtophieuts.ID_USER, dtophieuts.CREATED_AT.ToString("yyyy-MM-dd hh:mm:ss"));

                    MySqlDataAdapter sda = new MySqlDataAdapter(sqllay, _conn);
                    DataTable dtsacht = new DataTable();

                    sda.Fill(dtsacht);


                    return Int32.Parse(dtsacht.Rows[0]["id"].ToString());
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

            return -1;
        }

        public bool themCTP_TraSach(DTO_CHITIETTRASACH dtoctts)
        {
            try
            {
                _conn.Open();

                string sql = string.Format("INSERT INTO CHITIETTRASACH (ID_TRASACH, ID_SACH, CREATED_AT) VALUES ( {0}, {1}, '{2}' )",
                    dtoctts.ID_TRASACH, dtoctts.ID_SACH, dtoctts.CREATED_AT.ToString("yyyy-MM-dd hh:mm:ss"));

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
    }
}
