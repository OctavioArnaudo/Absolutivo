using System;
using System.Linq.Expressions;
using UnityEngine;

public static class DebuggerService
{
    /// <summary>
    /// 
    /// Prints the name and value of a variable using an expression.
    /// 
    /// <typeparam name="T">The type of the variable.</typeparam>
    /// 
    /// <param name="expression">An expression representing the variable.</param>
    /// 
    /// <example>
    /// 
    /// <code>
    /// 
    // int myVariable = 42;
    // DebuggerUtility.PrintVariable(() => myVariable);
    ///
    /// </code>
    /// 
    /// </example>
    /// 
    /// </summary>
    public static void PrintVariable<T>(Expression<Func<T>> expression)
    {
        // Get the variable name from the expression
        string variableName = ((MemberExpression)expression.Body).Member.Name;
 
        // Compile the expression to get the value
        T value = expression.Compile().Invoke();

        // Print the variable name and value
        Console.WriteLine($"{variableName}: {value}");

        Debug.Log($"{variableName}: {value}");
    }
}