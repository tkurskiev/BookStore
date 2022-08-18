# BookStore

## EF Scripts

Database scaffolding:
```
dotnet ef dbcontext scaffold "Server=.;Database=BookStoreDb;User Id=Tims;Password=LightningBolt1;" Microsoft.EntityFrameworkCore.SqlServer -o Models --context-dir Data
```
or:
```
dotnet ef dbcontext scaffold Name=ConnectionStrings:BookStoreDatabase  Microsoft.EntityFrameworkCore.SqlServer -o Models --context-dir Data
```

## SQL Scripts

```
CREATE DATABASE BookStoreDb;
GO

USE BookStoreDb;
GO

CREATE TABLE Books
(
    id int  NOT NULL IDENTITY(1, 1),
    author char(256)  NOT NULL,
    title char(256)  NOT NULL,
    publication_date date NOT NULL,
    CONSTRAINT book_ak_1 UNIQUE (author, title),
    CONSTRAINT book_pk PRIMARY KEY  (id)
);
GO

INSERT INTO Books(author, title, publication_date)
VALUES (N'Михаил Булгаков', N'Мастер и Маргарита', '19670101')
,('Jerome David Salinger', 'The Catcher in the Rye', '19510716')
,('Aldous Huxley', 'Point Counter Point', '19280101')
,(N'Александр Пушкин', N'Евгений Онегин', '18330101')
,('John Ronald Reuel Tolkien', 'The Lord of the Rings', '19551020')

USE [BookStoreDb]
GO
CREATE LOGIN Tims WITH PASSWORD = 'LightningBolt1'
GO
Use [BookStoreDb];
GO

IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'Tims')
BEGIN
    CREATE USER Tims FOR LOGIN Tims
    EXEC sp_addrolemember N'db_owner', N'Tims'
END;
GO
```
