using System.Collections.Generic;
using System;

namespace HairSalon.Models
{
  public class Stylist
  {
    public Stylist()
    {
      this.Customers = new HashSet<Customer>();
    }

    public int StylistId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime HireDate { get; set; }
    public string Position { get; set; }
    public string Specialty { get; set; }
    public int PriorExperienceInYears { get; set; }
    public string ScheduledDays { get; set; }
    public TimeSpan ShiftStart { get; set; }
    public TimeSpan ShiftEnd { get; set; }

    public virtual ICollection<Customer> Customers { get; set; }

  }
}