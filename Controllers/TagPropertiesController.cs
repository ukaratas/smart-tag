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
    [Route("tag")]
    public class TagPropertiesController : ControllerBase
    {

        private readonly ILogger<TagPropertiesController> _logger;

        public TagPropertiesController(ILogger<TagPropertiesController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Retrieves propresties of tag 
        /// </summary>
        [HttpGet("{tag-code}/Property")]
        [SwaggerOperation(Tags = new[] { "Tag - Properties" })]
        //[ProducesResponseType(typeof(IEnumerable<FieldBase>), 200)]
        public IEnumerable<FieldBase> Properties()
        {

            return null;
        }

        [HttpPost("{tag-code}/Property")]
        [SwaggerOperation(Tags = new[] { "Tag - Properties" })]
        public IEnumerable<string> PostProperty()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => index.ToString()).ToArray();
        }


        [HttpPatch("{tag-code}/Property/{property-code}")]
        [SwaggerOperation(Tags = new[] { "Tag - Properties" })]
        public IEnumerable<string> PatchProperty()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => index.ToString()).ToArray();
        }

        [HttpDelete("{tag-code}/Property/{property-code}")]
        [SwaggerOperation(Tags = new[] { "Tag - Properties" })]
        public IEnumerable<string> DeleteProperty()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => index.ToString()).ToArray();
        }

    }
}
