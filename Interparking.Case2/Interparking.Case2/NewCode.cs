using Interparking.Case2.Contracts.Interfaces;

namespace Interparking.Case2
{
    public class NewCode
    {
        public void ProcessMessage(IMessage message)
        {
            message.Execute();
        }
    }
}
