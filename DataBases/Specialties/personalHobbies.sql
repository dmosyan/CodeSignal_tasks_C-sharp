/*Please add ; after each select statement*/
CREATE PROCEDURE personalHobbies()
BEGIN
	SELECT name FROM people_hobbies
    WHERE INSTR(hobbies, 'sport') AND INSTR(hobbies, 'reading');
END