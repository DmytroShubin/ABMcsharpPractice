using System;

class Program {
    static void Main(string[] args) {
        // Welcome message
        Console.WriteLine("Welcome to Ikea Montreal, Ottawa, Calgary");

        // Initialize the items and their costs
        string[] items = {"Billy Bookcase", "Kallax Shelving Unit", "Malm Bed Frame", "Poäng Armchair"};
        double[] costs = {79.99, 69.99, 199.99, 129.00};

        // Initialize the quantity of each item ordered
        int[] qty = new int[items.Length];

        // Get the quantity of each item ordered from the customer
        for (int i = 0; i < items.Length; i++) {
            Console.Write("Enter the quantity of " + items[i] + " ordered: ");
            qty[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Get the province from the customer
        Console.Write("Enter your province (Montreal, Calgary, or Ottawa): ");
        string province = Console.ReadLine();

        // Calculate the subtotal of the order
        double subtotal = 0;
        for (int i = 0; i < items.Length; i++) {
            subtotal += costs[i] * qty[i];
        }

        // Calculate the tax based on the province
        double tax = 0;
        if (province == "Montreal") {
            tax = subtotal * 0.1;
        }
        else if (province == "Calgary") {
            tax = subtotal * 0.05;
        }
        else if (province == "Ottawa") {
            tax = subtotal * 0.18;
        }

        // Get the delivery method from the customer
        Console.Write("Did you order online? (yes or no): ");
        string deliveryMethod = Console.ReadLine();

        // Calculate the delivery charges if ordered online
        double deliveryCharges = 0;
        if (deliveryMethod == "yes") {
            deliveryCharges = subtotal * 0.03;
        }

        // Calculate the total cost of the order
        double totalCost = subtotal + tax + deliveryCharges;

        // Print the bill
        Console.WriteLine("Item\t\tCost\tQty\tTotal");
        Console.WriteLine("--------------------------------------------");
        for (int i = 0; i < items.Length; i++) {
            Console.WriteLine(items[i] + "\t" + costs[i] + "\t" + qty[i] + "\t" + costs[i] * qty[i]);
        }
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("Subtotal\t\t\t\t" + subtotal);
        Console.WriteLine("Tax (" + province + ")\t\t\t\t" + tax);
        if (deliveryMethod == "yes") {
            Console.WriteLine("Delivery Charges\t\t\t" + deliveryCharges);
        }
        Console.WriteLine("Total\t\t\t\t\t" + totalCost);
    }
}