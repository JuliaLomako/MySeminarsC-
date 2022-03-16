//Павел, добрый вечер! Что-то у меня меня совсем затык :( делаю пока перерыв)) 
//если не решу ДО проверки, прошу подскажите, что не то длеаю!

//Задача номер 4 (по списку)

Console.Write("Введите натуральное число ");
int number = Convert.ToInt32(Console.ReadLine());

int number2 = number / 2;

while(number2 <= number)
{
    Console.WriteLine(number2);
    number2+=2;
}