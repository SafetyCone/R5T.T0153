using System;

using R5T.T0142;


namespace R5T.T0153
{
    [DataTypeMarker]
    public interface IHasSolutionDirectoryPath
    {
        public string SolutionDirectoryPath { get; set; }
    }
}
