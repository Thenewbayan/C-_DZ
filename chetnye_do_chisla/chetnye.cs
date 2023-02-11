Console.WriteLine("ДАвайте найдем все четные числа от 2 до вашего числа, введите число");
int number=Convert.ToInt32(Console.ReadLine());
int count=2;
while(count<=number)
{
    Console.WriteLine(count);
    count=count+2;
};