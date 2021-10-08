INSERT INTO tblRoles(Name)
VALUES
('Admin'),
('Customer'),
('OrdersManager');


INSERT INTO tblProducts(Name, Brand, ProducingCountry, Price)
VALUES
('Engine', 'BMW', 'Germany', 1000),
('Wheel', 'Audi', 'Germany', 200),
('Bugatti Veyron', 'Veyron', 'France', 4000000),
('Switch', 'Cisco', 'USA', 100),
('Simple Router', 'Cisco', 'USA', 200),
('ASA', 'Cisco', 'USA', 1000),
('Optic Cable 1m', 'Huawei', 'USA', 5),
('Xiaomi MI8', 'Xiaomi', 'China', 300),
('Iphone 10', 'Iphone', 'USA', 900),
('Nokia n82', 'Nokia', 'Finland', 50),
('Nokia 3110', 'Nokia', 'Finland', 10),
('Windows10-Proffesional', 'Microsoft', 'USA', 100),
('Office-16', 'Microsoft', 'USA', 40),
('WorldOfWarcraft', 'Blizzard Entartainment', 'USA', 15);


INSERT INTO tblSuppliers(Name)
VALUES
('Fluke Motors'),
('Dragonetworks'),
('Smartechnologies'),
('Ghost Software'),
('Blizzard Entertainment'),
('Cheap Software'),
('CarsForever'),
('Cisco Products');


INSERT INTO tblUsers(FirstName, LastName, Email, HashPassword, RoleId)
VALUES
('Victor', 'Seredovych', 'victor.seredovich@gmail.com', 'xHashPasswordx', 3),
('V', 'S', 'admin', '$MYHASH$V1$10000$DULDGIaj6rpI/9s0JCmzOivZEM9wi3FK9uGJw7wy6PtJVpi+', 3),
('Fabian', 'Colon', 'eddellippaza-8223@yopmail.com', 'xHashPasswordx', 2),
('Rafael', 'Murray','0achille.binde91o@dmxs8.com', 'xHashPasswordx', 2),
('Connor', 'Valenzuela', '1christian.rahbes@cordlessduoclean.com', 'xHashPasswordx', 2),
('Zachariah', 'Ross', 'xtawa@bighome.site', 'xHashPasswordx', 2),
('Zakaria', 'Barrera', '7morga@vendasml.ml', 'xHashPasswordx', 2),
('Ivan', 'Semenov', 'xtyreso1@jcfug.us', 'xHashPasswordx', 2),
('Igor', 'Petruk', 'prahma.l@everyshop.us', 'xHashPasswordx', 2),
('Bob', 'Ross', 'bob.ros@paint.com', 'xHashPasswordx', 2),
('Adam', 'Jensen', 'jensen@silent.nope', 'xHashPasswordx', 2),
('Jhon', 'Snow', 'know.nothing@what.why', 'xHashPasswordx', 2);


INSERT INTO tblOrders(UserId, Destination, OrderDate)
VALUES
(3, 'Germany', convert(datetime,'20190918 10:34:09 PM', 5) ),
(7, 'Germany', convert(datetime,'20190812 01:13:39 AM', 5) ),
(8, 'France',  convert(datetime,'20190316 06:42:13 AM', 5) ),
(4, 'USA',     convert(datetime,'20180516 11:35:23 PM', 5) ),
(5, 'Finland', convert(datetime,'20190126 03:24:09 AM', 5) ),
(3, 'USA',     convert(datetime,'20180315 04:12:21 AM', 5) ),
(6, 'Ukrain',  convert(datetime,'20190212 10:51:12 PM', 5) );


INSERT INTO tblOrdersToProducts(OrderId, ProductId, Quantity)
VALUES
(1, 2, 1),
(1, 6, 2),
(1, 2, 6),
(2, 7, 2),
(2, 2, 1),
(3, 3, 2),
(3, 9, 4),
(4, 7, 5),
(5, 1, 1),
(5, 3, 3),
(5, 3, 3),
(6, 7, 5),
(6, 3, 1),
(6, 6, 1),
(6, 2, 6),
(7, 6, 1);


INSERT INTO tblSuppliersToProducts(SupplierID, ProductId)
VALUES
(1, 1),
(1, 2),
(1, 3),
(2, 4),
(2, 5),
(2, 6),
(2, 7),
(3, 8),
(3, 9),
(3, 10),
(3, 11),
(4, 12),
(4, 13),
(4, 14),
(5, 14),
(6, 12),
(6, 13),
(7, 1),
(7, 2),
(8, 4),
(8, 5),
(8, 6);