bool arithmeticExpression(int a, int b, int c) 
{
    if(a+b ==c || a*b==c || (a/b ==c && a%b ==0) || a-b ==c)
        return true;
    else
        return false;
}
