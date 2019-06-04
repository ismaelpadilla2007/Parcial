using ClientPatientManagement.Core.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppVet.Models;

namespace WebAppVet.Data
{
    
    public class PiezaFacade : IRepository<Pieza>
    {

        private static PiezaFacade instance;
        
        public static PiezaFacade Instance()
        {
            if (instance == null)
            {
                instance = new PiezaFacade();
            }
            return instance;
        }

        
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Pieza GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Pieza entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pieza> List()
        {

            throw new NotImplementedException();
        }

        public void Update(Pieza entity)
        {
            throw new NotImplementedException();
        }
    }

    internal class PiezaDataGateway
    {
        public void add(String name, String Location)
        {
            
        }
        
    }
}