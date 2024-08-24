Create table Account(
Username varchar(50) not null,
Password varchar (50) not null,
FullName nvarchar(200) not null,
Phonenumber varchar(13) null,
Role varchar(50),
primary key(Username)
)
select * from Account
insert into Account values('huydeptrai','huy123456',N'Huy dep trai','0325885475', 'Admin')


----------------------

Create table Customer(
CustomerID int not null IDENTITY(1,1),
FullName nvarchar(200) not null,
Address nvarchar(500),
Phonenumber varchar(13) null,
primary key (CustomerID)
)

select * from Customer


----------

Create Table Kind(
KindID  int not null IDENTITY(1,1),
KindOfToy nvarchar(200),
primary key(KindOfToy)
)

select * from Kind




----------

Create table Toy(
ToyID int not null IDENTITY(1,1),
ToyTitle nvarchar(200) not null,
KindID int not null,
Price money not null,
Quantity float not null,
Note nvarchar(max) null,
primary key(ToyID)
)

select * from Toy


---------------------

Create table Bill(
BillID varchar(50) not null,
UserName nvarchar(200) not null,
CustomerID int not null ,
DayOfSale datetime not null,
TotalAmount money not null,
primary key(BillID)
)

select * from Bill 

------------------------------

Create table BillInfo(
BillID  varchar(50) not null,
ToyID int not null,
Quantity float not null,
Price money not null,
Discount money null,
Amount money not null,
primary key(BillID,ToyID)
)

select * from BillInfo 
