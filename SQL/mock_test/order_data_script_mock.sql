INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (29, '2024-01-10 13:04', 'Shipped');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 17, 2, 79.00);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (9, '2024-01-20 11:34', 'Shipped');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 24, 4, 49.00),
((SELECT seq from sqlite_sequence where name = "Order"), 8, 4, 79.20),
((SELECT seq from sqlite_sequence where name = "Order"), 7, 4, 65.60);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (12, '2024-01-27 14:29', 'Shipped');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 24, 4, 49.00);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (24, '2024-02-02 09:15', 'Shipped');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 7, 2, 32.80),
((SELECT seq from sqlite_sequence where name = "Order"), 18, 4, 43.80);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (14, '2024-02-08 12:29', 'Shipped');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 8, 4, 79.20);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (26, '2024-02-14 08:41', 'Shipped');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 1, 2, 14.98),
((SELECT seq from sqlite_sequence where name = "Order"), 14, 4, 84.60);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (16, '2024-02-22 14:57', 'Shipped');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 2, 2, 45.90);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (13, '2024-02-28 14:16', 'Shipped');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 15, 4, 53.00);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (23, '2024-03-09 10:12', 'Shipped');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 10, 2, 28.70),
((SELECT seq from sqlite_sequence where name = "Order"), 2, 3, 68.85),
((SELECT seq from sqlite_sequence where name = "Order"), 2, 4, 91.80),
((SELECT seq from sqlite_sequence where name = "Order"), 17, 2, 79.00);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (2, '2024-03-13 10:04', 'Shipped');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 20, 2, 31.50);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (13, '2024-03-20 17:15', 'Shipped');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 19, 1, 17.60);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (20, '2024-03-27 14:42', 'Shipped');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 19, 3, 52.80),
((SELECT seq from sqlite_sequence where name = "Order"), 7, 3, 49.20);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (8, '2024-04-05 14:08', 'Shipped');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 22, 3, 20.97);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (15, '2024-04-12 09:00', 'Shipped');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 15, 2, 26.50),
((SELECT seq from sqlite_sequence where name = "Order"), 17, 3, 118.50);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (5, '2024-04-19 09:56', 'Shipped');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 8, 3, 59.40),
((SELECT seq from sqlite_sequence where name = "Order"), 10, 2, 28.70);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (27, '2024-04-26 17:51', 'Shipped');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 21, 1, 26.80);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (22, '2024-05-03 18:06', 'Shipped');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 9, 1, 12.60),
((SELECT seq from sqlite_sequence where name = "Order"), 4, 2, 37.00);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (9, '2024-05-10 17:13', 'Shipped');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 23, 3, 100.35),
((SELECT seq from sqlite_sequence where name = "Order"), 7, 3, 49.20);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (17, '2024-05-18 12:57', 'Delivered');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 2, 4, 91.80);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (27, '2024-05-24 08:00', 'Shipped');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 11, 2, 17.80);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (21, '2024-05-31 10:47', 'Shipped');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 15, 4, 53.00);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (18, '2024-06-05 09:04', 'Shipped');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 23, 2, 66.90),
((SELECT seq from sqlite_sequence where name = "Order"), 18, 3, 32.85);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (19, '2024-06-13 14:08', 'Shipped');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 2, 3, 68.85);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (12, '2024-06-19 13:13', 'Cancelled');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 22, 2, 13.98),
((SELECT seq from sqlite_sequence where name = "Order"), 22, 1, 6.99);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (12, '2024-06-29 17:47', 'Shipped');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 5, 2, 59.50);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (28, '2024-07-04 10:56', 'Shipped');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 14, 2, 42.30),
((SELECT seq from sqlite_sequence where name = "Order"), 24, 3, 36.75);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (26, '2024-07-13 18:55', 'Shipped');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 24, 2, 24.50);

INSERT INTO [Order] (customer_id, order_date, order_status) 
VALUES (9, '2024-07-18 09:24', 'Cancelled');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 2, 4, 91.80);

INSERT INTO [Order] (customer_id, order_date, order_status) 
VALUES (8, '2024-07-25 15:22', 'Shipped');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price)
VALUES((SELECT seq from sqlite_sequence where name = "Order"), 10, 1, 14.35),
((SELECT seq from sqlite_sequence where name = "Order"), 22, 2, 13.98);

INSERT INTO [Order] (customer_id, order_date, order_status)
VALUES (13, '2024-08-02 12:55', 'Shipped');
-- SET @orderId = SCOPE_IDENTITY();
INSERT INTO OrderItem (order_id, product_id, quantity, price) 
VALUES ((SELECT seq from sqlite_sequence where name = "Order"), 3, 3, 29.97),
((SELECT seq from sqlite_sequence where name = "Order"), 12, 4, 109.20);