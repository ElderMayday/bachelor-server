


namespace Assets.Backend.Noisers
{
    /// <summary>
    /// Генератор нулевого шума
    /// </summary>
    public sealed class NoiserIdle : Noiser
    {
        /// <summary>
        /// Создает генератор нулевого шума
        /// </summary>
        public NoiserIdle()
        {

        }

        public override double Get()
        {
            return 0.0;
        }
    }
}
