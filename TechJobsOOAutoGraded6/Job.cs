﻿using System;
namespace TechJobsOOAutoGraded6
{
	public class Job
	{
        ///*

            public int Id { get; }
            private static int nextId = 1;
            public string Name { get; set; }
            public Employer EmployerName { get; set; }
            public Location EmployerLocation { get; set; }
            public PositionType JobType { get; set; }
            public CoreCompetency JobCoreCompetency { get; set; }

            // TODO: Task 3: Add the two necessary constructors.

         public Job()
        {
            Id = nextId;
            nextId++;
        }

        
        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        // TODO: Task 3: Generate Equals() and GetHashCode() methods.
        //
        public override bool Equals(object obj)
        {
            if (obj == null || !obj.GetType().Equals(this.GetType()))
            {
                return false;
            }
            Job otherJob = (Job)obj;
            return Id == otherJob.Id;
        }

        // TODO: Task 5: Generate custom ToString() method.
        //Until you create this method, you will not be able to print a job to the console.

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }



        public override string ToString()
        {
            string idString = $"\nID: {Id}\n";
            string nameString = $"\nName: {Name}\n";
            string employerString = $"\nEmployer: {(EmployerName?.Value == "" ? "Data not available" : EmployerName?.Value)}\n";
            string locationString = $"\nLocation: {(EmployerLocation?.Value == "" ? "Data not available" : EmployerLocation?.Value)}\n";
            string positionString = $"\nPosition Type: {(JobType?.Value == "" ? "Data not available" : JobType?.Value)}\n";
            string coreString = $"\nCore Competency: {(JobCoreCompetency?.Value == "" ? "Data not available" : JobCoreCompetency?.Value)}\n";

            return idString + nameString + employerString + locationString + positionString + coreString;
        }

    }
}

