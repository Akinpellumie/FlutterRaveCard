using Rave.NET.API;

namespace Rave.Models.Card
{
    public class ChargeRes<T> : RaveResponse<T> where T : ResponseData
    {
        public override T Data { get ;  set ; }
    }
}
