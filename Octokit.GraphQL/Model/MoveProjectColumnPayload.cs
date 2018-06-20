namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Autogenerated return type of MoveProjectColumn
    /// </summary>
    public class MoveProjectColumnPayload : QueryableValue<MoveProjectColumnPayload>
    {
        /// <inheritdoc />
        public MoveProjectColumnPayload(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; }

        /// <summary>
        /// The new edge of the moved column.
        /// </summary>
        public ProjectColumnEdge ColumnEdge => this.CreateProperty(x => x.ColumnEdge, Octokit.GraphQL.Model.ProjectColumnEdge.Create);

        internal static MoveProjectColumnPayload Create(Expression expression)
        {
            return new MoveProjectColumnPayload(expression);
        }
    }
}