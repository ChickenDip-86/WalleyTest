using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalleyAssignment;

namespace WalleyTests
{

    /**************************************************************
    *                                                             *
    *                             TESTS                           *
    *                       ACCUMULATED TOLL SUMS                 *
    *                                                             *
    **************************************************************/

    public class AccumultedTollSumsTests
    {
        [Fact]
        public void One_Pass_Tollrates1X_60min_Intervals_1X_Should_Be_8()
        {
            // Arrange
            int result = 8;
            var calculator = new TollCalculator();
            var car = new Car();
            DateTime[] dates = new DateTime[]
            {
                new DateTime(2013, 2, 4, 6, 10, 0),
            };

            // Act
            var tollFee = calculator.GetTotalTollFeeForDay(car, dates);

            // Assert
            Assert.Equal(result, tollFee);
        }

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
            var tollFee = calculator.GetTotalTollFeeForDay(car, dates);

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
            var tollFee = calculator.GetTotalTollFeeForDay(car, dates);

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
            var tollFee = calculator.GetTotalTollFeeForDay(car, dates);

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
            var tollFee = calculator.GetTotalTollFeeForDay(car, dates);

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
            var tollFee = calculator.GetTotalTollFeeForDay(car, dates);

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
            var tollFee = calculator.GetTotalTollFeeForDay(car, dates);

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
            var tollFee = calculator.GetTotalTollFeeForDay(car, dates);

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
            var tollFee = calculator.GetTotalTollFeeForDay(car, dates);

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
            var tollFee = calculator.GetTotalTollFeeForDay(car, dates);

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
            var tollFee = calculator.GetTotalTollFeeForDay(car, dates);

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
            var tollFee = calculator.GetTotalTollFeeForDay(car, dates);

            // Assert
            Assert.Equal(result, tollFee);
        }



        [Fact]
        public void Five_Passes_Tollrates3_60min_Intervals_3X_Should_Be_44()
        {
            // Arrange
            int result = 44;
            var calculator = new TollCalculator();
            var car = new Car();
            DateTime[] dates = new DateTime[]
            {
                new DateTime(2021, 11, 30, 6, 55, 0),
                new DateTime(2021, 11, 30, 7, 20, 0),
                                        // sub sum: 18 
                new DateTime(2021, 11, 30, 11, 15, 0),
                new DateTime(2021, 11, 30, 11, 56, 0),
                                        // sub sum: 8 
                new DateTime(2021, 11, 30, 16, 20, 0),
                                        // sub sum: 18 
            };

            // Act
            var tollFee = calculator.GetTotalTollFeeForDay(car, dates);

            // Assert
            Assert.Equal(result, tollFee);
        }

        [Fact]
        public void Three_Passes_Tollrates2_60min_Intervals_2X_Should_Be_21()
        {
            // Arrange
            int result = 21;
            var calculator = new TollCalculator();
            var car = new Car();
            DateTime[] dates = new DateTime[]
            {
                new DateTime(2011, 02, 03, 12, 12, 0),
                new DateTime(2011, 02, 03, 12, 55, 0),
                                        // sub sum: 8 
                new DateTime(2011, 02, 03, 17, 10, 0),
                                        // sub sum: 13 
            };
            // Act
            var tollFee = calculator.GetTotalTollFeeForDay(car, dates);

            // Assert
            Assert.Equal(result, tollFee);
        }

        [Fact]
        public void One_Pass_Tollrates1_60min_Intervals_1X_Should_Be_8()
        {
            // Arrange
            int result = 8;
            var calculator = new TollCalculator();
            var car = new Car();
            DateTime[] dates = new DateTime[]
            {
                new DateTime(2011, 02, 03, 12, 12, 0),
                                        // sub sum: 8 
            };
            // Act
            var tollFee = calculator.GetTotalTollFeeForDay(car, dates);

            // Assert
            Assert.Equal(result, tollFee);
        }



    }
}
