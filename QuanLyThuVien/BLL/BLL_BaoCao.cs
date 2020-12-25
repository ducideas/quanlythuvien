using DAL;
using System.Data;

namespace BLL
{
    public class BLL_BaoCao
    {
        DAL_BaoCao dalReport = new DAL_BaoCao();

        public DataTable layBaoCaoMuonSachTheLoai(int thang)
        {
            return dalReport.layBaoCaoMuonSachTheLoai(thang);
        }
        public DataTable layBaoCaoTraSachTre(string ngay)
        {
            return dalReport.layBaoCaoTraSachTre(ngay);
        }
    }
}
