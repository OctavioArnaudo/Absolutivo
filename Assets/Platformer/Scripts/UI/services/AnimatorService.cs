using System;
using System.Linq;
using System.Linq.Expressions;
using UnityEngine;

// <summary>
// Provides functionality to set animator parameters using expressions.
// </summary>
public static class AnimatorService
{
    public static bool WasInState(Animator animator, string stateName)
    {
        if (animator == null)
        {
            Debug.LogError("Animator is null. Cannot check state.");
            return false;
        }

        AnimatorStateInfo currentState = animator.GetCurrentAnimatorStateInfo(0);
        AnimatorTransitionInfo previousState = animator.GetAnimatorTransitionInfo(0);

        return animator.IsInTransition(0) && previousState.IsName(stateName);
    }
    public static T GetAnimatorParameter<T>(Animator animator, Expression<Func<T>> expression)
    {
        if (animator == null)
        {
            Debug.LogError("Animator is null. Cannot get parameter.");
            return default;
        }

        if (!(expression.Body is MemberExpression))
        {
            Debug.LogError("Expression must be a member expression (e.g., () => variableName).");
            return default;
        }

        string parameterName = ((MemberExpression)expression.Body).Member.Name;

        Type type = typeof(T);

        if (type == typeof(bool))
        {
            return (T)(object)animator.GetBool(parameterName);
        }
        else if (type == typeof(float))
        {
            return (T)(object)animator.GetFloat(parameterName);
        }
        else if (type == typeof(int))
        {
            return (T)(object)animator.GetInteger(parameterName);
        }
        else
        {
            Debug.LogWarning($"Parameter type '{type.Name}' not supported. Supported types are bool, float, and int.");
            return default;
        }
    }
    /// <summary>
    /// 
    /// Sets an animator parameter based on the provided expression.
    /// 
    /// <typeparam name="T">The type of the parameter value.</typeparam>
    /// 
    /// <param name="animator">The Animator component to set the parameter on.</param>
    /// 
    /// <param name="expression">An expression representing the parameter value.</param>
    /// 
    /// <example>
    /// 
    // <code>
    /// Animator animator = GetComponent<Animator>();
    /// 
    // // Set a boolean parameter named "isRunning"
    /// AnimatorDebugger.SetAnimatorParameter(animator, () => isRunning);
    /// 
    // // Set a float parameter named "speed"
    /// AnimatorDebugger.SetAnimatorParameter(animator, () => speed);
    /// 
    // // Set an integer parameter named "health"
    /// AnimatorDebugger.SetAnimatorParameter(animator, () => health);
    /// 
    // </code>
    ///
    /// </example>
    /// 
    /// </summary>
    public static void SetAnimatorParameter<T>(Animator animator, Expression<Func<T>> expression)
    {
        // Check if the expression is null
        if (expression == null)
        {
            // Log an error if the expression is null
            Debug.LogError("Expression is null. Cannot set parameter.");
            // Return early if the expression is null
            return;
        }
        // Check if the animator is null
        if (animator == null)
        {
            // Log an error if the animator is null
            Debug.LogError("Animator is null. Cannot set parameter.");
            // Return early if the animator is not valid
            return;
        }

        // Ensure the expression body is a member expression
        if (!(expression.Body is MemberExpression))
        {
            // Log an error if the expression is not a member expression
            Debug.LogError("Expression must be a member expression (e.g., () => variableName).");
            // Return early if the expression is not valid
            return;
        }
        // Extract the parameter name from the expression
        string parameterName = ((MemberExpression)expression.Body).Member.Name;

        // Check if the animator has the parameter
        T value = expression.Compile().Invoke();

        // Ensure the animator has the parameter before setting it
        if (!animator.parameters.Any(p => p.name == parameterName))
        {
            // Log a warning if the animator does not have the parameter
            Debug.LogWarning($"Animator does not have a parameter named '{parameterName}'.");
            // Return early if the parameter does not exist
            return;
        }
        // Set the parameter based on its type
        if (value is bool boolValue)
        {
            // Set the boolean parameter
            animator.SetBool(parameterName, boolValue);
        }
        // Check if the value is a float
        else if (value is float floatValue)
        {
            // Set the float parameter
            animator.SetFloat(parameterName, floatValue);
        }
        // Check if the value is an int
        else if (value is int intValue)
        {
            // Set the integer parameter
            animator.SetInteger(parameterName, intValue);
        }
        // If the value is not a supported type, log a warning
        else
        {
            // Log a warning for unsupported parameter types
            Debug.LogWarning($"Parameter type not supported for variable '{parameterName}'. Supported types are bool, float, and int.");
        }
    }
    /// <summary>
    /// Sets an Animator parameter based on a variable and an explicit value.
    /// This method is type-safe and prevents typos in parameter names.
    /// </summary>
    /// <param name="animator">The Animator component.</param>
    /// <param name="parameterExpression">An expression that points to the variable (e.g., () => isJumping).</param>
    /// <param name="value">The value to set for the parameter.</param>
    public static void SetAnimatorParameter<T>(Animator animator, Expression<Func<T>> parameterExpression, T value)
    {
        // Check for null Animator
        if (animator == null)
        {
            Debug.LogError("Animator is null. Cannot set parameter.");
            return;
        }

        // Get the parameter name from the expression
        if (!(parameterExpression.Body is MemberExpression memberExpression))
        {
            Debug.LogError("Expression must be a member expression (e.g., () => variableName).");
            return;
        }
        string parameterName = memberExpression.Member.Name;

        // Verify the parameter exists in the Animator
        if (!animator.parameters.Any(p => p.name == parameterName))
        {
            Debug.LogWarning($"Animator does not have a parameter named '{parameterName}'.");
            return;
        }

        // Set the parameter based on its type
        if (value is bool boolValue)
        {
            animator.SetBool(parameterName, boolValue);
        }
        else if (value is float floatValue)
        {
            animator.SetFloat(parameterName, floatValue);
        }
        else if (value is int intValue)
        {
            animator.SetInteger(parameterName, intValue);
        }
        else
        {
            Debug.LogWarning($"Parameter type not supported for variable '{parameterName}'. Supported types are bool, float, and int.");
        }
    }
}