public class DeploymentService
{
    public Deployment CreateDeployment(string name, string environment, string region,
        string owner, bool autoScale, int replicas, string version)
    {
        return Execute(name, environment, region, owner, autoScale, replicas, version);
    }
}
