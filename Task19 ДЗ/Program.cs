int num;
Console.Write("«Введите пятизначное число: ");
num = Convert.ToInt32(Console.ReadLine());

if(num > 9999 && num < 100000)
{
for(t = num; num = num / 10)
  