


namespace Assets.Backend.Noisers
{
    /// <summary>
    /// Генератор нулевого шума
    /// </summary>
    public sealed class NoiserIdle : Noiser
    {
        public override double Get()
        {
            return 0.0;
        }
    }
}
