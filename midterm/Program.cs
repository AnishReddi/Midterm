using System;

public class InventoryItem
{
    // Properties
    public string ItemName { get; set; }
    public int ItemId { get; set; }
    public double Price { get; set; }
    public int QuantityInStock { get; set; }

    // Constructor
    public InventoryItem(string itemName, int itemId, double price, int quantityInStock)
    {
        // TODO: Initialize the properties with the values passed to the constructor.
        ItemName = itemName;
        ItemId = itemId;
        Price = price;
        QuantityInStock = quantityInStock;
    }

    // Methods

    // Update the price of the item
    public void UpdatePrice(double newPrice)
    {
        // TODO: Update the item's price with the new price.
        Price = newPrice;
    }

    // Restock the item
    public void RestockItem(int additionalQuantity)
    {
        // TODO: Increase the item's stock quantity by the additional quantity.
        QuantityInStock = QuantityInStock + additionalQuantity;
    }

    // Sell an item
    public void SellItem(int quantitySold)
    {
        // TODO: Decrease the item's stock quantity by the quantity sold.
        // Make sure the stock doesn't go negative.
        if (quantitySold <= QuantityInStock)
        {
            QuantityInStock = QuantityInStock - quantitySold;
        }
        else
        {
            Console.WriteLine("Error: Not enough stock available to sell.");
        }
    }

    // Check if an item is in stock
    public bool IsInStock()
    {
        // TODO: Return true if the item is in stock else false.
        if (QuantityInStock > 0)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    // Print item details
    public void PrintDetails()
    {
        // TODO: Print the details of the item (name, id, price, and stock quantity).
        Console.WriteLine($"Item Name: {ItemName}");
        Console.WriteLine($"Item ID: {ItemId}");
        Console.WriteLine($"Price: {Price}");
        Console.WriteLine($"Quantity in Stock: {QuantityInStock}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating instances of InventoryItem
        InventoryItem item1 = new InventoryItem("Laptop", 101, 1200.50, 10);
        InventoryItem item2 = new InventoryItem("Smartphone", 102, 800.30, 15);
        // TODO: Implement logic to interact with these objects.
        // Example tasks:
        // 1. Print details of all items.
        // 2. Sell some items and then print the updated details.
        // 3. Restock an item and print the updated details.
        // 4. Check if an item is in stock and print a message accordingly.

        // 1.Print details of all items.
        Console.WriteLine("Details of Item 1:");
        Console.WriteLine();

        item1.PrintDetails();
        Console.WriteLine();

        Console.WriteLine("Details of Item 2:");
        Console.WriteLine();
        item2.PrintDetails();
        Console.WriteLine();

        // 2.Sell some items and then print the updated details.
        item1.SellItem(2);
        item2.SellItem(2);
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("selling 2 Laptops and 2 Smartphones");
        Console.WriteLine("---------------------------------------");
        Console.WriteLine();
        Console.WriteLine("Updated Details of Item 1:");
        Console.WriteLine();
        item1.PrintDetails();
        Console.WriteLine();

        Console.WriteLine("Updated Details of Item 2:");
        Console.WriteLine();
        item2.PrintDetails();
        Console.WriteLine();

        // 3.Restock an item and print the updated details.
        item1.RestockItem(6);
        Console.WriteLine("-------------------------");
        Console.WriteLine("Restocking 6 Laptops");
        Console.WriteLine("-------------------------");
        Console.WriteLine();
        Console.WriteLine("Details of Item 1:");
        Console.WriteLine();
        item1.PrintDetails();
        Console.WriteLine();

        // 4.Check if an item is in stock and print a message accordingly.
        if (item1.IsInStock())
        {

            Console.WriteLine($"{item1.ItemName} is in stock, with quantity {item1.QuantityInStock}");
        }       
           
        if (item2.IsInStock())
        {
            Console.WriteLine($"{item2.ItemName} is in stock, with quantity {item2.QuantityInStock}");
        }
    }
}
