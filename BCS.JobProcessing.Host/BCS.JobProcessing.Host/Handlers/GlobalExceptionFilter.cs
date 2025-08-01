using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Serilog;
using System;

namespace BCS.JobProcessing.Host.Handlers;

public class GlobalExceptionFilter : IExceptionFilter // Defines the GlobalExceptionFilter class, which implements the IExceptionFilter interface for handling exceptions globally.
{
    public void OnException(ExceptionContext context) // The OnException method is called when an exception occurs during request processing.
    {
        var exception = context.Exception; // Gets the exception that occurred.

        // Log the exception details using Serilog.
        Log.Error(exception, "An unhandled exception occurred. Error: {Message}, StackTrace: {StackTrace}, Source: {Source}, File: {File}, Line: {Line}",
            exception.Message, // Logs the error message.
            exception.StackTrace, // Logs the stack trace of the exception.
            exception.Source, // Logs the source of the exception.
            exception.TargetSite?.DeclaringType?.FullName, // Logs the source file name where the exception occurred.
            new System.Diagnostics.StackTrace(exception, true).GetFrame(0)?.GetFileLineNumber()); // Logs the line number where the exception occurred.

        var result = new ObjectResult(new { error = exception.Message }) // Creates a new ObjectResult to return the error message in the response.
        {
            StatusCode = 500 // Sets the status code to 500 (Internal Server Error).
        };
        context.Result = result; // Sets the result of the context to the ObjectResult.
        context.ExceptionHandled = true; // Marks the exception as handled to prevent further propagation.
    }
}
   