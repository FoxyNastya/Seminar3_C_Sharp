/*Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/ 
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

double getDistance(int x1, int y1, int z1, int x2, int y2, int z2){
    double result = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));
    return result;
}

int x1 = getCoordFromUser("Enter x coordinate of the first point");
int y1 = getCoordFromUser("Enter y coordinate of the first point");
int z1 = getCoordFromUser("Enter z coordinate of the first point");


int x2 = getCoordFromUser("Enter x coordinate of the second point");
int y2 = getCoordFromUser("Enter y coordinate of the second point");
int z2 = getCoordFromUser("Enter z coordinate of the second point");

double distance = getDistance(x1, y1, z1, x2, y2, z2);

Console.WriteLine($"Distance between({x1},{y1},{z1}) and ({x2},{y2},{z2}) is {distance}");

