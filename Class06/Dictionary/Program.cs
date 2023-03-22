using Dictionary;

try
{
    User user = new User(null);
}
catch (ArgumentNullException ex)
{

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
}