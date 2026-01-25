<<<<<<< HEAD
<<<<<<< HEAD
--problem 7
select concat(customers.first_name,' ',customers.last_name)  as full_name,order_id,amount
from customers full outer join orders
on orders.customer_id = customers.customer_id



=======
--problem 7
select customers.fname ||' '|| customers.lname  ass ffull_name,order_id,amount
from customers full outer join orders
on orders.customer_id = customers.customer_id

>>>>>>> 82d19ad (add new folder)
=======
--problem 7
select concat(customers.first_name,' ',customers.last_name)  as full_name,order_id,amount
from customers full outer join orders
on orders.customer_id = customers.customer_id



>>>>>>> 9d55383e658bdfc76b46a3535375a7a87378d498
