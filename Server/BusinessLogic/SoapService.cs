using System.ServiceModel;

namespace SoapInNetCore.BusinessLogic
{
    [ServiceContract]
    public interface ISoapService
    {
        [OperationContract]
        float SumNumbers(float first, float second);
        [OperationContract]
        float MultNumbers(float first, float second);
    }

    public class SoapService : ISoapService
    {
        public float SumNumbers(float first, float second)
        {
            return first + second;
        }

        public float MultNumbers(float first, float second)
        {
            return first * second;
        }
    }
}
