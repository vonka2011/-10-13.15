// Написать программу, кот.принимает на вход цифру, кот.явл.днем недели и проверяет выходной ли это.
void PrintDay(int num)
{
    if(num >0 && num < 8)
    {
        if (num == 6 || num==7) Console.WriteLine("Ура,выходной!");
        else Console.WriteLine("Дуй на работу!");

    }
    else Console.WriteLine("такого дня нема");

}
Console.WriteLine("Виудите число дня недели");
int numberOfDay = Convert.ToInt32(Console.ReadLine());
PrintDay (numberOfDay);

