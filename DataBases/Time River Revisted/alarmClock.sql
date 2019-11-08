/*Please add ; after each select statement*/
CREATE PROCEDURE alarmClocks()
BEGIN
	DECLARE last_day DATETIME;
    DECLARE first_day DATETIME;
    DECLARE x DATETIME;
    DROP TABLE IF EXISTS TempTable;
    CREATE TEMPORARY TABLE TempTable (alarm_date DATETIME);
    SELECT input_date INTO first_day FROM userInput;
    SET x = first_day;
    WHILE YEAR(x) = YEAR(first_day) DO
        INSERT INTO TempTable SELECT x;
        SET x = DATE_ADD(x, INTERVAL 7 DAY);
    END WHILE;
    SELECT * FROM TempTable;
END