--Views(10)
create view VIPCustomers_v
as
  select name , email, total_Amount as total_spent
  from Customers c join Order o
  on c.customer_id = o.customer_id
  where total_spent > 5000
  order by total_spent DESC
