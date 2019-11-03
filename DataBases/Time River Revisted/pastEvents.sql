/*Please add ; after each select statement*/
CREATE PROCEDURE pastEvents()
BEGIN
	SELECT name, event_date
    FROM Events
    WHERE datediff((SELECT MAX(event_date) FROM Events), event_date) BETWEEN 1 AND 7
    ORDER BY event_date DESC;
END