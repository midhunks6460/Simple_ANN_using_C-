using ArtificialNeuralNetwork;
using ArtificialNeuralNetwork.Factories;
namespace ConsoleApp1
{
    class Example
    { 
        public static void Main(string[] args)
        {
            int ips = 3;
            int ops = 1;
            int hlayer = 1;
            int nhlayer = 5;

            INeuralNetwork network = NeuralNetworkFactory.GetInstance().Create(ips, ops, hlayer, nhlayer);

            double[] inputs = new double[] { 1.0, 2.5, 3.0 };
            network.SetInputs(inputs);
            network.Process();
            double[] outputs = network.GetOutputs();

            System.Diagnostics.Debug.WriteLine(outputs.Length);
        }
    }
}
