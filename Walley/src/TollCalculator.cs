using System;
using System.Globalization;
using Holidays;

namespace WalleyAssignment
{
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

        public int GetTotalTollFeeForDay(IVehicle vehicle, DateTime[] allTimesOfDay)
        {
            int totalFee = 0;
            int intervalFee = 0;
            DateTime? newIntervalStart = null;

            if (vehicle == null || allTimesOfDay == null || allTimesOfDay.Length == 0)
            {
                throw new ArgumentException("Invalid input. Please provide a valid vehicle and at least one date.");
            }

            DateTime previousTimeOfDay = allTimesOfDay.FirstOrDefault();
            foreach (DateTime timeOfDay in allTimesOfDay.Skip(1))
            {
                if (timeOfDay <= previousTimeOfDay)
                {
                    throw new ArgumentException("Invalid input. Dates should be in ascending order.");
                }
                previousTimeOfDay = timeOfDay;
            }

            foreach (DateTime timeOfDay in allTimesOfDay)
            {
                int tollFee = GetTollFeeForSpecificTime(timeOfDay, vehicle);

                if (newIntervalStart == null)
                {
                    newIntervalStart = timeOfDay;
                    intervalFee = tollFee;
                }
                else
                {
                    TimeSpan intervalDuration = timeOfDay - newIntervalStart.Value;
                    if (intervalDuration.TotalMinutes <= tollIntervalMinutes)
                    {
                        intervalFee = Math.Max(intervalFee, tollFee);
                    }
                    else
                    {
                        totalFee += intervalFee;
                        newIntervalStart = timeOfDay;
                        intervalFee = tollFee;
                    }
                }
            }

            if (newIntervalStart != null)
            {
                totalFee += intervalFee;
            }

            if (totalFee > tollMaxAmountSEK)
            {
                totalFee = tollMaxAmountSEK;
            }

            return totalFee;
        }

        public int GetTollFeeForSpecificTime(DateTime date, IVehicle vehicle)
        {
            if (vehicle == null) throw new ArgumentNullException(nameof(vehicle), "Vehicle cannot be null.");
            
            int hour = date.Hour;
            int minute = date.Minute;
            
            if (vehicle.IsTollFree || IsTollFreeDate(date)) return 0;

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

        public bool IsTollFreeDate(DateTime date)
        {
            List<ReturnDates.Holiday> holidays = Holidays.ReturnDates.getAllHolidays(date.Year, ReturnDates.Country.Sweden, false, true);
            List<DateTime> daysBeforeHolidays = new List<DateTime>();
            DateTime december31st = new DateTime(date.Year, 12, 31);

            foreach (var holiday in holidays)
            {
                DateTime dayBefore = holiday.date.AddDays(-1);
                daysBeforeHolidays.Add(dayBefore);
            }

            if (date.Month == 7 ||
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



}