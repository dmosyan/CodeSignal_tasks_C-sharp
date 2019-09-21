/*Please add ; after each select statement*/
CREATE PROCEDURE suspectsInvestigation()
BEGIN
    select  id, name, surname from Suspect
    where height <= 170 and left(name, 1) = 'B'
    and surname like 'Gre_n';

END
