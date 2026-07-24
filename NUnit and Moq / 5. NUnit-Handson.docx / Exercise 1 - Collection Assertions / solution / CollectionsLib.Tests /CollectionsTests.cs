using System.Linq;
using NUnit.Framework;
using CollectionsLib;

namespace CollectionsLib.Tests
{
    [TestFixture]
    public class CollectionsTests
    {
        private CollectionsManager manager;

        [SetUp]
        public void SetUp()
        {
            manager = new CollectionsManager();
        }

        [Test]
        public void GetEmployees_ShouldNotContainNullValues()
        {
            var employees = manager.GetEmployees();

            CollectionAssert.AllItemsAreNotNull(employees);
        }

        [Test]
        public void GetEmployees_ShouldContainEmployeeWithId100()
        {
            var employees = manager.GetEmployees();

            Assert.That(employees.Any(e => e.Id == 100), Is.True);
        }

        [Test]
        public void GetEmployees_ShouldContainUniqueEmployees()
        {
            var employees = manager.GetEmployees();

            CollectionAssert.AllItemsAreUnique(employees);
        }

        [Test]
        public void EmployeeCollections_ShouldBeEqual()
        {
            var employees = manager.GetEmployees();
            var previousYearEmployees =
                manager.GetEmployeesWhoJoinedInPreviousYears();

            CollectionAssert.AreEquivalent(
                employees,
                previousYearEmployees);
        }
    }
}
