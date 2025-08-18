namespace SpecDrivenDevelopment.Services
{
    public class ExceptionHandlerService
    {
        public event Func<string, Task>? OnError;

        public async Task HandleExceptionAsync<T>(Exception ex, string methodName)
        {
            var componentName = typeof(T).Name;
            var errorMessage = $"Error in {componentName}.{methodName}: {ex.Message}";
            
            // Log the exception (you can integrate with ILogger here)
            Console.WriteLine($"[ERROR] {errorMessage}");
            Console.WriteLine($"[STACK TRACE] {ex.StackTrace}");
            
            // Notify subscribers (like ErrorDisplay component)
            if (OnError != null)
            {
                await OnError.Invoke(errorMessage);
            }
        }
    }
}
