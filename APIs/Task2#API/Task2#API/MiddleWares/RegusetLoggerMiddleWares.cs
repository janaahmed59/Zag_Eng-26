using System.Diagnostics;

namespace Task2_API.MiddleWares
{
    public class RegusetLoggerMiddleWares
    {
        private readonly RequestDelegate _next;
        public RegusetLoggerMiddleWares(RequestDelegate next)
        {
            _next = next;
        }   
        public async Task InvokeAsync(HttpContext context)
        {
            var startTime = DateTime.UtcNow;
            var stopwatch = Stopwatch.StartNew(); 
            Console.WriteLine($" {startTime:yyyy-MM-dd HH:mm:ss}  {context.Request.Method} -> {context.Request.Path}");
            await _next(context);
            stopwatch.Stop();
            var statusCode = context.Response.StatusCode;
            var endTime = DateTime.UtcNow;
            var duration = stopwatch.ElapsedMilliseconds;

            Console.WriteLine($"{endTime:yyyy-MM-dd HH:mm:ss} {context.Request.Method} {context.Request.Path} -> {statusCode} (took {duration}ms)");
        }
    }
}
