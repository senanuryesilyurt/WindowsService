using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsService
{

    public class MessageService : IMessageService
    {
        private readonly IModel _model;
        public MessageService(IModel model)
        {
            _model = model;
        }

        //Random bir mesaj dönüyor.
        public string GetMessage()
        {
            Random random = new Random();
            int lngth = _model.ReturnData().Length;
            int no= random.Next(0,lngth);

            return _model.ReturnData().ElementAt(no);
        }
    }
}
