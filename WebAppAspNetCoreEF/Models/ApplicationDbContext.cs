using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAspNetCoreEF.Models
{
    /// <summary>
    /// Dar ctrl + (.) Punto seleccionar Generar options esto es lo que hace es que me permite crear un,
    /// constructor a través del cual yo voy a recibir las configuraciones realizadas a Entity Framework.
    /// Esas configuraciones son por ejemplo que vamos a utilizar SQL Server que vamos a utilizar logs, etc.
    /// Vamos a traer este namespace (NotNullAttribute) que indica qué opciones no puede ser nulo.
    /// </summary>
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }
    }
}
