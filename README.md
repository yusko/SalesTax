Following programming problem was done in c#.  General assumption is made that we already know what product is exempted from local tax and 
which product is imported or not.  I suppose I could have wrote a class to categorize the product but for sake of time i decided to go with 
simple boolean.  I could have include some abstract classes and interfaces.  After writing the code I should have written the code in a more 
TDD (test driven developement) approach to writing the code.  I realize that some of practices used in real world is not something taught in class
so I had to figure out how to use Nunit.  Had some issue with Nunit not working in a 64-bit environment with a 32-bit program but it was resolved 
when i told NUnit to use any cpu type.  I tried to use object oriented approach as much as possible.  If i had more time i think i would have approach 
the coding differently like using bit of agile model drive development (AMDD) with more of  TDD approach.  It was a good learning experience using Nunit 
using github.  I'm more comfortable with googlecode or mercurial.

The follwoing is the programming problem: 

SalesTax
========
Basic sales tax is applicable at a rate of 10% on all goods, except books, food, and medical
products that are exempt. Import duty is an additional sales tax applicable on all imported
goods at a rate of 5%, with no exemptions.
When I purchase items I receive a receipt which lists the name of all the items and their price
(including tax), finishing with the total cost of the items, and the total amounts of sales taxes
paid. The rounding rules for sales tax are that for a tax rate of n%, a shelf price of p contains
(np/100 rounded up to the nearest 0.05) amount of sales tax.
Write an application that prints out the receipt details for these shopping baskets...

INPUT:

Input 1:
1 book at 12.49
1 music CD at 14.99
1 chocolate bar at 0.85

Input 2:
1 imported box of chocolates at 10.00
1 imported bottle of perfume at 47.50

Input 3:
1 imported bottle of perfume at 27.99
1 bottle of perfume at 18.99
1 packet of headache pills at 9.75
1 box of imported chocolates at 11.25


OUTPUT

Output 1:
1 book : 12.49
1 music CD: 16.49
1 chocolate bar: 0.85
Sales Taxes: 1.50
Total: 29.83

Output 2:
1 imported box of chocolates: 10.50
1 imported bottle of perfume: 54.65
Sales Taxes: 7.65
Total: 65.15

Output 3:
1 imported bottle of perfume: 32.19
1 bottle of perfume: 20.89
1 packet of headache pills: 9.75
1 imported box of chocolates: 11.85

Sales Taxes: 6.70
Total: 74.68
