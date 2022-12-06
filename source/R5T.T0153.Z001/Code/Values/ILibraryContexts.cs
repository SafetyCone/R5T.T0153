using System;

using R5T.T0131;


namespace R5T.T0153.Z001
{
	[ValuesMarker]
	public partial interface ILibraryContexts : IValuesMarker
	{
		public LibraryContext Example => new LibraryContext
		{
			LibraryName = Z0023.LibraryNames.Instance.Example,
			LibraryDescription = Z0023.LibraryDescriptions.Instance.Example,
		};
	}
}