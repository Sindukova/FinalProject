using Dapper;
using Final_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project
{
    public class MaterialRepository:IMaterialsRepository
    {
        private readonly IDbConnection _conn;
        public MaterialRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Materials> GetAllMaterials()
        {
            return _conn.Query<Materials>("SELECT * FROM materials;");
        }

        public Materials GetMaterials(int id)
        {
            return _conn.QuerySingle<Materials>("SELECT * FROM MATERIALS WHERE id_materials = @id",
                new { id = id });

        }

        public IEnumerable<Materials> SearchMaterial(string search)
        {
            return _conn.Query<Materials>("Select*FROM materials WHERE name like @name;",
               new
               {
                   name = "%" + search+ "%"
               });
        }
    }
}
