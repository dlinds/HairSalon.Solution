using System;

namespace HairSalon.Models
{
  public class Customer
  {
    public int CustomerId { get; set; }
    public int StylistId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public int Phone { get; set; }
    public DateTime Birthday { get; set; }
    public int TimesVisited { get; set; }
    public string PreferredCut { get; set; }
  }
}