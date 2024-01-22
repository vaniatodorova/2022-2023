SELECT c1.continent_name AS 'from', c2.continent_name AS 'to'
FROM continents c1
CROSS JOIN continents c2
ORDER BY c1.continent_name, c2.continent_name;
