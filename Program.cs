Console.Clear();

Profile profileZeColmeia = new Profile("129573892", "Zé Colmeia", 500);
profileZeColmeia.withdraw(145, DateTime.Now, "Caldo de cana chique");
profileZeColmeia.deposit(50, DateTime.Now, "Empréstimo do carinha que vende caldo de cana pra comprar caldo de cana");
Console.WriteLine(profileZeColmeia.getData());
Console.WriteLine();
Console.ReadKey();

Profile profileCatatau = new Profile("129234892", "Catatau", 340);
profileCatatau.withdraw(230, DateTime.Now, "Caldo de cana ainda mais chique");
Console.WriteLine(profileCatatau.getData());
Console.WriteLine();
Console.ReadKey();

Console.WriteLine("Contas criadas: "+Profile.profilesAmount);
Console.ReadKey();