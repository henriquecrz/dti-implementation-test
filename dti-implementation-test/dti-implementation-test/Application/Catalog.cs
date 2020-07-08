using System.Collections.Generic;
using System.Linq;

namespace dti_implementation_test.Application
{
    class Catalog
    {
        private List<PetShop> _petShops;

        public Catalog()
        {
            _petShops = new List<PetShop>();
        }

        public void AddPetShop(PetShop petShop)
        {
            _petShops.Add(petShop);
        }

        public void RemovePetShop(PetShop petShop)
        {
            _petShops.Remove(petShop);
        }

        public List<PetShop> GetPetShops()
        {
            return _petShops;
        }

        public PetShop GetBestPetShop()
        {
            return _petShops
                .OrderBy(petShop => petShop.Amount)
                .ThenBy(petShop => petShop.Distance)
                .ToList()
                .FirstOrDefault();
        }
    }
}
