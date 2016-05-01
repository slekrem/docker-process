namespace com.smerkel.DockerProcess
{
    using IDockerProcess.Results;
    using System;

    internal static class ParseDockerProcessOutput
    {
        public static IDockerProcesseResult ParseImagesOutput(this string dockerImagesOutput)
        {
            if (string.IsNullOrWhiteSpace(dockerImagesOutput))
                throw new ArgumentException(nameof(dockerImagesOutput) + " is null or white space");



            throw new NotImplementedException();
        }

        public static IDockerProcesseResult ParseErrorOutput(this string errorOutput)
        {
            throw new NotImplementedException();
        }
    }
}
