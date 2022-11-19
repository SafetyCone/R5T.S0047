using System;
using System.Threading.Tasks;

using Amazon.S3;

using R5T.F0074;
using R5T.T0132;


namespace R5T.S0047
{
	[FunctionalityMarker]
	public partial interface IS3Operations : IFunctionalityMarker,
		F0075.IS3Operations
	{
		public async Task CreatePublicBucket_ForDavid(
			string bucketName)
		{
			var s3BucketName = Instances.S3BucketNameOperator.ToS3BucketName(bucketName);

			var client = await this.GetS3Client_ForDavid();

			await this.CreatePublicBucket(
				client,
				s3BucketName);
		}

		public async Task<AmazonS3Client> GetS3Client_ForDavid()
		{
			var accessKeyFilePath = Instances.FilePaths.AwsAccessKeyFilePath_ForDavid;

			var client = await this.GetS3Client(
				accessKeyFilePath);

			return client;
		}

		public async Task UploadFile_ForDavid(
			string filePath,
			string bucketName,
			string key)
        {
			var s3BucketName = Instances.S3BucketNameOperator.ToS3BucketName(bucketName);

			var s3Key = Instances.S3ObjectKeyOperator.ToS3ObjectKey(key);

			var client = await this.GetS3Client_ForDavid();

			await this.UploadFile(
				client,
				s3BucketName,
				s3Key,
				filePath);
        }
	}
}