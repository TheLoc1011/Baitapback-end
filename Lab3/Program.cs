using System;
using System.Collections.Generic;

public class canbo
{
    public string hoten { get; set; }
    public int namsinh { get; set; }
    public string gioitinh { get; set; }
    public string diachi { get; set; }

    public virtual void nhapthongtin()
    {
        Console.Write("Nhap ho ten: ");
        hoten = Console.ReadLine();
        Console.Write("Nhap nam sinh: ");
        namsinh = int.Parse(Console.ReadLine());
        Console.Write("Nhap gioi tinh: ");
        gioitinh = Console.ReadLine();
        Console.Write("Nhap dia chi: ");
        diachi = Console.ReadLine();
    }

    public virtual void hienthithongtin()
    {
        Console.WriteLine($"Ho ten: {hoten}, Nam sinh: {namsinh}, Gioi tinh: {gioitinh}, Dia chi: {diachi}");
    }
}

public class congnhan : canbo
{
    public int bac { get; set; }

    public override void nhapthongtin()
    {
        base.nhapthongtin();
        Console.Write("Nhap bac (1-7): ");
        bac = int.Parse(Console.ReadLine());
    }

    public override void hienthithongtin()
    {
        base.hienthithongtin();
        Console.WriteLine($"Bac: {bac}/7");
    }
}

public class kysu : canbo
{
    public string nganhdaotao { get; set; }

    public override void nhapthongtin()
    {
        base.nhapthongtin();
        Console.Write("Nhap nganh dao tao: ");
        nganhdaotao = Console.ReadLine();
    }

    public override void hienthithongtin()
    {
        base.hienthithongtin();
        Console.WriteLine($"Nganh dao tao: {nganhdaotao}");
    }
}

public class nhanvien : canbo
{
    public string congviec { get; set; }

    public override void nhapthongtin()
    {
        base.nhapthongtin();
        Console.Write("Nhap cong viec: ");
        congviec = Console.ReadLine();
    }

    public override void hienthithongtin()
    {
        base.hienthithongtin();
        Console.WriteLine($"Cong viec: {congviec}");
    }
}

public class qlcb
{
    private List<canbo> danhsach = new List<canbo>();

    public void nhapcanbomoi()
    {
        Console.WriteLine("Chon loai can bo can nhap:");
        Console.WriteLine("1. Cong nhan");
        Console.WriteLine("2. Ky su");
        Console.WriteLine("3. Nhan vien");
        Console.Write("Lua chon cua ban: ");
        int chon = int.Parse(Console.ReadLine());

        canbo cb;
        switch (chon)
        {
            case 1:
                cb = new congnhan();
                break;
            case 2:
                cb = new kysu();
                break;
            case 3:
                cb = new nhanvien();
                break;
            default:
                Console.WriteLine("Lua chon khong hop le!");
                return;
        }

        cb.nhapthongtin();
        danhsach.Add(cb);
        Console.WriteLine("Da them can bo thanh cong!");
    }

    public void timkiemtheohoten()
    {
        Console.Write("Nhap ho ten can tim: ");
        string ten = Console.ReadLine();
        bool timthay = false;
        foreach (var cb in danhsach)
        {
            if (cb.hoten.ToLower().Contains(ten.ToLower()))
            {
                cb.hienthithongtin();
                timthay = true;
            }
        }

        if (!timthay)
            Console.WriteLine("Khong tim thay can bo nao voi ho ten da nhap.");
    }

    public void hienthidanhsach()
    {
        Console.WriteLine("Danh sach can bo:");
        foreach (var cb in danhsach)
        {
            cb.hienthithongtin();
            Console.WriteLine("----------------------------");
        }
    }
}

public class program
{
    public static void Main(string[] args)
    {
        qlcb ql = new qlcb();
        int luachon;

        do
        {
            Console.WriteLine("\n===== Quan ly can bo =====");
            Console.WriteLine("1. Them can bo moi");
            Console.WriteLine("2. Tim kiem theo ho ten");
            Console.WriteLine("3. Hien thi danh sach can bo");
            Console.WriteLine("4. Thoat");
            Console.Write("Chon chuc nang: ");
            luachon = int.Parse(Console.ReadLine());

            switch (luachon)
            {
                case 1:
                    ql.nhapcanbomoi();
                    break;
                case 2:
                    ql.timkiemtheohoten();
                    break;
                case 3:
                    ql.hienthidanhsach();
                    break;
                case 4:
                    Console.WriteLine("Thoat chuong trinh.");
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le.");
                    break;
            }
        } while (luachon != 4);
    }
}
