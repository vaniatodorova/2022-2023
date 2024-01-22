SELECT Department, MIN(SALARY) as MinSalary
FROM Employee
GROUP BY Department;