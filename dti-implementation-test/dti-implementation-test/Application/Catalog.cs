using System.Collections.Generic;
using System.Linq;

namespace dti_implementation_test.Application
{
    public class Catalog
    {
        private readonly IList<IPetShop> _petShops;

        public Catalog()
        {
            _petShops = new List<IPetShop>();
        }

        public void Add(IPetShop petShop) => _petShops.Add(petShop);

        public IPetShop GetBestPetShop()
        {
            return _petShops
                .OrderBy(petShop => petShop.Amount)
                .ThenBy(petShop => petShop.Distance)
                .ToList()
                .FirstOrDefault();
        }
    }
}
