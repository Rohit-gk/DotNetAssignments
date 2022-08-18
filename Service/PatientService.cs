using ApiCrudUsingGeneric.IService;
using ApiCrudUsingGeneric.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCrudUsingGeneric.Service
{
    public class PatientService : IGenericService<Patient>
    {
        List<Patient> _doctors = new List<Patient>();

        public PatientService()
        {
            for (int i = 1; i <= 9; i++)
            {
                _doctors.Add(new Patient()
                {
                    pid = i,
                    firstname = "Rohit" + i,
                    lastname = "Kalebag" + i,
                    age = 1 + i
                });
            }
        }
        public List<Patient> Delete(int id)
        {
            _doctors.RemoveAll(x => x.pid == id);
            return _doctors;
        }

        public List<Patient> GetAll()
        {
            return _doctors;
        }

        public Patient GetById(int id)
        {
            return _doctors.Where(x => x.pid == id).SingleOrDefault();
        }

        public List<Patient> Insert(Patient item)
        {
            _doctors.Add(item);
            return _doctors;
        }
    }
}
   
