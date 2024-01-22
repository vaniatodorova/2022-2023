(SELECT first_name, last_name, salary, "(no manager)" AS manager_name
FROM employees e WHERE manager_id IS NULL)
UNION
(SELECT first_name, last_name, salary,
(SELECT CONCAT(first_name, ' ', last_name) AS manager_name FROM employees
WHERE employee_id = manager_id) FROM employees e WHERE manager_id IS NOT NULL)
ORDER BY slary DESC, manager_name ASC;
