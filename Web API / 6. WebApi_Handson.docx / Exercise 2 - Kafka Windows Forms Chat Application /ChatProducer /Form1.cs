using Confluent.Kafka;

namespace ChatProducer;

public partial class Form1 : Form
{
    private readonly IProducer<Null, string> producer;

    public Form1()
    {
        InitializeComponent();

        var config = new ProducerConfig
        {
            BootstrapServers = "localhost:9092"
        };

        producer = new ProducerBuilder<Null, string>(config).Build();
    }

    private async void btnSend_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtMessage.Text))
            return;

        await producer.ProduceAsync(
            "chat-message",
            new Message<Null, string>
            {
                Value = txtMessage.Text
            });

        MessageBox.Show("Message Sent");

        txtMessage.Clear();
    }
}
