namespace TRPO_Lab3.WebApp.Models
{
    public class CustomModel
    {
        public double Length { get; set; }
        public double Height { get; set; }
        public double Volume { get; set; }
        public CustomModel(double length, double height, double volume)
        {
            Length = length;
            Height = height;
            Volume = volume;
        }
    }
}
