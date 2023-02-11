//поиск макс из 3 чисел

Console.WriteLine("Введите 3 любых целых числа, а программа найдет какое из них самое большое");
int numberA=Convert.ToInt32(Console.ReadLine());
int numberB=Convert.ToInt32(Console.ReadLine());
int numberC=Convert.ToInt32(Console.ReadLine());//ввод данных

int max=numberA;// проверяем условия, если чисел немногго то так можно, 
//но если чисел много то лучше через массив и индекс++
if(numberB>max)
{
    max=numberB;
};
if(numberC>max)
{
    max=numberC;
};
Console.WriteLine("Самое большое число это: "+max);