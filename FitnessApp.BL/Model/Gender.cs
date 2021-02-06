using System;


namespace FitnessApp.BL.Model
{
    [Serializable]
    /// <summary>
    /// Пол
    /// </summary>
    public class Gender
    {
        private string name;
        /// <summary>
        /// Название
        /// </summary>
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        /// <summary>
        /// Сконструировать новый пол
        /// </summary>
        /// <param name="name">Название</param>
        public Gender(string name)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException($"Заполните поле пола {nameof(name)}");
            }
            Name = name;
        }

        /// <summary>
        /// Вывод параметра Name
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Name;
        }
    }
}
