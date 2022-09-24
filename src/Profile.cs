class Profile
{
  public static int profilesAmount = 0;
  
  public string number;
  public string bearer;

  public decimal balance
  {
    get
    {
      decimal result = 0;
      foreach (Transaction transaction in this.moviments)
      {
        result += transaction.value;
      }
      return result;
    }
  }

  private List<Transaction> moviments = new List<Transaction>();

  public Profile(string number, string bearer, decimal balance)
  {
    this.number = number;
    this.bearer = bearer;
    this.deposit(balance, DateTime.Now, "Depósito Inicial da Conta Nº "+number);

    profilesAmount++;
  }

  public string getData()
  {
    string text = "";

    text += "Conta "+this.number;
    text += " do correntista "+this.bearer;
    text += " com saldo de "+this.balance.ToString();

    return text;
  }

  public void deposit(decimal value, DateTime date, string description)
  {
    Transaction deposit = new Transaction(value, date, description);

    this.moviments.Add(deposit);
  }

  public void withdraw(decimal value, DateTime date, string description)
  {
    Transaction withdraw = new Transaction(-value, date, description);

    this.moviments.Add(withdraw);
  }
}