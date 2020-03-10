using Swashbuckle.AspNetCore.Swagger;
using System;
using System.Collections.Generic;
using System.Text;

namespace Resurection
{
    public interface IDataRes
    {
        public void Send(string data);
    }
}
