using MySql.Data.MySqlClient;
using System.Data;

namespace DAL
{
    public class DAL_BaoCao:DBConnect
    {
        public DataTable layBaoCaoMuonSachTheLoai(int thang)
        {
            var TABLE_BORROWBOOK_REPORT = "baocao_muonsach_theloai";
            var TABLE_TYPE = "theloai";

            string SQL = $"SELECT bc.id, tl.ten, bc.SoLuotMuon from {TABLE_BORROWBOOK_REPORT} bc join {TABLE_TYPE} tl on bc.id_TheLoai = tl.id where bc.Thang= '{thang}'";
            MySqlDataAdapter da = new MySqlDataAdapter(SQL, _conn);
            DataTable dtBaoCaoMuonSachTheLoai = new DataTable();
            da.Fill(dtBaoCaoMuonSachTheLoai);
            return dtBaoCaoMuonSachTheLoai;
        }
        public DataTable layBaoCaoTraSachTre(string ngay)
        {
            var TABLE_RETURNBOOK_REPORT = "baocao_sach_tre";
            var TABLE_SACH= "sach";
            var TABLE_BORROWBOOK = "muonsach";
            var TABLE_RETURNBOOK = "trasach";
            var TABLE_DETAIL_RETURNBOOK = "chitiettrasach";

            string SQL = $"select bctst_final.id, bctst_final.TenSach, bctst_final.Ngay,ms.NgayMuon from(select bctst_update.id, bctst_update.TenSach, bctst_update.Ngay, ts.id_user from(select bctst.id, s.TenSach, bctst.id_TraSach, bctst.Ngay from (select bc.id, bc.id_TraSach, bc.Ngay, ts.id_Sach from {TABLE_RETURNBOOK_REPORT} bc join {TABLE_DETAIL_RETURNBOOK} ts on bc.id_TraSach = ts.id) bctst join {TABLE_SACH} s on bctst.id_Sach = s.id) bctst_update join {TABLE_RETURNBOOK} ts on bctst_update.id_TraSach = ts.id) bctst_final join {TABLE_BORROWBOOK} ms on bctst_final.id_user = ms.id_user where bctst_final.Ngay = '{ngay}'";
            MySqlDataAdapter da = new MySqlDataAdapter(SQL, _conn);
            DataTable dtBaoCaoTraSachTre = new DataTable();
            da.Fill(dtBaoCaoTraSachTre);
            return dtBaoCaoTraSachTre;
        }
    }
}
