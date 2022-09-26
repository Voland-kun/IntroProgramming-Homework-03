int getCoordinateFromUser(string userInformation)
{
    int result = 0;
    Console.Write($"{userInformation} ");
    while (!int.TryParse(Console.ReadLine(), out result))
    {
        Console.WriteLine($"Необходимо целое число. {userInformation} ");
    }
    return result;
    
} 

double findRangeBetweenTwoPoints(int coordinateX1, int coordinateY1, int coordinateZ1, int coordinateX2, int coordinateY2, int coordinateZ2)
{
    return Math.Sqrt(Math.Pow(coordinateX2 - coordinateX1, 2) + Math.Pow(coordinateY2 - coordinateY1, 2) + Math.Pow(coordinateZ2 - coordinateZ1, 2));
}

Console.WriteLine("Введите координаты первой точки");
int userCoordinateX1 = getCoordinateFromUser("X1: ");
int userCoordinateY1 = getCoordinateFromUser("Y1: ");
int userCoordinateZ1 = getCoordinateFromUser("Z1: ");
Console.WriteLine("Введите координаты второй точки");
int userCoordinateX2 = getCoordinateFromUser("X2: ");
int userCoordinateY2 = getCoordinateFromUser("Y2: ");
int userCoordinateZ2 = getCoordinateFromUser("Z2: ");

double range = findRangeBetweenTwoPoints(userCoordinateX1, userCoordinateY1, userCoordinateZ1, userCoordinateX2, userCoordinateY2, userCoordinateZ2);
Console.WriteLine($"Расстояние между двумя точками равно {range}");