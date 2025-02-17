SELECT e.employee_id, e.first_name, e.last_name, e.salary, d.name FROM employees AS e
JOIN departments AS d ON d.department_id = e.department_id
WHERE e.salary > 15000
ORDER BY employees_id DESC
LIMIT 5