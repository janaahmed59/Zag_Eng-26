--index(7)
SELECT service_name, created_at, status_code
FROM AppLogs
WHERE service_name = 'AuthService'
AND created_at >= '2026-01-01'
ORDER BY created_at DESC;

create Non clustered index idx
on AppLogs(service_name , created_at)
include(status_code)
--we search for service_name then sort by created -->index on service make the search being fast