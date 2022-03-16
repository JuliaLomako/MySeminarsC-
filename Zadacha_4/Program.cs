//Задача номер 4 (по списку)

Console.Write("Введите первое целое число ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число ");
int numB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье целое число ");
int numС = Convert.ToInt32(Console.ReadLine());

int max = numA;

if(numA > max) max = numA;
if(numB > max) max = numB;
if(numС > max) max = numС;

Console.Write("Максимальное = ");
Console.Write(max);