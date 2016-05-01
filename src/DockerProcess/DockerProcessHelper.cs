namespace com.smerkel.DockerProcess
{
    using System;
    using System.Diagnostics;

    internal static class DockerProcessHelper
    {
        public static TResult ExecuteDockerProcess<TResult>(
            this ProcessStartInfo dockerProcessStartInfo, 
            Func<string, TResult> parseProcessOutput, 
            Func<string, TResult> parseErrorOutput)
        {
            if (dockerProcessStartInfo == null)
                throw new ArgumentNullException(nameof(dockerProcessStartInfo));
            if (parseProcessOutput == null)
                throw new ArgumentNullException(nameof(parseProcessOutput));
            if (parseErrorOutput == null)
                throw new ArgumentNullException(nameof(parseErrorOutput));

            // settings
            dockerProcessStartInfo.RedirectStandardOutput = true;
            dockerProcessStartInfo.RedirectStandardError = true;

            // execute docker process
            using (var dockerProcess = Process.Start(dockerProcessStartInfo))
            {
                dockerProcess.WaitForExit();

                if (dockerProcess.ExitCode == 0)
                {
                    return parseProcessOutput(dockerProcess.StandardOutput.ReadToEnd());
                }
                else
                {
                    return parseErrorOutput(dockerProcess.StandardError.ReadToEnd());
                }
            }
        }
    }
}
