/*Please add ; after each select statement*/
CREATE PROCEDURE orderOfSuccession()
BEGIN
	SELECT IF(gender = 'M', CONCAT('King ', name), CONCAT('Queen ', name)) AS name FROM Successors
    ORDER BY birthday ASC;
END