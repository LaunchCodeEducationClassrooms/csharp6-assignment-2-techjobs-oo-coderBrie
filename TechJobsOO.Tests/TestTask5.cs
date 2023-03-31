
using TechJobs.Tests;

namespace TechJobsOO.Tests
{
	[TestClass]
    public class TestTask5
    {
        //Task 5 Tests used to verify that students are testing their custom ToString method.
        //Uses jobs from the Job class.
        //Tests are numbered.

        ///*TODO: Task 5: Remove this line to uncomment the tests

        //Unit Test 1:  TestToStringStartsAndEndsWithNewLine  -----------------------

        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {
            Job job = new Job();

            string testString = job.ToString();
            Assert.IsTrue(testString.StartsWith("\n"));
            Assert.IsTrue(testString.EndsWith("\n"));
        }

        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
            Job job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            string testString = job.ToString();

            Assert.IsTrue(testString.Contains($"ID: {job.Id}\n"));
            Assert.IsTrue(testString.Contains($"Name: {job.Name}\n"));
            Assert.IsTrue(testString.Contains($"Employer: {job.EmployerName}\n"));
            Assert.IsTrue(testString.Contains($"Location: {job.EmployerLocation}\n"));
            Assert.IsTrue(testString.Contains($"Position Type: {job.JobType}\n"));
            Assert.IsTrue(testString.Contains($"Core Competency: {job.JobCoreCompetency}\n"));
        }


        [TestMethod] //6


        public void TestToStringHandlesEmptyField()
        {
            Job job = new Job();
            job.Name = "Software Developer";
            job.EmployerName = new Employer("");
            job.EmployerLocation = new Location("");
            job.JobType = new PositionType("");
            job.JobCoreCompetency = new CoreCompetency("");

            string output = job.ToString();

            Assert.IsTrue(output.Contains($"ID: {job.Id}\n"));
            Assert.IsTrue(output.Contains($"Name: {job.Name}\n"));
            Assert.IsTrue(output.Contains($"Employer: Data not available\n"));
            Assert.IsTrue(output.Contains($"Location: Data not available\n"));
            Assert.IsTrue(output.Contains($"Position Type: Data not available\n"));
            Assert.IsTrue(output.Contains($"Core Competency: Data not available\n"));
        }
        //TODO: Task 5: Remove this line to uncomment the tests*/

    }

}

