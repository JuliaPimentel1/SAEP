
using ClinicaVet.Services;
using Microsoft.AspNetCore.DataProtection;
using Xunit;

namespace ClinicaVet.Tests
{
    public class CpfCriptoTests
    {
        [Fact]
        public void DeveCriptografarEDescriptografarCpf()
        {
            var provider = DataProtectionProvider.Create("ClinicaVet.Tests");
            var servico = new CpfCripto(provider);

            string cpfOriginal = "12345678900";

            string cpfCriptografado = servico.Criptografar(cpfOriginal);
            string cpfDescriptografado = servico.Descriptografar(cpfCriptografado);

            Assert.NotEqual(cpfOriginal, cpfCriptografado);
            Assert.Equal(cpfOriginal, cpfDescriptografado);
        }
    }
}
