// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


namespace CSharp_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string myName = "My name is Phuong";

            //Console.WriteLine("myName : " + myName);

            //int myInt = 10000;


            // Dat ten tuong minh, de goi nho.
            // cameCase:ky tu dau tien cua chu thu 2 viet hoa
            // Pascal Case: ky tu dau tien deu viet hoa
            // _underScore: ky tu dau tien se la dau _

            //var: kieu du lieu tu suy, tu suy ra kieu du lieu tu gia tri cua bien.
            //var myVariable = 100;
            //var myVariable2 = "string";

            //if (myInt > 10 && myInt < 100001)
            //{
            //Console.WriteLine("myName: " + myName);
            //}

            //var sum = myInt + myVariable;

            //Console.WriteLine("myName: " + myName);
            //Console.WriteLine("sum: " + sum);


            //Bai tap 1:
            int x = 10;
            int y = 5;



            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);

            var sumX = y + 3;
            var sumX1 = y - 2;
            var sumX2 = y * 5;
            var sumX3 = x / y;
            var sumX4 = x % y;


            Console.WriteLine("x = y + 3; x = " + sumX);
            Console.WriteLine("x = y - 2; x = " + sumX1);
            Console.WriteLine("x = y * 5; x = " + sumX2);
            Console.WriteLine("x = x / y; x = " + sumX3);
            Console.WriteLine("x = x % y; x = " + sumX4);

            //Bai tap 2: Tinh tong 2 so bat ky duoc nhap vao tu ban phim
            int a = 0;
            Console.WriteLine("Input a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Value of a is: " + a);
            
            int b = 0;
            Console.WriteLine("Input b");
            b = Convert.ToInt32(Console.ReadLine()); //Use to convert string to int
            Console.WriteLine("Value of b is: " + b);

            var sum02 = a + b;

            Console.WriteLine("Tong cua 2 so la: " + sum02);


            //ReadKey: dung man hinh cho xem user co bam them gi ko, sau do se tat.
            Console.ReadKey();
        }
    }
}