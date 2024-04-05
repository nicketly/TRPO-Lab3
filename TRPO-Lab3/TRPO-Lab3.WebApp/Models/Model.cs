namespace TRPO_Lab3.WebApp.Models
{
    public class Model
    {
        public double Length { get; set; }
        public double Height { get; set; }
        public double Volume { get; set; }
        public Model(double length, double height, double volume)
        {
            Length = length;
            Height = height;
            Volume = volume;
        }
    }
}
