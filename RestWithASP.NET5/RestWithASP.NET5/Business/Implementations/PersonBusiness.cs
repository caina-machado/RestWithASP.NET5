using RestWithASP.NET5.Data.Converter.Implementation;
using RestWithASP.NET5.Data.VO;
using RestWithASP.NET5.Model;
using RestWithASP.NET5.Repositories;
using System.Collections.Generic;

namespace RestWithASP.NET5.Business.Implementations
{
    public class PersonBusiness : IPersonBusiness
    {
        private readonly IRepository<Person> _personRepository;
        private readonly PersonConverter _converter;

        public PersonBusiness(IRepository<Person> personRepository)
        {
            _personRepository = personRepository;
            _converter = new PersonConverter();
        }

        public List<PersonVO> FindAll()
        {
            return _converter.Parse(_personRepository.FindAll());
        }

        public PersonVO FindById(long id)
        {
            return _converter.Parse(_personRepository.FindById(id));
        }

        public PersonVO Create(PersonVO person)
        {
            var personEntity = _converter.Parse(person);
            personEntity = _personRepository.Create(personEntity);
            return _converter.Parse(personEntity);
        }

        public PersonVO Update(PersonVO person)
        {
            var personEntity = _converter.Parse(person);
            personEntity = _personRepository.Update(personEntity);
            return _converter.Parse(personEntity);
        }

        public void Delete(long id)
        {
            _personRepository.Delete(id);
        }
    }
}
