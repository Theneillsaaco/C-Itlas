

namespace School.DAL.core
{
    public abstract class PersonBase : BaseEntity
    {
        public string Title
        {
            get { return Title; }
            set
            {
                if (value.Length <= 100)
                {
                    Title = value;
                }
                else
                {
                    throw new ArgumentException("El titulo no puede ser mas largo de 100 caracteres.");
                }
            }
        }
    
        public string Name
        {
            get { return Name; }
            set
            {
                if (value.Length <= 50)
                {
                    Name = value;
                }
                else
                {
                    throw new ArgumentException("El nombre no puede ser mas largo de 50 caracteres.");
                }
            }
        }
        public string LastName
        {
            get { return LastName; }
            set
            {
                if (value.Length <= 50)
                {
                    LastName = value;
                }
                else
                {
                    throw new ArgumentException("El apellido no puede ser mas largo de 50 caracteres.");
                }
            }
        }
        public string FirstName { 
            get { return FirstName; } 
            set {
            if (value.Length <= 50)
                    {
                    FirstName = value;
                }
            else
                {
                    throw new ArgumentException("El nombre no puede ser mas largo de 50 caracteres.");
                }
            } 
        }
    }
}
