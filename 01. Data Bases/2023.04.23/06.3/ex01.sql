SELECT e.`department_id`,
SUM(e.`salary`) AS 'Total Salary'
FROM `employees` AS e
GROUP BY e.`department_id`
HAVING `Total Salary` < 250000