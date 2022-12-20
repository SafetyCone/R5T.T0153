using System;

using R5T.T0142;


namespace R5T.T0153
{
    [DataTypeMarker]
    public class RazorComponentContext
    {
        public string Name { get; set; }
        public string NamespaceName { get; set; }
        public string RazorFilePath { get; set; }
        public string CodeBehindFilePath { get; set; }
    }
}
