SELECT e.first_name, e.last_name, e.hire_date, d.`name` FROM employees AS e
INNER JOIN departments AS d ON d.department_id = e.department_id
WHERE e.hire_date > ' 1/1/1999' AND d.name ='Finance' OR d.name='Sales'
ORDER BY e.hire_date ASC