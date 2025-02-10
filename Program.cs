internal class Program
{
    private static void Main(string[] args)
    {

        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập họ và tên");
        string ten = Console.ReadLine();
        Console.Write("Chào bạn {0} :"+ ten );
        

        /*
        Console.WriteLine("Nhập số thứ nhất:"); 
        double soThuNhat = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Nhập số thứ hai:");
        double soThuHai = Convert.ToDouble(Console.ReadLine());
        double tong = soThuNhat + soThuHai;
        Console.WriteLine(" Tổng của hai số là: " + tong);
        Console.WriteLine(soThuNhat + "+" + soThuHai + "=" + tong);
        Console.WriteLine(" {0} + {1} = {2} ", soThuNhat,soThuHai,tong);
        */
    }
}