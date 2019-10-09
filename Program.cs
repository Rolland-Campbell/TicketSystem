using System;
using TicketSystem.Controllers;

namespace TicketSystem
{
  class Program
  {
    static void Main(string[] args)
    {
      new TicketController().Run();
    }
  }
}
