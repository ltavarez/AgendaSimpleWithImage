using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.PersistentHelper;
using Database.Modelos;

using Database;

namespace BusinessLayer
{
    public class ServicioPersona : IServicios<Persona>
    {
    
        private readonly PersonaRepository _repository;

        public ServicioPersona(SqlConnection connection)
        {
            _repository = new PersonaRepository(connection);
        }

        public bool Add(Persona item)
        {
            return _repository.Add(item);
        }

        public bool Edit(Persona item)
        {
            return _repository.Edit(item);
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }

        public Persona GetById(int id)
        {
            return _repository.GetById(id);
        }

        public DataTable GetAll()
        {
            return _repository.List();
        }

        public bool SavePhoto(int id, string destination)
        {
            return _repository.SavePhoto(id, destination);
        }

        public int GetLastId()
        {
            return _repository.GetLastId();
        }
    }
}
