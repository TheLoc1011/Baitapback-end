using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int choice;
        do
        {
            Console.WriteLine("\nCHON BAI TAP (1-6), HOAC 0 DE THOAT:");
            Console.WriteLine("1. Tinh tong so chan trong mang");
            Console.WriteLine("2. Kiem tra va hien thi so nguyen to trong mang");
            Console.WriteLine("3. Dem so am va so duong trong mang");
            Console.WriteLine("4. Tim so lon thu hai trong mang");
            Console.WriteLine("5. Hoan vi 2 so nguyen");
            Console.WriteLine("6. Sap xep mang so thuc tang dan");
            Console.Write("Nhap lua chon cua ban: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Bai1_TongSoChan();
                    break;
                case 2:
                    Bai2_SoNguyenTo();
                    break;
                case 3:
                    Bai3_DemSoAmDuong();
                    break;
                case 4:
                    Bai4_TimSoLonThuHai();
                    break;
                case 5:
                    Bai5_HoanVi2So();
                    break;
                case 6:
                    Bai6_SapXepTangDan();
                    break;
                case 0:
                    Console.WriteLine("Thoat chuong trinh.");
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le.");
                    break;
            }
        } while (choice != 0);
    }

    // Bai 1
    static void Bai1_TongSoChan()
    {
        Console.Write("Nhap so phan tu cua mang: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Nhap cac phan tu:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"arr[{i}] = ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        int sum = arr.Where(x => x % 2 == 0).Sum();
        Console.WriteLine("Tong cac so chan: " + sum);
    }

    // Bai 2
    static void Bai2_SoNguyenTo()
    {
        Console.Write("Nhap so phan tu cua mang: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Nhap cac phan tu:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"arr[{i}] = ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Cac phan tu la so nguyen to:");
        for (int i = 0; i < n; i++)
        {
            if (LaSoNguyenTo(arr[i]))
            {
                Console.WriteLine($"Chiso: {i}, Gia tri: {arr[i]}");
            }
        }
    }

    static bool LaSoNguyenTo(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
            if (n % i == 0) return false;
        return true;
    }

    // Bai 3
    static void Bai3_DemSoAmDuong()
    {
        Console.Write("Nhap so phan tu cua mang: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Nhap cac phan tu:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"arr[{i}] = ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        int soAm = arr.Count(x => x < 0);
        int soDuong = arr.Count(x => x > 0);
        Console.WriteLine($"So phan tu am: {soAm}");
        Console.WriteLine($"So phan tu duong: {soDuong}");
    }

    // Bai 4
    static void Bai4_TimSoLonThuHai()
    {
        Console.Write("Nhap so phan tu cua mang: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Nhap cac phan tu:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"arr[{i}] = ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        int max = arr.Max();
        int max2 = int.MinValue;
        foreach (int x in arr)
        {
            if (x != max && x > max2)
                max2 = x;
        }

        if (max2 == int.MinValue)
            Console.WriteLine("Khong co so lon thu hai.");
        else
            Console.WriteLine("So lon thu hai la: " + max2);
    }

    // Bai 5
    static void Bai5_HoanVi2So()
    {
        Console.Write("Nhap so a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nhap so b: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine($"Truoc hoan vi: a = {a}, b = {b}");
        HoanVi(ref a, ref b);
        Console.WriteLine($"Sau hoan vi: a = {a}, b = {b}");
    }

    static void HoanVi(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    // Bai 6
    static void Bai6_SapXepTangDan()
    {
        Console.Write("Nhap so phan tu cua mang: ");
        int n = int.Parse(Console.ReadLine());
        double[] arr = new double[n];
        Console.WriteLine("Nhap cac phan tu:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"arr[{i}] = ");
            arr[i] = double.Parse(Console.ReadLine());
        }

        Array.Sort(arr);
        Console.WriteLine("Mang sau khi sap xep tang dan:");
        foreach (var x in arr)
        {
            Console.Write(x + " ");
        }
        Console.WriteLine();
    }
}
