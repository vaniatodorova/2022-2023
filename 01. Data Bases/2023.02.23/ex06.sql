SELECT e.salary, d.name FROM employees AS e
JOIN departmnets AS d ON d.department_id = e.departmnet_id
ORDER BY salary ASC