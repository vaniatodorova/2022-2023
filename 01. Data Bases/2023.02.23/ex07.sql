SELECT c.country_name
FROM countries AS c
LEFT OUTER JOIN mountains_countries AS m ON m.country_code = c.country_code
WHERE mountain_id IS NULL
