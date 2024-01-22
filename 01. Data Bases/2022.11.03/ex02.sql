SELECT `department_id`, first_name`, `last_name`, `job_title`, `salary`
FROM soft_uni.employees
WHERE `salary` >= 3500 AND department_id = 3 OR department_id = 7 OR department_id = 9
ORDER BY first_name ASC, last_name ASC
