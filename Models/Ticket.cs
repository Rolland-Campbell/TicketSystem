using TicketSystem.Interfaces;

namespace TicketSystem.Models
{
  public class Ticket : ITicket
  {
    public string Name { get; set; }
    public string Description { get; set; }

    public Ticket(string name, string description)
    {
      Name = name;
      Description = description;
    }
  }
}