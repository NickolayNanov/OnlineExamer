namespace OnlineExamer.Client.Infrastructure.LocalStorage
{
    public class ChangingEventArgs : ChangedEventArgs
    {
        public bool Cancel { get; set; }
    }
}
