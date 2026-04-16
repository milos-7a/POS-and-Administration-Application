# POS and Administration Application

C# Windows Forms point-of-sale and administration application targeting .NET Framework 4.8.

## Description

This repository contains a small POS (point-of-sale) and administration application implemented with Windows Forms. The project is written in C# (language version 7.3) and targets .NET Framework 4.8.

## Requirements

- Windows
- .NET Framework 4.8
- Visual Studio 2019/2022/2026 (or another IDE with .NET Framework support)
- XAMPP (for local MySQL/MariaDB server) if you plan to run the included MySQL database locally
- MySQL Connector/NET (NuGet package `MySql.Data`) if MySQL is used from .NET

## Build and run

1. Open `ProjekatPMK.sln` or `ProjekatPMK/ProjekatPMK.csproj` in Visual Studio.
2. Restore NuGet packages if prompted (install `MySql.Data` if you use MySQL).
3. Build the solution (Build -> Build Solution).
4. Run the application (Debug -> Start Debugging or Start Without Debugging).

## Project structure

- `ProjekatPMK/Program.cs` - application entry point
- `ProjekatPMK/Forme` - Windows Forms and resources (`.cs`, `.Designer.cs`, `.resx`)
- `ProjekatPMK/Klase` - domain classes and data access (check `DatabaseConnection.cs` for DB access)
- `ProjekatPMK/Properties` - application settings and resources

## Database (MySQL in XAMPP)

This project expects a MySQL (MariaDB) database. A common local development setup uses XAMPP.

Basic steps to prepare the database with XAMPP:

1. Install and start XAMPP, then start the `MySQL` (MariaDB) service from the XAMPP control panel.
2. Open phpMyAdmin (usually at `http://localhost/phpmyadmin`) or use the `mysql` CLI to create a database and user.

Example SQL (adapt names as needed):

```
CREATE DATABASE projekatpmk CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
USE projekatpmk;
-- Create tables according to the application needs (example placeholders)
-- CREATE TABLE Kategorije (ID INT PRIMARY KEY AUTO_INCREMENT, naziv VARCHAR(255));
-- CREATE TABLE Artikal (ID INT PRIMARY KEY AUTO_INCREMENT, naziv VARCHAR(255), cijena DECIMAL(10,2), kategorijaID INT);
-- CREATE TABLE Racun (ID INT PRIMARY KEY AUTO_INCREMENT, datum DATETIME, ukupno DECIMAL(10,2));
-- CREATE TABLE Stavka (ID INT PRIMARY KEY AUTO_INCREMENT, racunID INT, artikalID INT, kolicina INT, cijena DECIMAL(10,2));
```

Connection string examples:

- Local XAMPP default (no MySQL password):

```
Server=127.0.0.1;Port=3333;Database=projekatpmk;Uid=root;Pwd=;
```

- With explicit user/password:

```
Server=127.0.0.1;Port=3306;Database=projekatpmk;Uid=appuser;Pwd=your_password;
```

Where the application reads the connection string:

- Check `ProjekatPMK/Klase/DatabaseConnection.cs` for current usage. Prefer moving the connection string to `app.config` (connectionStrings) or `Settings` and loading credentials from environment variables for production.

If you need a database dump to import, export the schema/data from your local phpMyAdmin or `mysqldump` and keep the dump file out of source control or in a `db` folder ignored by git while sharing only sanitized examples.
rets
- Private keys or certificates

## Contributing

Contributions are welcome. Open an issue or submit a pull request with a clear description of changes.

## License

This project is licensed under the MIT License. See `LICENSE` for details.
