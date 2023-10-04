//lab№5/Сборник задач/Разветвляющиеся алгоритмы/условные операторы/высокий уровень/вариант 19
Console.Write("Введите сторону кирпича a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите сторону кирпича b: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите сторону кирпича c: ");
int c = int.Parse(Console.ReadLine());
Console.Write("Введите сторону отверстия x: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите сторону отверстия y: ");
int y = int.Parse(Console.ReadLine());
if ((a <= x && b <= y) || (a <= y && b <= x) || (a <= x && c <= y) || (a <= y && c <= x) || (b <= x && c <= y) || (b <= y && c <= x))
{
    Console.WriteLine("кирпич пройдёт");
} else
{
    Console.WriteLine("кирпич не проёдут благаду 27 года 19 века");
}