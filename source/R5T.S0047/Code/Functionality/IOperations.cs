using System;
using System.Threading.Tasks;

using Amazon.S3;

using R5T.F0074;
using R5T.T0132;


namespace R5T.S0047
{
	[FunctionalityMarker]
	public partial interface IOperations : IFunctionalityMarker
	{
		public async Task CreatePublicBucket_ForDavid()
        {
			var bucketName = "public.bucket.8acc798b-9220-4d85-9a78-551f46ec1dd2";

			await Instances.S3Operations.CreatePublicBucket_ForDavid(
				bucketName);
		}

		public async Task UploadFile_ForDavid()
        {
			var filePath = @"C:\Users\David\Downloads\DALL·E 2022-11-01 10.54.50 - an oil painting of a computer singing a sea shanty.png";
			var bucketName = "public.bucket.8acc798b-9220-4d85-9a78-551f46ec1dd2";
			var key = "Blog-Technical/Articles/what-can-you-do-with-an-empty-service-provider/Images/main-image.png";

			await Instances.S3Operations.UploadFile_ForDavid(
				filePath,
				bucketName,
				key);
        }
	}
}