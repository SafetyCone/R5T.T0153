using System;


namespace R5T.T0153
{
	public class LibraryOperator : ILibraryOperator
	{
		#region Infrastructure

	    public static ILibraryOperator Instance { get; } = new LibraryOperator();

	    private LibraryOperator()
	    {
        }

	    #endregion
	}
}