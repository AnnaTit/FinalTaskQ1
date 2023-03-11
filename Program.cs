/* Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*/

string[] Input = new string[9] {"monday", "Hi!", "wonderful", "How", "less", "are", "life", "you", "?"};
string[] Output = new string[Input.Length];
void OutputLessThree(string[] Input, string[] Output)
{
    int count = 0;
    for (int i = 0; i < Input.Length; i++)
    {
    if(Input[i].Length <= 3)
        {
        Output[count] = Input[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
OutputLessThree(Input, Output);
PrintArray(Output);