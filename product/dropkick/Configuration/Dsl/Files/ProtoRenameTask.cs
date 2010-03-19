namespace dropkick.Configuration.Dsl.Files
{
    using System;
    using DeploymentModel;
    using Tasks;

    public class ProtoRenameTask :
        BaseTask,
        RenameOptions
    {
        string _target;
        string _to;

        public ProtoRenameTask(string target)
        {
            _target = target;
        }

        public void Rename(string name)
        {
            _to = name;
        }

        public override Task ConstructTasksForServer(DeploymentServer server)
        {
            throw new NotImplementedException();
        }
    }
}