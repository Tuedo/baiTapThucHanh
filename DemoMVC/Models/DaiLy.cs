using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using DemoMVC.Models;
namespace DemoMVC.Models
// ho va ten : do duc tue
{
    public class DaiLy : HeThongPhanPhoi
    {
       
        public string MaDaiLy{ get; set; }
       
        public string TenDaiLy{ get; set; }
         public string DiaChi{ get; set; }
         public string NguoiDaiDien{ get; set; }
         public string DienThoai{ get; set; }
         public string MaHTPP{ get; set; }
        
    }
}
