
namespace TechJobs.Tests
{
	[TestClass]
	public class JobTests
	{
        //Testing Objects
        //initalize your testing objects here

        [TestMethod]
        public void TestMethod()
        {
            //    //TODO: Task 4: remove this method before you create your first test method 
            //

            //---------------------------------------------------------------------------------------------------------------------------/

            Job job1 = new Job();

            Job job2 = new Job();

            Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            //---------------------------------------------------------------------------------------------------------------------------//
            Assert.IsFalse(job1.Id == job2.Id);
            Assert.AreEqual(job1.Id + 1, job2.Id);

        }
    }
}

