namespace ClassLibrary
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Data.Entity;


    public class Initializer : DropCreateDatabaseIfModelChanges<MyDbContext>
    {
        protected override void Seed(MyDbContext context)
        {
            base.Seed(context);

            Client client1 = new Client() { Login = "1", Password = "1" };
            Client client2 = new Client() { Login = "login", Password = "password" };
            context.Clients.Add(client1);
            context.Clients.Add(client2);

            context.SaveChanges();

            Exchange USD = new Exchange() { Name = "USD" };
            Exchange EUR = new Exchange() { Name = "EUR" };
            Exchange RUB = new Exchange() { Name = "RUB" };
            Exchange PLN = new Exchange() { Name = "PLN" };
            Exchange CAD = new Exchange() { Name = "CAD" };
            Exchange UAH = new Exchange() { Name = "UAH" };
            Exchange GBP = new Exchange() { Name = "GBP" };
            Exchange CHF = new Exchange() { Name = "CHF" };
            Exchange BYN = new Exchange() { Name = "BYN" };
            Exchange DKK = new Exchange() { Name = "DKK" };
            context.Exchanges.AddRange(new List<Exchange>() {
              USD,
              EUR,
              RUB,
              PLN,
              CAD,
              UAH,
              GBP,
              CHF,
              BYN,
              DKK
            });
            context.SaveChanges();
            ExchangeRate exchangeUSD1 = new ExchangeRate() { ExchangeFrom = USD, ExchangeTo = EUR, Rate = 0.836575m };
            ExchangeRate exchangeUSD2 = new ExchangeRate() { ExchangeFrom = USD, ExchangeTo = RUB, Rate = 73.2403m };
            ExchangeRate exchangeUSD3 = new ExchangeRate() { ExchangeFrom = USD, ExchangeTo = PLN, Rate = 3.82596m };
            ExchangeRate exchangeUSD4 = new ExchangeRate() { ExchangeFrom = USD, ExchangeTo = CAD, Rate = 1.24741m };
            ExchangeRate exchangeUSD5 = new ExchangeRate() { ExchangeFrom = USD, ExchangeTo = UAH, Rate = 27.4740m };
            ExchangeRate exchangeUSD6 = new ExchangeRate() { ExchangeFrom = USD, ExchangeTo = GBP, Rate = 0.71757m };
            ExchangeRate exchangeUSD7 = new ExchangeRate() { ExchangeFrom = USD, ExchangeTo = CHF, Rate = 0.92900m };
            ExchangeRate exchangeUSD8 = new ExchangeRate() { ExchangeFrom = USD, ExchangeTo = BYN, Rate = 2.58967m };
            ExchangeRate exchangeUSD9 = new ExchangeRate() { ExchangeFrom = USD, ExchangeTo = DKK, Rate = 6.21706m };
            context.ExchangeRates.AddRange(new List<ExchangeRate>() {
               exchangeUSD1,
               exchangeUSD2,
               exchangeUSD3,
               exchangeUSD4,
               exchangeUSD5,
               exchangeUSD6,
               exchangeUSD7,
               exchangeUSD8,
               exchangeUSD9
            });
            context.SaveChanges();
            ExchangeRate exchangEUR1 = new ExchangeRate() { ExchangeFrom = EUR, ExchangeTo = USD, Rate = 1.19481m };
            ExchangeRate exchangEUR2 = new ExchangeRate() { ExchangeFrom = EUR, ExchangeTo = RUB, Rate = 87.5082m };
            ExchangeRate exchangEUR3 = new ExchangeRate() { ExchangeFrom = EUR, ExchangeTo = PLN, Rate = 4.57520m };
            ExchangeRate exchangEUR4 = new ExchangeRate() { ExchangeFrom = EUR, ExchangeTo = CAD, Rate = 1.49042m };
            ExchangeRate exchangEUR5 = new ExchangeRate() { ExchangeFrom = EUR, ExchangeTo = UAH, Rate = 32.8262m };
            ExchangeRate exchangEUR6 = new ExchangeRate() { ExchangeFrom = EUR, ExchangeTo = GBP, Rate = 0.85731m };
            ExchangeRate exchangEUR7 = new ExchangeRate() { ExchangeFrom = EUR, ExchangeTo = CHF, Rate = 1.11060m };
            ExchangeRate exchangEUR8 = new ExchangeRate() { ExchangeFrom = EUR, ExchangeTo = BYN, Rate = 3.09416m };
            ExchangeRate exchangEUR9 = new ExchangeRate() { ExchangeFrom = EUR, ExchangeTo = DKK, Rate = 7.43466m };
            context.ExchangeRates.AddRange(new List<ExchangeRate>() {
              exchangEUR1,
              exchangEUR2,
              exchangEUR3,
              exchangEUR4,
              exchangEUR5,
              exchangEUR6,
              exchangEUR7,
              exchangEUR8,
              exchangEUR9
            });
            context.SaveChanges();
            ExchangeRate exchangRUB1 = new ExchangeRate() { ExchangeFrom = RUB, ExchangeTo = USD, Rate = 0.01365m };
            ExchangeRate exchangRUB2 = new ExchangeRate() { ExchangeFrom = RUB, ExchangeTo = EUR, Rate = 0.01141m };
            ExchangeRate exchangRUB3 = new ExchangeRate() { ExchangeFrom = RUB, ExchangeTo = PLN, Rate = 0.05221m };
            ExchangeRate exchangRUB4 = new ExchangeRate() { ExchangeFrom = RUB, ExchangeTo = CAD, Rate = 0.01702m };
            ExchangeRate exchangRUB5 = new ExchangeRate() { ExchangeFrom = RUB, ExchangeTo = UAH, Rate = 0.37492m };
            ExchangeRate exchangRUB6 = new ExchangeRate() { ExchangeFrom = RUB, ExchangeTo = GBP, Rate = 0.00980m };
            ExchangeRate exchangRUB7 = new ExchangeRate() { ExchangeFrom = RUB, ExchangeTo = CHF, Rate = 0.01268m };
            ExchangeRate exchangRUB8 = new ExchangeRate() { ExchangeFrom = RUB, ExchangeTo = BYN, Rate = 0.03534m };
            ExchangeRate exchangRUB9 = new ExchangeRate() { ExchangeFrom = RUB, ExchangeTo = DKK, Rate = 0.08484m };
            context.ExchangeRates.AddRange(new List<ExchangeRate>() {
              exchangRUB1,
              exchangRUB2,
              exchangRUB3,
              exchangRUB4,
              exchangRUB5,
              exchangRUB6,
              exchangRUB7,
              exchangRUB8,
              exchangRUB9
            });
            context.SaveChanges();
            ExchangeRate exchangPLN1 = new ExchangeRate() { ExchangeFrom = PLN, ExchangeTo = USD, Rate = 0.26030m };
            ExchangeRate exchangPLN2 = new ExchangeRate() { ExchangeFrom = PLN, ExchangeTo = EUR, Rate = 0.21787m };
            ExchangeRate exchangPLN3 = new ExchangeRate() { ExchangeFrom = PLN, ExchangeTo = RUB, Rate = 19.0643m };
            ExchangeRate exchangPLN4 = new ExchangeRate() { ExchangeFrom = PLN, ExchangeTo = CAD, Rate = 0.32470m };
            ExchangeRate exchangPLN5 = new ExchangeRate() { ExchangeFrom = PLN, ExchangeTo = UAH, Rate = 7.15144m };
            ExchangeRate exchangPLN6 = new ExchangeRate() { ExchangeFrom = PLN, ExchangeTo = GBP, Rate = 0.18689m };
            ExchangeRate exchangPLN7 = new ExchangeRate() { ExchangeFrom = PLN, ExchangeTo = CHF, Rate = 0.24182m };
            ExchangeRate exchangPLN8 = new ExchangeRate() { ExchangeFrom = PLN, ExchangeTo = BYN, Rate = 0.67409m };
            ExchangeRate exchangPLN9 = new ExchangeRate() { ExchangeFrom = PLN, ExchangeTo = DKK, Rate = 1.61829m };
            context.ExchangeRates.AddRange(new List<ExchangeRate>() {
              exchangPLN1,
              exchangPLN2,
              exchangPLN3,
              exchangPLN4,
              exchangPLN5,
              exchangPLN6,
              exchangPLN7,
              exchangPLN8,
              exchangPLN9
            });
            context.SaveChanges();
            ExchangeRate exchangCAD1 = new ExchangeRate() { ExchangeFrom = CAD, ExchangeTo = USD, Rate = 0.80130m };
            ExchangeRate exchangCAD2 = new ExchangeRate() { ExchangeFrom = CAD, ExchangeTo = EUR, Rate = 0.66831m };
            ExchangeRate exchangCAD3 = new ExchangeRate() { ExchangeFrom = CAD, ExchangeTo = RUB, Rate = 58.6875m };
            ExchangeRate exchangCAD4 = new ExchangeRate() { ExchangeFrom = CAD, ExchangeTo = PLN, Rate = 3.06575m };
            ExchangeRate exchangCAD5 = new ExchangeRate() { ExchangeFrom = CAD, ExchangeTo = UAH, Rate = 22.0149m };
            ExchangeRate exchangCAD6 = new ExchangeRate() { ExchangeFrom = CAD, ExchangeTo = GBP, Rate = 0.57531m };
            ExchangeRate exchangCAD7 = new ExchangeRate() { ExchangeFrom = CAD, ExchangeTo = CHF, Rate = 0.74441m };
            ExchangeRate exchangCAD8 = new ExchangeRate() { ExchangeFrom = CAD, ExchangeTo = BYN, Rate = 2.07510m };
            ExchangeRate exchangCAD9 = new ExchangeRate() { ExchangeFrom = CAD, ExchangeTo = DKK, Rate = 4.98174m };
            context.ExchangeRates.AddRange(new List<ExchangeRate>() {
              exchangCAD1,
              exchangCAD2,
              exchangCAD3,
              exchangCAD4,
              exchangCAD5,
              exchangCAD6,
              exchangCAD7,
              exchangCAD8,
              exchangCAD9
            });
            context.SaveChanges();
            ExchangeRate exchangUAH1 = new ExchangeRate() { ExchangeFrom = UAH, ExchangeTo = USD, Rate = 0.03574m };
            ExchangeRate exchangUAH2 = new ExchangeRate() { ExchangeFrom = UAH, ExchangeTo = EUR, Rate = 0.02989m };
            ExchangeRate exchangUAH3 = new ExchangeRate() { ExchangeFrom = UAH, ExchangeTo = RUB, Rate = 2.61787m };
            ExchangeRate exchangUAH4 = new ExchangeRate() { ExchangeFrom = UAH, ExchangeTo = PLN, Rate = 0.13675m };
            ExchangeRate exchangUAH5 = new ExchangeRate() { ExchangeFrom = UAH, ExchangeTo = CAD, Rate = 0.04459m };
            ExchangeRate exchangUAH6 = new ExchangeRate() { ExchangeFrom = UAH, ExchangeTo = GBP, Rate = 0.02566m };
            ExchangeRate exchangUAH7 = new ExchangeRate() { ExchangeFrom = UAH, ExchangeTo = CHF, Rate = 0.03321m };
            ExchangeRate exchangUAH8 = new ExchangeRate() { ExchangeFrom = UAH, ExchangeTo = BYN, Rate = 0.09256m };
            ExchangeRate exchangUAH9 = new ExchangeRate() { ExchangeFrom = UAH, ExchangeTo = DKK, Rate = 0.22222m };
            context.ExchangeRates.AddRange(new List<ExchangeRate>() {
             exchangUAH1,
             exchangUAH2,
             exchangUAH3,
             exchangUAH4,
             exchangUAH5,
             exchangUAH6,
             exchangUAH7,
             exchangUAH8,
             exchangUAH9
            });
            context.SaveChanges();
            ExchangeRate exchangGBP1 = new ExchangeRate() { ExchangeFrom = GBP, ExchangeTo = USD, Rate = 1.39131m };
            ExchangeRate exchangGBP2 = new ExchangeRate() { ExchangeFrom = GBP, ExchangeTo = EUR, Rate = 1.16609m };
            ExchangeRate exchangGBP3 = new ExchangeRate() { ExchangeFrom = GBP, ExchangeTo = RUB, Rate = 101.900m };
            ExchangeRate exchangGBP4 = new ExchangeRate() { ExchangeFrom = GBP, ExchangeTo = PLN, Rate = 5.32310m };
            ExchangeRate exchangGBP5 = new ExchangeRate() { ExchangeFrom = GBP, ExchangeTo = CAD, Rate = 1.73553m };
            ExchangeRate exchangGBP6 = new ExchangeRate() { ExchangeFrom = GBP, ExchangeTo = UAH, Rate = 38.2248m };
            ExchangeRate exchangGBP7 = new ExchangeRate() { ExchangeFrom = GBP, ExchangeTo = CHF, Rate = 1.29329m };
            ExchangeRate exchangGBP8 = new ExchangeRate() { ExchangeFrom = GBP, ExchangeTo = BYN, Rate = 3.60303m };
            ExchangeRate exchangGBP9 = new ExchangeRate() { ExchangeFrom = GBP, ExchangeTo = DKK, Rate = 8.64986m };
            context.ExchangeRates.AddRange(new List<ExchangeRate>() {
            exchangGBP1,
            exchangGBP2,
            exchangGBP3,
            exchangGBP4,
            exchangGBP5,
            exchangGBP6,
            exchangGBP7,
            exchangGBP8,
            exchangGBP9
            });
            context.SaveChanges();
            ExchangeRate exchangCHF1 = new ExchangeRate() { ExchangeFrom = CHF, ExchangeTo = USD, Rate = 1.07530m};
            ExchangeRate exchangCHF2 = new ExchangeRate() { ExchangeFrom = CHF, ExchangeTo = EUR, Rate = 0.89960m};
            ExchangeRate exchangCHF3 = new ExchangeRate() { ExchangeFrom = CHF, ExchangeTo = RUB, Rate = 78.7555m};
            ExchangeRate exchangCHF4 = new ExchangeRate() { ExchangeFrom = CHF, ExchangeTo = PLN, Rate = 4.11407m};
            ExchangeRate exchangCHF5 = new ExchangeRate() { ExchangeFrom = CHF, ExchangeTo = CAD, Rate = 1.34134m};
            ExchangeRate exchangCHF6 = new ExchangeRate() { ExchangeFrom = CHF, ExchangeTo = UAH, Rate = 29.5429m};
            ExchangeRate exchangCHF7 = new ExchangeRate() { ExchangeFrom = CHF, ExchangeTo = GBP, Rate = 0.77233m};
            ExchangeRate exchangCHF8 = new ExchangeRate() { ExchangeFrom = CHF, ExchangeTo = BYN, Rate = 2.78468m};
            ExchangeRate exchangCHF9 = new ExchangeRate() { ExchangeFrom = CHF, ExchangeTo = DKK, Rate = 6.68523m};
            context.ExchangeRates.AddRange(new List<ExchangeRate>() {
            exchangCHF1,
            exchangCHF2,
            exchangCHF3,
            exchangCHF4,
            exchangCHF5,
            exchangCHF6,
            exchangCHF7,
            exchangCHF8,
            exchangCHF9
            });
            context.SaveChanges();
            ExchangeRate exchangBYN1 = new ExchangeRate() { ExchangeFrom = BYN, ExchangeTo = USD, Rate = 0.38490m};
            ExchangeRate exchangBYN2 = new ExchangeRate() { ExchangeFrom = BYN, ExchangeTo = EUR, Rate = 0.32191m};
            ExchangeRate exchangBYN3 = new ExchangeRate() { ExchangeFrom = BYN, ExchangeTo = RUB, Rate = 28.1904m};
            ExchangeRate exchangBYN4 = new ExchangeRate() { ExchangeFrom = BYN, ExchangeTo = PLN, Rate = 1.47263m};
            ExchangeRate exchangBYN5 = new ExchangeRate() { ExchangeFrom = BYN, ExchangeTo = CAD, Rate = 0.48013m};
            ExchangeRate exchangBYN6 = new ExchangeRate() { ExchangeFrom = BYN, ExchangeTo = UAH, Rate = 10.5748m};
            ExchangeRate exchangBYN7 = new ExchangeRate() { ExchangeFrom = BYN, ExchangeTo = GBP, Rate = 0.27635m};
            ExchangeRate exchangBYN8 = new ExchangeRate() { ExchangeFrom = BYN, ExchangeTo = CHF, Rate = 0.35758m};
            ExchangeRate exchangBYN9 = new ExchangeRate() { ExchangeFrom = BYN, ExchangeTo = DKK, Rate = 2.39297m};
            context.ExchangeRates.AddRange(new List<ExchangeRate>() {
             exchangBYN1,
             exchangBYN2,
             exchangBYN3,
             exchangBYN4,
             exchangBYN5,
             exchangBYN6,
             exchangBYN7,
             exchangBYN8,
             exchangBYN9
            });
            context.SaveChanges();
            ExchangeRate exchangDKK1 = new ExchangeRate() { ExchangeFrom = DKK, ExchangeTo = USD, Rate = 0.16063m };
            ExchangeRate exchangDKK2 = new ExchangeRate() { ExchangeFrom = DKK, ExchangeTo = EUR, Rate = 0.13446m };
            ExchangeRate exchangDKK3 = new ExchangeRate() { ExchangeFrom = DKK, ExchangeTo = RUB, Rate = 11.7648m };
            ExchangeRate exchangDKK4 = new ExchangeRate() { ExchangeFrom = DKK, ExchangeTo = PLN, Rate = 0.61458m };
            ExchangeRate exchangDKK5 = new ExchangeRate() { ExchangeFrom = DKK, ExchangeTo = CAD, Rate = 0.20038m };
            ExchangeRate exchangDKK6 = new ExchangeRate() { ExchangeFrom = DKK, ExchangeTo = UAH, Rate = 4.41323m };
            ExchangeRate exchangDKK7 = new ExchangeRate() { ExchangeFrom = DKK, ExchangeTo = GBP, Rate = 0.11533m };
            ExchangeRate exchangDKK8 = new ExchangeRate() { ExchangeFrom = DKK, ExchangeTo = CHF, Rate = 0.14923m };
            ExchangeRate exchangDKK9 = new ExchangeRate() { ExchangeFrom = DKK, ExchangeTo = BYN, Rate = 0.41599m };
            context.ExchangeRates.AddRange(new List<ExchangeRate>() {
             exchangDKK1,
             exchangDKK2,
             exchangDKK3,
             exchangDKK4,
             exchangDKK5,
             exchangDKK6,
             exchangDKK7,
             exchangDKK8,
             exchangDKK9
            });
            context.SaveChanges();

        }
    }
}

