namespace PAQMEX_API.Security
{
    public interface IAuthUrreaService
    {
        public bool IsUserValid(int cveCliente, string pwdInternet);
    }
}
