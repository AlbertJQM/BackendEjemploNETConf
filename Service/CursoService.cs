using DB.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class CursoService : IService<Curso>
    {
        private readonly CursoRepository _cursoRepository;

        public CursoService(CursoRepository cursoRepository)
        {
            _cursoRepository = cursoRepository;
        }
        public Task<Curso> Create(Curso entity)
        {
            return _cursoRepository.Create(entity);
        }

        public Task<Curso> Delete(int id)
        {
            return _cursoRepository.Delete(id);
        }

        public Task<List<Curso>> GetAll()
        {
            return _cursoRepository.GetAll();
        }

        public Task<Curso> GetById(int id)
        {
            return _cursoRepository.GetByID(id);
        }

        public Task<Curso> Update(Curso entity)
        {
            return _cursoRepository.Update(entity);
        }
    }
}
