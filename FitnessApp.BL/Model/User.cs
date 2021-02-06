using System;


namespace FitnessApp.BL.Model
{
    [Serializable]
    /// <summary>
    /// Пользователь
    /// </summary>
    public class User
    {

        private string name;
        private Gender gender;
        private DateTime birthDate;
        private double weight;
        private double hieght;
        #region Свойства
        /// <summary>
        /// Имя
        /// </summary>
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }
        /// <summary>
        /// Пол
        /// </summary>
        public Gender Gender
        {
            get { return gender; }
            private set { gender = value; }
            
        }  
        /// <summary>
        /// Дата рожения
        /// </summary>
        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }
        /// <summary>
        /// Вес
        /// </summary>
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        /// <summary>
        /// Рост
        /// </summary>
        public double Hieght
        {
            get { return hieght; }
            private set { hieght = value; }
        }
        #endregion
        #region Конструктор
        /// <summary>
        /// Сконструировать нового пользователя
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="gender">Пол</param>
        /// <param name="birthDate">Дата рождения</param>
        /// <param name="weight">Вес</param>
        /// <param name="hieght">Рост</param>
        public User(string name, Gender gender, DateTime birthDate, double weight, double height) 
        { 
            if (String.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException($"Заполните поле имя {nameof(name)}");
            }
            Name = name;

            if (gender == null) 
            {
                throw new ArgumentNullException($"Заполните поле пола {nameof(gender)}");
            }
            Gender = gender;
            if (birthDate < DateTime.Parse("01.01.1920"))
            {
                throw new ArgumentNullException($"Дата меньше 01.01.1920 не может быть указана {nameof(name)}");
            }
            BirthDate = birthDate;
        }
        #endregion


    }
}
