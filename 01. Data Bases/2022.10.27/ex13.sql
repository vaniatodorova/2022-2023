SELECT `job_title`, `first_name`, `salary`
FROM soft_uni.employees
WHERE `salary` BETWEEN 2000 AND 4000
ORDER BY salary ASC