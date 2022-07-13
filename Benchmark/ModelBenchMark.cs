using BenchmarkDotNet.Attributes;

namespace EstudosGerais.Benchmark
{
    public class ModelBenchMark
    {
        [Benchmark]
        public int QuantasVezes()
        {
            var total = 0;

            for (var i = 0; i < 100; i++)
            {
                total += i;
            }

            return total;
        }
    }
}
