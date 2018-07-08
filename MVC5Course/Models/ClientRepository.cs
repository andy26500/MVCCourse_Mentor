using System;
using System.Linq;
using System.Collections.Generic;
	
namespace MVC5Course.Models
{   
	public  class ClientRepository : EFRepository<Client>, IClientRepository
	{
        public IQueryable<Client> All(bool isAll = false)
        {
            if (isAll)
            {
                return base.All();
            }
            return base.All().Where(p => p.CreditRating < 2);
        }
        public Client Find(int id)
        {
            return this.All().FirstOrDefault(p => p.ClientId == id);
        }

        public IQueryable<Client> ·j´M¦WºÙ(string keyword)
        {
            var client = this.All();

            if (!String.IsNullOrEmpty(keyword))
            {
                client = client.Where(p => p.FirstName.Contains(keyword));
            }

            return client;
        }
    }

	public  interface IClientRepository : IRepository<Client>
	{

	}
}