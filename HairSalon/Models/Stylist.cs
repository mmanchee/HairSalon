using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    public Stylist()
    {
      this.Clients = new HashSet<Client>();
    }
    public string StylistName { get; set; }
    public int StylistId { get; set; }
    public virtual ICollection<Client> Clients { get; set; }
  }
}