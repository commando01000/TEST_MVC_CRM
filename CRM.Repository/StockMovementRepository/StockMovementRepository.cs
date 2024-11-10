using CRM.Repository.Helpers;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Xml.Linq;

namespace CRM.Repository.StockMovementService
{
    public class StockMovementRepository : BasePlugin, IStockMovement
    {
        public StockMovementRepository()
        {
            _Service = OrganizationServiceFactory.GetCrmService();
        }
        public void Add(Entity stockMovement)
        {
            throw new NotImplementedException();
        }

        public void Delete(Entity stockMovement)
        {
            throw new NotImplementedException();
        }

        public Entity Get(int id)
        {
            throw new NotImplementedException();
        }

        public DataCollection<Entity> GetAll()
        {
            string fetchXml = @"<fetch>
                              <entity name='initiumc_stockmovement'>
                                <attribute name='initiumc_date' />
                                <attribute name='initiumc_quantity' />
                                <attribute name='initiumc_relatedproduct' />
                                <attribute name='initiumc_movementtype' />
                                <attribute name='initiumc_stockmovementid' />
                              </entity>
                            </fetch>";

            return XrmExtensions.FetchMultiple(_Service, fetchXml);
        }

        public void Update(Entity stockMovement)
        {
            throw new NotImplementedException();
        }
    }
}
