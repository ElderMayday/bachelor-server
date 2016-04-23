using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Backend.Auxiliary;
using System.Globalization;
using UnityEngine;

namespace Assets.Backend.Deserializers
{
    /// <summary>
    /// Десериализатор собственного пакета
    /// </summary>
    public sealed class DeserializerCustom : Deserializer
    {
        /// <summary>
        /// Создает десериализатор собственного пакета
        /// </summary>
        public DeserializerCustom()
        {
            
        }

        /// <summary>
        /// Проводит десериалзиацию
        /// </summary>
        /// <param name="package">Содержимое пакета</param>
        /// <returns>Структура из трех величин</returns>
        public override Vector3d Do(string package)
        {
            string sub = "";
            Vector3d result = new Vector3d();

            int index1 = 0;
            int index2 = package.LastIndexOf('>');

            for (int i = index2 - 1; i >= 0; i--)
            {
                if (package[i] == '<')
                {
                    index1 = i;
                    break;
                }
            }

            if ((index1 != -1) && (index2 != -1) && (index2 >= index1))
                sub = package.Substring(index1 + 1, index2 - index1 - 1);
            else
                throw new ExceptionServer("Block borders are not found");

            string[] parameters = sub.Split(';');

            result.X = double.Parse(parameters[0].Replace(',', '.'), CultureInfo.InvariantCulture); // Pitch
            result.Y = double.Parse(parameters[1].Replace(',', '.'), CultureInfo.InvariantCulture); // Roll
            result.Z = double.Parse(parameters[2].Replace(',', '.'), CultureInfo.InvariantCulture); // Yaw

            return result;
        }
    }
}
