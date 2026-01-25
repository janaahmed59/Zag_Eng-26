<<<<<<< HEAD
<<<<<<< HEAD
--problem 6
select product_name , supplier_name
from products left join suppliers
on products.supplier_id = suppliers.supplier_id
=======
--problem 6
select product_name , supplier_name
from products left join suppliers
on products.supplier_id = suppliers.supplier_id
>>>>>>> 82d19ad (add new folder)
=======
--problem 6
select product_name , supplier_name
from products left join suppliers
on products.supplier_id = suppliers.supplier_id
>>>>>>> 9d55383e658bdfc76b46a3535375a7a87378d498
where product_name like '%Phone%'