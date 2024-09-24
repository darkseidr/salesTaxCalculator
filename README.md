# Sales Tax Calculator

A simple console application for calculating sales tax on items purchased. This program helps users input item details and calculates the applicable sales taxes and total cost based on predefined tax rules.

## Features

- Accepts user input for:
  - Item name
  - Price
  - Quantity
  - Tax exemption status
- Supports both imported and non-imported items.
- Calculates total sales taxes and total cost.
- Handles invalid inputs gracefully.
- Outputs a detailed receipt for the items purchased.

## Requirements

- .NET Core SDK

## Getting Started

### Clone the Repository

```bash
git clone https://github.com/darkseidr/salesTaxCalculator.git
cd salesTaxCalculator
```

### Build and Run

To build and run the application, use the following commands:

```bash
dotnet build
dotnet run
```

## Usage

1. Follow the prompts to enter the item details.
2. Review the calculated sales tax and total cost in the receipt.

## Example Input

```
Enter item name: Book
Enter item price: 12.49
Enter quantity: 1
Is the item imported? (yes/no): no
```

## Example Output

```
Receipt:
1 x Book: 12.49
Sales Taxes: 0.00
Total: 12.49
```
