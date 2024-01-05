# product-search

Pulling data from a file into a complex data structure makes
parsing much simpler. Many programming languages support the JSON format, a popular way of representing data.
Create a program that takes a product name as input and
retrieves the current price and quantity forthat product. The
product data is in a data file in the JSON format and looks
like this:
{
"products" : [
{"name": "Widget", "price": 25.00, "quantity": 5 },
{"name": "Thing", "price": 15.00, "quantity": 5 },
{"name": "Doodad", "price": 5.00, "quantity": 10 }
]
}
Print out the product name, price, and quantity if the product
is found. If no product matches the search, state that no
product was found and start over.
Example Output
What is the product name? iPad
Sorry, that product was not found in our inventory.
What is the product name? Widget
Name: Widget
Price: $25.00
Quantity on hand: 5
Constraints
• The file is in the JSON format. Use a JSON parserto pull
the values out of the file.
• If no record is found, prompt again.
Challenges
• Ensure that the product search is case insensitive.
• When a product is not found, ask if the product should
be added. If yes, ask for the price and the quantity, and
save it in the JSON file. Ensure the newly added product
is immediately available for searching withoutrestarting
the program
