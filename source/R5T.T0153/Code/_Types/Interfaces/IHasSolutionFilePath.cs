using System;

using R5T.T0142;


namespace R5T.T0153
{
    [DataTypeMarker]
    public interface IHasSolutionFilePath
    {
        public string SolutionFilePath { get; set; }
    }
}
