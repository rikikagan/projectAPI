using Newtonsoft.Json;

namespace WeightWatchers.config
{
    public class MidelWare
    {
        public class ErrorHandlingMiddleware
        {
            private readonly RequestDelegate _next;
            private readonly ILogger<ErrorHandlingMiddleware> _looger;
            public ErrorHandlingMiddleware(RequestDelegate next, ILogger<ErrorHandlingMiddleware> looger)
            {
                _next = next;
                _looger = looger;
            }
            public async Task InvokeAsync(HttpContext context )
            {
                try
                {
                    string time = DateTime.Now.ToString("yyyy-MM-dd HH:ss:mm");
                    _looger.LogDebug($"start cell api {context.Request.Path} start in {time} ");
                    context.Items.Add("RequestSequence", time);
                    await _next(context);
                    string time2 = DateTime.Now.ToString("yyyy-MM-dd HH:ss:mm");
                    _looger.LogInformation($"end  cell api {context.Request.Path} start in {time2} ");
                }
                catch (Exception ex)
                {
                    await HandleExceptionAsync(context, ex);
                }
            }
            private static Task HandleExceptionAsync(HttpContext context, Exception ex)
            {
                //ממיר את השגיאה לJSON ומחזיר מכל הפונקציות במקרה ונפל 

                var result = JsonConvert.SerializeObject(new { error = ex.Message });
                //context.Response.ContentType = "application/json";            
                return context.Response.WriteAsync(result);
            }
        }
    }
}
