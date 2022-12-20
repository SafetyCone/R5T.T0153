using System;


namespace R5T.T0153
{
    public class InstanceTypeContext
    {
        public string NamespaceName { get; set; }
        public string InterfaceTypeName { get; set; }
        public string ClassTypeName { get; set; }

        public string MarkerAttributeTypeName { get; set; }
        public string MarkerAttributeNamespaceName { get; set; }
        public string MarkerInterfaceTypeName { get; set; }
        public string MarkerInterfaceNamespaceName { get; set; }

        public string InterfaceCodeFilePath { get; set; }
        public string ClassCodeFilePath { get; set; }
    }
}
