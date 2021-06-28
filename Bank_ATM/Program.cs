using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_ATM
{

    #region BANK
    //class BankCard
    //{
    //    private static readonly Random random = new Random();
    //    public BankCard() { }
    //    public string Bankname { get; set; } = String.Empty;
    //    public DateTime ExpireDate { get; set; } = DateTime.Now;
    //    public int CVC { get; set; } = default;
    //    public decimal Balance { get; set; } = default;
    //    private string pan;
    //    public string PAN
    //    {
    //        get => pan;
    //        set
    //        {
    //            if (value.Length == 16)
    //            {
    //                pan = value;
    //            }
    //        }
    //    }
    //    private string pin;
    //    public string PIN
    //    {
    //        get => pin;
    //        set
    //        {
    //            if (value.Length == 4)
    //            {
    //                pin = value;
    //            }
    //        }
    //    }
    //    public BankCard(string bankname,string pan,string pin,DateTime expiredate)
    //    {
    //        Bankname = bankname;
    //        PAN = pan;
    //        PIN = pin;
    //        ExpireDate = expiredate;
    //    }
    //   public int GetCVC()
    //   {           
    //        CVC = random.Next(100, 999);
    //        return CVC;       
    //   }
    //    public decimal GetBalance()
    //    {
    //        Balance = random.Next(1000, 10000);
    //        return Balance;
    //    }
    //    public void ShowBankCard()
    //    {
    //        Console.WriteLine($"Bank name: {Bankname}");
    //        Console.WriteLine($"Pan: {pan}");
    //        Console.WriteLine($"Pin: {pin}");
    //        Console.WriteLine($"CVC: {GetCVC()}");
    //        Console.WriteLine($"Expire date: {ExpireDate.Day}/{ExpireDate.Year}");
    //        Console.WriteLine($"Balance: {GetBalance()} azn\n");
    //    }
    //}
    //class Client
    //{
    //    public Client() { Id = ++ClientId; }
    //    public int Id { get; set; } = default;
    //    public int ClientId { get; set; } = 0;
    //    public string Name { get; set; } = String.Empty;
    //    public string Surname { get; set; } = String.Empty;
    //    public int Age { get; set; } = default;
    //    public double Salary { get; set; } = default;
    //    public BankCard[] Cards { get; set; }
    //    public int CardCount { get; set; } = 0;
    //    public Client(string name,string surname,int age,double salary)
    //    {
    //        Id = ++ClientId;
    //        Name = name;
    //        Surname = surname;
    //        Age = age;
    //        Salary = salary;
    //    }
    //    public void AddCard(ref BankCard card)
    //    {
    //        BankCard[] temp = new BankCard[++CardCount];
    //        if (Cards != null)
    //        {
    //            Cards.CopyTo(temp, 0);
    //        }
    //        temp[temp.Length - 1] = card;
    //        Cards = temp;
    //    }
    //    public void ShowCards()
    //    {
    //        if (Cards != null)
    //        {
    //            foreach (var card in Cards)
    //            {
    //                card.ShowBankCard();
    //            }
    //        }
    //    }
    //    public void ShowClient()
    //    {
    //        Console.WriteLine($"ID: {Id}");
    //        Console.WriteLine($"Name: {Name}");
    //        Console.WriteLine($"Surname: {Surname}");
    //        Console.WriteLine($"Age: {Age}");
    //        Console.WriteLine($"Salary: {Salary} azn\n");
    //        ShowCards();
    //    }

    //}

    //class Bank
    //{
    //    public Bank() { }
    //    public Client[] Clients { get; set; }
    //    public int ClientCount { get; set; } = 0;
    //    public void AddClient(ref Client client)
    //    {
    //        Client[] temp = new Client[++ClientCount];
    //        if (Clients != null)
    //        {
    //            Clients.CopyTo(temp, 0);
    //        }
    //        temp[temp.Length - 1] = client;
    //        Clients = temp;
    //    }
    //    public void ShowBank()
    //    {
    //        if (Clients != null)
    //        {
    //            foreach (var card in Clients)
    //            {
    //                card.ShowClient();
    //            }
    //        }
    //    }
    //    public void ShowCardBalance(string pin,string pan)
    //    {
    //        for (int i = 0; i < ClientCount; i++)
    //        {
    //            var card = Clients[i].Cards;
    //            for (int k = 0; k < Clients[i].CardCount; k++)
    //            {
    //                if (card[k].PIN == pin && card[k].PAN == pan) 
    //                {
    //                    Console.WriteLine($"Balance: {card[k].Balance}");
    //                }
    //            }

    //        }       
    //    }
    //}
    //class Program
    //{

    //    static void Main(string[] args)
    //    {

    //        BankCard bankCard = new BankCard
    //        {
    //            Bankname = "Kapital",
    //            PAN = "4169878732326666",
    //            PIN = "1111",
    //            ExpireDate = new DateTime(2024, 02, 02)
    //        };
    //        BankCard bankCard2 = new BankCard
    //        {
    //            Bankname = "UniBank",
    //            PAN = "5127232788690000",
    //            PIN = "1234",
    //            ExpireDate = new DateTime(2022, 03, 02)
    //        };


    //        Client client = new Client
    //        {
    //            Name = "Murad",
    //            Surname = "Muradli",
    //            Age = 27,
    //            Salary = 2000
    //        };           

    //        client.AddCard(ref bankCard);
    //        client.AddCard(ref bankCard2);

    //        Bank bank = new Bank();
    //        bank.AddClient(ref client);
    //        bank.ShowBank();

    //        bank.ShowCardBalance("1234", "5127232788690000");
    //    }
    //}

    #endregion

    #region ATM
    


    #endregion

}
