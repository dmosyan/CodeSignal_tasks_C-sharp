/*Please add ; after each select statement*/
CREATE PROCEDURE projectsTeam()
BEGIN
SELECT DISTINCT name FROM projectLog /* distinct is selecting unique values */
ORDER BY name;
END
