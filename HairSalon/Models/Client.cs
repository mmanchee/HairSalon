using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public string ClientName { get; set; }
    [DataType(DataType.MultilineText)]
    public string Likes { get; set; }
    [DataType(DataType.MultilineText)]
    public string Dislikes { get; set; }
    public string Phone { get; set; }
    public int StylistId { get; set; }
    public virtual Stylist Stylist { get; set; }

    public static List<Client> Search(List<Client> allClients, string searchParam)
    {
      List<Client> matchingClients = new List<Client> { };
      if (searchParam != null)
      {
        foreach (Client client in allClients)
        {
          if (client.ClientName.ToLower().Contains(searchParam.ToLower()))
          {
            matchingClients.Add(client);
          }
        }
      }
      return matchingClients;
    }
  }
}