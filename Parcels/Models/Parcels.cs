using System;
using System.Collections.Generic;

namespace Parcel.Models
{
  public class ParcelObject
  {
    private string _length;
    private string _width;
    private string _height;
    private string _weight;
    private static List<ParcelObject> _instances = new List<ParcelObject> {};

    public ParcelObject(string length = "", string width = "", string height = "", string weight = "")
    {
      _length = length;
      _width = width;
      _height = height;
      _weight = weight;
    }

    public static List<ParcelObject> GetAll()
    {
       return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
    public int Volume()
    {
      return int.Parse(_length) * int.Parse(_width) * int.Parse(_height);
    }
    public int CostToShip()
    {
      return this.Volume() * 4 + int.Parse(_weight) * 9;
    }
    public void SetWidth(string newWidth)
    {
      _width = newWidth;
    }
    public string GetWidth()
    {
      return _width;
    }

    public void SetLength (string newLength)
    {
      _length = newLength;
    }
    public string GetLength()
    {
      return _length;
    }

    public void SetHeight (string newHeight)
    {
      _height = newHeight;
    }
    public string GetHeight()
    {
      return _height;
    }

    public void SetWeight (string newWeight)
    {
      _weight = newWeight;
    }
    public string GetWeight()
    {
      return _weight;
    }
  }
}
