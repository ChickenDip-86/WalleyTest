using WalleyAssignment;

namespace WalleyTests
{

    /**************************************************************
    *                                                            *
    *                             TESTS                          *
    *                          TIME TABLE                        *
    *                                                            *
    **************************************************************/

    public class TimeTableTests
    {
        [Theory]
        [InlineData(2013, 2, 4, 06, 10, 0)]
        public void Car_0610_Should_Be_8(int year, int month, int day, int hour, int minute, int second)
        {
            // Arrange
            int result = 8;
            var calculator = new TollCalculator();
            var car = new Car();
            var date = new DateTime(year, month, day, hour, minute, second);

            // Act
            var tollFee = calculator.GetTollFeeForSpecificTime(date, car);

            // Assert
            Assert.Equal(result, tollFee);
        }

        [Theory]
        [InlineData(2013, 2, 4, 12, 12, 0)]
        public void Car_1212_Should_Be_8(int year, int month, int day, int hour, int minute, int second)
        {
            // Arrange
            int result = 8;
            var calculator = new TollCalculator();
            var car = new Car();
            var date = new DateTime(year, month, day, hour, minute, second);

            // Act
            var tollFee = calculator.GetTollFeeForSpecificTime(date, car);

            // Assert
            Assert.Equal(result, tollFee);
        }

        [Theory]
        [InlineData(2013, 2, 4, 18, 10, 0)]
        public void Car_1810_Should_Be_8(int year, int month, int day, int hour, int minute, int second)
        {
            // Arrange
            int result = 8;
            var calculator = new TollCalculator();
            var car = new Car();
            var date = new DateTime(year, month, day, hour, minute, second);

            // Act
            var tollFee = calculator.GetTollFeeForSpecificTime(date, car);

            // Assert
            Assert.Equal(result, tollFee);
        }

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
            var tollFee = calculator.GetTollFeeForSpecificTime(date, car);

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
            var tollFee = calculator.GetTollFeeForSpecificTime(date, car);

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
            var tollFee = calculator.GetTollFeeForSpecificTime(date, car);

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
            var tollFee = calculator.GetTollFeeForSpecificTime(date, car);

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
            var tollFee = calculator.GetTollFeeForSpecificTime(date, car);

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
            var tollFee = calculator.GetTollFeeForSpecificTime(date, car);

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
            var tollFee = calculator.GetTollFeeForSpecificTime(date, car);

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
            var tollFee = calculator.GetTollFeeForSpecificTime(date, car);

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
            var tollFee = calculator.GetTollFeeForSpecificTime(date, car);

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
            var tollFee = calculator.GetTollFeeForSpecificTime(date, car);

            // Assert
            Assert.Equal(result, tollFee);
        }
    }







    /**************************************************************
   *                                                            *
   *                       SHOULD FAIL TESTS                    *
   *                                                            *
   **************************************************************/





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
            var tollFee = calculator.GetTollFeeForSpecificTime(date, car);

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
            var tollFee = calculator.GetTollFeeForSpecificTime(date, car);

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
            var tollFee = calculator.GetTollFeeForSpecificTime(date, car);

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
            var tollFee = calculator.GetTollFeeForSpecificTime(date, car);

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
            var tollFee = calculator.GetTollFeeForSpecificTime(date, car);

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
            var tollFee = calculator.GetTollFeeForSpecificTime(date, car);

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
            var tollFee = calculator.GetTollFeeForSpecificTime(date, car);

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
            var tollFee = calculator.GetTollFeeForSpecificTime(date, car);

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
            var tollFee = calculator.GetTollFeeForSpecificTime(date, car);

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
            var tollFee = calculator.GetTollFeeForSpecificTime(date, car);

            // Assert
            Assert.Equal(result, tollFee);
        }
    }



}








    
   


 
