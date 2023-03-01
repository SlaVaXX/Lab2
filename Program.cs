using System.Numerics;

namespace Lab2
{
    internal class Program
    {
        static int size = 7;//розмір місиву векторів за варіантом
        static void init(Vector[] vectors)
        {
            for (int i = 0,j = 6; j > 3; i++, j--)
            {
                vectors[j] = vectors[i];
            }
            vectors[3] = new Vector();
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            Vector[] vectors = new Vector[size];
            for (int i = -1;i < 3;)
            {
                Console.WriteLine("\nВведіть наступну дію:\n(new - створити новий вектор)\n(change - змінити координати вектора)\n(data - отримати дані про даний вектор)\n(end - завершити виконання програми)");
                string request = Console.ReadLine();
                Console.Clear();
                if (request == "new")
                {
                    i++;
                    if (i == 3)
                    {
                        Console.Clear();
                        break;
                    }
                    Console.WriteLine("Введіть довжину вектора:");
                    string temp = Console.ReadLine();
                    int length = Convert.ToInt32(temp);
                    Console.WriteLine("Введіть кут під яким знаходиться вектор:");
                    temp = Console.ReadLine();
                    int angle = Convert.ToInt32(temp);
                    vectors[i] = new Vector(angle, length);
                    continue;
                }
                else if (request == "change" && i != -1)
                {
                    Console.Write("Введіть координати вектора:\nX = ");
                    float X = (float)Math.Round(float.Parse(Console.ReadLine()), 2);
                    Console.Write("\nY = ");
                    float Y = (float)Math.Round(float.Parse(Console.ReadLine()), 2);
                    vectors[i].changeCoordinates(new Vector2(X, Y));
                    Console.Clear();
                    vectors[i].vectorData();
                    continue;
                }
                else if (request == "data" && i != -1)
                {
                    vectors[i].vectorData();
                    continue;
                }
                else if (request == "end")
                {
                    Console.Clear();
                    break;
                }
            }
            init(vectors);
            Console.ReadLine();
        }
    }
}
