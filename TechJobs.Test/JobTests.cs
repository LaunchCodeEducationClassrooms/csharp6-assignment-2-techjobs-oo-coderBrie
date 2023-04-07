    
using TechJobsOOAutoGraded6;

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




            Job job1 = new Job();

            Job job2 = new Job();

            Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));


            Assert.IsFalse(job1.Id == job2.Id);
            Assert.AreEqual(job1.Id + 1, job2.Id);

        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            // Arrange
            Job job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            // Act & Assert
            Assert.AreEqual("Product tester", job.Name);
            Assert.AreEqual("ACME", job.EmployerName.Value);
            Assert.AreEqual("Desert", job.EmployerLocation.Value);
            Assert.AreEqual("Quality control", job.JobType.Value);
            Assert.AreEqual("Persistence", job.JobCoreCompetency.Value);
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            // Arrange
            Job job1 = new Job("Software Engineer", new Employer("ABC Company"), new Location("Seattle"), new PositionType("Full-Time"), new CoreCompetency("Coding"));
            Job job2 = new Job("Data Scientist", new Employer("XYZ Inc."), new Location("San Francisco"), new PositionType("Full-Time"), new CoreCompetency("Data Analysis"));

            // Act
            bool result = job1.Equals(job2);

            // Assert
            Assert.IsFalse(result);
        }

        public void TestSettingJobId()
        {
            // Arrange
            Job job = new Job();
            int expectedId = 1;

            // Act
            int actualId = job.Id;

            // Assert
            Assert.AreEqual(expectedId, actualId);
        }

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

            [TestMethod]
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


    }
}

