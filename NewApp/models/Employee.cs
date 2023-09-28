namespace NewApp.Models
{
    public class Employee
    {
        public string MaNhanVien { get; set; } 
        public string TenNhanVien { get; set; } 
        public int Tuoi { get; set; }   
        public int Luong { get; set; }  

        public void Input()
        {
            System.Console.Write("Ma Nhan Vien : ");
            MaNhanVien = Console.ReadLine();
            
            System.Console.Write("Ten Nhan Vien : ");
            TenNhanVien = Console.ReadLine();
            
            System.Console.Write("Tuoi : ");
            Tuoi = Convert.ToInt32(Console.ReadLine());
            
            System.Console.Write("Luong : ");
            Luong = Convert.ToInt32(Console.ReadLine());
            
        }

        public void Output()
        {
            System.Console.WriteLine("--------------------------");
            System.Console.WriteLine(MaNhanVien + "-" + TenNhanVien + "-" + Tuoi + "-" + Luong + "USD");

        }
         try
        {
            Console.Write("Tuổi: ");
            Age = int.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Lỗi: Tuổi phải là một số nguyên.");
            Age = 0; // Gán giá trị mặc định
        }
    }
}