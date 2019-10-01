bool tennisSet(int score1, int score2) 
{
  if ((score1 == 7 || score2 == 7) && (score1 < 5 || score2 < 5)) 
    return false;
  else if (
    score1 > 5 &&
    score2 > 5 &&
    score1 <= 7 &&
    score2 <= 7 &&
    Math.Abs(score1 - score2) >= 1
  ) 
    return true;
  
  else if (score1 <= 7 && score2 <= 7 && Math.Abs(score1 - score2) >= 2) 
    return true;
  
  return false;
}
