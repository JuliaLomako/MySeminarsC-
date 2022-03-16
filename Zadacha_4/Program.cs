//Павел, добрый вечер! в настоящий момент в процессе решения))) 
//мучаю уже несколько часов две задачи

//Задача номер 4 (по списку)

Console.Write("Введите натуральное число ");
int number = Convert.ToInt32(Console.ReadLine());

int number2 = number / 2;

while(number2 <= number)
{
    Console.WriteLine(number2);
    number2++;
}