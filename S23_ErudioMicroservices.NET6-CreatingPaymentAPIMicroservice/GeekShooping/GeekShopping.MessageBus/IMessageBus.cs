using System.Threading.Tasks;

namespace GeekShopping.MessageBus
{
    public interface IMessageBus
    {
        Task PublicMessage(BaseMessage message, string queueName);
    }
}
