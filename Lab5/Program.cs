using System;
using System.Collections.Generic;

class PhanSo
{
    public int TuSo { get; set; }
    public int MauSo { get; set; }

    public PhanSo()
    {
        TuSo = 0;
        MauSo = 1;
    }

    public PhanSo(int tu, int mau)
    {
        TuSo = tu;
        MauSo = (mau != 0) ? mau : 1;
    }

    public void Nhap()
    {
        Console.Write("Nhap tu so: ");
        TuSo = int.Parse(Console.ReadLine());

        Console.Write("Nhap mau so (khac 0): ");
        do
        {
            MauSo = int.Parse(Console.ReadLine());
            if (MauSo == 0)
            {
                Console.Write("Mau so phai khac 0. Nhap lai: ");
            }
        } while (MauSo == 0);
    }

    public static PhanSo Cong(PhanSo a, PhanSo b)
    {
        int tu = a.TuSo * b.MauSo + b.TuSo * a.MauSo;
        int mau = a.MauSo * b.MauSo;
        return new PhanSo(tu, mau);
    }

    public void Xuat()
    {
        Console.WriteLine($"{TuSo}/{MauSo}");
    }
}

abstract class Hinh
{
    public abstract double TinhChuVi();
    public abstract double TinhDienTich();
}

class HinhTron : Hinh
{
    public double BanKinh { get; set; }

    public HinhTron(double r)
    {
        BanKinh = r;
    }

    public override double TinhChuVi()
    {
        return 2 * Math.PI * BanKinh;
    }

    public override double TinhDienTich()
    {
        return Math.PI * BanKinh * BanKinh;
    }
}

class HinhVuong : Hinh
{
    public double Canh { get; set; }

    public HinhVuong(double c)
    {
        Canh = c;
    }

    public override double TinhChuVi()
    {
        return 4 * Canh;
    }

    public override double TinhDienTich()
    {
        return Canh * Canh;
    }
}

class HinhChuNhat : Hinh
{
    public double Dai { get; set; }
    public double Rong { get; set; }

    public HinhChuNhat(double dai, double rong)
    {
        Dai = dai;
        Rong = rong;
    }

    public override double TinhChuVi()
    {
        return 2 * (Dai + Rong);
    }

    public override double TinhDienTich()
    {
        return Dai * Rong;
    }
}

class HinhTamGiac : Hinh
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }

    public HinhTamGiac(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }

    public override double TinhChuVi()
    {
        return A + B + C;
    }

    public override double TinhDienTich()
    {
        double p = (A + B + C) / 2;
        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }
}

class Program
{
    static void Main()
    {
        int choice;
        do
        {
            Console.WriteLine("\n=== CHUONG TRINH ===");
            Console.WriteLine("1. Tinh tong cac phan so");
            Console.WriteLine("2. Tinh chu vi va dien tich cac hinh");
            Console.WriteLine("0. Thoat");
            Console.Write("Nhap lua chon: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    BaitapPhanSo();
                    break;
                case 2:
                    BaitapHinhHoc();
                    break;
                case 0:
                    Console.WriteLine("Tam biet!");
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le.");
                    break;
            }

        } while (choice != 0);
    }

    static void BaitapPhanSo()
    {
        List<PhanSo> danhSach = new List<PhanSo>();

        Console.Write("Nhap so luong phan so: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Phan so thu {i + 1}:");
            PhanSo ps = new PhanSo();
            ps.Nhap();
            danhSach.Add(ps);
        }

        PhanSo tong = new PhanSo(0, 1);
        foreach (PhanSo ps in danhSach)
        {
            tong = PhanSo.Cong(tong, ps);
        }

        Console.WriteLine("Tong cac phan so la:");
        tong.Xuat();
    }

    static void BaitapHinhHoc()
    {
        List<Hinh> danhSachHinh = new List<Hinh>();

        Console.Write("Nhap so luong hinh: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nChon loai hinh thu {i + 1}:");
            Console.WriteLine("1. Hinh tron");
            Console.WriteLine("2. Hinh vuong");
            Console.WriteLine("3. Hinh chu nhat");
            Console.WriteLine("4. Hinh tam giac");
            Console.Write("Nhap lua chon (1-4): ");
            int loai = int.Parse(Console.ReadLine());

            switch (loai)
            {
                case 1:
                    Console.Write("Nhap ban kinh: ");
                    double r = double.Parse(Console.ReadLine());
                    danhSachHinh.Add(new HinhTron(r));
                    break;
                case 2:
                    Console.Write("Nhap canh: ");
                    double c = double.Parse(Console.ReadLine());
                    danhSachHinh.Add(new HinhVuong(c));
                    break;
                case 3:
                    Console.Write("Nhap chieu dai: ");
                    double dai = double.Parse(Console.ReadLine());
                    Console.Write("Nhap chieu rong: ");
                    double rong = double.Parse(Console.ReadLine());
                    danhSachHinh.Add(new HinhChuNhat(dai, rong));
                    break;
                case 4:
                    Console.Write("Nhap canh a: ");
                    double a = double.Parse(Console.ReadLine());
                    Console.Write("Nhap canh b: ");
                    double b = double.Parse(Console.ReadLine());
                    Console.Write("Nhap canh c: ");
                    double cc = double.Parse(Console.ReadLine());
                    if (a + b > cc && a + cc > b && b + cc > a)
                        danhSachHinh.Add(new HinhTamGiac(a, b, cc));
                    else
                        Console.WriteLine("Tam giac khong hop le, bo qua.");
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le.");
                    break;
            }
        }

        double tongChuVi = 0;
        double tongDienTich = 0;

        foreach (Hinh h in danhSachHinh)
        {
            tongChuVi += h.TinhChuVi();
            tongDienTich += h.TinhDienTich();
        }

        Console.WriteLine("\nTong chu vi cac hinh: " + tongChuVi);
        Console.WriteLine("Tong dien tich cac hinh: " + tongDienTich);
    }
}
