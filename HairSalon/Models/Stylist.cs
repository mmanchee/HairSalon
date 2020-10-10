using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HairSalon.Models
{
  public class Stylist
  {
    public Stylist()
    {
      this.Clients = new HashSet<Client>();
    }
    public string StylistName { get; set; }
    [DataType(DataType.MultilineText)]
    public string Specialty { get; set; }
    public int StylistId { get; set; }
    public virtual ICollection<Client> Clients { get; set; }

    public static List<Stylist> Search(List<Stylist> allStylists, string searchParam)
    {
      List<Stylist> matchingStylists = new List<Stylist> { };
      if (searchParam != null)
      {
        foreach (Stylist stylist in allStylists)
        {
          if (stylist.StylistName.ToLower().Contains(searchParam.ToLower()))
          {
            matchingStylists.Add(stylist);
          }
        }
      }
      return matchingStylists;
    }
  }
}