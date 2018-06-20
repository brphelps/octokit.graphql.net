namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Autogenerated return type of UnlockLockable
    /// </summary>
    public class UnlockLockablePayload : QueryableValue<UnlockLockablePayload>
    {
        /// <inheritdoc />
        public UnlockLockablePayload(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; }

        /// <summary>
        /// The item that was unlocked.
        /// </summary>
        public ILockable UnlockedRecord => this.CreateProperty(x => x.UnlockedRecord, Octokit.GraphQL.Model.Internal.StubILockable.Create);

        internal static UnlockLockablePayload Create(Expression expression)
        {
            return new UnlockLockablePayload(expression);
        }
    }
}