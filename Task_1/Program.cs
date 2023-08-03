/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом(первое == последнему, второе == предпоследнему).
14212 -> нет
12821 -> да
23432 -> да*/

Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine()!);
string NumStr = num.ToString();

if(NumStr.Length != 5) Console.WriteLine("Введено не пятизначное число! ");

else{
    if(NumStr.Length == 5)
    {
        if(NumStr[0] == NumStr[4] && NumStr[1] == NumStr[3]) Console.WriteLine("Да");
        else Console.WriteLine("Нет");
    }
}
