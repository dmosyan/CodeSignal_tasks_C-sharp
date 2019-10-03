bool willYou(bool young, bool beautiful, bool loved) 
{
    if(young && beautiful && loved)
        return false;
    else if(young && beautiful && loved==false)
        return true;
    else if ((young && beautiful) || loved)
        return true;
    else
        return false;
}
