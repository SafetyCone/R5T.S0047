using System;

using R5T.F0064;
using R5T.F0074;
using R5T.Z0017;


namespace R5T.S0047
{
    public static class Instances
    {
        public static IFilePaths FilePaths { get; } = Z0017.FilePaths.Instance;
        public static IOperations Operations { get; } = S0047.Operations.Instance;
        public static IS3BucketNameOperator S3BucketNameOperator { get; } = F0074.S3BucketNameOperator.Instance;
        public static IS3ObjectKeyOperator S3ObjectKeyOperator { get; } = F0074.S3ObjectKeyOperator.Instance;
        public static IS3Operations S3Operations { get; } = S0047.S3Operations.Instance;
        public static IServiceCollectionOperator ServiceCollectionOperator { get; } = F0064.ServiceCollectionOperator.Instance;
    }
}