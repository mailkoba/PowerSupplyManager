
using System;

namespace PowerSupplyManager.Dto
{
    public class FloatValue
    {
        public FloatValue(int digitsCount)
        {
            _digitsCount = digitsCount;
        }

        public int Integer { get; set; }

        public int Divisional { get; set; }

        public float ToFloat()
        {
            return Integer + Divisional / (float) Math.Pow(10, _digitsCount);
        }

        public void SetValue(FloatValue value)
        {
            Integer = value.Integer;
            Divisional = value.Divisional;
        }

        private readonly int _digitsCount;
    }
}
