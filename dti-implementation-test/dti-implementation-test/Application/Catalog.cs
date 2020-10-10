using System.Collections.Generic;
using System.Linq;

namespace dti_implementation_test.Application
{
    public class Catalog
    {
        private List<PetShop> _petShops;

        public Catalog() => _petShops = new List<PetShop>();

        public void Add(PetShop petShop) => _petShops.Add(petShop);

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
