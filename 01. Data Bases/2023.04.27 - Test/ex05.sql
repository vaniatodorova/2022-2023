SELECT r.id, r.name, COUNT(i.repository_id) AS 'issues' FROM repositories as r
JOIN issues AS i ON i.repository_id=r.id
GROUP BY r.name
ORDER BY issues DESC
LIMIT 5