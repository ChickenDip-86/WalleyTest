using WalleyAssignment;

bool continueApp = true;
UserInput userInput = new UserInput();
TollCalculator tollCalculator = new TollCalculator();   

while (continueApp)
{
    Console.Clear(); 
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("Welcome to the Toll Fee Calculator, ");
    Console.WriteLine("we hope you're having a great day!");
    Console.WriteLine("");
    Console.WriteLine("In this app you can check the total fee for any given day");
    Console.WriteLine("After your input, press Enter to confirm");
    Console.WriteLine("");
    Console.Write("First input the year: ");

    int year = userInput.GetYear();
    int month = userInput.GetMonth();
    int day = userInput.GetDay(year, month, out string dayOfWeek);
    Console.WriteLine("");
    Console.WriteLine($"You've selected a {dayOfWeek}");

    DateTime[] timeOfDay = userInput.GetTimesOfDay();
    DateTime[] dateTimeArray = userInput.AssembleDateTimeArray(year, month, day, timeOfDay);

    IVehicle vehicleType = userInput.GetVehicle();

    Console.WriteLine($"The Total toll fee for {year}-{month:D2}-{day:D2}, which is a {dayOfWeek}, is: {tollCalculator.GetTotalTollFeeForDay(vehicleType, dateTimeArray)} SEK");
    Console.WriteLine("Do you want to calculate another toll fee (Press any Key), or (N + Enter) to exit)");
    
    string response = Console.ReadLine();
    if (response == "N" || response == "n")
    {
        continueApp = false;
    }










}
