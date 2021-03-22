using System.Data.Entity;

namespace BL.Lacteos
{
    class DatosdeInicio: CreateDatabaseIfNotExists<Contexto>

    {
        protected override void Seed(Contexto contexto)
        {
            var usuarioAdmin = new Usuario();
            usuarioAdmin.Nombre = "admin";
            usuarioAdmin.Contrasena = "123";

            contexto.Usuarios.Add(usuarioAdmin);

            var categoria1 = new Categoria();
            categoria1.Descripcion = "Categoria 1";
            contexto.Categorias.Add(categoria1);


            var categoria2 = new Categoria();
            categoria2.Descripcion = "Categoria 2";
            contexto.Categorias.Add(categoria2);

            var tipo1 = new Tipo();
            tipo1.Descripcion = "Tipo 1";
            contexto.Tipos.Add(tipo1);

            var tipo2 = new Tipo();
            tipo2.Descripcion = "Tipo 2";
            contexto.Tipos.Add(tipo2);

            base.Seed(contexto);

        }
    }
}