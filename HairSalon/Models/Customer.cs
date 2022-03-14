using System;

namespace HairSalon.Models
{
  public class Customer
  {
    public int CustomerId { get; set; }
    public int StylistId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public long Phone { get; set; }
    public DateTime Birthday { get; set; }
    public int TimesVisited { get; set; }
    public int HaircutTypeId { get; set; }
  }
}