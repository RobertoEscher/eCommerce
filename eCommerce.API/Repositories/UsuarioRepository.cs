using eCommerce.API.Database;
using eCommerce.Models;

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
            return _db.Usuarios.OrderBy(a => a.Id).ToList();
        }

        public Usuario Get(int id)
        {
            //return _db.Find(x => x.Id == id)!;
            return _db.Usuarios.Find(id)!;
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

            _db.Usuarios.Add(usuario);
            _db.SaveChanges();
        }

        public void Update(Usuario usuario)
        {
            //_db.Remove(Get(usuario.Id));
            //_db.Add(usuario);

            _db.Usuarios.Update(usuario);
            _db.SaveChanges();

        }

        public void Delete(int id)
        {
            //_db.Remove(Get(id));

            _db.Usuarios.Remove(Get(id));
            _db.SaveChanges();
        }
    }
}
