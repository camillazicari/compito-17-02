Dictionary<int, (string Nome, decimal Prezzo)> menu = new Dictionary<int, (string, decimal)>
        {
            { 1, ("Coca Cola 150 ml", 2.50m) },
            { 2, ("Insalata di pollo", 5.20m) },
            { 3, ("Pizza Margherita", 10) },
            { 4, ("Pizza 4 Formaggi", 12.50m) },
            { 5, ("Pz patatine fritte", 3.50m) },
            { 6, ("Insalata di riso", 8) },
            { 7, ("Frutta di stagione", 5) },
            { 8, ("Pizza fritta", 5) },
            { 9, ("Piadina vegetariana", 6) },
            { 10, ("Panino Hamburger", 7.90m) }
        };

List<(string Nome, decimal Prezzo)> ordine = new List<(string Nome, decimal Prezzo)>();
decimal servizio = 3;
decimal totale = 0;

restart:
Console.WriteLine("==============MENU==============");
Console.WriteLine("Scegli una delle seguenti opzioni:");
    foreach (var cibo in menu)
    {
        Console.WriteLine(cibo.Key + ": " + cibo.Value.Nome + "(euro " + cibo.Value.Prezzo + ")");
    }
    Console.WriteLine("11. Stampa conto finale e conferma");
    int.TryParse(Console.ReadLine(), out int scelta);
if (scelta >=1 && scelta<=11)
{


    if (scelta == 11)
    {
        if (totale < 1)
        {
            Console.Clear();
            Console.WriteLine("Nessun elemento aggiunto al carello, il conto totale è: " + totale + ". Arrivederci!");
        } else
        {
            Console.Clear();
            Console.WriteLine("Ecco il riepilogo del tuo ordine:");
            foreach (var cibo in ordine)
            {
                Console.WriteLine(cibo.Nome + ": euro " + cibo.Prezzo);
            }
            Console.WriteLine("Prezzo servizio: euro " + servizio);
            totale += servizio;
            Console.WriteLine("Il totale dell'ordine è: " + totale);
            Console.WriteLine("Arrivederci!");
        }
    }
    else
    {
        Console.Clear();
        ordine.Add((menu[scelta].Nome, menu[scelta].Prezzo));
        totale += menu[scelta].Prezzo;
        Console.WriteLine(menu[scelta].Nome + " è stato aggiunto al carrello!");
        Console.WriteLine("--------------------");
        Console.WriteLine("Totale attuale senza servizio: euro " + totale);
        Console.WriteLine("Prezzo servizio: euro " + servizio);
        goto restart;
    }

} else
{
    Console.Clear();
    Console.WriteLine("Scelta non valida. Riprovare.");
    goto restart;
}
