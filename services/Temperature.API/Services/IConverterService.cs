using System;
using System.Threading.Tasks;

namespace Temperature.API.Services
{
    public interface IConverterService
    {
        Task<double> CentigradeToFahrenheit(double request);
        Task<double> CentigradeToKelvin(double request);

        Task<double> FahrenheitToCentigrade(double request);
        Task<double> FahrenheitToKelvin(double request);

        Task<double> KelvinToCentigrade(double request);
        Task<double> KelvinToFahrenheit(double request);
    }
}
