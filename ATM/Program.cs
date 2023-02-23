using System;

public class cardHolder
{
    string cardNum;
    int pin;
    string firstName;
    string lastName;
    double balance;


    public cardHolder(string cardNum, int pin, string firstName, string lastName, double balance)
    {
        this.cardNum = cardNum;
        this.pin = pin;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;
    }

    public string getNum()
    {
        return cardNum;
    }

    public int getPin()
    {
        return pin;
    }

    public string getFirstName()
    {
        return firstName;
    }

    public string getLastName()
    {
        return lastName;
    }

    public double getBalance()
    {
        return balance;
    }

    public void setNum(String newCardNum)
    {
        cardNum = newCardNum;
    }

    public void setPin(int newPin)
    {
        pin = newPin;
    }

    public void setFirstName(String newFirstName)
    {
        firstName = newFirstName;
    }

    public void setLastName(string newLastName)
    {
        lastName = newLastName;
    }

    public void setBalance(double newBalance)
    {
        balance = newBalance;
    }

    public static void Main(String[] args)
    {
        void printOptions()
        {
            Console.WriteLine("Please choose from one of the following options at Matt's ATM");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");

        }

        void deposit(cardHolder currentUser)
        {
            Console.WriteLine("How much $$$$$ would you like to deposit?  ");
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.setBalance(currentUser.getBalance() + deposit);
            Console.WriteLine("Thank you for your $$. your new balance is: " + currentUser.getBalance());
        }

        void withdraw(cardHolder currentUser)
        {
            Console.WriteLine("How much $$$$$ would you like to withdraw: ");
            double withdrawal = Double.Parse(Console.ReadLine());
            //check for the correct ammount from user
            if (currentUser.getBalance() < withdrawal)
            {
                Console.WriteLine("Insufficient balance :'( ");
            }
            else
            {
                currentUser.setBalance(currentUser.getBalance() - withdrawal);
                Console.WriteLine("You are good to go, thank you!");
            }

        }
        void balance(cardHolder currentUser)
        {
            Console.WriteLine("Current balance: " + currentUser.getBalance());
        }

        List<cardHolder> cardHolders = new List<cardHolder>();
        cardHolders.Add(new cardHolder("10463782912", 1111, "Matt", "Henry", 34989821.34));
        cardHolders.Add(new cardHolder("12345372812", 2222, "Lewis", "Hamilton", 234232.43));
        cardHolders.Add(new cardHolder("34321234561", 3333, "Max", "Verstappen", 3451.43));
        cardHolders.Add(new cardHolder("66574903422", 4444, "Jimmy", "Smokesalot", 420.32));
        cardHolders.Add(new cardHolder("86753091212", 5555, "Tony", "Soprano", 4343664543.95));
        cardHolders.Add(new cardHolder("34534542345", 6666, "Big", "Bird", 33.78));
        cardHolders.Add(new cardHolder("43453453454", 7777, "Elmur", "Fudd", 4322.53));
        cardHolders.Add(new cardHolder("45676098908", 8888, "Lola", "Bunny", 2323212.87));
        cardHolders.Add(new cardHolder("99872718299", 9999, "George", "Jettson", 6545654.87));

        //promt user

        Console.WriteLine("welcome to Matts ATM");
        Console.WriteLine("Please insert debit card to continue:  ");
        Console.WriteLine("Please have a wonderful day <3");
        String debitCardNum = " ";
        cardHolder currentUser;

        while (true)
        {
            try
            {
                debitCardNum = Console.ReadLine();
                currentUser = cardHolders.FirstOrDefault(a => a.cardNum == debitCardNum);
                if (currentUser != null) { break; }
                else { Console.WriteLine("Card not recognized. please try again :)"); }
            }
            catch
            {
                Console.WriteLine("Card not recognized. please try again :)");
            }

        };
        Console.WriteLine("Please enter your pin: ");
        int userPin = 0;
        while (true)
        {
            try
            {
                userPin = int.Parse(Console.ReadLine());
                if (currentUser.getPin() == userPin) { break; }
                else { Console.WriteLine("incorrect Pin! try again. "); }
            }
            catch
            {
                Console.WriteLine("TRY AGAIN YOU GUESSED WRONG");
            }

        };

        Console.WriteLine("Welcome to the Matts ATM, " + currentUser.getFirstName().ToString() + " <3");

        int option = 0;
        do
        {
            printOptions();
            try
            {
                option = int.Parse(Console.ReadLine());
            }
            catch { }
            if (option == 1) { deposit(currentUser); }
            else if (option == 2) { withdraw(currentUser); }
            else if (option == 3) { balance(currentUser); }
            else if (option == 4) { break; }
            else { option = 0; }

        } while (option != 4);
        Console.WriteLine("Thank you for using Matts ATM have a wonderful day :)");

    }

   
}