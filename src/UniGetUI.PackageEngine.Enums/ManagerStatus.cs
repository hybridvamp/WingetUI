namespace UniGetUI.PackageEngine.Classes.Manager.ManagerHelpers
{
    public struct ManagerStatus
    {
        public string Version = "";
        public bool Found = false;
        public string ExecutablePath = "";
        public string ExecutableCallArgs { get; set; } = "Unset";
        public ManagerStatus()
        { }
    }
}
