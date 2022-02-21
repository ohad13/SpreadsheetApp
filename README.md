# Spreadsheet App

This spreadsheet can be shared between multiple concurrent users like Google Docs and Google Sheets. 
The spreadsheet represent a table of n*m cells (n=rows, m=columns).
Each cell holds a string. 
The spreadsheet object can be access concurrently by many users, and users can perform operations concurrently.

To implement this spreadsheet we used multiply locks - Mutexs and Semaphore to avoid any deadlock or crashes during runtime, based on "reader writer strategy". 
In addation we created a GUI using Visual Studio to allow users to perform various operations that include create, load, save spreadsheet, edit cells, adding and remove rows and columns, etc.
