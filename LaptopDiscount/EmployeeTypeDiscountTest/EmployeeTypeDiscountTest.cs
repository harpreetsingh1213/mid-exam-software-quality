using LaptopDiscount;
namespace EmployeeTypeDiscountTest
{
    public class Tests
    {
        [Test]
        public void PartTimeEmployee_NoDiscount()
        {
            //Create instance
            var employeeDiscount = new EmployeeDiscount
            {
                EmployeeType = EmployeeType.PartTime,
                Price = 100m
            };

            // Act
            var discountedPrice = employeeDiscount.CalculateDiscountedPrice();

            // Assert
            Assert.That(discountedPrice, Is.EqualTo(100m));
        }

        [Test]
        public void PartialLoadEmployee_5PercentDiscount()
        {
            //Create instance
            var employeeDiscount = new EmployeeDiscount
            {
                EmployeeType = EmployeeType.PartialLoad,
                Price = 100m
            };

            // Act
            var discountedPrice = employeeDiscount.CalculateDiscountedPrice();

            // Assert
            Assert.That(discountedPrice, Is.EqualTo(95m));
        }

        [Test]
        public void FullTimeEmployee_10PercentDiscount()
        {
            //Create instance
            var employeeDiscount = new EmployeeDiscount
            {
                EmployeeType = EmployeeType.FullTime,
                Price = 100m
            };

            // Act
            var discountedPrice = employeeDiscount.CalculateDiscountedPrice();

            // Assert
            Assert.That(discountedPrice, Is.EqualTo(90m));
        }

        [Test]
        public void CompanyPurchasingEmployee_20PercentDiscount()
        {
            //Create instance
            var employeeDiscount = new EmployeeDiscount
            {
                EmployeeType = EmployeeType.CompanyPurchasing,
                Price = 100m
            };

            // Act
            var discountedPrice = employeeDiscount.CalculateDiscountedPrice();

            // Assert
            Assert.That(discountedPrice, Is.EqualTo(80m));
        }

        [Test]
        public void PartTimeEmployee_0PercentDiscount()
        {
            //Create instance
            var employeeDiscount = new EmployeeDiscount
            {
                EmployeeType = EmployeeType.PartTime,
                Price = 200m
            };

            // Act
            var discountedPrice = employeeDiscount.CalculateDiscountedPrice();

            // Assert
            Assert.That(discountedPrice, Is.EqualTo(200m));
        }

        [Test]
        public void PartTimeEmployee_0PercentDiscount_2()
        {
            //Create instance
            var employeeDiscount = new EmployeeDiscount
            {
                EmployeeType = EmployeeType.PartTime,
                Price = 500m
            };

            // Act
            var discountedPrice = employeeDiscount.CalculateDiscountedPrice();

            // Assert
            Assert.That(discountedPrice, Is.EqualTo(500m));
        }
    }
}