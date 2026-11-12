using Microsoft.AspNetCore.DataProtection;

namespace ClinicaVet.Services
{
    public class CpfCripto : ICpfCripto
    {
        private readonly IDataProtector _protector;

        public CpfCripto(IDataProtectionProvider provider)
        {
            _protector = provider.CreateProtector("ClinicaVet.Cpf");
        }

        public string Criptografar(string cpf)
        {
            return _protector.Protect(cpf);
        }

        public string Descriptografar(string cpfCriptografado)
        {
            return _protector.Unprotect(cpfCriptografado);
        }
    }
}
