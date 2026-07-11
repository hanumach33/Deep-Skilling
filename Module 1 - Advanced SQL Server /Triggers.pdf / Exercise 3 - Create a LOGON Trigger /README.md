Exercise 3 - Create a LOGON Trigger

Objective

Learn how to create a LOGON Trigger in SQL Server to restrict database access during maintenance hours.

Scenario

The Employee Management System requires preventing users from logging into the SQL Server instance during the maintenance window from 2:00 AM to 3:00 AM.

Topics Covered

- CREATE TRIGGER
- LOGON Trigger
- ROLLBACK
- DATEPART()
- SQL Server Security

Tasks

- Create a LOGON trigger.
- Check the current login time.
- Prevent login between 2:00 AM and 3:00 AM.
- Display an error message when login is denied.

Files

- solution.sql
