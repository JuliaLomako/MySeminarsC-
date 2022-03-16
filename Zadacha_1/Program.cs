// Задача номер 1 (по списку)

Console.Write("Введите первое целое число ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число ");
int numB = Convert.ToInt32(Console.ReadLine());

int max = numA;
int min = numB;

if(numA > max) max = numA;
if(numB > max) max = numB;
if(numA < min) min = numA;
if(numB < min) min = numB;

Console.Write("Максимальное = ");
Console.Write(max);

Console.Write(" Минимальное = ");
Console.Write(min);