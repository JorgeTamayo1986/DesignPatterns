namespace DesignPatterns
{
    public class Animal : ICloneable
    {
        public int Leg { get; set; }

        public string Name { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
