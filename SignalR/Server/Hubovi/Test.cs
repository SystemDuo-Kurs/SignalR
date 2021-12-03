using Microsoft.AspNetCore.SignalR;
using SignalR.Shared;

namespace SignalR.Server.Hubovi
{
    public class Test : Hub
    {
        public void Foo(Nesto n)
        {
            Console.WriteLine(n.Bla);
            n.Bla = $"{DateTime.Now.TimeOfDay}: {n.Bla}";
            Clients.All.SendAsync("dodavanje", n);
        } 
        public void Sab(int x, int y)
        {
            Clients.Caller.SendAsync("rezultat", x + y);
        }
    }
}
