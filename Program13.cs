// Задача 13: Написать программу, кот.выводит 3 цифру заданного числа или сообщает,шо 3 числа нема

int N( int num)

 {
    while(num >999)
    {
      num = num / 10;
    }
    int third = num % 10;
    return third;
 }
 int check;
 int number;
 int result;
 Console.Write("Введите целое число : ");
 check =Convert.ToInt32(Console.ReadLine());
 if (check < 0) number =check  * (-1);
 else number = check;
 if( number < 100) Console.WriteLine($"Данное число {check} не имеет третьей цифры");
 else{
   result = N(number);
   
   Console.WriteLine ($"Данное число {check}, третья цифра {result}");
 }







    


