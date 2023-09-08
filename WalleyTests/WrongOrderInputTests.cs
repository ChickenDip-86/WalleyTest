using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalleyAssignment;

namespace WalleyTests
{
    public class WrongOrderInputTests
    {
        [Fact]
        public void Wrong_Order_Of_Input_Should_Throw()
        {
            // Arrange
            var calculator = new TollCalculator();
            var car = new Car();
            DateTime[] dates = new DateTime[]
            {
                new DateTime(2013, 2, 4, 6, 40, 0),
                new DateTime(2013, 2, 4, 6, 10, 0),
            };

            // Act and Assert
            Assert.Throws<ArgumentException>(() => calculator.GetTotalTollFeeForDay(car, dates));

        }

        [Fact]
        public void Wrong_Order_Of_Input_Should_Throw_2()
        {
            // Arrange
            var calculator = new TollCalculator();
            var car = new Car();
            DateTime[] dates = new DateTime[]
            {
                new DateTime(2023, 2, 4, 8, 10, 0),
                new DateTime(2023, 2, 4, 9, 10, 0),
                new DateTime(2023, 2, 4, 19, 10, 0),
                new DateTime(2023, 2, 4, 12, 10, 0),
            };

            // Act and Assert
            Assert.Throws<ArgumentException>(() => calculator.GetTotalTollFeeForDay(car, dates));

        }








    }







}
