int getNumberFromUser(string userInformation)
{
    int result = 0;
    Console.Write($"{userInformation} ");
    while (!int.TryParse(Console.ReadLine(), out result) || (result < 1 ))
    {
        Console.Write($"Необходимо натуральное число. {userInformation} ");
    }
    return result;
}

int[] cubesChart(int userNumber)
{
    int[] result = new int [userNumber];
    for(int i = 1; i <= userNumber; i++)
    {
        result[i - 1] = (int)(Math.Pow(i, 3));
    }
    return result;
}

int userNumber = 0;
userNumber = getNumberFromUser("Введите натуральное число: ");
int[] chart = cubesChart(userNumber);

for (int i = 0; i < userNumber; i++)
{
    Console.Write(chart[i] + " ");
}