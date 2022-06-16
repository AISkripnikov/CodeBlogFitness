using System;

namespace CodeBlogFitness.BL.Model
{
    /// <summary>
    /// Пол.
    /// </summary>


    public class Gender
    {
        private string name;

        /// <summary>
        /// Навзвание.
        /// </summary>

        public string Name { get; }

        /// <summary>
        /// Создать новый пол.
        /// </summary>
        /// <param name="name">Имя пола.</param>

        public Gender(string name)

        {
            if (stringIsNullOrWhriteSpace (name))
            {
                throw new ArumentNullException("Имя пола не может быть пустым или null", nameoff(name));
            }

            Name = name;
        }

        private object nameoff(string name)
        {
            throw new NotImplementedException();
        }

        private bool stringIsNullOrWhriteSpace(string name)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return name;
        }
    }
}
