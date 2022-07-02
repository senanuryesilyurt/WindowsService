using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsService
{
    public class Model:IModel
    {
        public string[] ReturnData()
        {
            string[] messages = { "message1", "message2", "message3", "message4", "message5", "message6", "message7" };
            return messages;
        }
    }
}
