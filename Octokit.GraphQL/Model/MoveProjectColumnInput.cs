namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of MoveProjectColumn
    /// </summary>
    public class MoveProjectColumnInput
    {
        public ID ColumnId { get; set; }

        public ID? AfterColumnId { get; set; }

        public string ClientMutationId { get; set; }
    }
}