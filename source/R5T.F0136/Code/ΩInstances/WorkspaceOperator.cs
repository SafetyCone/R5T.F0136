using System;


namespace R5T.F0136
{
    public class WorkspaceOperator : IWorkspaceOperator
    {
        #region Infrastructure

        public static IWorkspaceOperator Instance { get; } = new WorkspaceOperator();


        private WorkspaceOperator()
        {
        }

        #endregion
    }
}
