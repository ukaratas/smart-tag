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
    public class TagController : ControllerBase
    {

        private readonly ILogger<TagController> _logger;

        public TagController(ILogger<TagController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Retrieves queried tag(s) 
        /// </summary>
        /// <remarks>
        /// All registered tags are searched with using tag propeties, entity codes and entity instance id. 
        /// ## with tag-query can filter query with tag properties
        /// - with entity code filter tags used for specific type of entity. 
        /// - with instance id of tagged item,  directly filter items tags 
        /// </remarks>
        [SwaggerOperation(Tags = new[] { "Tag" })]
        [HttpGet()]
        public ResponsePage<Tag> Tags([FromQuery(Name = "tag-query")] string tagQuery, [FromQuery(Name = "entity-code")] string entityCode, [FromQuery(Name = "instance-id")] string instanceId, [FromQuery(Name = "page-index")] int pageIndex, [FromQuery(Name = "page-size")] int pageSize)
        {
            return new ResponsePage<Tag> { HasNextPage = true };
        }


        /// <summary>
        /// Creates new tag(s) 
        /// </summary>
        [SwaggerOperation(OperationId = "TagPost", Tags = new[] { "Tag" })]
        [HttpPost]
        public void Post([FromBody] IEnumerable<Tag> items)
        {

        }


        /// <summary>
        /// Updates existing tag 
        /// </summary>
        [SwaggerOperation(OperationId = "TagPathc", Tags = new[] { "Tag" })]
        [HttpPatch("{tag-code}")]
        public void Patch([FromRoute(Name = "tag-code")] string tagCode, [FromBody] TagPatch patch)
        {

        }


        /// <summary>
        /// Deletes existing tag 
        /// </summary>
        [SwaggerOperation(OperationId = "TagDelete", Tags = new[] { "Tag" })]
        [HttpDelete("{tag-code}")]
        public void Delete([FromRoute(Name = "tag-code")] string tagCode, [FromQuery(Name = "force-delete")] bool forceDelete = false)
        {
        }

        /// <summary>
        /// Returns tag usage statistics
        /// </summary>
        [SwaggerOperation(OperationId = "TagStatistics", Tags = new[] { "Tag" })]
        [HttpGet("{tag-code}/Statistics")]
        public TagStatistics Statistics()
        {

            return null;
        }
    }
}
