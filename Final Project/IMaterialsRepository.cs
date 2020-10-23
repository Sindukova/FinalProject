using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project
{
    public interface IMaterialsRepository
    {
        public IEnumerable<Materials> GetAllMaterials();
        public Materials GetMaterials(int id);
        public IEnumerable<Materials> SearchMaterial(string search);

    }
}
