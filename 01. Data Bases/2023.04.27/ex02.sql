SELECT Department, SUM(Salary) as TotalSalary
FROM Employee
GROUP BY Department;