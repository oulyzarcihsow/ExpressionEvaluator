/******************************************************************************************************
    Project : ExpressionEvaluator (https://github.com/codingseb/ExpressionEvaluator)

    Author : Coding Seb
    Licence : MIT (https://github.com/codingseb/ExpressionEvaluator/blob/master/LICENSE.md)
*******************************************************************************************************/

using System;
using System.Collections.Generic;

namespace CodingSeb.ExpressionEvaluator
{
    /// <summary>
    /// Event args that contains informations to evaluate on the fly a function or method  before it is evaluated the classic way
    /// </summary>
    public partial class FunctionPreEvaluationEventArg : FunctionEvaluationEventArg
    {
        public FunctionPreEvaluationEventArg(string name, Func<string, object> evaluateFunc, List<string> args = null, ExpressionEvaluator evaluator = null, object onInstance = null, string genericTypes = null, Func<string, Type[]> evaluateGenericTypes = null)
            : base(name, evaluateFunc, args, evaluator, onInstance, genericTypes, evaluateGenericTypes)
        { }

        /// <summary>
        /// If set to true cancel the evaluation of the current function or method and throw an exception that the function does not exists
        /// </summary>
        public bool CancelEvaluation { get; set; }
    }
}
