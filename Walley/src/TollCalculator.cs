using System;
using System.Globalization;
using TollFeeCalculator;
using Holidays;

public class TollCalculator
{
    // Toll rates
    private int tollNoneSEK = 0;
    private int tollLowSEK = 8;
    private int tollMediumSEK = 13;
    private int tollHighSEK = 18;

    // Toll rate and Time MAX 
    private int tollMaxAmountSEK = 60;
    private int tollIntervalMinutes = 60;



    public int GetTollFee(IVehicle vehicle, DateTime[] dates)
    {
        int totalFee = 0;
        int intervalFee = 0;
        DateTime? new60MinuteInterval = null;

        foreach (DateTime date in dates)
        {
            int nextFee = GetTollFee(date, vehicle);
            intervalFee = Math.Max(intervalFee, nextFee);

            if (new60MinuteInterval == null || (date - new60MinuteInterval).Value.TotalMinutes > tollIntervalMinutes)
            {
                if (new60MinuteInterval != null)
                {
                    totalFee += intervalFee;
                }

                new60MinuteInterval = date;
                intervalFee = 0;
            }
        }

        if (new60MinuteInterval != null)
        {
            totalFee += intervalFee;
        }

        if (totalFee > tollMaxAmountSEK)
        {
            totalFee = tollMaxAmountSEK;
        }

        return totalFee;
    }



    public int GetTollFee(DateTime date, IVehicle vehicle)
    {
        if (IsTollFreeDate(date) || IsTollFreeVehicle(vehicle)) return 0;

        int hour = date.Hour;
        int minute = date.Minute;

        if (hour == 6 && minute >= 0 && minute <= 29) return tollLowSEK;
        else if (hour == 6 && minute >= 30 && minute <= 59) return tollMediumSEK;
        else if (hour == 7 && minute >= 0 && minute <= 59) return tollHighSEK;
        else if (hour == 8 && minute >= 0 && minute <= 29) return tollMediumSEK;
        else if ((hour == 8 && minute >= 30) || (hour >= 9 && hour <= 14)) return tollLowSEK;
        else if (hour == 15 && minute >= 0 && minute <= 29) return tollMediumSEK;
        else if ((hour == 15 && minute >= 30) || (hour == 16 && minute <= 59)) return tollHighSEK;
        else if (hour == 17 && minute >= 0 && minute <= 59) return tollMediumSEK;
        else if (hour == 18 && minute >= 0 && minute <= 29) return tollLowSEK;
        else return tollNoneSEK;
    }


    private bool IsTollFreeVehicle(IVehicle vehicle)
    {
        if (vehicle == null)
        {
            return false;
        }

        String vehicleType = vehicle.GetVehicleType();
        
        return vehicleType.Equals(TollFreeVehicles.Motorbike.ToString()) ||
               vehicleType.Equals(TollFreeVehicles.Tractor.ToString()) ||
               vehicleType.Equals(TollFreeVehicles.Emergency.ToString()) ||
               vehicleType.Equals(TollFreeVehicles.Diplomat.ToString()) ||
               vehicleType.Equals(TollFreeVehicles.Foreign.ToString()) ||
               vehicleType.Equals(TollFreeVehicles.Military.ToString());
    }


    private enum TollFreeVehicles
    {
        Motorbike,
        Tractor,
        Emergency,
        Diplomat,
        Foreign,
        Military
    }



    public Boolean IsTollFreeDate(DateTime date)
    {
        List<ReturnDates.Holiday> holidays = Holidays.ReturnDates.getAllHolidays(date.Year, ReturnDates.Country.Sweden, false, true);
        List<DateTime> daysBeforeHolidays = new List<DateTime>();
        DateTime december31st = new DateTime(date.Year, 12, 31);

        foreach (var holiday in holidays)
        {
            DateTime dayBefore = holiday.date.AddDays(-1);
            daysBeforeHolidays.Add(dayBefore);
        }

        if (date.Month == 7      || 
            date == december31st ||
            Holidays.ReturnDates.isHoliday(date, ReturnDates.Country.Sweden, true, true))
        {
            return true;
        }

        foreach (var dayBeforeHoliday in daysBeforeHolidays)
        {
            if (date == dayBeforeHoliday)
            {
                return true;
            }
        }

        return false;
    }


  









}