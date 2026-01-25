<<<<<<< HEAD
<<<<<<< HEAD
--problem 2
select customer_id,count(*) as count_no_trans
from Visits left join Transactions
on Visits.visit_id = Transactions.visit_id
where Transactions.visit_id is Null
=======
--problem 2
select customer_id,count(*) as count_no_trans
from Visits left join Transactions
on Visits.visit_id = Transactions.visit_id
where Transactions.visit_id is Null
>>>>>>> 82d19ad (add new folder)
=======
--problem 2
select customer_id,count(*) as count_no_trans
from Visits left join Transactions
on Visits.visit_id = Transactions.visit_id
where Transactions.visit_id is Null
>>>>>>> 9d55383e658bdfc76b46a3535375a7a87378d498
group by customer_id