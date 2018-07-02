using System.IO;

namespace CarDealershipC.Models
{
  public class UsedCars
  {
    private string _year;
    private string _make;
    private string _model;
    private string _miles;
    private string _cost;

    public UsedCars(string newYear, string newMake, string newModel,
    string newMiles, string newCost)
    {
      _year = newYear;
      _make = newMake;
      _model = newModel;
      _miles = newMiles;
      _cost = newCost;
    }

    public string GetYear()
    {
      return _year;
    }
    public void SetYear(string newYear)
    {
      _year = newYear;
    }

    public string GetMake()
    {
      return _make;
    }
    public void SetMake(string newMake)
    {
      _make = newMake;
    }

    public string GetModel()
    {
      return _model;
    }
    public void SetModel(string newModel)
    {
      _model = newModel;
    }

    public string GetMiles()
    {
      return _miles;
    }
    public void SetMiles(string newMiles)
    {
      _miles = newMiles;
    }

    public string GetCost()
    {
      return _cost;
    }
    public void SetCost(string newCost)
    {
      _cost = newCost;
    }

  }
}
