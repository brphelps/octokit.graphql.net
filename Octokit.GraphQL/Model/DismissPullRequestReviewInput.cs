namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of DismissPullRequestReview
    /// </summary>
    public class DismissPullRequestReviewInput
    {
        /// <summary>
        /// The Node ID of the pull request review to modify.
        /// </summary>
        public ID PullRequestReviewId { get; set; }

        /// <summary>
        /// The contents of the pull request review dismissal message.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}