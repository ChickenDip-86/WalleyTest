using TollFeeCalculator;

namespace WalleyTests
{

     /**************************************************************
     *                                                            *
     *                       WalleyTests                           *
     *                                                            *
     **************************************************************/

    public class WalleyTests
    {
        // All tests in this document
    }

    public class TimeTableTests
    {
        [Theory]
        [InlineData(2013, 2, 4, 06, 00, 0)]
        [InlineData(2013, 2, 4, 06, 01, 0)]
        [InlineData(2013, 2, 4, 06, 10, 0)]
        [InlineData(2013, 2, 4, 06, 15, 0)]
        [InlineData(2013, 2, 4, 06, 25, 0)]
        [InlineData(2013, 2, 4, 06, 29, 0)]
        public void Car_0600_0629_Should_Be_8(int year, int month, int day, int hour, int minute, int second)
        {
            // Arrange
            int result = 8;
            var calculator = new TollCalculator();
            var car = new Car();
            var date = new DateTime(year, month, day, hour, minute, second);

            // Act
            var tollFee = calculator.GetTollFee(date, car);

            // Assert
            Assert.Equal(result, tollFee);
        }

        [Theory]
        [InlineData(2013, 2, 4, 06, 30, 0)]
        [InlineData(2013, 2, 4, 06, 31, 0)]
        [InlineData(2013, 2, 4, 06, 45, 0)]
        [InlineData(2013, 2, 4, 06, 55, 0)]
        [InlineData(2013, 2, 4, 06, 59, 0)]
        public void Car_0630_0659_Should_Be_13(int year, int month, int day, int hour, int minute, int second)
        {
            // Arrange
            int result = 13;
            var calculator = new TollCalculator();
            var car = new Car();
            var date = new DateTime(year, month, day, hour, minute, second);

            // Act
            var tollFee = calculator.GetTollFee(date, car);

            // Assert
            Assert.Equal(result, tollFee);
        }

        [Theory]
        [InlineData(2013, 2, 4, 07, 00, 0)]
        [InlineData(2013, 2, 4, 07, 01, 0)]
        [InlineData(2013, 2, 4, 07, 10, 0)]
        [InlineData(2013, 2, 4, 07, 15, 0)]
        [InlineData(2013, 2, 4, 07, 29, 0)]
        [InlineData(2013, 2, 4, 07, 30, 0)]
        [InlineData(2013, 2, 4, 07, 31, 0)]
        [InlineData(2013, 2, 4, 07, 45, 0)]
        [InlineData(2013, 2, 4, 07, 55, 0)]
        [InlineData(2013, 2, 4, 07, 59, 0)]
        public void Car_0700_0759_Should_Be_18(int year, int month, int day, int hour, int minute, int second)
        {
            // Arrange
            int result = 18;
            var calculator = new TollCalculator();
            var car = new Car();
            var date = new DateTime(year, month, day, hour, minute, second);

            // Act
            var tollFee = calculator.GetTollFee(date, car);

            // Assert
            Assert.Equal(result, tollFee);
        }

        [Theory]
        [InlineData(2013, 2, 4, 08, 00, 0)]
        [InlineData(2013, 2, 4, 08, 01, 0)]
        [InlineData(2013, 2, 4, 08, 10, 0)]
        [InlineData(2013, 2, 4, 08, 15, 0)]
        [InlineData(2013, 2, 4, 08, 28, 0)]
        [InlineData(2013, 2, 4, 08, 29, 0)]
        public void Car_0800_0829_Should_Be_13(int year, int month, int day, int hour, int minute, int second)
        {
            // Arrange
            int result = 13;
            var calculator = new TollCalculator();
            var car = new Car();
            var date = new DateTime(year, month, day, hour, minute, second);

            // Act
            var tollFee = calculator.GetTollFee(date, car);

            // Assert
            Assert.Equal(result, tollFee);
        }

        [Theory]
        [InlineData(2013, 2, 4, 08, 30, 0)]
        [InlineData(2013, 2, 4, 08, 31, 0)]
        [InlineData(2013, 2, 4, 08, 45, 0)]
        [InlineData(2013, 2, 4, 08, 59, 0)]

        [InlineData(2013, 2, 4, 09, 00, 0)]
        [InlineData(2013, 2, 4, 09, 01, 0)]
        [InlineData(2013, 2, 4, 09, 15, 0)]
        [InlineData(2013, 2, 4, 09, 29, 0)]
        [InlineData(2013, 2, 4, 09, 30, 0)]
        [InlineData(2013, 2, 4, 09, 31, 0)]
        [InlineData(2013, 2, 4, 09, 45, 0)]
        [InlineData(2013, 2, 4, 09, 59, 0)]

        [InlineData(2013, 2, 4, 10, 00, 0)]
        [InlineData(2013, 2, 4, 10, 01, 0)]
        [InlineData(2013, 2, 4, 10, 15, 0)]
        [InlineData(2013, 2, 4, 10, 29, 0)]
        [InlineData(2013, 2, 4, 10, 30, 0)]
        [InlineData(2013, 2, 4, 10, 31, 0)]
        [InlineData(2013, 2, 4, 10, 45, 0)]
        [InlineData(2013, 2, 4, 10, 59, 0)]

        [InlineData(2013, 2, 4, 11, 00, 0)]
        [InlineData(2013, 2, 4, 11, 01, 0)]
        [InlineData(2013, 2, 4, 11, 15, 0)]
        [InlineData(2013, 2, 4, 11, 29, 0)]
        [InlineData(2013, 2, 4, 11, 30, 0)]
        [InlineData(2013, 2, 4, 11, 31, 0)]
        [InlineData(2013, 2, 4, 11, 45, 0)]
        [InlineData(2013, 2, 4, 11, 59, 0)]

        [InlineData(2013, 2, 4, 12, 00, 0)]
        [InlineData(2013, 2, 4, 12, 01, 0)]
        [InlineData(2013, 2, 4, 12, 15, 0)]
        [InlineData(2013, 2, 4, 12, 29, 0)]
        [InlineData(2013, 2, 4, 12, 30, 0)]
        [InlineData(2013, 2, 4, 12, 31, 0)]
        [InlineData(2013, 2, 4, 12, 45, 0)]
        [InlineData(2013, 2, 4, 12, 59, 0)]

        [InlineData(2013, 2, 4, 13, 00, 0)]
        [InlineData(2013, 2, 4, 13, 01, 0)]
        [InlineData(2013, 2, 4, 13, 15, 0)]
        [InlineData(2013, 2, 4, 13, 29, 0)]
        [InlineData(2013, 2, 4, 13, 30, 0)]
        [InlineData(2013, 2, 4, 13, 31, 0)]
        [InlineData(2013, 2, 4, 13, 45, 0)]
        [InlineData(2013, 2, 4, 13, 59, 0)]

        [InlineData(2013, 2, 4, 14, 00, 0)]
        [InlineData(2013, 2, 4, 14, 01, 0)]
        [InlineData(2013, 2, 4, 14, 15, 0)]
        [InlineData(2013, 2, 4, 14, 29, 0)]
        [InlineData(2013, 2, 4, 14, 30, 0)]
        [InlineData(2013, 2, 4, 14, 31, 0)]
        [InlineData(2013, 2, 4, 14, 45, 0)]
        [InlineData(2013, 2, 4, 14, 59, 0)]
        public void Car_0830_1459_Should_Be_8(int year, int month, int day, int hour, int minute, int second)
        {
            // Arrange
            int result = 8;
            var calculator = new TollCalculator();
            var car = new Car();
            var date = new DateTime(year, month, day, hour, minute, second);

            // Act
            var tollFee = calculator.GetTollFee(date, car);

            // Assert
            Assert.Equal(result, tollFee);
        }

        [Theory]
        [InlineData(2013, 2, 4, 15, 00, 0)]
        [InlineData(2013, 2, 4, 15, 01, 0)]
        [InlineData(2013, 2, 4, 15, 10, 0)]
        [InlineData(2013, 2, 4, 15, 15, 0)]
        [InlineData(2013, 2, 4, 15, 25, 0)]
        [InlineData(2013, 2, 4, 15, 29, 0)]
        public void Car_1500_1529_Should_Be_13(int year, int month, int day, int hour, int minute, int second)
        {
            // Arrange
            int result = 13;
            var calculator = new TollCalculator();
            var car = new Car();
            var date = new DateTime(year, month, day, hour, minute, second);

            // Act
            var tollFee = calculator.GetTollFee(date, car);

            // Assert
            Assert.Equal(result, tollFee);
        }

        [Theory]
        [InlineData(2013, 2, 4, 15, 30, 0)]
        [InlineData(2013, 2, 4, 15, 31, 0)]
        [InlineData(2013, 2, 4, 15, 45, 0)]
        [InlineData(2013, 2, 4, 15, 59, 0)]
        [InlineData(2013, 2, 4, 16, 00, 0)]
        [InlineData(2013, 2, 4, 16, 01, 0)]
        [InlineData(2013, 2, 4, 16, 15, 0)]
        [InlineData(2013, 2, 4, 16, 25, 0)]
        [InlineData(2013, 2, 4, 16, 29, 0)]
        [InlineData(2013, 2, 4, 16, 30, 0)]
        [InlineData(2013, 2, 4, 16, 31, 0)]
        [InlineData(2013, 2, 4, 16, 45, 0)]
        [InlineData(2013, 2, 4, 16, 55, 0)]
        [InlineData(2013, 2, 4, 16, 59, 0)]
        public void Car_1530_1659_Should_Be_18(int year, int month, int day, int hour, int minute, int second)
        {
            // Arrange
            int result = 18;
            var calculator = new TollCalculator();
            var car = new Car();
            var date = new DateTime(year, month, day, hour, minute, second);

            // Act
            var tollFee = calculator.GetTollFee(date, car);

            // Assert
            Assert.Equal(result, tollFee);
        }

        [Theory]
        [InlineData(2013, 2, 4, 17, 00, 0)]   
        [InlineData(2013, 2, 4, 17, 01, 0)]   
        [InlineData(2013, 2, 4, 17, 10, 0)]   
        [InlineData(2013, 2, 4, 17, 15, 0)]
        [InlineData(2013, 2, 4, 17, 25, 0)]
        [InlineData(2013, 2, 4, 17, 30, 0)]
        [InlineData(2013, 2, 4, 17, 35, 0)]
        [InlineData(2013, 2, 4, 17, 45, 0)]
        [InlineData(2013, 2, 4, 17, 55, 0)]
        [InlineData(2013, 2, 4, 17, 59, 0)]
        public void Car_1700_1759_Should_Be_13(int year, int month, int day, int hour, int minute, int second)
        {
            // Arrange
            int result = 13;
            var calculator = new TollCalculator();
            var car = new Car();
            var date = new DateTime(year, month, day, hour, minute, second);

            // Act
            var tollFee = calculator.GetTollFee(date, car);

            // Assert
            Assert.Equal(result, tollFee);
        }

        [Theory]
        [InlineData(2013, 2, 4, 18, 00, 0)]
        [InlineData(2013, 2, 4, 18, 01, 0)]
        [InlineData(2013, 2, 4, 18, 10, 0)]
        [InlineData(2013, 2, 4, 18, 15, 0)]
        [InlineData(2013, 2, 4, 18, 25, 0)]
        [InlineData(2013, 2, 4, 18, 29, 0)]
        public void Car_1800_1829_Should_Be_8(int year, int month, int day, int hour, int minute, int second)
        {
            // Arrange
            int result = 8;
            var calculator = new TollCalculator();
            var car = new Car();
            var date = new DateTime(year, month, day, hour, minute, second);

            // Act
            var tollFee = calculator.GetTollFee(date, car);

            // Assert
            Assert.Equal(result, tollFee);
        }

        [Theory]
        [InlineData(2013, 2, 4, 18, 30, 0)]
        [InlineData(2013, 2, 4, 18, 31, 0)]
        [InlineData(2013, 2, 4, 18, 45, 0)]
        [InlineData(2013, 2, 4, 18, 59, 0)]
        [InlineData(2013, 2, 4, 19, 00, 0)]
        [InlineData(2013, 2, 4, 19, 01, 0)]
        [InlineData(2013, 2, 4, 19, 29, 0)]
        [InlineData(2013, 2, 4, 19, 30, 0)]
        [InlineData(2013, 2, 4, 19, 31, 0)]
        [InlineData(2013, 2, 4, 19, 59, 0)]
        [InlineData(2013, 2, 4, 20, 00, 0)]
        [InlineData(2013, 2, 4, 20, 01, 0)]
        [InlineData(2013, 2, 4, 20, 30, 0)]
        [InlineData(2013, 2, 4, 21, 00, 0)]
        [InlineData(2013, 2, 4, 21, 30, 0)]
        [InlineData(2013, 2, 4, 22, 00, 0)]
        [InlineData(2013, 2, 4, 23, 00, 0)]
        [InlineData(2013, 2, 4, 23, 30, 0)]
        [InlineData(2013, 2, 4, 00, 00, 0)]
        [InlineData(2013, 2, 4, 00, 30, 0)]
        [InlineData(2013, 2, 4, 00, 59, 0)]
        [InlineData(2013, 2, 4, 01, 00, 0)]
        [InlineData(2013, 2, 4, 01, 30, 0)]
        [InlineData(2013, 2, 4, 02, 00, 0)]
        [InlineData(2013, 2, 4, 02, 30, 0)]
        [InlineData(2013, 2, 4, 03, 00, 0)]
        [InlineData(2013, 2, 4, 03, 30, 0)]
        [InlineData(2013, 2, 4, 04, 00, 0)]
        [InlineData(2013, 2, 4, 04, 30, 0)]
        [InlineData(2013, 2, 4, 04, 59, 0)]
        [InlineData(2013, 2, 4, 05, 00, 0)]
        [InlineData(2013, 2, 4, 05, 30, 0)]
        [InlineData(2013, 2, 4, 05, 59, 0)]
        public void Car_1829_0559_Should_Be_0(int year, int month, int day, int hour, int minute, int second)
        {
            // Arrange
            int result = 0;
            var calculator = new TollCalculator();
            var car = new Car();
            var date = new DateTime(year, month, day, hour, minute, second);

            // Act
            var tollFee = calculator.GetTollFee(date, car);

            // Assert
            Assert.Equal(result, tollFee);
        }
    }


    public class TimeTableEdgeCases_SHOULD_FAIL_Tests
    {
        [Theory]
        [InlineData(2013, 2, 4, 05, 59, 0)] // Should Fail
        [InlineData(2013, 2, 4, 06, 30, 0)] // Should Fail
        public void Car_0600_0629_Interval_Should_Fail(int year, int month, int day, int hour, int minute, int second)
        {
            // Arrange
            int result = 8;
            var calculator = new TollCalculator();
            var car = new Car();
            var date = new DateTime(year, month, day, hour, minute, second);

            // Act
            var tollFee = calculator.GetTollFee(date, car);

            // Assert
            Assert.Equal(result, tollFee);
        }

        [Theory]
        [InlineData(2013, 2, 4, 06, 29, 0)] // Should Fail
        [InlineData(2013, 2, 4, 07, 00, 0)] // Should Fail
        public void Car_0630_0659_Interval_Should_Fail(int year, int month, int day, int hour, int minute, int second)
        {
            // Arrange
            int result = 13;
            var calculator = new TollCalculator();
            var car = new Car();
            var date = new DateTime(year, month, day, hour, minute, second);

            // Act
            var tollFee = calculator.GetTollFee(date, car);

            // Assert
            Assert.Equal(result, tollFee);
        }

        [Theory]
        [InlineData(2013, 2, 4, 06, 59, 0)] // Should Fail
        [InlineData(2013, 2, 4, 08, 00, 0)] // Should Fail
        public void Car_0700_0759_Interval_Should_Fail(int year, int month, int day, int hour, int minute, int second)
        {
            // Arrange
            int result = 18;
            var calculator = new TollCalculator();
            var car = new Car();
            var date = new DateTime(year, month, day, hour, minute, second);

            // Act
            var tollFee = calculator.GetTollFee(date, car);

            // Assert
            Assert.Equal(result, tollFee);
        }


        [Theory]
        [InlineData(2013, 2, 4, 07, 59, 0)] // Should Fail
        [InlineData(2013, 2, 4, 08, 30, 0)] // Should Fail
        public void Car_0800_0829_Interval_Should_Fail(int year, int month, int day, int hour, int minute, int second)
        {
            // Arrange
            int result = 13;
            var calculator = new TollCalculator();
            var car = new Car();
            var date = new DateTime(year, month, day, hour, minute, second);

            // Act
            var tollFee = calculator.GetTollFee(date, car);

            // Assert
            Assert.Equal(result, tollFee);
        }

        [Theory]
        [InlineData(2013, 2, 4, 08, 29, 0)] // Should Fail
        [InlineData(2013, 2, 4, 15, 00, 0)] // Should Fail
        public void Car_0830_1459_Interval_Should_Fail(int year, int month, int day, int hour, int minute, int second)
        {
            // Arrange
            int result = 8;
            var calculator = new TollCalculator();
            var car = new Car();
            var date = new DateTime(year, month, day, hour, minute, second);

            // Act
            var tollFee = calculator.GetTollFee(date, car);

            // Assert
            Assert.Equal(result, tollFee);
        }

        [Theory]
        [InlineData(2013, 2, 4, 14, 59, 0)] // Should Fail
        [InlineData(2013, 2, 4, 15, 30, 0)] // Should Fail
        public void Car_1500_1529_Interval_Should_Fail(int year, int month, int day, int hour, int minute, int second)
        {
            // Arrange
            int result = 13;
            var calculator = new TollCalculator();
            var car = new Car();
            var date = new DateTime(year, month, day, hour, minute, second);

            // Act
            var tollFee = calculator.GetTollFee(date, car);

            // Assert
            Assert.Equal(result, tollFee);
        }

        [Theory]
        [InlineData(2013, 2, 4, 15, 29, 0)] // Should Fail
        [InlineData(2013, 2, 4, 17, 00, 0)] // Should Fail
        public void Car_1530_1659_Interval_Should_Fail(int year, int month, int day, int hour, int minute, int second)
        {
            // Arrange
            int result = 18;
            var calculator = new TollCalculator();
            var car = new Car();
            var date = new DateTime(year, month, day, hour, minute, second);

            // Act
            var tollFee = calculator.GetTollFee(date, car);

            // Assert
            Assert.Equal(result, tollFee);
        }

        [Theory]
        [InlineData(2013, 2, 4, 16, 59, 0)] // Should Fail
        [InlineData(2013, 2, 4, 18, 00, 0)] // Should Fail
        public void Car_1700_1759_Interval_Should_Fail(int year, int month, int day, int hour, int minute, int second)
        {
            // Arrange
            int result = 13;
            var calculator = new TollCalculator();
            var car = new Car();
            var date = new DateTime(year, month, day, hour, minute, second);

            // Act
            var tollFee = calculator.GetTollFee(date, car);

            // Assert
            Assert.Equal(result, tollFee);
        }

        [Theory]
        [InlineData(2013, 2, 4, 17, 59, 0)] // Should Fail
        [InlineData(2013, 2, 4, 18, 30, 0)] // Should Fail
        public void Car_1800_1829_Interval_Should_Fail(int year, int month, int day, int hour, int minute, int second)
        {
            // Arrange
            int result = 8;
            var calculator = new TollCalculator();
            var car = new Car();
            var date = new DateTime(year, month, day, hour, minute, second);

            // Act
            var tollFee = calculator.GetTollFee(date, car);

            // Assert
            Assert.Equal(result, tollFee);
        }

        [Theory]
        [InlineData(2013, 2, 4, 18, 29, 0)] // Should Fail
        [InlineData(2013, 2, 4, 06, 00, 0)] // Should Fail
        public void Car_1830_0559_Interval_Should_Fail(int year, int month, int day, int hour, int minute, int second)
        {
            // Arrange
            int result = 0;
            var calculator = new TollCalculator();
            var car = new Car();
            var date = new DateTime(year, month, day, hour, minute, second);

            // Act
            var tollFee = calculator.GetTollFee(date, car);

            // Assert
            Assert.Equal(result, tollFee);
        }
    }


    public class AccululatedTollSumsTest
    {
        [Fact]
        public void Multiple_Passes_Tollrates1X_60min_Intervals_1X_Should_Be_8()
        {
            // Arrange
            int result = 8;
            var calculator = new TollCalculator();
            var car = new Car();
            DateTime[] dates = new DateTime[]
            {
                new DateTime(2013, 2, 4, 6, 0, 0),
                new DateTime(2013, 2, 4, 6, 5, 0),
                new DateTime(2013, 2, 4, 6, 10, 0),
                new DateTime(2013, 2, 4, 6, 12, 0),
                new DateTime(2013, 2, 4, 6, 15, 0),
                new DateTime(2013, 2, 4, 6, 25, 0),
            };

            // Act
            var tollFee = calculator.GetTollFee(car, dates);

            // Assert
            Assert.Equal(result, tollFee);
        }

        [Fact]
        public void Multiple_Passes_Tollrates1X_60min_Intervals_1X_Should_Be_13()
        {
            // Arrange
            int result = 13;
            var calculator = new TollCalculator();
            var car = new Car();
            DateTime[] dates = new DateTime[]
            {
                new DateTime(2013, 2, 4, 6, 30, 0),
                new DateTime(2013, 2, 4, 6, 35, 0),
                new DateTime(2013, 2, 4, 6, 45, 0),
                new DateTime(2013, 2, 4, 6, 46, 0),
                new DateTime(2013, 2, 4, 6, 47, 0),
                new DateTime(2013, 2, 4, 6, 48, 0),
                new DateTime(2013, 2, 4, 6, 49, 0),
                new DateTime(2013, 2, 4, 6, 51, 0),
                new DateTime(2013, 2, 4, 6, 52, 0),
                new DateTime(2013, 2, 4, 6, 55, 0),
            };

            // Act
            var tollFee = calculator.GetTollFee(car, dates);

            // Assert
            Assert.Equal(result, tollFee);
        }


        [Fact]
        public void Two_Passes_Tollrates2X_60min_Intervals_1X_Should_Be_13()
        {
            // Arrange
            int result = 13;
            var calculator = new TollCalculator();
            var car = new Car();
            DateTime[] dates = new DateTime[]
            {
                new DateTime(2013, 2, 4, 6, 10, 0),
                new DateTime(2013, 2, 4, 6, 40, 0),
            };

            // Act
            var tollFee = calculator.GetTollFee(car, dates);

            // Assert
            Assert.Equal(result, tollFee);
        }

        [Fact]
        public void Three_Passes_Tollrates3X_60min_Intervals_1X_Should_Be_18()
        {
            // Arrange
            int result = 18;
            var calculator = new TollCalculator();
            var car = new Car();
            DateTime[] dates = new DateTime[]
            {
                new DateTime(2013, 2, 4, 6, 10, 0), //toll rate is: 8
                new DateTime(2013, 2, 4, 6, 35, 0), //toll rate is: 13
                new DateTime(2013, 2, 4, 7, 05, 0), //toll rate is: 18
            };

            // Act
            var tollFee = calculator.GetTollFee(car, dates);

            // Assert
            Assert.Equal(result, tollFee);
        }

        [Fact]
        public void Four_Passes_Tollrates3X_60min_Intervals_1X_Should_Be_18()
        {
            // Arrange
            int result = 18;
            var calculator = new TollCalculator();
            var car = new Car();
            DateTime[] dates = new DateTime[]
            {
                new DateTime(2013, 2, 4, 6, 10, 0),
                new DateTime(2013, 2, 4, 6, 15, 0),
                new DateTime(2013, 2, 4, 6, 25, 0),
                new DateTime(2013, 2, 4, 7, 05, 0),
            };

            // Act
            var tollFee = calculator.GetTollFee(car, dates);

            // Assert
            Assert.Equal(result, tollFee);
        }

        [Fact]
        public void Six_Passes_Tollrates4X_60min_Intervals_2X_Should_Be_36()
        {
            // Arrange
            int result = 36;
            var calculator = new TollCalculator();
            var car = new Car();
            DateTime[] dates = new DateTime[]
            {
                new DateTime(2013, 2, 4, 6, 10, 0),
                new DateTime(2013, 2, 4, 6, 15, 0),
                new DateTime(2013, 2, 4, 7, 05, 0),
                                    // sub sum: 18 
                new DateTime(2013, 2, 4, 15, 10, 0),
                new DateTime(2013, 2, 4, 15, 15, 0),
                new DateTime(2013, 2, 4, 15, 35, 0),
                                    // sub sum: 18 
            };

            // Act
            var tollFee = calculator.GetTollFee(car, dates);

            // Assert
            Assert.Equal(result, tollFee);
        }

        [Fact]
        public void Nine_Passes_Tollrates4X_60min_Intervals_3X_Should_Be_39()
        {
            // Arrange
            int result = 39;
            var calculator = new TollCalculator();
            var car = new Car();
            DateTime[] dates = new DateTime[]
            {
                // chunk 1
                new DateTime(2013, 2, 4, 6, 10, 0),
                new DateTime(2013, 2, 4, 6, 15, 0),
                new DateTime(2013, 2, 4, 7, 05, 0),
                                    // sub sum: 18 
                // chunk 2
                new DateTime(2013, 2, 4, 15, 10, 0),
                new DateTime(2013, 2, 4, 15, 15, 0),
                new DateTime(2013, 2, 4, 15, 25, 0),
                                    // sub sum: 13 
                // chunk 3
                new DateTime(2013, 2, 4, 18, 0, 0),
                new DateTime(2013, 2, 4, 18, 10, 0),
                new DateTime(2013, 2, 4, 18, 25, 0),
                                    // sub sum: 8 
            };

            // Act
            var tollFee = calculator.GetTollFee(car, dates);

            // Assert
            Assert.Equal(result, tollFee);
        }

        [Fact]
        public void Sixteen_Passes_Tollrates4X_60min_Intervals_4X_Should_Be_57()
        {
            // Arrange
            int result = 57;
            var calculator = new TollCalculator();
            var car = new Car();
            DateTime[] dates = new DateTime[]
            {
                // chunk 1
                new DateTime(2013, 2, 4, 6, 10, 0),
                new DateTime(2013, 2, 4, 6, 15, 0),
                new DateTime(2013, 2, 4, 7, 05, 0),
                                    // sub sum: 18 

                // chunk 2
                new DateTime(2013, 2, 4, 7, 11, 0),
                new DateTime(2013, 2, 4, 7, 13, 0),
                new DateTime(2013, 2, 4, 7, 14, 0),
                new DateTime(2013, 2, 4, 7, 15, 0),
                new DateTime(2013, 2, 4, 7, 25, 0),
                new DateTime(2013, 2, 4, 7, 35, 0),
                new DateTime(2013, 2, 4, 8, 10, 0),
                                    // sub sum: 18 

                // chunk 3
                new DateTime(2013, 2, 4, 15, 10, 0),
                new DateTime(2013, 2, 4, 15, 15, 0),
                new DateTime(2013, 2, 4, 15, 25, 0),
                                    // sub sum: 13 
                // chunk 4
                new DateTime(2013, 2, 4, 18, 0, 0),
                new DateTime(2013, 2, 4, 18, 10, 0),
                new DateTime(2013, 2, 4, 18, 25, 0),
                                    // sub sum: 8 
            };

            // Act
            var tollFee = calculator.GetTollFee(car, dates);

            // Assert
            Assert.Equal(result, tollFee);
        }

        [Fact]
        public void Nineteen_Passes_Tollrates4X_60min_Intervals_4X_Should_Be_57()
        {
            // Arrange
            int result = 60;
            var calculator = new TollCalculator();
            var car = new Car();
            DateTime[] dates = new DateTime[]
            {
                // chunk 1
                new DateTime(2013, 2, 4, 6, 10, 0),
                new DateTime(2013, 2, 4, 6, 15, 0),
                new DateTime(2013, 2, 4, 7, 05, 0),
                                    // sub sum: 18 

                // chunk 2
                new DateTime(2013, 2, 4, 7, 11, 0),
                new DateTime(2013, 2, 4, 7, 13, 0),
                new DateTime(2013, 2, 4, 7, 14, 0),
                new DateTime(2013, 2, 4, 7, 15, 0),
                new DateTime(2013, 2, 4, 7, 25, 0),
                new DateTime(2013, 2, 4, 7, 35, 0),
                new DateTime(2013, 2, 4, 8, 10, 0),
                                    // sub sum: 18 

                // chunk 3
                new DateTime(2013, 2, 4, 12, 10, 0),
                new DateTime(2013, 2, 4, 13, 15, 0),
                new DateTime(2013, 2, 4, 14, 25, 0),
                                    // sub sum: 8 
                
                // chunk 4
                new DateTime(2013, 2, 4, 15, 10, 0),
                new DateTime(2013, 2, 4, 15, 15, 0),
                new DateTime(2013, 2, 4, 15, 25, 0),
                                    // sub sum: 13 
                // chunk 5
                new DateTime(2013, 2, 4, 18, 0, 0),
                new DateTime(2013, 2, 4, 18, 10, 0),
                new DateTime(2013, 2, 4, 18, 25, 0),
                                    // sub sum: 8 
            };

            // Act
            var tollFee = calculator.GetTollFee(car, dates);

            // Assert
            Assert.Equal(result, tollFee);
        }








        [Fact]
        public void Four_Passes_Tollrates4X_60min_Intervals_1X_Should_Be_18()
        {
            // Arrange
            int result = 18;
            var calculator = new TollCalculator();
            var car = new Car();
            DateTime[] dates = new DateTime[]
            {
                new DateTime(2013, 2, 4, 6, 28, 0),
                                    // sub sum: 8 
                new DateTime(2013, 2, 4, 6, 50, 0),
                                    // sub sum: 13 
                new DateTime(2013, 2, 4, 6, 52, 0),
                                    // sub sum: 13 
                new DateTime(2013, 2, 4, 7, 25, 0),
                                    // sub sum: 18 
            };

            // Act
            var tollFee = calculator.GetTollFee(car, dates);

            // Assert
            Assert.Equal(result, tollFee);
        }

        [Fact]
        public void Five_Passes_Tollrates4X_60min_Intervals_1X_Should_Be_18()
        {
            // Arrange
            int result = 18;
            var calculator = new TollCalculator();
            var car = new Car();
            DateTime[] dates = new DateTime[]
            {
                new DateTime(2013, 2, 4, 6, 28, 0),
                                    // sub sum: 8 
                new DateTime(2013, 2, 4, 6, 45, 0),
                                    // sub sum: 13 
                new DateTime(2013, 2, 4, 6, 50, 0),
                                    // sub sum: 13 
                new DateTime(2013, 2, 4, 6, 52, 0),
                                    // sub sum: 13 
                new DateTime(2013, 2, 4, 7, 25, 0),
                                    // sub sum: 18 
            };

            // Act
            var tollFee = calculator.GetTollFee(car, dates);

            // Assert
            Assert.Equal(result, tollFee);
        }






    }








    public class TollFreeVehiclesTests
    {
        [Fact]
        public void MotorBike_Return_0()
        {
            // Arrange
            var calculator = new TollCalculator();
            var motorbike = new Motorbike();
            var date = new DateTime(2023, 2, 3, 8, 0, 0); // 8:00 Sunday

            // Act
            var tollFee = calculator.GetTollFee(date, motorbike);

            // Assert
            Assert.Equal(0, tollFee);
        }
    }

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