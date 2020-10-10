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
  }
}