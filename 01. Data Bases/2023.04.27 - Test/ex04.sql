SELECT id, `name`, size  
FROM  files 
WHERE id NOT IN (SELECT DISTINCT parent_id FROM   files WHERE parent_id is NOT NULL); 
/*(1,2,3,4,5,7,8,9,10,11,13,14,15,16,20,21,22,24,25,26,27,28,30,42,47);*/