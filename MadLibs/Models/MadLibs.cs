namespace MadLibs.Models
{
  public class MadLibsVariable
  {
    public string Adj1 {get; set; }
    public string Food1 { get; set; }
    public string Vegetable1 { get; set; }
    public string Food2 { get; set; }
    public string Vegetable2 { get; set; }
    public string Verb1 { get; set; }
    public string Verb2 { get; set; }
    public string Vegetable3 { get; set; }
    public string Vegetable4 { get; set; }
    public string Verb3 { get; set; }

    public MadLibsVariable(string adj1, string food1, string vegetable1, string food2, string vegetable2, string verb1, string verb2, string vegetable3, string vegetable4, string verb3) {
      Adj1 = adj1;
      Food1 = food1;
      Vegetable1 = vegetable1;
      Food2 = food2;
      Vegetable2 = vegetable2;
      Verb1 = verb1;
      Verb2 = verb2;
      Vegetable3 = vegetable3;
      Vegetable4 = vegetable4;
      Verb3 = verb3;
    }
  }
}

