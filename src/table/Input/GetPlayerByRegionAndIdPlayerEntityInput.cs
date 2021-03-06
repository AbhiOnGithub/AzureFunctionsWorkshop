using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using AzureFunctions.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace AzureFunctions.Table.Input
{
    public static class GetPlayerByRegionAndIdPlayerEntityInput
    {
        [FunctionName(nameof(GetPlayerByRegionAndIdPlayerEntityInput))]
        public static IActionResult Run(
            [HttpTrigger(
                AuthorizationLevel.Function,
                nameof(HttpMethods.Get),
                Route = "GetPlayerByRegionAndIdTableInput/{region}/{id}")] HttpRequest request,
            string region,
            string id,
            [Table(
                TableConfig.Table,
                "{region}",
                "{id}")] PlayerEntity playerEntity)
        {
            return new OkObjectResult(playerEntity);
        }
    }
}
