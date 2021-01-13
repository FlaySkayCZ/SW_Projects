using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_Cviko2
{

    [Serializable]
    public class MyGenericException : Exception
    {
        public MyGenericException() { }
        public MyGenericException(string message) : base(message) { }
        public MyGenericException(string message, Exception inner) : base(message, inner) { }
        protected MyGenericException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    [Serializable]
    public class MyOtherEx : Exception
    {
        public MyOtherEx() { }
        public MyOtherEx(string message) : base(message) { }
        public MyOtherEx(string message, Exception inner) : base(message, inner) { }
        protected MyOtherEx(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

}
