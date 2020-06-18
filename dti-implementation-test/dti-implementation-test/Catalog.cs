using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dti_implementation_test
{
    class Catalog
    {
        private List<Petshop> _petshops;

        public Catalog()
        {
            _petshops = new List<Petshop>();
        }

        public List<Petshop> Petshops { get => _petshops; }

        public void AddPetshop(Petshop petshop)
        {
            _petshops.Add(petshop);
        }
        
        public Petshop GetBestPetshop()
        {
            List<Petshop> petshops = _petshops.OrderBy(petshop => petshop.Amount).ThenBy(petshop => petshop.Distance).ToList();

            return (petshops.Count > 0) ? petshops.ElementAt(0) : new Petshop("", 0); // throw new CustomException();
        }
    }
}
