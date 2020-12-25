using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_QuyDinh : DBConnect
    {
        public static string TABLE_SETTING = "setting";
        public DataTable layQuyDinh()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM setting", _conn);
            DataTable dtSetting = new DataTable();
            da.Fill(dtSetting);
            return dtSetting;
        }
        public bool themSetting(DTO_SETTING dtoSetting)
        {
            try
            {
                _conn.Open();
                
                string SQL = $"INSERT INTO {TABLE_SETTING} (id,nameSetting, valueSetting) " +
                             $"VALUES ({dtoSetting.ID}, '{dtoSetting.NAMESETTING}', '{dtoSetting.VALUESETTING}')";
                MySqlCommand cmd = new MySqlCommand(SQL, _conn);
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
        public bool xoaQuyDinh(int IdSetsting)
        {
            try
            {
                _conn.Open();
                string SQL = $"DELETE FROM {TABLE_SETTING} WHERE id = '{IdSetsting}'";
                MySqlCommand cmd = new MySqlCommand(SQL, _conn);
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
        public bool suaQuyDinh(DTO_SETTING dtoSetting)
        {
            try
            {
                _conn.Open();
                string SQL = $"UPDATE {TABLE_SETTING} SET nameSetting='{dtoSetting.NAMESETTING}', valueSetting='{dtoSetting.VALUESETTING}' WHERE id='{dtoSetting.ID}'";
                MySqlCommand cmd = new MySqlCommand(SQL, _conn);
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

        public int layQuyDinh(string namequydinh)
        {
            try
            {
                _conn.Open();

                string sql = string.Format("SELECT VALUESETTING FROM SETTING WHERE NAMESETTING LIKE '{0}'", namequydinh);
                MySqlDataAdapter sda = new MySqlDataAdapter(sql, _conn);
                DataTable dtquydinh = new DataTable();

                sda.Fill(dtquydinh);

                int mucquydinh = Int32.Parse(dtquydinh.Rows[0]["valueSetting"].ToString());


                return mucquydinh;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                _conn.Close();
            }

            return 0;
        }
    }
}
