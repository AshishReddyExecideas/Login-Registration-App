using BethanysPieShopHRM1.HR;

namespace TestProject1BethanysPieShopHRM1.Test
{
    public class EmployeeTests
    {
        [Fact]
        public void PerformWork_Adds_NumberofHours()
        {
            //Arrange
            Employee employee = new Employee("Bethany", "Smith", "bethany@gmail.com",new DateTime(1979,1,16),25);
            int numberOfHours = 3;

            //Act
            employee.PerformWork(numberOfHours);

            //Assert
            Assert.Equal(numberOfHours, employee.numberOfHoursWorked);
        }
    }
}