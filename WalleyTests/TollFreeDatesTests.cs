using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalleyAssignment;

namespace WalleyTests
{
    /**************************************************************
   *                                                            *
   *                             TESTS                          *
   *                       TOLL FREE DATES                      *
   *                                                            *
   **************************************************************/
    
    public class TollFreeDatesTests
    {
        [Theory]
        [InlineData(2013, 1, 1)]   // New Year's Day (toll-free)
        [InlineData(2013, 3, 28)]  // Toll-free
        [InlineData(2013, 3, 29)]  // Toll-free
        [InlineData(2013, 4, 1)]   // Toll-free
        [InlineData(2013, 5, 1)]   // Toll-free
        [InlineData(2013, 5, 8)]   // Toll-free
        [InlineData(2013, 5, 9)]   // Toll-free
        [InlineData(2013, 6, 5)]   // Toll-free
        [InlineData(2013, 6, 6)]   // Toll-free
        [InlineData(2013, 6, 21)]  // Toll-free
        [InlineData(2013, 7, 1)]   // Toll-free
        [InlineData(2013, 11, 1)]  // Toll-free
        [InlineData(2013, 12, 24)] // Toll-free
        [InlineData(2013, 12, 25)] // Toll-free
        [InlineData(2013, 12, 26)] // Toll-free
        [InlineData(2013, 12, 31)] // Toll-free
        [InlineData(2014, 1, 1)] // Toll-free
        public void TollFreeDates_2013_Should_Be_True(int year, int month, int day)
        {
            // Arrange
            var tollCalculator = new TollCalculator();
            var date = new DateTime(year, month, day);

            // Act
            var isTollFree = tollCalculator.IsTollFreeDate(date);

            // Assert
            Assert.True(isTollFree);
        }

        [Fact]
        public void TollFree_Saturday_And_Sunday_Should_Be_True()
        {
            // Arrange
            var tollCalculator = new TollCalculator();

            var saturdayDate = new DateTime(2013, 2, 2); // Saturday
            var sundayDate = new DateTime(2013, 2, 3);   // Sunday

            // Act
            var isTollFreeOnSaturday = tollCalculator.IsTollFreeDate(saturdayDate);
            var isTollFreeOnSunday = tollCalculator.IsTollFreeDate(sundayDate);

            // Assert
            Assert.True(isTollFreeOnSaturday);
            Assert.True(isTollFreeOnSunday);
        }


        [Theory]
        [InlineData(2021, 01, 01)]
        [InlineData(2021, 01, 06)]
        [InlineData(2021, 04, 02)]
        [InlineData(2021, 04, 04)]
        [InlineData(2021, 04, 05)]
        [InlineData(2021, 05, 01)]
        [InlineData(2021, 05, 13)]
        [InlineData(2021, 05, 23)]
        [InlineData(2021, 06, 06)]
        [InlineData(2021, 06, 26)]
        [InlineData(2021, 11, 06)]
        [InlineData(2021, 12, 25)]
        [InlineData(2021, 12, 26)]
        public void TollFreeDates_2021_Should_Be_True(int year, int month, int day)
        {
            // Arrange
            var tollCalculator = new TollCalculator();
            var date = new DateTime(year, month, day);

            // Act
            var isTollFree = tollCalculator.IsTollFreeDate(date);

            // Assert
            Assert.True(isTollFree);
        }


        [Theory]
        //[InlineData(2023, 1, 1)]
        [InlineData(2023, 1, 2)]
        [InlineData(2023, 1, 3)]
        [InlineData(2023, 1, 4)]
        //[InlineData(2023, 1, 5)]
        //[InlineData(2023, 1, 6)]
        //[InlineData(2023, 1, 7)]
        //[InlineData(2023, 1, 8)]
        [InlineData(2023, 1, 9)]
        [InlineData(2023, 1, 10)]
        [InlineData(2023, 1, 11)]
        [InlineData(2023, 1, 12)]
        [InlineData(2023, 1, 13)]
        //[InlineData(2023, 1, 14)]
        //[InlineData(2023, 1, 15)]
        [InlineData(2023, 1, 16)]
        [InlineData(2023, 1, 17)]
        [InlineData(2023, 1, 18)]
        [InlineData(2023, 1, 19)]
        [InlineData(2023, 1, 20)]
        //[InlineData(2023, 1, 21)]
        //[InlineData(2023, 1, 22)]
        [InlineData(2023, 1, 23)]
        [InlineData(2023, 1, 24)]
        [InlineData(2023, 1, 25)]
        [InlineData(2023, 1, 26)]
        [InlineData(2023, 1, 27)]
        //[InlineData(2023, 1, 28)]
        //[InlineData(2023, 1, 29)]
        [InlineData(2023, 1, 30)]
        [InlineData(2023, 1, 31)]

        public void All_Dates_In_January_That_Should_Be_False(int year, int month, int day)
        {
            // Arrange
            var tollCalculator = new TollCalculator();
            var date = new DateTime(year, month, day);

            // Act
            var isTollFree = tollCalculator.IsTollFreeDate(date);

            // Assert
            Assert.False(isTollFree);

        }
    }

}

