using eCommerce.API.Database;
using eCommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.API.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly eCommerceContext _db;

        public UsuarioRepository(eCommerceContext db)
        {
            _db = db;
        }

        //public static List<Usuario> _db = new List<Usuario>();

        public List<Usuario> Get()
        {
            //return _db;
            return _db.Usuarios.Include(a => a.Contato).OrderBy(a => a.Id).ToList();
        }

        public Usuario Get(int id)
        {
            //return _db.Find(x => x.Id == id)!;
            return _db.Usuarios.Include(a => a.Contato).Include(a => a.EnderecosEntrega).Include(a => a.Departamentos).FirstOrDefault(a => a.Id == id)!;
        }

        public void Add(Usuario usuario)
        {
            /* Unit of Works

                // Memory - EF Core
                _db.Add(usuario);
                _db.Add(usuario);
                _db.Add(usuario);
                _db.Remove(Get(usuario.Id));

                // Memory > SGBD
                _db.SaveChanges();

            */

            //_db.Add(usuario);

            CriarVinculodoUsuarioComDepartamento(usuario);

            _db.Usuarios.Add(usuario);
            _db.SaveChanges();
        }



        public void Update(Usuario usuario)
        {
            //_db.Remove(Get(usuario.Id));
            //_db.Add(usuario);

            //TODO - Excluir os vínculos do Usuário com o Departamento
            EcluirVinculoDoUsuarioComDepartamento(usuario);

            //TODO - Criar vínculos e criar Departamentos se necessário
            CriarVinculodoUsuarioComDepartamento(usuario);

            _db.Usuarios.Update(usuario);
            _db.SaveChanges();

        }



        public void Delete(int id)
        {
            //_db.Remove(Get(id));

            _db.Usuarios.Remove(Get(id));
            _db.SaveChanges();
        }

        private void CriarVinculodoUsuarioComDepartamento(Usuario usuario)
        {
            if (usuario.Departamentos != null)
            {
                var departamentos = usuario.Departamentos;
                usuario.Departamentos = new List<Departamento>();

                foreach (var departamento in departamentos)
                {
                    if (departamento.Id > 0)
                    {
                        // Ref. Registro do Banco de Dados
                        usuario.Departamentos.Add(_db.Departamentos.Find(departamento.Id)!);
                    }
                    else
                    {
                        // Ref. Objeto novo que não existe no SGBD. (Novo registro de Departamentos)
                        usuario.Departamentos.Add(departamento);
                    }
                }
            }
        }

        private void EcluirVinculoDoUsuarioComDepartamento(Usuario usuario)
        {
            var usuarioDoBanco = _db.Usuarios.Include(a => a.Departamentos).FirstOrDefault(a => a.Id == usuario.Id);

            foreach (var departamento in usuarioDoBanco!.Departamentos!)
            {
                usuarioDoBanco.Departamentos.Remove(departamento);
            }

            _db.SaveChanges();
            _db.ChangeTracker.Clear();
        }
    }
}
