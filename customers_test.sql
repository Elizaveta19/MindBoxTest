Select Customers.Name from Customers
JOIN Products on Customers.CustomerId = Products.CustomerId and Customers.CustomerId not in (select Products.CustomerId from Products where Products.Name = 'сметана' and Products.PurchaiseDatetime >= now() - interval'1 month')
Where (Products.Name = 'молоко')