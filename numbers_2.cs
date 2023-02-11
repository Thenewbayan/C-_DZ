//Прога для поиска максимального из вводимых чисел

Console.WriteLine("Введите число");
int numberA=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число и программа выдаст которое из них больше и какое меньше");
int numberB=Convert.ToInt32(Console.ReadLine());
//Ввод исходных данных, дальше код самой проги
if (numberA>numberB)
{
    Console.WriteLine("Число "+numberA+" является большим из заданных, а число "+numberB+" меньшим");
};
//первое условие
if (numberB>numberA)
{
    Console.WriteLine("Число "+numberB+" является большим из заданных, а число "+numberA+" меньшим");
};//второе условие
if(numberA==numberB)
{
    Console.WriteLine("Хитро! Вы задали одинаковые числа");
};// vse rabotaet!
