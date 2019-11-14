bool increaseNumberRoundness(int n) 
{
  bool increased = false;
  while (n > 0) 
  {
    if (n % 10 == 0 && increased) 
    {
      return true;
    } else if (n % 10 != 0) 
    {
      increased = true;
    }
    n /=  10 ;
  }
  return false;
}
