Console.Clear();

Account profileZeColmeia = new Account("129573892", "Zé Colmeia", 500);
profileZeColmeia.withdraw(145, DateTime.Now, "Caldo de cana chique");
profileZeColmeia.deposit(50, DateTime.Now, "Empréstimo do carinha que vende caldo de cana pra comprar caldo de cana");
profileZeColmeia.deposit(50, DateTime.Now, "Coca show");
profileZeColmeia.withdraw(500, DateTime.Now, "Pagamento da escola do Colmeinha");
Console.WriteLine(profileZeColmeia.getData());
Console.WriteLine();
Console.WriteLine("Extrato");
Console.WriteLine();
Console.WriteLine(profileZeColmeia.showExtract());
Console.ReadKey();

SpecialAccount profileCatatau = new SpecialAccount("129234892", "Catatau", 340, 400);
profileCatatau.withdraw(230, DateTime.Now, "Caldo de cana ainda mais chique");
profileCatatau.withdraw(100, DateTime.Now, "Um pastelzin cheio de classe");
profileCatatau.withdraw(300, DateTime.Now, "Escola do Catatauzinho");
Console.WriteLine(profileCatatau.getData());
Console.WriteLine();
Console.WriteLine("Extrato");
Console.WriteLine();
Console.WriteLine(profileCatatau.showExtract());
Console.ReadKey();

Console.WriteLine("Contas criadas: "+Account.accountsAmount);
Console.ReadKey();
