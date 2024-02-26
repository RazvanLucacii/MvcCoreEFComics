#region

using System.Collections.Generic;

//create or replace procedure SP_INSERT_COMIC 
//(p_nombre COMICS.NOMBRE%TYPE, p_imagen COMICS.IMAGEN%TYPE, p_descripcion COMICS.DESCRIPCION%TYPE)
//as NEXTID COMICS.IDCOMIC%TYPE;
//begin
//    SELECT MAX(IDCOMIC) + 1 into NEXTID FROM COMICS;
//INSERT INTO COMICS VALUES (NEXTID, p_nombre, p_imagen, p_descripcion);
//COMMIT;
//end;


#endregion

namespace MvcCoreEFComics.Repositories
{
    public class RepositoryComicsOracle
    {

    }
}
