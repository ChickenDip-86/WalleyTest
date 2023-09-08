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
    *                       TOLL FREE VEHICLES                   *
    *                                                            *
    **************************************************************/

    public class TollFreeVehiclesTests
    {
        [Fact]
        public void MotorBike_Return_0()
        {
            // Arrange
            var calculator = new TollCalculator();
            var motorbike = new Motorbike();
            var date = new DateTime(2023, 9, 7, 10, 0, 0); // 10:00 Thursday

            // Act
            var tollFee = calculator.GetTollFeeForSpecificTime(date, motorbike);

            // Assert
            Assert.Equal(0, tollFee);
        }


        [Fact]
        public void All_Toll_Free_Vehicles_Should_Be_0()
        {
            TollCalculator calculator = new TollCalculator();

            List<IVehicle> vehicleTypes = new List<IVehicle>
            {
                new Motorbike(),
                new Tractor(),
                new Emergency(),
                new Foreign(),
                new Diplomat(),
                new Military()
            };

            foreach (var vehicle in vehicleTypes)
            {
                var date = new DateTime(2023, 9, 7, 10, 0, 0); // 10:00 Thursday
                var tollFee = calculator.GetTollFeeForSpecificTime(date, vehicle);
                Assert.Equal(0, tollFee);
            }

        }



















    }




}
