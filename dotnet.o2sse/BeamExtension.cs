using LibNoSourceAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet.o2sse
{
    public static class BeamExtension
    {
        public enum StackSide
        {
            Width,
            Length,
            Height
        }
        public static Beam Stack(this Beam beam1, Beam beam2, StackSide stackSide)
        {
            switch(stackSide)
            {
                case StackSide.Width:
                    return StackWidth(beam1, beam2);
                case StackSide.Length:
                    return StackLength(beam1, beam2);
                case StackSide.Height:
                    return StackHeight(beam1, beam2);
                default:
                    return null;
            }
        }

        public static Beam StackWidth(this Beam beam1, Beam beam2)
        {
            Beam beam3 = NewBeam(beam1, beam2);
            beam3.Width = beam1.Width + beam2.Width;
            beam3.Length = Math.Max(beam1.Length, beam2.Length);
            beam3.Height = Math.Max(beam1.Height, beam2.Height);
            return beam3;
        }

        public static Beam StackLength(this Beam beam1, Beam beam2)
        {
            Beam beam3 = NewBeam(beam1, beam2);
            beam3.Width = Math.Max(beam1.Width, beam2.Width);
            beam3.Length = beam1.Length + beam2.Length;
            beam3.Height = Math.Max(beam1.Height, beam2.Height);
            return beam3;
        }

        public static Beam StackHeight(this Beam beam1, Beam beam2)
        {
            Beam beam3 = NewBeam(beam1, beam2);
            beam3.Width = Math.Max(beam1.Width, beam2.Width);
            beam3.Length = Math.Max(beam1.Length, beam2.Length);
            beam3.Height = beam1.Height + beam2.Height;
            return beam3;
        }

        private static Beam NewBeam(Beam beam1, Beam beam2)
        {
            Beam beam3 = new Beam();
            beam3.Weight = beam1.Weight + beam2.Weight;
            return beam3;
        }
    }
}
