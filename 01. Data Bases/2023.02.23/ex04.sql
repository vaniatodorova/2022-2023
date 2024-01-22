SELECT e.employee_id, e.first_name FROM employees AS e
LEFT JOIN employees_projects AS p ON p.employee_id = e.employee_id
ORDER BY employee_id DESC
LIMIT 3