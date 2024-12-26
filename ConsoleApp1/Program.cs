// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
Khai báo biến: Kieu_du_lieu Ten_bien;
Tên biến: có phân biệt chữ hoa/thường 
    - a..z, A..Z
    - 0..9
    - _
    - ko dc bắt đầu bằng số

*/
string studentName; // biến kiểu chuỗi (xâu ký tự)
int studentAge = 25; // kiểu số nguyên (32bit, có dấu)
char a; // kiểu 1 ký tự 
bool isValid; // kiểu luận lý true,false

float c; // kiểu số thực dấu chấm động (32bit)
//c = 12.12; // error: nếu nhập số thực có dấu chấm động thì C# ngầm hiểu là kiểu double(64bit)
c = 12.12f; // thêm f vào hậu tố để C# biết đó là giá trị kiểu float
c = (float)12.12; // ép kiểu

// string: là kiểu dữ liệu tham chiếu
object d;
//d = studentName; // error: biến sau khi khai báo phải dc khởi tạo giá trị thì mới dùng dc
studentName = "bunbo";
d = studentName;

int e, f, g;
double so_pi = 3.14;

Console.WriteLine(so_pi);

// Lớp Console , thuộc namespace System, có nhiều phương thức tĩnh (static)
// Có thể gọi mà ko cần tạo đối tượng console

Console.Title = "Ví dụ về sử dụng console";
Console.ForegroundColor = ConsoleColor.DarkMagenta; //màu chữ
Console.BackgroundColor = ConsoleColor.Blue; // màu nền
Console.ResetColor(); //reset màu

Console.WriteLine("Xin chào !");

string hovaten;
Console.WriteLine("Vui lòng nhập họ tên");
hovaten = Console.ReadLine();
Console.WriteLine("Xin chào {0}", hovaten);

// convert chuỗi thành số
// Cách 1 : float.Parse()
// Cách 2: Convert.Tosingle()
// Lưu ý: thao tác convert dễ bị handle exception. sau này nhớ thêm try...catch vào
float x, y;
string sinput;
Console.WriteLine("Nhập số a : ");
sinput = Console.ReadLine();
x = float.Parse(sinput);

Console.WriteLine("Nhập số b : ");
sinput = Console.ReadLine();
y = Convert.ToSingle(sinput);

Console.WriteLine("Số a : {0} ; số b : {1}", x, y);

// Khai báo biến kiểu ngầm định : var
var k = 12.12f; // kiểu float
var isEmpty = true; // kiểu boolean

// hằng số :const
const double PI = 3.14;
const string WED = "Thứ tư";
Console.WriteLine("Số Pi : {0}", PI);
Console.WriteLine("Hôm nay là {0}", WED);
