<<<<<<< HEAD
<<<<<<< HEAD
--problem 4
select w1.id
from Weather w1 join weather w2
on datediff(day,w2.recordDate,w1.recordDate) = 1
=======
--problem 4
select w1.id
from Weather w1 join weather w2
on datediff(day,w2.recordDate,w1.recordDate) = 1
>>>>>>> 82d19ad (add new folder)
=======
--problem 4
select w1.id
from Weather w1 join weather w2
on datediff(day,w2.recordDate,w1.recordDate) = 1
>>>>>>> 9d55383e658bdfc76b46a3535375a7a87378d498
where w1.temperature > w2.temperature