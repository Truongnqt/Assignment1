Console.WriteLine("Nhap so nguyen x : ");
var inputNumber=Console.ReadLine();

var checkChar =int.TryParse(inputNumber, out int x);
while (!checkChar)
{
	Console.WriteLine("Nhap sai dinh dang,nhap lai  : ");
	inputNumber = Console.ReadLine();
    checkChar = int.TryParse(inputNumber, out x);
}
double y = 2 * Math.Pow(x, 3) - 6 * Math.Pow(x, 2) + 2 * x - 1 ;
Console.WriteLine($"Gia tri cua bieu thuc : 2 * Math.Pow(x, 3) - 6 * Math.Pow(x, 2) + 2 * x - 1 = {y} ");

