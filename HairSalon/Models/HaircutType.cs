using System;

namespace HairSalon.Models
{
  public class HaircutType
  {
    public int HaircutTypeId { get; set; }
    public string Name { get; set; }
    public int Cost { get; set; }
    public int TimeEstimate { get; set; }
  }
}