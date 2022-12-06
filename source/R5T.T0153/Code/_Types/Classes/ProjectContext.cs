using System;

using R5T.T0142;


namespace R5T.T0153
{
    [DataTypeMarker]
    public class ProjectContext
    {
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public string ProjectDefaultNamespaceName { get; set; }
        public string ProjectDirectoryPath { get; set; }
        public string ProjectFilePath { get; set; }
    }
}
