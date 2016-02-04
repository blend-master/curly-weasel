public class Test
{
  public string Str1 { get; set; }
  public string Str2 { get; set; }
  
  public Test()
  {
    Str1 = null;
    Str2 = null;
  }
  
  public Test(string str1, string str2)
  {
    Str1 = str1;
    Str2 = str2;
  }
}
