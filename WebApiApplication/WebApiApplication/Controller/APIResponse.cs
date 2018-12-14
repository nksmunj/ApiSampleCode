using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleDiagnostics.Entity
{
    public class APIResponseEntity
    {
        public int success { get; set; }
        public object data { get; set; }
        public string message { get; set; }
    }

    public class APIResponse
    {
        public static APIResponseEntity Success(object data)
        {
            APIResponseEntity entity = new APIResponseEntity();
            try
            {
                entity.success = 1;
                entity.data = data;
                entity.message = "Success";
            }
            catch (Exception ex) { throw ex; }
            return entity;
        }

        public static APIResponseEntity Success()
        {
            APIResponseEntity entity = new APIResponseEntity();
            try
            {
                entity.success = 1;
                entity.data = string.Empty;
                entity.message = "Success";
            }
            catch (Exception ex) { throw ex; }
            return entity;
        }

        public static APIResponseEntity BadRequest(string message)
        {
            APIResponseEntity entity = new APIResponseEntity();
            try
            {
                List<string> empty = new List<string>();
                entity.success = 0;
                entity.data = empty;
                entity.message = message;
            }
            catch (Exception ex) { throw ex; }
            return entity;
        }
    }
}
