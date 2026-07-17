using Confluent.Kafka;

namespace ChatConsumer;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        Task.Run(ReadMessages);
    }

    private void ReadMessages()
    {
        var config = new ConsumerConfig
        {
            BootstrapServers = "localhost:9092",
            GroupId = "windows-chat",
            AutoOffsetReset = AutoOffsetReset.Earliest
        };

        using var consumer =
            new ConsumerBuilder<Ignore, string>(config).Build();

        consumer.Subscribe("chat-message");

        while (true)
        {
            var result = consumer.Consume();

            Invoke(() =>
            {
                lstMessages.Items.Add(result.Message.Value);
            });
        }
    }
}
