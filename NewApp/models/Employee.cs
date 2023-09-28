namespace Employee.cs
{
    public class Employee
    {
        public string EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        // Phương thức nhập thông tin
    public void InputInfo()
    {
        Console.WriteLine("Nhập thông tin nhân viên:");
        Console.Write("Mã nhân viên: ");
        EmployeeID = Console.ReadLine();
        Console.Write("Tên nhân viên: ");
        EmployeeName = Console.ReadLine();
        Console.Write("Tuổi: ");
        Age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Lương: ");
        Salary = Convert.ToDouble(Console.ReadLine());
    }// Phương thức hiển thị thông tin
    public void DisplayInfo()
    {
        Console.WriteLine("Thông tin nhân viên:");
        Console.WriteLine($"Mã nhân viên: {EmployeeID}");
        Console.WriteLine($"Tên nhân viên: {EmployeeName}");
        Console.WriteLine($"Tuổi: {Age}");
        Console.WriteLine($"Lương: {Salary}");
    }
    }
}