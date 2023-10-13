namespace ApiLayer.Security
{
    public class Token
    {
        public string AccessToken { get; set; }//Erişim Belirteci
        public string RefreshToken { get; set; } // ilgili token süresi bitiği zaman logine ynlendirmeden devam etirir
        public DateTime Expiration { get; set; } //Sona Erme
    }
}
