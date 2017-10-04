using ImageCalculator.Service.Models;

namespace ImageCalculator.Service.Calculators
{
    public interface ICalculator
    {
        VertexesResult Draw(int startRow);
    }
}
