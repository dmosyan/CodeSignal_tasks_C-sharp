/*Please add ; after each select statement*/
CREATE PROCEDURE suspectsInvestigation2()
BEGIN
    SELECT id, name, surname FROM Suspect
    WHERE height<=170 OR LEFT(name, 1) != 'b' OR surname NOT LIKE 'gre_n';
END
