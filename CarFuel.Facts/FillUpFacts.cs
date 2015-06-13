using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFuel.Models;


using Xunit;
namespace CarFuel.Facts
{
    public class FillUpFacts
    {
        public class GeneralUsage
        {
            [Fact]
            public void Basic()
            {
                //Arrange
                var f1 = new FillUp();
                f1.Odometer = 1000;
                f1.IsFull = true;
                f1.Liters = 50.0;

                //Act

                //Assert
                Assert.Equal(1000, f1.Odometer);
                Assert.Equal(true, f1.IsFull);
                Assert.Equal(50.0, f1.Liters);
            }

            [Fact]
            public void DefualtDateShouldBeNow()
            {
                // a
                var f = new FillUp();
                //f.Date = DateTime.Now;
                // a
                DateTime dt = f.Date;

                // a
                Assert.Equal(expected: DateTime.Now, actual: dt);


            }
        }
    }
}
