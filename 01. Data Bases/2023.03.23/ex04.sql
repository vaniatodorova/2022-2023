SELECT c.country_name, MAX(p.elevation) AS 'highest_peak_evelation', MAX(r.length) AS 'highest_river_evelation' 
FROM countries AS c
LEFT JOIN mountains_countries AS mc ON mc.country_code = c.country_code
LEFT JOIN peaks AS p ON p.mountain_id = mc.mountain_id
LEFT JOIN countries_rivers AS cr ON cr.country_code = c.country_code
LEFT JOIN rivers AS r ON r.Id = cr.river_id
GROUP BY c.country_name
ORDER BY highest_peak_evelation DESC, highest_river_evelation DESC, c.country_name ASC
limit 5;