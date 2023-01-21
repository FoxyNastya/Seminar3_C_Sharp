/*
Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
*/
int GetNumber(string message)
{
    int resultNumber = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out resultNumber) && resultNumber != 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число или не корректное число. Повторите ввод!\n");
        }
    }

    return resultNumber;
}

int GetQuarter(int x, int y)
{
    if(x > 0 && y > 0)
        return 1;
    else if(x < 0 && y > 0)
        return 2;
    else if(x < 0 && y < 0)
        return 3;
    else
        return 4;
}

int x = GetNumber("Введите координату Х, которая не равна 0:");
int y = GetNumber("Введите координату Y, которая не равна 0:");
int quarter = GetQuarter(x,y);

Console.WriteLine($"Точка с координатами ({x},{y}) лежит в {quarter} четверти");



/*
Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
*/
int getQuarterFromUser(string message){
    int result = 0;
    while (true){
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result > 0 && result < 5 ){
            if (result != 0){
                break;
            } else {
                Console.WriteLine("You can't choose 0 in this programm");
            }
        }
        else{
            Console.WriteLine("You've entered incorrect quarter");
        }
    }
    return result;
}


int quarter = getQuarterFromUser("Enter quarter number");


if (quarter == 1){
    Console.WriteLine($"x in {quarter} lies between 0 and infinity, y in {quarter} lies between 0 and infinity");
} else if (quarter == 2){
    Console.WriteLine($"x in {quarter} lies between 0 and -infinity, y in {quarter} lies between 0 and infinity");
} else if (quarter == 3){
    Console.WriteLine($"x in {quarter} lies between 0 and -infinity, y in {quarter} lies between 0 and -infinity");
} else if (quarter == 4){
    Console.WriteLine($"x in {quarter} lies between 0 and infinity, y in {quarter} lies between 0 and -infinity");
}

/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
*/
int getCoordFromUser(string message){
    int result = 0;
    while (true){
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result)){
                break;
        }        
        else{
            Console.WriteLine("You've entered incorrect number");
        }
    }
    return result;
}

double getDistance(int ax, int ay, int bx, int by){
    double result = Math.Sqrt(Math.Pow(ax-bx,2) + Math.Pow(ay-by, 2));
    return result;
}

int ax = getCoordFromUser("Enter x coordinate of the first point");
int ay = getCoordFromUser("Enter y coordinate of the first point");


int bx = getCoordFromUser("Enter x coordinate of the second point");
int by = getCoordFromUser("Enter y coordinate of the second point");

double distance = getDistance(ax, ay, bx, by);

Console.WriteLine($"Distance between({ax},{ay}) and ({bx},{by}) is {distance}");



/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());


for (int i = 1; i <= number; i++)
{
    Console.Write($"{i*i},");
}

