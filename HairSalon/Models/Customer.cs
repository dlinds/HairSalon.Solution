using System;

namespace HairSalon.Models
{
  public class Customer
  {
    public int CustomerId { get; set; }
    public int StylistId { get; set; }
    public string Name { get; set; }
    public string PreferredCut { get; set; }
    public int TimesVisited { get; set; }
    public DateTime Birthday { get; set; }
  }
}