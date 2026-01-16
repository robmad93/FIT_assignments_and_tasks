--DECLARE @orderId INT;

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (1, '2022-02-25 09:14', 'Delivered');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 20, 1, 149.99);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (2, '2022-02-27 13:30', 'Delivered');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 5, 3, 38.97),
((SELECT seq from sqlite_sequence where name = "Order"), 21, 1, 19.99),
((SELECT seq from sqlite_sequence where name = "Order"), 14, 1, 14.99);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (1, '2022-03-05 09:14', 'Delivered');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 20, 1, 149.99);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (3, '2022-03-25 21:57', 'Delivered');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 22, 1, 129.99),
((SELECT seq from sqlite_sequence where name = "Order"), 24, 3, 44.97);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (5, '2022-04-01 13:06', 'Delivered');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 15, 1, 199.99);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (6, '2022-04-03 11:25', 'Delivered');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 18, 1, 29.99),
((SELECT seq from sqlite_sequence where name = "Order"), 6, 1, 129.99);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (7, '2022-04-05 10:15', 'Delivered');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 7, 1, 49.99);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (6, '2022-04-10 12:39', 'Delivered');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 1, 3, 89.97);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (8, '2022-04-11 17:43', 'Delivered');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 2, 1, 149.99),
((SELECT seq from sqlite_sequence where name = "Order"), 23, 1, 99.99),
((SELECT seq from sqlite_sequence where name = "Order"), 10, 1, 29.99),
((SELECT seq from sqlite_sequence where name = "Order"), 3, 3, 19.99);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (9, '2022-04-11 21:03', 'Delivered');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 2, 1, 149.99);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (10, '2022-04-12 12:03', 'Delivered');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 5, 5, 64.95);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (11, '2022-04-15 18:31', 'Delivered');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 12, 1, 119.99),
((SELECT seq from sqlite_sequence where name = "Order"), 9, 1, 19.99);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (12, '2022-04-20 12:11', 'Delivered');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 19, 2, 49.98);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (13, '2022-04-25 08:19', 'Delivered');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 4, 1, 39.99),
((SELECT seq from sqlite_sequence where name = "Order"), 8, 1, 24.99);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (14, '2022-04-26 21:01', 'Delivered');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 13, 2, 19.98),
((SELECT seq from sqlite_sequence where name = "Order"), 24, 1, 14.99);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (15, '2022-05-05 17:53', 'Delivered');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 5, 3, 38.97);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (16, '2022-05-06 20:47', 'Delivered');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 5, 2, 25.98),
((SELECT seq from sqlite_sequence where name = "Order"), 14, 1, 14.99);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (18, '2022-05-09 12:20', 'Delivered');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 9, 2, 39.98),
((SELECT seq from sqlite_sequence where name = "Order"), 12, 1, 119.99);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (19, '2022-05-11 21:02', 'Cancelled');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 20, 1, 149.99);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (20, '2022-05-15 15:32', 'Delivered');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 15, 1, 199.99);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (22, '2022-05-16 07:11', 'Delivered');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 20, 1, 149.99);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (23, '2022-05-20 10:57', 'Delivered');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 5, 1, 12.99),
((SELECT seq from sqlite_sequence where name = "Order"), 9, 1, 19.99);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (23, '2022-05-25 16:23', 'Delivered');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 5, 2, 25.98);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (10, '2022-05-27 15:11', 'Shipped');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 19, 3, 74.97),
((SELECT seq from sqlite_sequence where name = "Order"), 8, 2, 49.98);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (24, '2022-05-30 21:09', 'Delivered');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 1, 3, 89.97);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (12, '2022-06-02 12:01', 'Delivered');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 19, 1, 24.99),
((SELECT seq from sqlite_sequence where name = "Order"), 9, 2, 39.98);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (19, '2022-06-04 22:31', 'Delivered');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 20, 1, 149.99);

INSERT INTO [Order] (customer_id, order_date, order_status) 
VALUES (25, '2022-06-10 20:30', 'Shipped');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 22, 1, 129.99);

INSERT INTO [Order] (customer_id, order_date, order_status) 
VALUES (15, '2022-06-15 15:15', 'Delivered');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price)
VALUES((SELECT seq from sqlite_sequence where name = "Order"), 9, 2, 39.98),
((SELECT seq from sqlite_sequence where name = "Order"), 19, 1, 24.99);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (29, '2022-06-30 15:32', 'Delivered');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 5, 2, 25.98),
((SELECT seq from sqlite_sequence where name = "Order"), 14, 1, 14.99);