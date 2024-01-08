using SoapReference;
using System.Globalization;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void magicBtn_Click(object sender, EventArgs e)
        {
            ISoapService soapServiceChannel = new SoapServiceClient(SoapServiceClient.EndpointConfiguration.BasicHttpBinding_ISoapService_soap);
            float first = float.Parse(firstNumberInput.Text, CultureInfo.InvariantCulture.NumberFormat);
            float second = float.Parse(secondNumberInput.Text, CultureInfo.InvariantCulture.NumberFormat);
            var sumResponse = await soapServiceChannel.SumNumbersAsync(first, second);

            sumResult.Text = sumResponse.ToString();

            var multResponse = await soapServiceChannel.MultNumbersAsync(first, second);

            multResult.Text = multResponse.ToString();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
