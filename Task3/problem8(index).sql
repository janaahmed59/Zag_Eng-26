--index(8)
create index idx
on Orders(order_date,customer_id,total_amount)
include(customer_id,total_amount)
--order id has aaa clustered index
--the index on order_date is not sufficient because is ot covering the query requirement
--we modify the index to cover all columns for searching and not causing key lookups