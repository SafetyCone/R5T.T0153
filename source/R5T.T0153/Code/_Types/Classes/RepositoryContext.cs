using System;

using R5T.T0142;


namespace R5T.T0153
{
    [DataTypeMarker]
    public class RepositoryContext
    {
        public string RepositoryName { get; set; }
        public string RepositoryDescription { get; set; }
        public bool IsPrivate { get; set; }
        public string LocalDirectoryPath { get; set; }
        public string RemoteUrl { get; set; }
    }
}


namespace R5T.T0153.N001
{
    [DataTypeMarker]
    public class RepositoryContext
    {
        public string RepositoryName { get; set; }
        public string RepositoryDescription { get; set; }
        public bool IsPrivate { get; set; }
    }
}


namespace R5T.T0153.N002
{
    [DataTypeMarker]
    public class RepositoryContext
    {
        public string LocalDirectoryPath { get; set; }
        public string RemoteUrl { get; set; }
    }
}


namespace R5T.T0153.N003
{
    [DataTypeMarker]
    public class RepositoryContext
    {
        public string RepositoryName { get; set; }
        public string UnadjustedRepositoryName { get; set; }
        public string PrivacyAdjustedRepositoryName { get; set; }
        public string RepositoryDescription { get; set; }
        public bool IsPrivate { get; set; }
    }
}


namespace R5T.T0153.N004
{
    [DataTypeMarker]
    public class RepositoryContext
    {
        public string RepositoryName { get; set; }
        public string UnadjustedRepositoryName { get; set; }
        public string PrivacyAdjustedRepositoryName { get; set; }
        public string RepositoryDescription { get; set; }
        public bool IsPrivate { get; set; }
        public string LocalDirectoryPath { get; set; }
    }
}


namespace R5T.T0153.N005
{
    [DataTypeMarker]
    public class RepositoryContext
    {
        public string RepositoryOwner { get; set; }
        public string RepositoryName { get; set; }
        public string UnadjustedRepositoryName { get; set; }
        public string PrivacyAdjustedRepositoryName { get; set; }
        public string RepositoryDescription { get; set; }
        public bool IsPrivate { get; set; }
        public string LocalDirectoryPath { get; set; }
    }
}


namespace R5T.T0153.N006
{
    [DataTypeMarker]
    public class RepositoryContext
    {
        public string RepositoryName { get; set; }
        public string UnadjustedRepositoryName { get; set; }
        public string PrivacyAdjustedRepositoryName { get; set; }
        public bool IsPrivate { get; set; }
    }
}