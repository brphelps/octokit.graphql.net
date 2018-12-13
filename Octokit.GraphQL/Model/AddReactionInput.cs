namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of AddReaction
    /// </summary>
    public class AddReactionInput
    {
        /// <summary>
        /// The Node ID of the subject to modify.
        /// </summary>
        public ID SubjectId { get; set; }

        /// <summary>
        /// The name of the emoji to react with.
        /// </summary>
        public ReactionContent Content { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}