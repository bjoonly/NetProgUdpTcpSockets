using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Service
    {
        MyDbContext ctx;

        public Service()
        {
            ctx = new MyDbContext();
        }
        public IEnumerable<Log> GetLogs()
        {
            return ctx.Logs;
        }
        public IEnumerable<Client> GetClients()
        {
            return ctx.Clients;
        }
        public IEnumerable<Exchange> GetExchanges()
        {
            return ctx.Exchanges;
        }
        public IEnumerable<ExchangeRate> GetExchangeRates()
        {
            return ctx.ExchangeRates;
        }
        public ExchangeRate GetRate(string from,string to)
        {
            return ctx.ExchangeRates.Where(e => e.ExchangeFrom.Name == from && e.ExchangeTo.Name == to).FirstOrDefault();
        }
        public void Save()
        {
            ctx.SaveChanges();
        }
        public void AddLog(Log log)
        {
            ctx.Logs.Add(log);
            ctx.SaveChanges();
        }
        public void AddClient(Client client)
        {
            if (ctx.Clients.FirstOrDefault(c => c.Login == client.Login) == null) {
                ctx.Clients.Add(client);
             ctx.SaveChanges();
            }
        }
        public int CountLogsLastMin(string login)
        {
            DateTime d1 = DateTime.Now - new TimeSpan(0,0, 1, 0);       
            return ctx.Logs.Count(l => l.Client.Login == login && l.ConntectionTime > d1);
        }
        
    }
}
