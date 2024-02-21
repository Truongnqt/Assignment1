int firstNumber = 0;
int secondNumber = 1;
Console.WriteLine("Nhap so nguyen n : ");
var inputNumber = Console.ReadLine();
var checkChar = int.TryParse(inputNumber, out int n);
while (!checkChar)
{
	Console.WriteLine("Nhap sai dinh dang,nhap lai  : ");
	inputNumber = Console.ReadLine();
	checkChar = int.TryParse(inputNumber, out n);
}
for (int i = 0; i < n; i++)
{
	Console.WriteLine(secondNumber);
	int nextNumber = firstNumber + secondNumber;
	firstNumber = secondNumber;
	secondNumber = nextNumber;
}
