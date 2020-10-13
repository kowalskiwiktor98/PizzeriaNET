# PizzaNET

Repository created for job interview at MetaPack Zielona Góra

# Table of Contents
- [PizzaNET](#pizzanet)
- [Table of Contents](#table-of-contents)
- [Requirements](#requirements)
- [Custom Features](#custom-features)
- [Possible Improvements](#possible-improvements)
- [Links](#links)
  - [API](#api)
  - [Website](#website)
  - [Winforms](#winforms)
#

# Requirements
- Order any set of dishes

- Each item can be added multiple times

- Responsive total price while ordering

- Send email notification with order details

- View order history

#
# Custom Features
- All projects based on .NET 5 Preview
- API, Dataabse and Website hosted on Azure App Service and Azure VM
- Using SendGrid as mail delivery service

#
# Possible Improvements

**Currently both Website and Winforms doesn't really allow you to add multiple additions to a meal, but API itself and Database allow this**

API
- Add email validation
- Add caching mechanism to Menu endpoint
- More unit tests
- Change notifyservice to decorator(?)

WinForms
- Add UnitTests, currently prevented by a bug in net5.0-rc described [here](https://github.com/microsoft/vstest/pull/2491) and [here](https://github.com/microsoft/vstest/pull/2491/commits/0298100b98bbc0860a06bcf5b11e40479c6f8158)
- Add email validation

Website
- Add CSS and stuff. dunno im not a web designer ¯\\_(ツ)_/¯
- Add email validation

Database
- Add indexes to speedup searching for order history
- Cleanup mess with column and functions types, make it consistent

#
# Links

## API
- [Root/HealthCheck](https://api-pizzerianet.azurewebsites.net/)
- [Swagger](https://api-pizzerianet.azurewebsites.net/swagger/index.html)

NOTE: Swagger should not be enabled outside dev environment, i just enabled it i case someone wants to test api via browser
- [Menu Endpoint](https://api-pizzerianet.azurewebsites.net/api/menu)

## Website
- [Main Website](https://pizzerianet.azurewebsites.net/)
  
  This is just a proof of concept website, it ~~just works~~ mostly works when you enter proper values

## Winforms
- [Release]()
