/*Please add ; after each select statement*/
CREATE PROCEDURE soccerGameSeries()
BEGIN
	SELECT IF((SELECT COUNT(1) FROM scores WHERE first_team_score > second_team_score) >
    		  (SELECT COUNT(1) FROM scores WHERE first_team_score < second_team_score), 1, 
    	   IF((SELECT COUNT(1) FROM scores WHERE first_team_score > second_team_score) <
    		  	(SELECT COUNT(1) FROM scores WHERE first_team_score < second_team_score), 2,
    	   IF((SELECT SUM(first_team_score) FROM scores) > (SELECT SUM(second_team_score) FROM scores), 1, 
           IF ((SELECT SUM(first_team_score) FROM scores) < (SELECT SUM(second_team_score) FROM scores), 2, 
    	   IF((SELECT SUM(first_team_score) FROM scores WHERE match_host != 1) >
    		    (SELECT SUM(second_team_score) FROM scores WHERE match_host != 2), 1, 
    	   IF((SELECT SUM(first_team_score) FROM scores WHERE match_host != 1) < 
    		    (SELECT SUM(second_team_score) FROM scores WHERE match_host != 2), 2, 0)))))) AS winner;
END