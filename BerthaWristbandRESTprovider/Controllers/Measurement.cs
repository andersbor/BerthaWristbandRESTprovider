namespace BerthaWristbandRESTprovider.Controllers
{
    public class Measurement
    {
        public int DeviceId { get; set; }
        public double Pm25 { get; set; }
        public double Pm10 { get; set; }
        public int Co2 { get; set; }
        public int O3 { get; set; }
        public double Pressure { get; set; }
        public double Temperature { get; set; }
        public double Humidity { get; set; }
    }
}
