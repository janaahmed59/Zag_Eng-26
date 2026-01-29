--index(8)
create index idx
on Orders(order_date,order_id,customer_id,total_amount)
--the index on order_date is not sufficient because is ot covering the query requirement
--we modify the index to cover all columns for searching and not causing key lookups