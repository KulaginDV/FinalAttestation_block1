// Ввод исходного массива с клавиатуры

Console.WriteLine("Введите элементы массива через пробел: ");
string input = Console.ReadLine();
string [] inputArray = input.Split(' ');

// Создание нового массива

string [] newArray = new string [inputArray.Length];
int newIndex = 0;

// Заполнение новыми массивами элементами, длина которых меньше или равна 3 символам

for (int i = 0; i < inputArray.Length; i++)
{
    if (inputArray[i].Length <=3)
    {
        newArray[newIndex] = inputArray[i];
        newIndex++;
    }
}

// Вывод результата

Console.WriteLine("Новый массив с элементами длиной меньше или равной 3 символам:");
for (int i = 0; i < newIndex; i++)
{
    Console.Write(newArray[i] + " ");
}
