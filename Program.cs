// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.


int Input(string input)                          // Описываем метод ввода чисел с клавы 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void ArrayInput(string [] stringArray)               // Описываем метод ввода исходного массива
{
  for (int i = 0;i<stringArray.Length;i++)
  {
     Console.WriteLine($"Введите {i+1} элемент массива");
     stringArray[i] = Console.ReadLine();
  }
}

string [] array2(string [] stringArray)               // Описываем метод фрмирования второго массива
{
  int n = 0;
  for (int i = 0;i<stringArray.Length;i++)
  {
    if(stringArray[i].Length <=3)
    n++;
  }
  string [] rez = new string [n];
  int j = 0;
  for (int i = 0;i<stringArray.Length;i++)
  {
    if(stringArray[i].Length <=3)
    {
        rez[j] = stringArray[i];
        j++;
    }
  }
  return rez;
}

void printArray(string [] stringArray)                //  Описываем метод печати массива
{
    Console.Write("[");
    for (int i = 0;i<stringArray.Length;i++)
    {
    Console.Write($" ‘{stringArray[i]}’, ");
    }
    Console.WriteLine("]");
}






Console.Clear();                                     // Для красоты

int m = Input("Введите количество элементов исходного массива:   ");   // получаем колличество элементов массива через метод ввода с клавы

string [] stringArray = new string [m];                     // Объявляем исходный массив
ArrayInput(stringArray);                                    // Заполняем исходный массив

string[] arrayRez = array2(stringArray);                    // Объявляем искомый массив

Console.Write($"Исходный массив:              ");   // Для красоты
printArray(stringArray);                  // Выводим исходный массив через метода вывода массива
Console.Write($"Конечный(искомый) массив:     ");  // Для красоты
printArray(arrayRez);          // Выводим конечный(искомый) массив через метода вывода массива
