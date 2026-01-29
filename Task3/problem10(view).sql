--Views(10)
create view VIPCustomers_v
as
  select name , email, total_spent
  from Customers
  where total_spent > 5000
  order by total_spent DESC