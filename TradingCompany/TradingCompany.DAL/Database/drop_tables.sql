IF (OBJECT_ID('dbo.tblOrdersToProducts') IS NOT NULL)
BEGIN
    ALTER TABLE dbo.tblOrdersToProducts
    DROP CONSTRAINT FK_OrdersToProducts_Orders;
	ALTER TABLE dbo.tblOrdersToProducts
    DROP CONSTRAINT FK_OrdersToProducts_Products;
	DROP TABLE dbo.tblOrdersToProducts;
END

IF (OBJECT_ID('dbo.tblSuppliersToProducts') IS NOT NULL)
BEGIN
    ALTER TABLE dbo.tblSuppliersToProducts
    DROP CONSTRAINT FK_SuppliersToProducts_Suppliers;
	ALTER TABLE dbo.tblSuppliersToProducts
    DROP CONSTRAINT FK_SuppliersToProducts_Products;
	DROP TABLE dbo.tblSuppliersToProducts;
END

IF (OBJECT_ID('dbo.tblOrders') IS NOT NULL)
BEGIN
    ALTER TABLE dbo.tblOrders
    DROP CONSTRAINT FK_Orders_Users;
	DROP TABLE dbo.tblOrders;
END

IF (OBJECT_ID('dbo.tblUsers') IS NOT NULL)
BEGIN
    ALTER TABLE dbo.tblUsers
    DROP CONSTRAINT FK_Users_Roles;
	DROP TABLE dbo.tblUsers;
END

DROP TABLE IF EXISTS dbo.tblRoles;

DROP TABLE IF EXISTS dbo.tblProducts;

DROP TABLE IF EXISTS dbo.tblSuppliers;