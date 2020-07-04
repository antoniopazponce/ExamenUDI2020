using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using C_Entidades;

namespace Business
{
    public class CargoB
    {
        CargoDA cargoDA = new CargoDA();
        public void AgregarCargo(CargoE cargo)
        {
            cargoDA.AgregarCargo(cargo);

        }
        public List<CargoE> ObtenerCargo()
        {
            return cargoDA.ObtenerCargo();
        }
        public void Upadate(CargoE cargo)
        {
            cargoDA.Upadate(cargo);
        }
        public void Delete(CargoE cargo)
        {
            cargoDA.Delete(cargo);
        }
    }
}
