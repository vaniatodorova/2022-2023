SELECT City, Gender,
SUM(Salary) as TotalSalary,
COUNT(ID) as TotalEmployees
FROM Employee
GROUP BY CITY, Gender;