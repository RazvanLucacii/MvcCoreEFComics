using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MvcCoreEFComics.Data;
using MvcCoreEFComics.Models;

#region PROCEDURES

//create procedure SP_INSERT_COMIC
//(@NOMBRE NVARCHAR(50), @IMAGEN NVARCHAR(50), @DESCRIPCION NVARCHAR(50))
//as
//	declare @NEXTID int
//	select @NEXTID = MAX(IDCOMIC) + 1 from COMICS
//	insert into COMICS values(@NEXTID, @NOMBRE, @IMAGEN, @DESCRIPCION)
//go

#endregion

namespace MvcCoreEFComics.Repositories
{
    public class RepositoryComicsSQLServer : IRepositoryComics
    {
        private HospitalContext context;

        public RepositoryComicsSQLServer(HospitalContext context)
        {
            this.context = context;
        }

        public async Task<List<Comic>> GetComicsAsync()
        {
            var consulta = from datos in this.context.Comics
                           select datos;
            return await consulta.ToListAsync();
        }

       

        public void InsertComic(string nombre, string imagen, string descripcion)
        {
            string sql = "SP_INSERT_COMIC @NOMBRE, @IMAGEN, @DESCRIPCION";
            SqlParameter pamNombre = new SqlParameter("@NOMBRE", nombre);
            SqlParameter pamImagen = new SqlParameter("@IMAGEN", imagen);
            SqlParameter pamDescripcion = new SqlParameter("@DESCRIPCION", descripcion);
            this.context.Database.ExecuteSqlRaw(sql, pamNombre, pamImagen, pamDescripcion);
        }
        public void DeleteComic(int idComic)
        {
            string sql = "delete from COMICS where IDCOMIC=@idcomic";
            SqlParameter pamId = new SqlParameter("idcomic", idComic);
            this.context.Database.ExecuteSqlRaw(sql, pamId);
        }

        public Task<Comic> FindComicAsync(int idComic)
        {
            throw new NotImplementedException();
        }
    }
}
