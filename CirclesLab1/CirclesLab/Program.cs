



using CirclesLab;

Console.WriteLine("Welcome to my circle tester");

bool validNum = true;
bool makeMoreCircles = false;
double userRadius = 0;
string circumference;
string area;
do
{
   
    do
    {
        Console.WriteLine("Please enter a radius: ");
        string userRadiusAsString = Console.ReadLine();

        try
        {
            userRadius = double.Parse(userRadiusAsString);
        }
        catch (Exception)
        {
            Console.WriteLine("Please enter a valid number\n");
            validNum = false;
        }

         

         var passRadius = new Circles(userRadius);

         circumference = passRadius.CalculatedFormattedCircumference();

         area = passRadius.CalculateFormattedArea();
         
        



    } while (validNum == false);

    Console.WriteLine("Circumference: " + circumference);

    Console.WriteLine("Area: " + area);

    List<Circles> userCircles = new List<Circles>()
    {
        new Circles(userRadius)
    };


    int userCount = userCircles.Count() + 1;


    Console.WriteLine("Would you like to make another Circle? enter y to continue or any other key to exit. ");
    string userContinue = Console.ReadLine();

    if (userContinue == "y")
    {
        makeMoreCircles = false;
    }
    else
    {
        Console.WriteLine("Goodbye");
        Console.WriteLine($"You have made {userCount} Circles");
        makeMoreCircles = true;
    }

}
while (makeMoreCircles == false);