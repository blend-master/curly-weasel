public class Test
{
  private string _str1;
  public string Str1
  {
    get { return _str1; }
    set { _str1 = value; }
  }
  
  public Test()
  {
    _str1 = null;
  }
  
  public Test(string str1)
  {
    _str1 = str1;
  }
}
