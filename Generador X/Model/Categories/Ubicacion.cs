using Bogus;
using System;
using System.Collections.Generic;
using System.Text;

namespace Generador_X.Model.Categories
{
    class Ubicacion
    {
        private Faker faker;

        public Ubicacion(string lng = "es")
        {
            faker = new Faker(lng);
        }

        public string CodigoPostal()
        {
            return faker.Address.ZipCode();
        }

        public string Ciudad()
        {
            return faker.Address.City();
        }

        public string Pais()
        {
            return faker.Address.Country();
        }
    }
}
