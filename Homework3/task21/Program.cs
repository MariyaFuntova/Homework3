int getNumberFromUser( string messege );
{
    int result = 0;
    Console.WriteLine(messege);
    result = Convert.ToInt32(Console.ReadLine());
    return result;
}

double getDistance (double xa, double ya, double za, double xb, double yb, double zb);
{
    double distance = Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya) , 2) + Math.Pow((zb - za), 2));
    return distance;
}
int xa = getNumberFromUser("Введите X1:");
int ya = getNumberFromUser("Введите Y1:");
int za = getNumberFromUser("Введите Z1:");
int xb = getNumberFromUser("Введите X2:");
int yb = getNumberFromUser("Введите Y2:");
int zb = getNumberFromUser("Введите Z2:");

double distanse = GetDistance( xa, ya, za, xb, yb, zb);
Console.WriteLine($"Расстояние между точками = {distance} ");