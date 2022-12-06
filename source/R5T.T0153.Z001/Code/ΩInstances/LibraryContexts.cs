using System;


namespace R5T.T0153.Z001
{
	public class LibraryContexts : ILibraryContexts
	{
		#region Infrastructure

	    public static ILibraryContexts Instance { get; } = new LibraryContexts();

	    private LibraryContexts()
	    {
        }

	    #endregion
	}
}