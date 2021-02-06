using FitnessApp.BL.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace FitnessApp.BL.Controller
{
    /// <summary>
    /// Контроллер
    /// </summary>
    public class UserController
    {
        private User user;

        #region Свойства
        /// <summary>
        /// Пользователь
        /// </summary>
        public User User
        {
            get { return user; }
            private set { user = value; }
        }
        #endregion
        #region Конструктор

        /// <summary>
        /// Создание нового контроллера c имеющимися данными пользователя
        /// </summary>
        public UserController()
        {
            var fileUserFormatter = new BinaryFormatter();
            using (var fileStreamUser = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                if (fileUserFormatter.Deserialize(fileStreamUser) is User user)
                {
                    User = user;
                }
            }
        }
        /// <summary>
        /// Создание нового контроллера пользователя
        /// </summary>
        /// <param name="user">Пользователь</param>
        public UserController(string userName, string genderName, DateTime birthDay, double weight, double height)
        {

            var gender = new Gender(genderName);
            User = new User(userName, gender, birthDay, weight, height);
        }
        #endregion
        /// <summary>
        /// Сохрание данных о пользователях
        /// </summary>
        public void Save()
        {
            var fileUserFormatter = new BinaryFormatter();

            using (var fileStreamUser = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                fileUserFormatter.Serialize(fileStreamUser, User);
            }
        }
        /// <summary>
        /// Загрузка данных пользователя
        /// </summary>
        /// <returns>Данные пользователя</returns>







    }
}
