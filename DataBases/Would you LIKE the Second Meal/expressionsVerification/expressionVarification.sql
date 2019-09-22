/*Please add ; after each select statement*/
CREATE PROCEDURE expressionsVerification()
BEGIN
	SELECT * FROM expressions
    WHERE
    (a + b = c AND operation = '+') OR
    (a - b = c AND operation = '-') OR
    (a * b = c AND operation = '*') OR
    (a / b = c AND operation = '/');
END
