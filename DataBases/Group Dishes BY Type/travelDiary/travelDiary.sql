/*Please add ; after each select statement*/
CREATE PROCEDURE travelDiary()
BEGIN
	SELECT GROUP_CONCAT(DISTINCT country) AS countries FROM diary
    ORDER BY country;
END
