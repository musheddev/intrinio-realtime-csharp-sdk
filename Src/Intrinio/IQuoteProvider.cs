namespace Intrinio
{
    public interface IQuoteProvider
    {
        string AuthURL();
        string MakeWebSocketUrl(string Token);
    }
}