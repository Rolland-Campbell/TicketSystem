using System;
using TicketSystem.Services;

namespace TicketSystem.Controllers
{
  public class TicketController
  {
    private TicketService _ts = new TicketService();
    public void Run()
    {
      while (true)
      {
        //clearGetTicketList();
        GetUserInput();
      }
    }
    private void GetUserInput()
    {
      System.Console.WriteLine(@"Please pick from the following options:
      1. Create a Ticket
      2. View a Ticket
      3. Remove a Ticket
      ");
      string input = Console.ReadLine().ToLower();
      switch (input)
      {
        case "q":
          Environment.Exit(0);
          break;
        case "1":
          CreateTicket(); //see below function
          break;
        case "2":
          ViewTicket(); //see below function
          break;
        case "3":
          RemoveTicket(); //see below function
          break;
      }
    }

    private void RemoveTicket()
    {

    }

    public void ViewTicket()
    {
      Console.WriteLine(_ts.ViewTickets());
      Console.ReadLine();
    }


    private void CreateTicket()
    {
      Console.WriteLine("Please give the ticket a title:");
      string name = Console.ReadLine();
      Console.WriteLine("Please add a description:");
      string desc = Console.ReadLine();
      Console.WriteLine("You created a ticket!");
      Console.Clear();
      _ts.CreateTicket(name, desc);
    }
  }
}