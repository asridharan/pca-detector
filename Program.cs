using Accord.Controls;
using Accord.IO;
using Accord.Math;
using Accord.Statistics.Analysis;

namespace pca_detector
{
    class Program
    {
        static void Main(string[] args)
        {
            double[][] matrix = {
    new double[] { 1, 2 },
    new double[] { 3, 4 },
    new double[] { 5, 6 },
};
            PrincipalComponentAnalysis pca = new PrincipalComponentAnalysis(PrincipalComponentMethod.Center);

            pca.Learn(matrix);

        }
    }
}
