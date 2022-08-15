 Console.Write("Введите пятизначное число: ");
string a1 = Console.ReadLine();
int size = a1.Length;
bool result = true;
for(int i = 0; i < size /2 ; i++)
{
    if (a1[i] != a1[size - 1 -i] )
    {
        result = false;
        break;
    }
}
if (result) {
    Console.WriteLine("Да, это палиндром!");
    }
else {
    Console.WriteLine("Нет, это не палиндром!");
}