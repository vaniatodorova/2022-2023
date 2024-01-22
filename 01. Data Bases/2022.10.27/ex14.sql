SELECT `first_name`, `last_name`, `job_title`, `salary`
FROM soft_uni.employees
WHERE `salary` >= 3500
ORDER BY first_name ASC, last_name ASC