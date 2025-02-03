using Microsoft.VisualBasic;
using s10257582_prg2assignment;

//-----------------------------------Main------------------------------------------

//create dic to store customers
//name is key
Dictionary<string, Customer> customerDic = new Dictionary<string, Customer>();
Queue<Order> orders = new Queue<Order>();

string[] lines = File.ReadAllLines("customers.csv");
while (true)
{
    //display options
    displaymenu();
    string option = Console.ReadLine();

    //add customer to dic
    for (int i = 1; i < lines.Length; i++)
    {
        string[] column = lines[i].Split(',');
        Customer customerAdd = new Customer(column[0], Convert.ToInt32(column[1]), DateTime.Parse(column[2]));
        customerDic.Add(column[0], customerAdd);
    }

    if (option == "1")
    {
        displaycustomers();

    }
    //List all current orders
    else if (option == "2")
    {
        displayorders();
    }
    else if (option == "3")
    {
        registercus();
    }

    else if (option == "4")
    {
        createorder();
    }

    else if (option == "5")
    {

    }

    else if (option == "6")
    {

    }

    else
    {
        Console.WriteLine("Please enter a valid option.");
    }
}



//-----------------------------------Method------------------------------------------

void displaymenu()
{
    Console.Write("------------- MENU --------------\r" +
        "\n[1] List all customers\r" +
        "\n[2] List all current orders\r" +
        "\n[3] Register a new customer Table\r" +
        "\n[4] Create a customer’s order\r" +
        "\n[5] Display order details of a customer\r" +
        "\n[6] Modify order details\r" +
        "\n---------------------------------\r" +
        "\nEnter your option : ");
}

void displaycustomers()
{
    Console.WriteLine($"{"Name",-17}{"MemberID",-17}{"Date of birth",-17}");
    foreach (var dict in customerDic)
    {
        Console.WriteLine($"{dict.Key,-17}{dict.Value.MemberID,-17}{dict.Value.DOB.ToString("dd/MM/yyyy"),-17}");
    }
}

void displayorders()
{

}

void registercus()
{
    Console.WriteLine("Enter name: ");
    string Name = Console.ReadLine();
    Console.WriteLine("Enter id number: ");
    int id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter date of birth: ");
    DateTime dob = Convert.ToDateTime(Console.ReadLine());
    Customer cus = new Customer(Name, id, dob);
    PointCard pc = new PointCard();
    using (StreamWriter writer = new StreamWriter("Customers.csv", true))
    {
        writer.WriteLine($"{Name,-17}{id,-17}{dob,-17:dd/MM/yyyy}");
        Console.WriteLine("Status: registered ");
    }
}

void createorder()
{
    void input()
    {
        Console.WriteLine("Ice Cream order");
        Console.WriteLine("option: ");
        string option = Console.ReadLine();
        Console.WriteLine("Scoops: ");
        int scoops = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("flavours: ");
        string flavours = Console.ReadLine();
        Console.WriteLine("Toppings: ");
        int toppings = Convert.ToInt32(Console.ReadLine());
        IceCream iceCream = new IceCream();
    }
    displaycustomers();
    Console.WriteLine("Enter customer name: ");
    string name = Console.ReadLine();
    foreach(var dict in customerDic)
    {
        if (dict.Key == name)
        {
            Order order = new Order();
            input();
            Console.WriteLine("Would you like to add another ice cream to the order?[Y/N] ");
            string add = Console.ReadLine();
            if (add.ToUpper() == "Y")
            {
                input();
            }
            else if (add.ToUpper() == "N")
            {

            }
        }
    }
}