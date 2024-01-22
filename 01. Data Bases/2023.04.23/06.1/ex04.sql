SELECT e.`department_id`,
MAX(e.`salary`) AS 'MaxSalary'
FROM `employees` AS e
GROUP BY e.`department_id`