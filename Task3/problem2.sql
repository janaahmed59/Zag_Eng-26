--problem2
select p.project_id ,round((sum(e.experience_years*1.0)/ count(p.project_id)) ,2)
as average_years
from Employee e inner join Project p
on e.employee_id = p.employee_id
group by p.project_id