SELECT Department, AVG(Salary) as AverageSalary
FROM Employee
GROUP BY Department;