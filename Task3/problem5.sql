--problem5
select employee_id
from Employees
where salary < 30000 and 
manager_id is not null and 
manager_id not in (select employee_id -- subquery -> select employee_id not manager_id 
                      from Employees ) -- there is no where clause in subQ, there is not in exp
                      
group by employee_id
                                        