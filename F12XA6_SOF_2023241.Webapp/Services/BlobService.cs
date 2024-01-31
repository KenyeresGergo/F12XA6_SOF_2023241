using Azure;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading.Tasks;
namespace F12XA6_SOF_2023241.Webapp.Services
{
    

    public class BlobService
    {
        private readonly BlobServiceClient _blobServiceClient;
        private readonly string _containerName;

        public BlobService()
        {
            _blobServiceClient = new BlobServiceClient("DefaultEndpointsProtocol=https;AccountName=soffelevesblob;AccountKey=U3SfdnU9DAurp0nHGTTpKWaEoKGGw4UqhYyiTHoI6WPVmtbpvSwtodbnpGr+1dJrOpRWYXPyQ3lv+AStdV2VQg==;EndpointSuffix=core.windows.net");
            _containerName = "logosblob";
        }

        public async Task UploadSvgToBlobStorageAsync(IFormFile file)
        {
            var blobContainerClient = _blobServiceClient.GetBlobContainerClient(_containerName);

            // Create the container if it doesn't exist
            await blobContainerClient.CreateIfNotExistsAsync();

            // Get a reference to the blob
            var blobName = $"{file.FileName}";
            var blobClient = blobContainerClient.GetBlobClient(blobName);

            // Upload the file to the blob
            using (var stream = file.OpenReadStream())
            {
                await blobClient.UploadAsync(stream, true);
            }
        }
    }
}
