using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Backend.Auxiliary;
using System.Globalization;

namespace Assets.Backend.Deserializers
{
    /// <summary>
    /// Абстрактный десериализатор для получения данных из сетевого пакета
    /// </summary>
    public sealed class DeserializerCustom : Deserializer
    {
        /// <summary>
        /// Проводит десериалзиацию
        /// </summary>
        /// <param name="package">Содержимое пакета</param>
        /// <returns>Структура из трех величин</returns>
        public override Vector3 Do(string package)
        {
            Vector3 result = new Vector3();

            int index1 = package.IndexOf('<');
            int index2 = package.IndexOf('>');

            if ((index1 != -1) && (index2 != -1) && (index2 >= index1))
                package = package.Substring(index1 + 1, index2 - index1 - 1);
            else
                throw new Exception("Block borders are not found");

            string[] parameters = package.Split(';');

            result.X = double.Parse(parameters[0], CultureInfo.InvariantCulture); // Pitch
            result.Y = double.Parse(parameters[1], CultureInfo.InvariantCulture); // Roll
            result.Z = double.Parse(parameters[2], CultureInfo.InvariantCulture); // Yaw

            return result;
        }
    }
}
