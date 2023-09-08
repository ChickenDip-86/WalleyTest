using System;
using System.Globalization;
using WalleyAssignment;

namespace WalleyAssignment
{
    public class UserInput
    {
        public int GetYear()
        {
            int year;
            while (true)
            {
                Console.Write("Enter a year (2000-2023): ");
                if (int.TryParse(Console.ReadLine(), out year) && year >= 2000 && year <= 2023)
                {
                    return year;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a year between 2000 and 2023.");
                }
            }
        }

        public int GetMonth()
        {
            int month;
            while (true)
            {
                Console.Write("Enter a month (1-12): ");
                if (int.TryParse(Console.ReadLine(), out month) && month >= 1 && month <= 12)
                {
                    return month;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a month between 1 and 12.");
                }
            }
        }

        public int GetDay(int year, int month, out string dayOfWeek)
        {
            var maxDaysOfMonth = DateTime.DaysInMonth(year, month);

            int day;
            while (true)
            {
                Console.Write($"Enter a day for {year}-{month} (1-{maxDaysOfMonth}): ");
                if (int.TryParse(Console.ReadLine(), out day) && day >= 1 && day <= maxDaysOfMonth)
                {
                    DateTime selectedDate = new DateTime(year, month, day);
                    dayOfWeek = selectedDate.ToString("dddd", System.Globalization.CultureInfo.InvariantCulture);
                    return day;
                }
                else
                {
                    Console.WriteLine($"Invalid input. Please enter a day between 1 and {maxDaysOfMonth}.");
                }
            }
        }

        public DateTime[] GetTimesOfDay()
        {
            List<DateTime> times = new List<DateTime>();
            bool validInput;

            while (true)
            {
                Console.WriteLine("Times must be in chronological order (earlier times first).");
                Console.Write("Enter one or more times (HH:mm separated by spaces): ");

                string[] timeStrings = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (timeStrings.Length == 0)
                {
                    Console.WriteLine("No times entered. Please enter at least one time.");
                    continue; 
                }

                times.Clear();
                validInput = true;

                foreach (string timeString in timeStrings)
                {
                    if (DateTime.TryParseExact(timeString, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime time))
                    {
                        times.Add(time);
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"ERROR: Invalid time format: {timeString}. Please use HH:mm format.");
                        validInput = false;
                        break; 
                    }
                }

                if (!validInput)
                {
                    continue;
                }

                for (int i = 1; i < times.Count; i++)
                {
                    if (times[i] <= times[i - 1])
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"ERROR: Times should be in chronological order. {timeStrings[i]} is not greater than the previous time.");
                        times.Clear(); 
                        validInput = false;
                        break; 
                    }
                }

                if (validInput)
                {
                    return times.ToArray(); 
                }
            }
        }

        public DateTime[] AssembleDateTimeArray(int year, int month, int day, DateTime[] timeOfDay)
        {
            DateTime[] dateTimeArray = new DateTime[timeOfDay.Length];

            for (int i = 0; i < timeOfDay.Length; i++)
            {
                if (timeOfDay[i] != null)
                {
                    dateTimeArray[i] = new DateTime(year, month, day, timeOfDay[i].Hour, timeOfDay[i].Minute, timeOfDay[i].Second);
                }
            }

            return dateTimeArray;
        }

        public IVehicle GetVehicle()
        {
            Console.WriteLine("Select a vehicle type:");

            List<IVehicle> vehicleTypes = new List<IVehicle>
            {
                new Car(),
                new Motorbike(),
                new Diplomat(),
                new Emergency(),
                new Foreign(),
                new Tractor(),
                new Military()
            };

            for (int i = 0; i < vehicleTypes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {vehicleTypes[i].GetVehicleType()}");
            }

            int selectedValue;
            while (!int.TryParse(Console.ReadLine(), out selectedValue) || selectedValue < 1 || selectedValue > vehicleTypes.Count)
            {
                Console.WriteLine("Invalid input. Please select a valid vehicle type.");
            }

            return vehicleTypes[selectedValue - 1];
        }


    }

}
