using Assets.Backend.Auxiliary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Backend.Deserializers
{
    /// <summary>
    /// Абстрактный десериализатор для получения данных из сетевого пакета
    /// </summary>
    public abstract class Deserializer
    {
        /// <summary>
        /// Проводит десериалзиацию
        /// </summary>
        /// <param name="package">Содержимое пакета</param>
        /// <returns>Структура из трех величин</returns>
        public abstract Vector3 Do(string package); 
    }
}
