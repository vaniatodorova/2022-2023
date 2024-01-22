SELECT e.employee_id, e.first_name, p.`name`
  FROM projects AS p
  INNER JOIN employees_projects AS ep
  ON ep.project_id = p.project_id
  INNER JOIN employees AS e
  ON e.employee_id = ep.employee_id
  WHERE p.start_date > '13.08.2002' OR p.end_date IS NULL
  ORDER BY e.first_name ASC, p.`name` ASC
  LIMIT 5