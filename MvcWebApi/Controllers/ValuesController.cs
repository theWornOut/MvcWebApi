using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcWebApi.Controllers
{
    //[Authorize]
    public class ValuesController : ApiController
    {
        static List<string> _valueList = new List<string>
        {
            "value0", "value1", "value2"
        };

        // GET api/values
        [HttpGet]
        public IEnumerable<string> ValueGet()
        {
            //return new string[] { "value1", "value2" };
            return _valueList;
        }

        // GET api/values/5
        [HttpGet]
        public string ValueGet(int id)
        {
            //return "value";
            return _valueList[id];
        }

        // POST api/values
        [HttpPost]
        public void ValuePost([FromBody]string value)
        {
            _valueList.Add(value);
        }

        // PUT api/values/5
        [HttpPut]
        public void ValuePut(int id, [FromBody]string value)
        {
            _valueList[id] = value;
        }

        // DELETE api/values/5
        [HttpDelete]
        public void ValueDelete(int id)
        {
            _valueList.RemoveAt(id);
        }
    }
}