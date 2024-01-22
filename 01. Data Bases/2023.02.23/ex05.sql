SELECT employee_id, first_name, manager_id, concat(first_name) AS manager_name
FROM employees
WHERE manager_id = 7 or manager_id = 3
ORDER BY first_name ASC