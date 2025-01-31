using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace postDataStorage
{
    public class funcaoPostDataStorage
    {
        private readonly ILogger<funcaoPostDataStorage> _logger;

        public funcaoPostDataStorage(ILogger<funcaoPostDataStorage> logger)
        {
            _logger = logger;
        }

        [Function("funcaoPostDataStorage")]
        public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "post")] HttpRequest req)
        {
            _logger.LogInformation("Processando o arquivo no storage.");

            if (!req.Headers.TryGetValue("file-type", out var fileTypeHeader))
            {
                return new BadRequestObjectResult("O cabeçalho 'file-type' é obrigatório.")
            }

            var fileType = fileTypeHeader.ToString();
            var form = await req.ReadFromAsync();
            var file = form.Files["file"];

            if (file == null || file.Length == 0)
            {
                return new BadRequestObjectResult("O arquivo não foi enviado.");
            }

            string connectionString = Environment.GetEnvironmentVariable("AzureWebJobsStorage");
            string containerName = fileType;
            BlobClient blobClient = new BlobClient(connectionString, containerName, file.FileName);
            BlobContainerClient containerClient = new BlobContainerClient(connectionString, containerName);

            await containerClient.CreateIfNotExistsAsync();
            await containerClient.SetAccessPolicyAsync(PublicAccessType.BlobContainer);

            string blobName = file.FileName;

            var blob = containerClient.GetBlobClient(blobName);

            using (var stream = file.OpenReadStream())
            {
                await blob.UploadAsync(stream, true);
            }

            _logger.LogInformation($"Arquivo {file.FileName} armazenado com sucesso.");
            
            return new OkObjectResult(new
            {
                Message = "Arquivo armazenado com sucesso.",
                BlobUri = blob.Uri
            });
        }
    }
}