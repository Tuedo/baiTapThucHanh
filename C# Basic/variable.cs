// ho va ten : Do Duc Tue mssv 2121050190

namespace variable
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Khai báo biến có tên studentName, lưu loại dữ liệu chuỗi
            string studentName;

            // Khai báo biến và gán ngay giá trị lưu vào biến
            string address = "Hà Nội, Việt Nam";

            // Khai báo biến, sau đó trước khi sử dụng gán giá trị cho biến
            int studentAge;
            studentAge = 22;

            int seconds = 60;                    //khai báo biến số nguyên
            double so_pi = 3.14;                 //khai báo biến số thực
            bool deltaIsSezo = true;             //Khai báo biến logic
            char chooseAction = 'S' ;            //Khai báo biến kiểu ký tự
            string msgResult = "Kết quả giải:" ; // khai báo biến chuỗi


             Console.WriteLine();                                                //Xuống dòng
            Console.WriteLine();                                                //Xuống dòng
            
            Console.ForegroundColor = ConsoleColor.DarkMagenta;                 //Đặt màu chữ
            Console.WriteLine("XIN CHÀO - CHƯƠNG TRÌNH NHẬP XUẤT DỮ LIỆU");     //In dòng chữ
            Console.ResetColor();                                               //Reset màu
            
            Console.Write("Giá trị biến so_pi là : ");                          //In dòng chữ
            Console.WriteLine(so_pi);                                           //In giá trị biến
            Console.WriteLine();                                                //Xuống dòng

            int a = 123;
            double b = 567.123;

            Console.WriteLine("Biến a = {0}, biến b = {1}", a, b);

            Console.WriteLine($"Biến a = {a}, biến b = {b} - tích là {a * b}");


 
            
            

        }

         


    }
}
