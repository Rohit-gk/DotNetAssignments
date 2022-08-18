using ApiCrudUsingGeneric.IService;
using ApiCrudUsingGeneric.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCrudUsingGeneric.Service
{
    public class DoctorService : IGenericService<Doctor>
    {
        List<Doctor> _doctors = new List<Doctor>();

        public DoctorService()
        {
            for(int i = 1; i <= 9; i++)
            {
                _doctors.Add(new Doctor()
                {
                    id = i,
                    firstname = "Rohit" + i,
                    lastname = "Kalebag" + i,
                    address = "pune" + i
                });
            }
        }   
        public List<Doctor> Delete(int id)
        {
            _doctors.RemoveAll(x => x.id == id);
            return _doctors;
        }

        public List<Doctor> GetAll()
        {
            return _doctors;
        }

        public Doctor GetById(int id)
        {
            return _doctors.Where(x => x.id == id).SingleOrDefault();
        }

        public List<Doctor> Insert(Doctor item)
        {
            _doctors.Add(item);
            return _doctors;
        }
    }
}
