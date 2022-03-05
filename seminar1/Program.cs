/*
// Пояснение семинара
Console.Write("Введите целое число: ");
int value = Convert.ToInt32(Console.ReadLine());
int kvadrat_value = value * value;

Console.Write("Квадрат данного числа равен ");
Console.WriteLine(kvadrat_value);




// 1 задача семинара1:

Console.Write("Введите первое целое число: ");
int value1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int value2 = Convert.ToInt32(Console.ReadLine());

int kvadrat_value2 = value2 *  value2;

if(kvadrat_value2 == value1)
{
    Console.WriteLine("Квадрат второго числа ссответствует первому");
}

else
{
    Console.WriteLine("Искомых соответствий не выявлено");
}


// 2 задача семинара1: 

Console.Write("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number <= 7 && number >= 1)
{
    if(number == 1)
    {
        Console.WriteLine("Понедельник");
    }
    if(number == 2)
    {
       Console.WriteLine("Вторник"); 

    }
}
else
{
    Console.WriteLine("Такого дня недели не существует");
}


// 3 задача семинар1:

Console.Write("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int neg_n = n*(-1);

while(neg_n <= n)
{
    Console.WriteLine(neg_n);
    neg_n+=3;
}




//Домашнее задание 1 к первому семинару по С#;(Найти большее из двух чисел)


Console.Write("Введите первое целое число: ");

    int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число: ");

    int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Большее число: ");

     if (number1 >= number2)
    {
        Console.WriteLine(number1);
     }

     if (number2 >= number1)
    {
        Console.WriteLine(number2);
    }



// Вторая задача по семинару 1 по С#;(Найти большее из трёх чисел)

Console.Write("Введите целое число: ");

    int number = Convert.ToInt32(Console.ReadLine());

    int delitel = 2 ;

    int even = number % delitel;
            if(even == 0)
    {
        Console.WriteLine("Четное");
    }
            if(even == +-1)
    {
        Console.WriteLine("Не четное");
    }

*/