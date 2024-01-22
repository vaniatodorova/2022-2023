SELECT Department, MAX(SALARY) as MaxSalary
FROM Employee
GROUP BY Department;