using System;

using R5T.T0132;


namespace R5T.T0153
{
	[FunctionalityMarker]
	public partial interface ILibraryOperator : IFunctionalityMarker
	{
		public string GetLibraryContextRepresentation(
			LibraryContext libraryContext)
		{
			var representation = $"{libraryContext.LibraryName}: {libraryContext.LibraryDescription}";
			return representation;
        }
	}
}