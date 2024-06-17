using LaptopDiscount;
namespace EmployeeeTypeDiscountTest
{
    public class Tests
    {
        private EmployeeDiscount _employeeDiscount { get; set; } = null;

        [SetUp]
        public void Setup()
        {
            _employeeDiscount = new EmployeeDiscount();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}