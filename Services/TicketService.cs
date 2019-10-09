using System.Collections.Generic;
using TicketSystem.Models;

namespace TicketSystem.Services
{
  public class TicketService
  {

    public List<string> Messages { get; set; }
    public List<Ticket> Tickets { get; set; } = new List<Ticket>(); //List<Ticket> makes a list of ticket models.


    public string ViewTickets()
    {
      string template = "";

      for (var i = 0; i < Tickets.Count; i++)
      {
        template += $"{i}. {Tickets[i].Name}";
      }
      return template;
    }

    public void CreateTicket(string name, string description)
    {
      Tickets.Add(new Ticket(name, description));
    }

    public void RemoveTicket()
    {

    }
  }
}