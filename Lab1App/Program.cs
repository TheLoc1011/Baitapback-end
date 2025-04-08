using System;

namespace Lab1App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so bai ban muon chay (1 - 10): ");
            int choice = int.Parse(Console.ReadLine() ?? "");

            switch (choice)
            {
                case 1:
                    Bai1.Run();
                    break;
                case 2:
                    Bai2.Run();
                    break;
                case 3:
                    Bai3.Run();
                    break;
                case 4:
                    Bai4.Run();
                    break;
                case 5:
                    Bai5.Run();
                    break;
                case 6:
                    Bai6.Run();
                    break;
                case 7:
                    Bai7.Run();
                    break;
                case 8:
                    Bai8.Run();
                    break;
                case 9:
                    Bai9.Run();
                    break;
                case 10:
                    Bai10.Run();
                    break;
                default:
                    Console.WriteLine("Bai nay chua co hoac khong hop le!");
                    break;
            }
        }

        class Bai1
        {
            public static void Run()
            {
                /*Viết chương trình nhập vào tên và tuổi, sau đó in ra màn hình thông báo "Xin chào
                    [tên], bạn [tuổi] tuổi!".*/
                string ten;
                int tuoi;
                Console.Write("Nhap ten cua ban: ");
                ten = Console.ReadLine();
                Console.Write("Nhap tuoi cua ban: ");
                tuoi = int.Parse(Console.ReadLine() ?? "");
                Console.WriteLine($"Xin chao {ten}, ban {tuoi} tuoi!");
            }
        }

        class Bai2
        {
            public static void Run()
            {
                /*Viết chương trình tính diện tích của hình chữ nhật khi người dùng nhập chiều dài và
                    chiều rộng.*/
                int cdai, crong;
                Console.Write("Nhap chieu dai: ");
                cdai = int.Parse(Console.ReadLine() ?? "");
                Console.Write("Nhap chieu rong: ");
                crong = int.Parse(Console.ReadLine() ?? "");
                Console.WriteLine($"Dien tich HCN la: {cdai * crong}");
            }
        }

        class Bai3
        {
            public static void Run()
            {
                //Bài 3: Viết chương trình chuyển đổi nhiệt độ từ độ C sang độ F
                //Công thức: F = (C * 9 / 5) + 32
                int doC, doF;
                Console.WriteLine("Nhap do C: ");
                doC = int.Parse(Console.ReadLine() ?? "");
                doF = ((doC * 9 / 5) + 32);
                Console.WriteLine($"Do C sau khi chuyen qua do F la: {doF}");

            }
        }
        class Bai4
        {
            public static void Run()
            {
                //Viết chương trình nhập vào một số nguyên và kiểm tra xem số đó có phải là số chẵn
                // hay không.
                int x;
                Console.WriteLine("Nhap x: ");
                x = int.Parse(Console.ReadLine() ?? "");
                if (x % 2 == 0)
                {
                    Console.WriteLine($"{x} la so chan.");
                }
                else
                {
                    Console.WriteLine($"{x} la so le.");
                }
            }
        }
        class Bai5
        {
            public static void Run()
            {
                // Viết chương trình tính tổng và tích của hai số nhập từ bàn phím.
                int x, y;
                Console.WriteLine("Nhap so x: ");
                x = int.Parse(Console.ReadLine() ?? "");
                Console.WriteLine("Nhap so y: ");
                y = int.Parse(Console.ReadLine() ?? "");
                Console.WriteLine($"Tong 2 so la: {x + y}");
                Console.WriteLine($"Tich 2 so la: {x * y}");
            }

        }
        class Bai6
        {
            public static void Run()
            {
                //Bài 6: Viết chương trình kiểm tra xem một số nhập vào có phải là số dương, số âm hay số không.
                int x;
                Console.WriteLine("Nhap x: ");
                x = int.Parse(Console.ReadLine() ?? "");
                if (x > 0)
                {
                    Console.WriteLine($"{x} la so duong.");
                }
                else
                {
                    Console.WriteLine($"{x} la so am.");
                }
            }
        }
        class Bai7
        {
            public static void Run()
            {
                //Bài 7: Viết chương trình kiểm tra xem một năm nhập vào có phải là năm nhuận hay không.
                //(Năm nhuận là năm chia hết cho 4, trừ các năm chia hết cho 100 nhưng không chia hết 400).
                int nam;
                Console.WriteLine("Nhap nam: ");
                nam = int.Parse(Console.ReadLine() ?? "");
                if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))
                {
                    Console.WriteLine($"{nam} la nam nhuan.");
                }
                else
                {
                    Console.WriteLine($"{nam} khong phai la nam nhuan.");
                }
            }
        }
        class Bai8
        {
            public static void Run()
            {
                //Bài 8: Viết chương trình in ra bảng cửu chương từ 1 đến 10.
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"Bang cuu chuong {i}:");

                    // In ra các phép nhân của số i
                    for (int j = 1; j <= 10; j++)
                    {
                        Console.WriteLine($"{i} x {j} = {i * j}");
                    }
                    Console.WriteLine();
                }
            }
        }
        class Bai9
        {
            public static void Run()
            {
                //Bài 9: Viết chương trình tính giai thừa của một số nguyên dương n.
                int n;
                long factorial = 1;

                // Nhập số nguyên dương n
                Console.Write("Nhap mot so nguyen duong: ");
                n = int.Parse(Console.ReadLine() ?? "");

                // Kiểm tra xem n có phải là số nguyên dương không
                if (n < 0)
                {
                    Console.WriteLine("Vui long nhap mot so nguyen duong.");
                }
                else
                {
                    // Tính giai thừa
                    for (int i = 1; i <= n; i++)
                    {
                        factorial *= i;  // Giai thừa = giai thừa trước * i
                    }

                    // In kết quả
                    Console.WriteLine($"Giai thua cua {n} la: {factorial}");

                }
            }
        }
    }
    class Bai10
    {
        public static void Run()
        {
            //Bài 10: Viết chương trình kiểm tra xem một số có phải là số nguyên tố hay không.
            int n;

            // Nhap so nguyen duong
            Console.Write("Nhap mot so nguyen duong: ");
            n = int.Parse(Console.ReadLine() ?? "");

            // Kiem tra so nguyen to
            if (n <= 1)
            {
                Console.WriteLine($"{n} khong phai la so nguyen to.");
            }
            else
            {
                bool isPrime = true;  // Bien de kiem tra so nguyen to

                // Kiem tra chia het tu 2 den can bac 2 cua n
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)  // Neu n chia het cho i thi khong phai so nguyen to
                    {
                        isPrime = false;
                        break;
                    }
                }

                // In ket qua
                if (isPrime)
                    Console.WriteLine($"{n} la so nguyen to.");
                else
                    Console.WriteLine($"{n} khong phai la so nguyen to.");
            }
        }
    }
}