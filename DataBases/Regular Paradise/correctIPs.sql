/*Please add ; after each select statement*/
CREATE PROCEDURE correctIPs()
BEGIN
	SELECT id, ip FROM ips
    WHERE IS_IPV4(ip)
    HAVING ip REGEXP '^[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{2,3}.*$'
    OR ip REGEXP '^[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{2,3}$'
    ORDER BY id;
END