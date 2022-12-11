// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/* 0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
 */

using static UserMethods.Method;

Console.WriteLine($"How many number you want entered?");
int usersLenghtArray = InputIntNumberTryParse();
while(usersLenghtArray <= 0) // отсеивание значений <=0, пока юзер нормально не введёт.
{
    Console.WriteLine($"Entered unacceptable number. Need number > 0");
    usersLenghtArray = InputIntNumberTryParse(); 
}

int[] arrayEnteredUsersNumbers = CreatedArrayUserEntered(usersLenghtArray);
int result = CounterNumbersMoreThenZeroForUserEnter(arrayEnteredUsersNumbers);

Console.WriteLine($"{result} -- ammount numbers > 0");


// метод создание массива путём ввода с клавиатуры
int[] CreatedArrayUserEntered (int enteredNumber)
{
    int[] array = new int[enteredNumber];
    for (int i = 0; i < array.Length; i++)
    {   
        Console.Write($"Enter [{i+1}] number: "); 
        array[i] = InputIntNumberTryParse();
    }
    return array;
}
// метод счётчика количество элементов массива с значением 0
int CounterNumbersMoreThenZeroForUserEnter(int[] enteredArray)
{
    int count = 0;
    for(int i = 0; i < enteredArray.Length; i++)
    {
        if (enteredArray[i] > 0) count++;
    }
    return count;
}