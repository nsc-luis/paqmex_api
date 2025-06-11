using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
using PAQMEX_API.Models.PAQUETERIAPQ;
using System;
using System.Linq;

namespace PAQMEX_API.Data.PAQUETERIAPQ
{
    public class ListUsuarios
    {
        private readonly PaqueteriapqContext _context;
        public ListUsuarios(PaqueteriapqContext context)
        {
            _context = context;
        }

        public class objListaUsuarios
        {
            public int op { get; set; }
            public string CveUsuario { get; set; }
            public string Usuario { get; set; }
            public string Pasword { get; set; }
        }
        public class Usuarios
        {
            public TbUsuario TbUsuario { get; set; }
            public string Nom_Oficina { get; set; }
        }

        public List<Usuarios> ListUsuariosData(objListaUsuarios objUsuario)
        {         
            List<Usuarios> usuarios = new List<Usuarios>();
            List<TbUsuario> users = new List<TbUsuario>();
            switch (objUsuario.op)
            {
                case 1:
                    //select usu.* from tb_Usuario AS Usu (NOLOCK)
                    //where usu.Activo = 1
                    //AND NOT EXISTS(SELECT pr.CVE_PROGRAMA FROM TB_PRIVILEGIO as pr
                    //WHERE  pr.cve_rol =usu.cve_rol  and
                    //pr.cve_programa  IN (0,999))
                    //ORder by nom_usuario
                    users = (from usu in _context.TbUsuarios
                                where usu.Activo == true
                                && !_context.TbPrivilegios.Any(
                                    pr=>pr.CveRol == usu.CveRol 
                                    && (pr.CvePrograma == 0 || pr.CvePrograma == 999))
                                orderby usu.NomUsuario ascending
                                select usu).ToList();
                    foreach(TbUsuario u in users)
                    {
                        usuarios.Add(new Usuarios { TbUsuario = u, Nom_Oficina = "" });
                    }
                    
                    break;
                case 2:
                    users = _context.TbUsuarios.Where(u => u.Activo == true).ToList();
                    foreach (TbUsuario u in users)
                    {
                        usuarios.Add(new Usuarios { TbUsuario = u, Nom_Oficina = "" });
                    }
                    break;
                case 3:
                    //select usu.*, Ofi.desc_oficina as Nom_Oficina
                    //from tb_Usuario as Usu(NOLOCK), tb_Oficina as Ofi(nolock)
                    //where usu.cve_oficina = Ofi.Cve_Oficina
                    //and Usu.usuario = @usuario
                    //and Usu.pasword = @pasword and Usu.Activo = 1
                    var foo = (from usu in _context.TbUsuarios
                                join ofi in _context.TbOficinas on usu.CveOficina equals ofi.CveOficina
                                where usu.Usuario == objUsuario.Usuario && usu.Pasword == objUsuario.Pasword
                                select new
                                {
                                    usu,
                                    Nom_Oficina = ofi.DescOficina
                                }).ToList();
                    foreach (var u in foo)
                    {
                        usuarios.Add(new Usuarios { TbUsuario = u.usu, Nom_Oficina = u.Nom_Oficina });
                    }
                    break;
            }
            return usuarios;
        }
    }

}
