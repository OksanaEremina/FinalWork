// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна трём символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.



Console.WriteLine("Введите количество строк");
int arrayLength = Convert.ToInt32(Console.ReadLine());
string[] array = new string[arrayLength];
int count = 0; 
for (int i = 0; i < arrayLength; i++)
{
    string? inputLine = Console.ReadLine();
    if (inputLine != null && inputLine.Length <= 3) 
    {
        array[count++] = inputLine;
    } 
}
string[] resultArray = new string[count];
for (int i = 0; i < count; i++)
{
    resultArray[i] = array[i];
}
Console.WriteLine("Итоговый массив: ");
for (int i = 0; i < count; i++)
{
    Console.WriteLine(resultArray[i]);
}