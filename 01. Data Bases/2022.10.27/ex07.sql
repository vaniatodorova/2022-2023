SELECT `last_name`, `salary`
FROM soft_uni.employees
WHERE NOT (`manager_id` = 3 OR `manager_id` = 4);