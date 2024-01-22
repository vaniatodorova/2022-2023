SELECT `department_id`, `job_title`, `first_name`, `last_name`, `salary`
FROM soft_uni.employees
WHERE department_id = 7
ORDER BY salary DESC, first_name ASC, last_name ASC