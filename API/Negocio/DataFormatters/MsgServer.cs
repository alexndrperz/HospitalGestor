using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.DataFormatters
{
    public class MsgServer
    {
        public int status { get; set; }
        public bool success { get; set; }
        public object data { get; set; }    

        public static MsgServer msgSuccess(object data, int status=200)
        {
            return new MsgServer() { status = status, data = data, success =true};
        }

        public static MsgServer msgError(int status, string msg)
        {
            return new MsgServer() { status = status, data = new { msg= msg}, success = false};

        }
    }
}
