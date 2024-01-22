SELECT concat(`first_name`, ' ', `middle_name`, ' ', `last_name`) AS 'full name'
FROM soft_uni.employees
WHERE salary = 25000 OR salary = 14000 OR salary = 12500 OR salary = 23600

