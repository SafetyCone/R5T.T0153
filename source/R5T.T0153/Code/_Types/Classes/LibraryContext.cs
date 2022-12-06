using System;


namespace R5T.T0153
{
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
