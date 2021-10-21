CREATE TABLE tblRoles(
    Id bigint IDENTITY(1,1) PRIMARY KEY not null ,
    Name nvarchar(50) not null,
    RowInsertTime datetime2(7) default getutcdate(),
    RowUpdateTime datetime2(7) default getutcdate()
);


CREATE TABLE tblProducts(
    Id bigint IDENTITY(1,1) PRIMARY KEY not null,
    Name nvarchar(50) not null,
    Brand nvarchar(50) not null,
    ProducingCountry nvarchar(50) not null,
    Price int not null,
    RowInsertTime datetime2(7) default getutcdate(),
    RowUpdateTime datetime2(7) default getutcdate()
);


CREATE TABLE tblSuppliers(
    Id bigint IDENTITY(1,1) PRIMARY KEY not null,
    Name nvarchar(50) not null,
    RowInsertTime datetime2(7) default getutcdate(),
    RowUpdateTime datetime2(7) default getutcdate()
);


CREATE TABLE tblUsers(
    Id bigint not null IDENTITY(1,1) PRIMARY KEY,
    FirstName nvarchar(50) not null,
    LastName nvarchar(50) not null,
    Email nvarchar(50) not null,
    HashPassword varchar(256) not null,
    RoleId bigint not null,
    RowInsertTime datetime2(7) default getutcdate(),
    RowUpdateTime datetime2(7) default getutcdate()
);

ALTER TABLE tblUsers
   ADD CONSTRAINT FK_Users_Roles FOREIGN KEY (RoleId)
      REFERENCES tblRoles (Id)
      ON DELETE CASCADE
      ON UPDATE CASCADE
;



CREATE TABLE tblOrders(
    Id bigint not null IDENTITY(1,1) PRIMARY KEY,
    UserId bigint not null, 
    Destination nvarchar(50) not null,
    OrderDate DateTime not null,
    RowInsertTime datetime2(7) default getutcdate(),
    RowUpdateTime datetime2(7) default getutcdate()
);

ALTER TABLE tblOrders
   ADD CONSTRAINT FK_Orders_Users FOREIGN KEY (UserId)
      REFERENCES tblUsers (Id)
      ON DELETE CASCADE
      ON UPDATE CASCADE
;



CREATE TABLE tblOrdersToProducts(
    Id bigint not null IDENTITY(1,1) PRIMARY KEY,
    OrderId bigint not null,
    ProductId bigint not null,
    Quantity int not null,
    RowInsertTime datetime2(7) default getutcdate(),
    RowUpdateTime datetime2(7) default getutcdate()
);

ALTER TABLE tblOrdersToProducts
   ADD CONSTRAINT FK_OrdersToProducts_Orders FOREIGN KEY (OrderId)
      REFERENCES tblOrders (Id)
      ON DELETE CASCADE
      ON UPDATE CASCADE
;
ALTER TABLE tblOrdersToProducts
   ADD CONSTRAINT FK_OrdersToProducts_Products FOREIGN KEY (ProductId)
      REFERENCES tblProducts (Id)
      ON DELETE CASCADE
      ON UPDATE CASCADE
;



CREATE TABLE tblSuppliersToProducts(
    Id bigint not null IDENTITY(1,1) PRIMARY KEY,
    SupplierId bigint not null,
    ProductId bigint not null,
    RowInsertTime datetime2(7) default getutcdate(),
    RowUpdateTime datetime2(7) default getutcdate()
);

ALTER TABLE tblSuppliersToProducts
   ADD CONSTRAINT FK_SuppliersToProducts_Suppliers FOREIGN KEY (SupplierId)
      REFERENCES tblSuppliers (Id)
      ON DELETE CASCADE
      ON UPDATE CASCADE
;
ALTER TABLE tblSuppliersToProducts
   ADD CONSTRAINT FK_SuppliersToProducts_Products FOREIGN KEY (ProductId)
      REFERENCES tblProducts (Id)
      ON DELETE CASCADE
      ON UPDATE CASCADE
;