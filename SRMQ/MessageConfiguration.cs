namespace SRMQ
{
    public class MessageConfiguration
    {
        public MessageConfiguration()
        {
            RoutingKey = "Cimplx";
        }

        public string Message { get; set; }
        public string RoutingKey { get; set; }
    }
}
