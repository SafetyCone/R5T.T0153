using System;

using R5T.T0142;


namespace R5T.T0153
{
    [DataTypeMarker]
    public class SolutionContext :
        IHasSolutionFilePath,
        IHasSolutionDirectoryPath
    {
        public string SolutionName { get; set; }
        public string SolutionDescription { get; set; }
        public string SolutionFilePath { get; set; }
        public string SolutionDirectoryPath { get; set; }
    }
}

namespace R5T.T0153.N001
{
    [DataTypeMarker]
    public class SolutionContext :
        IHasSolutionFilePath,
        IHasSolutionDirectoryPath
    {
        public string SolutionFilePath { get; set; }
        public string SolutionDirectoryPath { get; set; }
    }
}



namespace R5T.T0153.N003
{
    [DataTypeMarker]
    public class SolutionContext :
        IHasSolutionFilePath,
        IHasSolutionDirectoryPath
    {
        public string SolutionName { get; set; }
        public string UnadjustedSolutionName { get; set; }
        public string PrivacyAdjustedSolutionName { get; set; }
        public string SolutionDescription { get; set; }
        public string SolutionFilePath { get; set; }
        public string SolutionDirectoryPath { get; set; }
    }
}
