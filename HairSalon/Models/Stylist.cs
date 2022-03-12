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
    public TimeSpan ShiftStart { get; set; }
    public TimeSpan ShiftEnd { get; set; }
    public bool ScheduledSunday { get; set; }
    public bool ScheduledMonday { get; set; }
    public bool ScheduledTuesday { get; set; }
    public bool ScheduledWednesday { get; set; }
    public bool ScheduledThursday { get; set; }
    public bool ScheduledFriday { get; set; }
    public bool ScheduledSaturday { get; set; }

    public virtual ICollection<Customer> Customers { get; set; }

  }
}