namespace helloworld;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        int hoursToAdd, minutesToAdd, secondsToAdd;
        hoursToAdd = minutesToAdd = secondsToAdd = 0;
        string isChangeReuired = "N";
        Console.WriteLine("Current Date and Time is: " + DateTime.Now.ToString("MM/dd/yy hh:mm:ss tt"));
        Console.Write("Enter Hours to Add: ");
        hoursToAdd = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Minutes to Add: ");
        minutesToAdd = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Seconds to Add: ");
        secondsToAdd = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Updated Date and Time is: " 
                + DateTime.Now
                .AddHours(hoursToAdd)
                .AddMinutes(minutesToAdd)
                .AddSeconds(secondsToAdd)
                .ToString("dd-MMM-yyyy HH:mm:ss")
            );

        Console.Write("Do you want to change the date again ?");
        isChangeReuired = (Console.ReadLine());
        if(isChangeReuired.ToLower() == "y" ){
            Console.Write("Enter Hours to Add: ");
            hoursToAdd = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Minutes to Add: ");
            minutesToAdd = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Seconds to Add: ");
            secondsToAdd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Updated Date and Time is: " 
                    + DateTime.Now
                    .AddHours(hoursToAdd)
                    .AddMinutes(minutesToAdd)
                    .AddSeconds(secondsToAdd)
                    .ToString("dd-MMM-yyyy HH:mm:ss")
                );
        }

        //For
        //While
        //Do-While
        for(int i = 0; i<5;i++){
            Console.Write("Enter Hours to Add: ");
            hoursToAdd = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Minutes to Add: ");
            minutesToAdd = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Seconds to Add: ");
            secondsToAdd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Updated Date and Time is: " 
                    + DateTime.Now
                    .AddHours(hoursToAdd)
                    .AddMinutes(minutesToAdd)
                    .AddSeconds(secondsToAdd)
                    .ToString("dd-MMM-yyyy HH:mm:ss")
                );
        }
    }
}
