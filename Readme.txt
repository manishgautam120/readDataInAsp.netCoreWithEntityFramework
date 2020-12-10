create "Customer" table in sql server and insert the data 


CREATE TABLE Customer (
    ID int NOT NULL,
    LastName varchar(255) NOT NULL,
    FirstName varchar(255),
    Age int,
    PRIMARY KEY (ID)
);

insert into dbo.Customer(ID,LastName,FirstName,Age)values(1,'GAUTAM','MANISH',24);