# Project

### By Jessica Munoz

#### _A web application to track vendors and their orders. - August 2nd, 2019_

---

## Description

Simple web application used to track Pierre's Bakery vendors and their corresponding orders.

## Technologies Used

- C#
- .NET
- MSTesting

## Installation

- Install .NET locally if it isn't already installed
- Clone this repository locally
- Open the terminal and navigate to the project folder Tracker.Solution/Tracker
  - Enter the command: dotnet restore
  - Enter the command: dotnet build
  - Enter the command: dotnet run
  - Browse to http://localhost:5000/

## Specs

| Behaviors                              |                                                   Input                                                    |                Output                 |
| -------------------------------------- | :--------------------------------------------------------------------------------------------------------: | :-----------------------------------: |
| User can add new vendors.              |                      User clicks "Add a new vendor", fills out form and clicks "Add".                      |        New vendor is created.         |
| User can add new orders to the vendor. | User clicks on previously created vendor, clicks "Add a new order", fills out form and clicks "Add Order". | New order for that vendor is created. |
| User can view all vendor orders.       |                   User clicks previously created vendor with previously created orders.                    |     List of that vendor's orders.     |
| User can view all vendors.             |                                         User clicks "View vendors"                                         |  List of previously created vendors.  |

## Known Bugs

- No known bugs at this time.

## Support and contact details

_Please contact Jessica Munoz with questions and comments._

### License

_GNU GPLv3_

Copyright (c) 2019 **_Jessica Munoz_**
