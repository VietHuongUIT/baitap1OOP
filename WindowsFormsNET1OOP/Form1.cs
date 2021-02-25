
1
2
3
4
5
6
7
8
9
10
11
12
13
14
15
16
17
18
19
20
21
22
23
24
25
26
27
28
29
30
31
32
33
34
35
36
37
38
39
40
41
42
43
44
45
46
47
48
49
50
51
52
53
54
55
56
57
58
59
60
61
62
63
64
65
66
67
68
69
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QuanLySinhVienConsole
{
    class SinhVien
    {
        private string hoTen;
        private string maSV;
        private int diemToan;
        private int diemVan;
        private int diemAnh;
        public string HoTen
        {
            get = &gt; hoTen; set = &gt; hoTen = value; }
public string MaSV
        {
            get = &gt; maSV; set = &gt; maSV = value; }
public int DiemToan
        {
            get = &gt; diemToan; set = &gt; diemToan = value; }
public int DiemVan
        {
            get = &gt; diemVan; set = &gt; diemVan = value; }
public int DiemAnh
        {
            get = &gt; diemAnh; set = &gt; diemAnh = value; }
public void NhapTT()
        {
            Console.Write("Nhap Ten: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhap MSV: ");
            maSV = Console.ReadLine();
            Console.Write("Nhap diem Toan: ");
            do
            {
                diemToan = Convert.ToInt32(Console.ReadLine());
                if (diemToan & gt; 10 || diemToan & lt; 0)
{
                    Console.WriteLine("Error! 0 &lt; Diem Toan &lt; 10");
                    Console.Write("Nhap lai Diem Toan:");
                }
else break;
            } while (diemToan & lt; 10 || diemToan & gt; 0);
            Console.Write("Nhap diem Van : ");
            do
            {
                diemVan = Convert.ToInt32(Console.ReadLine());
                if (diemVan & gt; 10 || diemVan & lt; 0)
{
                    Console.WriteLine("Error! 0 &lt; Diem Van &lt; 10");
                    Console.Write("Nhap lai Diem Van:");
                }
else break;
            } while (diemVan & lt; 10 || diemVan & gt; 0);
            Console.Write("Nhap diem Anh : ");
            do
            {
                diemAnh = Convert.ToInt32(Console.ReadLine());
                if (diemAnh & gt; 10 || diemAnh & lt; 0)
{
                    Console.WriteLine("Error! 0 &lt; Diem Anh &lt; 10");
                    Console.Write("Nhap lai Diem Anh:");
                }
else break;
            } while (diemAnh & lt; 10 || diemAnh & gt; 0);
        }
        public void XuatTT()
        {
            Console.WriteLine("Ho Ten: {0}|| MSV: {1}|| DiemToan: {2}|| DiemVan|| {3}|| DiemAnh {4}|| DiemTB {5}", hoTen, maSV, diemToan, diemVan, diemAnh, DiemTB(diemToan, diemVan, diemAnh));
        }
        public float DiemTB(int diemtoan, int diemvan, int diemanh)
        {
            return (float)((diemtoan + diemvan + diemanh) / 3.0);
        }
    }
}