SELECT country_name, population
FROM georgaphy.countries
WHERE continent_code = 'EU'
ORDER BY population DESC, country_name ASC
LIMIT 30
