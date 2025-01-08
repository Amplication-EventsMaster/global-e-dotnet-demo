using Microsoft.Extensions.DependencyInjection;
using Service_2.Brokers.Infrastructure;
using Service_2.Brokers.Kafka;

namespace Service_2.Brokers.Kafka;

public class KafkaConsumerService : KafkaConsumerService<KafkaMessageHandlersController>
{
    public KafkaConsumerService(IServiceScopeFactory serviceScopeFactory, KafkaOptions kafkaOptions)
        : base(serviceScopeFactory, kafkaOptions) { }
}
