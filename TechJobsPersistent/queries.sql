--Part 1 SQL TASK:  list the columns and their data types in the Jobs table.


DESCRIBE techjobs.jobs;


--Part 2 write a query to list the names of the employers in St. Louis City.

SELECT employers.Name, employers.Location
FROM techjobs.employers
WHERE employers.Location = "St. Louis City";

--OR

SELECT employers.Name
FROM techjobs.employers
WHERE employers.Location = "St. Louis City";

--Part 3 return a list of the names and descriptions of all skills that are attached to jobs in alphabetical order.
--If a skill does not have a job listed, it should not be included in the results of this query.


SELECT j.Name as JobName, s.Name SkillName, s.Description
FROM techjobs.jobskills js 
INNER JOIN techjobs.jobs j ON js.JobId = j.Id
INNER JOIN techjobs.skills s on js.SkillId = s.Id
ORDER BY j.Name asc, s.Name asc;

