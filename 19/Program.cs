Console.WriteLine("Введите число ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int userNumberCopy = userNumber;
bool palindromStatus = false;

if(userNumberCopy < 0) palindromStatus = false;
else
{
    int placeValue = 1;
    while(userNumberCopy / placeValue > 9)
    {
        placeValue = placeValue * 10;
    }
    while(placeValue >= 1)
    {
        int firstDigit = userNumberCopy / placeValue;
        int lastDigit = userNumberCopy % 10;
        if(firstDigit != lastDigit) 
        {
            palindromStatus = false;
            break;
        }
        else
        {
            palindromStatus = true;
            userNumberCopy = (userNumberCopy % placeValue) / 10;
            placeValue = placeValue / 100;
        }
    }
}
    if(palindromStatus == true) Console.WriteLine($"Число {userNumber} является палиндромом");
    else Console.WriteLine($"Число {userNumber} не является палиндромом");