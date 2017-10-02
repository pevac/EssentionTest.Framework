using EssentionTest.Model;
using Essention.Text;
using System.IO;
using System;
using System.Web.Http;
using System.Web.Http.Cors;

namespace EssentionTest.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class TextSerializerController : ApiController
    {
        [HttpPost()]
        public IHttpActionResult SerializerText([FromBody]TextToSerializer value)
        {
            if (value.FormatType == "cvs")
            {
                var formatText = TextSerializer.SerializeToCvs(value.Text, value.SeparatorCvs);

                return Ok(new { formatText });
            }
            else if (value.FormatType == "xml")
            {
                var xmlText = TextSerializer.SerializeToXml(value.Text);

                var formatText = xmlText.Root.ToString();

                return Ok(new { formatText });
            }
            
            return BadRequest();
        }
    }
}
