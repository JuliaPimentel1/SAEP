namespace ClinicaVet.Services
{
    public interface ICpfCripto
    {
        string Criptografar(string cpf);

        string Descriptografar(string cpfCriptografado);
    }
}
