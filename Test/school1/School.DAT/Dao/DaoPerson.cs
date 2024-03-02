using School.DAL.Context;
using School.DAL.Entities;
using School.DAL.Exceptions;
using School.DAL.Interfaces;
using School.DAL.Enums;


namespace School.DAL.Dao
{
    public class DaoPerson : IDaoPerson
    {
        private readonly SchoolContext context;
        public DaoPerson(SchoolContext context)
        {
            this.context = context;
        }

        public bool ExtistsPerson(Func<Person, bool> filter)
        {
            return this.context.Persons.Any(filter);
        }

        public Person GetPerson(int Id)
        {
            return this.context.Persons.Find(Id);
        }

        public List<Person> GetPersons()
        {
            return this.context.Persons.ToList();
        }

        public List<Person> GetPersons(Func<Person, bool> filter)
        {
            return this.context.Persons.Where(filter).ToList();
        }

        public void RemovePerson(Person person)
        {
            Person personToRemove = this.GetPerson(person.PersonId);

            personToRemove.Deleted = person.Deleted;
            personToRemove.DeletedDate = person.DeletedDate;
            personToRemove.UserDeleted = person.UserDeleted;

            this.context.Persons.Update(personToRemove);

            this.context.SaveChanges();
        }

        public void SavePerson(Person person)
        {
            string message = string.Empty;

            if (!IsPersonValid(person, ref message, Operations.Save))
                throw new DaoCourseException(message);



            this.context.Persons.Add(person);
            this.context.SaveChanges();
        }

        public void UpdatePerson(Person person)
        {
            string message = string.Empty;

            if (!IsPersonValid(person, ref message, Operations.Update))
                throw new DaoPersonException(message);

            Person personToUpdate = this.GetPerson(person.PersonId);

            personToUpdate.ModifyDate = person.ModifyDate;
            personToUpdate.Name = person.Name;
            personToUpdate.UserMod = person.UserMod;

            this.context.Persons.Add(personToUpdate);
            this.context.SaveChanges();
        }
        private bool IsPersonValid(Person person, ref string message, Operations operations)
        {
            bool result = false;

            if (string.IsNullOrEmpty(person.LastName))
            {
                message = "El apellido del course es requerido.";
                return true;
            }
            if (person.LastName.Length > 50)
            {
                message = "El apellido es demaciado largo, El limite es 50 caracteres.";
                return true;
            }


            if (string.IsNullOrEmpty(person.FirstName))
            {
                message = "El nombre del course es requerido.";
                return true;
            }
            if (person.FirstName.Length > 50)
            {
                message = "El nombre es demaciado largo, El limite es 50 caracteres.";
                return true;
            }
            if (operations == Operations.Save)
            {
                if (this.ExtistsPerson(cd => cd.Title == person.Title))
                {
                    message = "El nombre ya existe.";
                    return true;
                }
            }
            else
                result = true;

            return result;
        }
    }
}
