SELECT Department, Salary, COUNT(*) AS EmployeeCount
FROM Employee
GROUP BY Department, Salary
ORDER BY Department;