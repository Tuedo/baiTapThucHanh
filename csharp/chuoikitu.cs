using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
namespace CS12_String {
    class Program {

        /// <summary>
        /// Ví dụ khai báo chuỗi
        /// </summary>
        static void khaibaochuoi() {
            string sExample = "Xin chào";   // Khai báo và khởi tạo chuỗi
            sExample += " các bạn";         // Nối chuỗi +=, trả về "Xin chào các bạn"
            sExample = sExample + "!";      // Nối chuỗi +, trả về "Xin chào các bạn!"
            char c = sExample[1];           // c= 'i'

        }
    /// <summary>
        /// Ví dụ định dạng với $
        /// </summary>
        static void vidu1()
        {
            Console.WriteLine($"{"VòngLặp",10} {"Chẵn/Lẻ", -5}");
            for (int i = 8; i < 15; i++)
            {
                string chanle = (i%2 == 0) ? "Chẵn" : "Lẻ";
                Console.WriteLine($"{i,10} {chanle, -5}");
            }
        }
        /// <summary>
        /// Một số phép toán trên chuỗi
        /// </summary>
        static void vidu2()
        {
            string stringA =  "Xin chào,";
            string stringB = "các bạn!";
        
    }
}
