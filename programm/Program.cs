// Задание: Из имеющегося массива строк формировать массив из строк, длина которых меньше или равно 3
// Первоначальный массив ввести с клавиатуры или задать на старте
// пользуемся только массивами


int InputSize(string prompt) //Функция ввода размера массива
{
  System.Console.Write($"{prompt}");
  return Convert.ToInt32(Console.ReadLine());
}


string InputData(string prompt) // Функция ввода элементов массива
{
  System.Console.Write($"{prompt}");
  string data = Console.ReadLine();
  return data;
}


string[] FillArray(int size) // Функция заполнения массива
{
  string [] array = new string[size];
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = InputData("Введите элемент массива: ");
  }
  return array;
}


int countSymbolsInElement(int index, string [] array) //Функция подсчета символов в элементе массива
{
  int countSymbols = array[index].Length;
  return countSymbols;
}


int FindSizeNewArray(string [] array) // Функция определения размера выходного массива
{
  int sizeNewArray = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if(countSymbolsInElement(i, array) <= 3) sizeNewArray ++;
  }
  return sizeNewArray;
}

string [] CreateArray(string [] array) // Фнукция создания нового массива с элементами, у которых количество символов не более 3
{
  string [] newArray = new string[FindSizeNewArray(array)];
  int n = 0;
  for (int i = 0; i < newArray.Length; i++)
  {
    for (int j = n; j < array.Length; j++)
    {
      if(array[j].Length <= 3)
      {
        newArray[i] = array[j];
        n++;
        break;
      }
      else n++;
    }
  }
  return newArray;
}


void PrintArray(string[] array) // Функция печати массива
{
  System.Console.Write("{ " );
  for (int i = 0; i < array.Length; i++)
  {
    System.Console.Write($"{array[i]} ");
  }
  System.Console.Write("}" );
  System.Console.WriteLine();
}


int sizeArray = InputSize("Введите размер массива: ");
string [] array = FillArray(sizeArray);
PrintArray(array);
string [] newArray = CreateArray(array);
PrintArray(newArray);
