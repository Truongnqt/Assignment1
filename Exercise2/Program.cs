Console.WriteLine("Nhap so nguyen x : ");
var inputNumber = Console.ReadLine();

var checkChar = int.TryParse(inputNumber, out int decimalNumber);
while (!checkChar)
{
	Console.WriteLine("Nhap sai dinh dang,nhap lai  : ");
	inputNumber = Console.ReadLine();
	checkChar = int.TryParse(inputNumber, out decimalNumber);
}
if (decimalNumber == 0)
{
	Console.WriteLine("0");
}
List<int> list = new List<int>();
while (decimalNumber > 0)
{
	int remainder = decimalNumber % 2;
	list.Add(remainder);
	decimalNumber = decimalNumber / 2;
}
list.Reverse();
Console.WriteLine("Nhi phan: ");
foreach (var item in list)
{
	Console.Write(item);
}	