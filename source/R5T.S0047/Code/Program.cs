using System;
using System.Threading.Tasks;


namespace R5T.S0047
{
    partial class Program
    {
        public async Task Run()
        {
            //await Instances.Operations.CreatePublicBucket_ForDavid();
            await Instances.Operations.UploadFile_ForDavid();
        }
    }
}