using System;

namespace LibNoSourceAccess
{
    public class Beam
    {
        public int Width { get; set; }
        public int Length { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }

        public Beam() { }
        public Beam(int width, int length, int height, int weight)
        {
            this.Width = width;
            this.Length = length;
            this.Height = height;
            this.Weight = weight;
        }

        public override string ToString()
        {
            return $"Beam.\tWidth: {Width};\tLength: {Length};\tHeight: {Height},\tWeight {Weight}";
        }

    }
}
