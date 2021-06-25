try
{
    threw new NullReferenceException();
}
catch(Exception ex)
{
    Console.Log("Exception caught");
}
catch(NullReferenceException)
{
    Console.Log("NullReferenceException caught");
}