using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;

namespace RolesUsuario.Models
{
    public class AplicationRoleManager : RoleManager<IdentityRole>
    {
        // Constructor que recibe la instancia de roleStore: para gestionar los registros de la tabla de roles
        public AplicationRoleManager(IRoleStore<IdentityRole, string> store) 
            : base(store)
        {
        }

        public static AplicationRoleManager Create(IdentityFactoryOptions<AplicationRoleManager> options, IOwinContext context)
        {
            var roleStore = new RoleStore<IdentityRole>(context.Get<ApplicationDbContext>());
            return new AplicationRoleManager(roleStore);
        }
    }
}