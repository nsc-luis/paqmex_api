using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
using PAQMEX_API.Models.PAQUETERIA;
using System;
using System.Linq;

namespace PAQMEX_API.Data.PAQUETERIA
{
    public class ListUsuarios1
    {
        private readonly PAQUETERIAContext _context;
        public ListUsuarios1(PAQUETERIAContext context)
        {
            _context = context;
        }

        public class objListaUsuarios1
        {
            public int op { get; set; }
            public string CveUsuario { get; set; }
            public string Usuario { get; set; }
            public string Pasword { get; set; }
        }
        public class Usuarios
        {
            public tb_usuario TbUsuario { get; set; }
            public string Nom_Oficina { get; set; }
        }

        public List<Usuarios> ListUsuariosData(objListaUsuarios1 objUsuario)
        {         
            List<Usuarios> usuarios = new List<Usuarios>();
            List<tb_usuario> users = new List<tb_usuario>();
            switch (objUsuario.op)
            {
                case 1:
                    //select usu.* from tb_Usuario AS Usu (NOLOCK)
                    //where usu.Activo = 1
                    //AND NOT EXISTS(SELECT pr.CVE_PROGRAMA FROM TB_PRIVILEGIO as pr
                    //WHERE  pr.cve_rol =usu.cve_rol  and
                    //pr.cve_programa  IN (0,999))
                    //ORder by nom_usuario
                    users = (from usu in _context.tb_usuarios
                             where usu.Activo == true
                                && !_context.tb_privilegios.Any(
                                    pr=>pr.cve_rol == usu.cve_rol 
                                    && (pr.cve_programa == 0 || pr.cve_programa == 999))
                                orderby usu.nom_usuario ascending
                                select usu).ToList();
                    foreach(tb_usuario u in users)
                    {
                        usuarios.Add(new Usuarios { TbUsuario = u, Nom_Oficina = "" });
                    }
                    
                    break;
                case 2:
                    users = _context.tb_usuarios.Where(u => u.Activo == true).ToList();
                    foreach (tb_usuario u in users)
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
                    var foo = (from usu in _context.tb_usuarios
                                join ofi in _context.tb_Oficinas on usu.cve_oficina equals ofi.Cve_Oficina
                                where usu.usuario == objUsuario.Usuario && usu.pasword == objUsuario.Pasword
                                select new
                                {
                                    usu,
                                    Nom_Oficina = ofi.desc_oficina
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
