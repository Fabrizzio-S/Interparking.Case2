using Interparking.Case2.Contracts.Legacy;

namespace Interparking.Case2
{
    public class LegacyCode
    {
        public void ProcessMessage(object message)
        {
            if (message is MessageA)
            {
                var messageA = message as MessageA;
                messageA?.MyCustomMethodOnA();
            }
            else if (message is MessageB)
            {
                var messageB = message as MessageB;
                messageB?.MyCustomMethodOnB();
                messageB.SomeAdditionalMethodOnB();
            }
            else if (message is MessageC)
            {
                var messageC = message as MessageC;
                messageC?.MyCustomMethodOnC();
            }
        }
    }
}
