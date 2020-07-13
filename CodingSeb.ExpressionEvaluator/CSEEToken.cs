/******************************************************************************************************
    Project : ExpressionEvaluator (https://github.com/codingseb/ExpressionEvaluator)

    Author : Coding Seb
    Licence : MIT (https://github.com/codingseb/ExpressionEvaluator/blob/master/LICENSE.md)
*******************************************************************************************************/

namespace CodingSeb.ExpressionEvaluator
{
    /// <summary>
    /// Represent a ExpressionEvaluator language token. The basic element for the syntaxic tree.
    /// </summary>
    public abstract partial class CSEEToken
    {
        /// <summary>
        /// The sub text part of the expression that represent this token
        /// </summary>
        public string CapturedText { get; set; }

        /// <summary>
        /// The position of this token in it's parent expression
        /// </summary>
        public int Position { get; set; }
    }
}
