/******************************************************************************************************
    Project : ExpressionEvaluator (https://github.com/codingseb/ExpressionEvaluator)

    Author : Coding Seb
    Licence : MIT (https://github.com/codingseb/ExpressionEvaluator/blob/master/LICENSE.md)
*******************************************************************************************************/

using System;

namespace CodingSeb.ExpressionEvaluator
{
    /// <summary>
    /// Event args that contains informations to evaluate on the fly a variable or property before it is evaluated the classic way
    /// </summary>
    public partial class VariablePreEvaluationEventArg : VariableEvaluationEventArg
    {
        public VariablePreEvaluationEventArg(string name, ExpressionEvaluator evaluator = null, object onInstance = null, string genericTypes = null, Func<string, Type[]> evaluateGenericTypes = null)
            : base(name, evaluator, onInstance, genericTypes, evaluateGenericTypes)
        { }

        /// <summary>
        /// If set to true cancel the evaluation of the current variable, field or property and throw an exception it does not exists
        /// </summary>
        public bool CancelEvaluation { get; set; }
    }
}
