SELECT `job_title`, concat(`first_name`, ' ', `middle_name`, ' ', `last_name`) AS 'full name',
`salary`
FROM soft_uni.employees
WHERE (`salary` < 10000 AND `department_id` = 5)
ORDER BY salary ASC, first_name DESC, middle_name DESC, last_name DESC