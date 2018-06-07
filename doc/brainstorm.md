Expense Tracker - Love My Money
- Accounts
- Transactions
	- Edit Revenues or Expenses
- Categories
	- Set
- Bill reminder (Alerts)
- Upcoming bills
- Budget

--------------------------------------------

- Accounts
	- Transactions
		- Type: Revenue or Expense
		- Category
		- Date
		- Date Added
		- Last Updated
		- Value
		- Obs.

--------------------------------------------

Simple architecture
- Windows Azure as the back-end with


--------------------------------------------------------------------------
- Xamarin App (Windows, Android & IOS)		- Web Client (Digital Ocean) -
--------------------------------------------------------------------------
----------------------- Azure App Service (Web App)	----------------------
-- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - --- 
------------ Web API -----------------------> Azure web job	--------------
--------- Entity Framework ---------------- Entity Framework -------------
--------------------------------------------------------------------------
--------------------------- Azure SQL Database ---------------------------


Three tiers:
- So we have a Front-end with mobile apps and a web app.
- We have the App Service formed by one Web API (REST) that is on top of Azure web job both using EF.
- And finally the database.
