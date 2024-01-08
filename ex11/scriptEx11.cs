public static bool ispalindrome(string str)
{
    string plndrme = "";
    foreach (char element in str)
    {
        plndrme = element + plndrme;
    }
    if (plndrme == str)
    {
        return true;
    }
    else
    {
        return false;
    }
}