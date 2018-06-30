namespace SRMQ
{
    public class MessageConfiguration
    {
        public MessageConfiguration()
        {
            RoutingKey = "SRMQ";
        }

        public string Message { get; set; }
        public string RoutingKey { get; set; }
    }
}
