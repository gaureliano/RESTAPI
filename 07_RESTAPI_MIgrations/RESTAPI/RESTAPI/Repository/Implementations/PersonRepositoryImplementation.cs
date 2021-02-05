﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using RESTAPI.Business;
using RESTAPI.Controllers.Model;
using RESTAPI.Model.Context;

namespace RESTAPI.Repository.Implementations
{
    public class PersonRepositoryImplementation : IPersonRepository
    {
        private MySQLContext _context;
        private long id;

        public PersonRepositoryImplementation(MySQLContext context)
        {
            _context = context;
        }

        public Person Create(Person person)
        {
            try
            {
                _context.Add(person);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            return person;
        }

        public void Delete(long id)
        {
            var result = _context.Persons.SingleOrDefault(p => p.ID.Equals(id));

            if (result != null)
            {
                try
                {
                    _context.Persons.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public List<Person> FindAll()
        {
            return _context.Persons.ToList();
        }

        public Person FindByID(long id)
        {
            return _context.Persons.SingleOrDefault(p => p.ID.Equals(id));
        }

        public Person Update(Person person)
        {
            if (!Exists(person.ID)) return new Person();

            var result = _context.Persons.SingleOrDefault(p => p.ID.Equals(id));

            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(person);
                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return person;
        }

        public bool Exists(long id)
        {
            return _context.Persons.Any(p => p.ID.Equals(id));
        }

    }
}
