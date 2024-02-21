Console.WriteLine("Nhap so nguyen x : ");
var inputNumber = Console.ReadLine();

var checkChar = int.TryParse(inputNumber, out int x);
while (!checkChar )
{
	Console.WriteLine("Nhap sai dinh dang,nhap lai  : ");
	inputNumber = Console.ReadLine();
	checkChar = int.TryParse(inputNumber, out x);
}
if (x < 2)
{
	Console.WriteLine($"{x} khong phai so nguyen to");
	return;
}
else 
	for (int i = 2;i<=x/2;i++)
	{
		if (x%i == 0)
		{
			Console.WriteLine($"{x} khong phai so nguyen to");
			return; 
		}
	}
Console.WriteLine($"{x} la so nguyen to");