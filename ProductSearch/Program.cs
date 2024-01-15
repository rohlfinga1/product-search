using ProductSearch;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// examples:
// user searches ipad, ipad not in file
// user searches thing, thing in file
// user searches ipad, ipad not in file. does user want to add ipad? yes - allow add product
// does user want to add ipad? no - back to search

// open file
// get file path
// get file name
// combine path
// open path
var fileName = "input-file.json";
var path = Path.GetDirectoryName(fileName);
var combinedPath = Path.Combine(path, fileName);

var read = new StreamReader(combinedPath);

Console.WriteLine($"What is the product name?");
var userInput = Console.ReadLine();
var product = new Product();

if (userInput != null)
{
    try
    {
        while (!read.EndOfStream)
        {
            var line = read.ReadLine();

            if (line != null && line.Contains("name") && (line.ToLower()).Contains(userInput.ToLower()))
            {
                var value = line.Substring(9);
                product.Name = value.Substring(0, value.Length - 2).Trim();
            }
            else if (line != null && line.Contains("price"))
            {
                var value = line.Substring(9);
                var final = Decimal.Parse(value.Substring(0, value.Length - 1).Trim());
                product.Price = final;
            }
            else if (line != null && line.Contains("quantity"))
            {
                var value = int.Parse(line.Substring(12));
                product.Quantity = value;
            }

            if (product.Name != null && product.Price != null && product.Quantity != null)
            {
                if (product.Name.ToLower() == userInput.ToLower())
                {
                    Console.WriteLine($"Name: {product.Name}");
                    Console.WriteLine($"Price: {product.Price}");
                    Console.WriteLine($"Quantity on hand: {product.Quantity}");
                }
            }
        }
    }
    catch
    {

    }
}

string answer;

if (product == null)
{
    Console.WriteLine($"Sorry, that product was not found in our inventory.");
    Console.WriteLine($"Would you like to add this product to the inventory? Y/N ");
    answer = Console.ReadLine();
}
else
{
    answer = "";
}

if (answer.ToLower() != "y")
{

}
else
{

}

// ask user for input
// open streamreader

// Ensure that the product search is case insensitive.
// • When a product is not found, ask if the product should be added.
//  If yes, ask for the price and the quantity, and save it in the JSON file.
//  Ensure the newly added product is immediately available for searching without restarting the program
//  (write without exiting)
// clean user input
// read from file
// if an item we read has a name that mataches our user input, then we grab json object containing name.
// error handle
// output
// close streamreader
// close file
