using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;

namespace smart_tag.Controllers
{
    [ApiController]
    [Route("document")]
    public class DocumentController : ControllerBase
    {

        private readonly ILogger<DocumentController> _logger;

        public DocumentController(ILogger<DocumentController> logger)
        {
            _logger = logger;
        }
        /*

        [HttpGet]
        [SwaggerOperation(Tags = new[] { "Document" })]
        public IEnumerable<string> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => index.ToString()).ToArray();
        }

        [HttpPost]
        [SwaggerOperation(Tags = new[] { "Document" })]
        public IEnumerable<string> Post()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => index.ToString()).ToArray();
        }

        [HttpPatch("{document-id}")]
        [SwaggerOperation(Tags = new[] { "Document" })]
        public IEnumerable<string> Patch()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => index.ToString()).ToArray();
        }


        [HttpDelete("{document-id}")]
        [SwaggerOperation(Tags = new[] { "Document" })]
        public IEnumerable<string> Delete()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => index.ToString()).ToArray();
        }


        [HttpGet("{document-id}")]
        [SwaggerOperation(Tags = new[] { "Document" })]
        public IEnumerable<string> Document()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => index.ToString()).ToArray();
        }

        [HttpPost("{document-id}/check-out")]
        [SwaggerOperation(Tags = new[] { "Document" })]
        public IEnumerable<string> Checkout()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => index.ToString()).ToArray();
        }

        [HttpPost("{document-id}/check-in")]
        [SwaggerOperation(Tags = new[] { "Document" })]
        public IEnumerable<string> CheckIn()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => index.ToString()).ToArray();
        }

        [HttpGet("{document-id}/Preview/{page}")]
        [SwaggerOperation(Tags = new[] { "Document" })]
        public IEnumerable<string> Preview()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => index.ToString()).ToArray();
        }


        [HttpGet("{document-id}/Content")]
        [SwaggerOperation(Tags = new[] { "Document" })]
        public IEnumerable<string> Content()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => index.ToString()).ToArray();
        }




        [HttpGet("{document-id}/Security")]
        [SwaggerOperation(Tags = new[] { "Document" })]
        public IEnumerable<string> Security()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => index.ToString()).ToArray();
        }
*/
    }
}
