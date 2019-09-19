/*Please add ; after each select statement*/
CREATE PROCEDURE mostExpensive()
BEGIN
SELECT name FROM Products
WHERE quantity*price = (SELECT MAX(quantity*price) FROM Products)
ORDER BY name LIMIT 1;
END
