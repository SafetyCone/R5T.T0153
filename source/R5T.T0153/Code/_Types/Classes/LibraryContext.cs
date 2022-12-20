using System;

using R5T.T0142;


namespace R5T.T0153
{
    [DataTypeMarker]
    public class LibraryContext
    {
        public string LibraryName { get; set; }
        public string LibraryDescription { get; set; }


        public override string ToString()
        {
            var representation = LibraryOperator.Instance.GetLibraryContextRepresentation(this);
            return representation;
        }
    }
}
