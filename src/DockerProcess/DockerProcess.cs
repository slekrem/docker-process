namespace com.smerkel.DockerProcess
{
    using System;
    using IDockerProcess;
    using IDockerProcess.Models;
    using IDockerProcess.Results;
    using System.Diagnostics;

    public class DockerProcess : IDockerProcess
    {
        private readonly ProcessStartInfo _dockerProcessStartInfo;

        public DockerProcess()
        {
            _dockerProcessStartInfo = new ProcessStartInfo("docker.exe")
            {
                RedirectStandardError = true,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                UseShellExecute = false
            };
        }

        public IDockerProcesseResult Attach(IDockerProcesseModel dockerProcesseModel)
        {
            throw new NotImplementedException();
        }

        public IDockerProcesseResult Build(IDockerProcesseModel dockerProcesseModel)
        {
            throw new NotImplementedException();
        }

        public IDockerProcesseResult Commit(IDockerProcesseModel dockerProcesseModel)
        {
            throw new NotImplementedException();
        }

        public IDockerProcesseResult CopyFiles(IDockerProcesseModel dockerProcesseModel)
        {
            throw new NotImplementedException();
        }

        public IDockerProcesseResult Create(IDockerProcesseModel dockerProcesseModel)
        {
            throw new NotImplementedException();
        }

        public IDockerProcesseResult Diff(IDockerProcesseModel dockerProcesseModel)
        {
            throw new NotImplementedException();
        }

        public IDockerProcesseResult Events(IDockerProcesseModel dockerProcesseModel)
        {
            throw new NotImplementedException();
        }

        public IDockerProcesseResult Exec(IDockerProcesseModel dockerProcesseModel)
        {
            throw new NotImplementedException();
        }

        public IDockerProcesseResult Export(IDockerProcesseModel dockerProcesseModel)
        {
            throw new NotImplementedException();
        }

        public IDockerProcesseResult History(IDockerProcesseModel dockerProcesseModel)
        {
            throw new NotImplementedException();
        }

        public IDockerProcesseResult Images(IDockerProcesseModel dockerProcesseModel)
        {
            _dockerProcessStartInfo.Arguments = "images";

            return _dockerProcessStartInfo.ExecuteDockerProcess(
                output => output.ParseImagesOutput(),
                errorOutput => errorOutput.ParseErrorOutput()
                );
        }

        public IDockerProcesseResult Import(IDockerProcesseModel dockerProcesseModel)
        {
            throw new NotImplementedException();
        }

        public IDockerProcesseResult Info(IDockerProcesseModel dockerProcesseModel)
        {
            using(var process = Process.Start(_dockerProcessStartInfo))
            {
                process.WaitForExit();
            }

            throw new NotImplementedException();
        }

        public IDockerProcesseResult Inspect(IDockerProcesseModel dockerProcesseModel)
        {
            throw new NotImplementedException();
        }

        public IDockerProcesseResult Kill(IDockerProcesseModel dockerProcesseModel)
        {
            throw new NotImplementedException();
        }

        public IDockerProcesseResult ListContainers(IDockerProcesseModel dockerProcesseModel)
        {
            throw new NotImplementedException();
        }

        public IDockerProcesseResult Load(IDockerProcesseModel dockerProcesseModel)
        {
            throw new NotImplementedException();
        }

        public IDockerProcesseResult Login(IDockerProcesseModel dockerProcesseModel)
        {
            throw new NotImplementedException();
        }

        public IDockerProcesseResult Logout(IDockerProcesseModel dockerProcesseModel)
        {
            throw new NotImplementedException();
        }

        public IDockerProcesseResult Logs(IDockerProcesseModel dockerProcesseModel)
        {
            throw new NotImplementedException();
        }

        public IDockerProcesseResult Pause(IDockerProcesseModel dockerProcesseModel)
        {
            throw new NotImplementedException();
        }

        public IDockerProcesseResult Port(IDockerProcesseModel dockerProcesseModel)
        {
            throw new NotImplementedException();
        }

        public IDockerProcesseResult Pull(IDockerProcesseModel dockerProcesseModel)
        {
            throw new NotImplementedException();
        }

        public IDockerProcesseResult Push(IDockerProcesseModel dockerProcesseModel)
        {
            throw new NotImplementedException();
        }

        public IDockerProcesseResult RemoveContainers(IDockerProcesseModel dockerProcesseModel)
        {
            throw new NotImplementedException();
        }

        public IDockerProcesseResult RemoveImages(IDockerProcesseModel dockerProcesseModel)
        {
            throw new NotImplementedException();
        }

        public IDockerProcesseResult Rename(IDockerProcesseModel dockerProcesseModel)
        {
            throw new NotImplementedException();
        }

        public IDockerProcesseResult Restart(IDockerProcesseModel dockerProcesseModel)
        {
            throw new NotImplementedException();
        }

        public IDockerProcesseResult Run(IDockerProcesseModel dockerProcesseModel)
        {
            throw new NotImplementedException();
        }

        public IDockerProcesseResult Save(IDockerProcesseModel dockerProcesseModel)
        {
            throw new NotImplementedException();
        }

        public IDockerProcesseResult Search(IDockerProcesseModel dockerProcesseModel)
        {
            throw new NotImplementedException();
        }

        public IDockerProcesseResult Start(IDockerProcesseModel dockerProcesseModel)
        {
            throw new NotImplementedException();
        }

        public IDockerProcesseResult Stats(IDockerProcesseModel dockerProcesseModel)
        {
            throw new NotImplementedException();
        }

        public IDockerProcesseResult Stop(IDockerProcesseModel dockerProcesseModel)
        {
            throw new NotImplementedException();
        }

        public IDockerProcesseResult Tag(IDockerProcesseModel dockerProcesseModel)
        {
            throw new NotImplementedException();
        }

        public IDockerProcesseResult Top(IDockerProcesseModel dockerProcesseModel)
        {
            throw new NotImplementedException();
        }

        public IDockerProcesseResult Unpause(IDockerProcesseModel dockerProcesseModel)
        {
            throw new NotImplementedException();
        }

        public IDockerProcesseResult Version(IDockerProcesseModel dockerProcesseModel)
        {
            throw new NotImplementedException();
        }

        public IDockerProcesseResult Wait(IDockerProcesseModel dockerProcesseModel)
        {
            throw new NotImplementedException();
        }
    }
}
