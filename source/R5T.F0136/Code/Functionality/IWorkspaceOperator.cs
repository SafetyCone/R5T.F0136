using System;
using System.Threading.Tasks;

using Microsoft.CodeAnalysis.MSBuild;

using R5T.T0132;


namespace R5T.F0136
{
    [FunctionalityMarker]
    public partial interface IWorkspaceOperator : IFunctionalityMarker
    {
        public void In_WorkspaceContext(
            Action<MSBuildWorkspace> workspaceAction)
        {
            Instances.MSBuildLocationOperator.In_RegisteredLocationContext(
                () =>
                {
                    using var workspace = MSBuildWorkspace.Create();

                    Instances.ActionOperator.Run(
                        workspaceAction,
                        workspace);
                });
        }

        public async Task In_WorkspaceContext(
            Func<MSBuildWorkspace, Task> workspaceAction)
        {
            await Instances.MSBuildLocationOperator.In_RegisteredLocationContext(
                async () =>
                {
                    using var workspace = MSBuildWorkspace.Create();

                    await Instances.ActionOperator.Run(
                        workspaceAction,
                        workspace);
                });
        }
    }
}
