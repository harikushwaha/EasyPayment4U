using EasyPayment4u.Core.Data;
using EasyPayment4u.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPayment4u.Services.Consumers
{
    public class ConsumerService : IConsumerService
    {
        private readonly IRepository<Consumer> _ConsumerRepository;

        public ConsumerService(IRepository<Consumer> consumerRepository)
        {
            _ConsumerRepository = consumerRepository;
        }



        public Consumer GetConsumer(int consumerID)
        {
            if (consumerID == 0)
                return null;

            return _ConsumerRepository.GetById(consumerID);
        }

        public IList<Consumer> GetConsumers()
        {
            return _ConsumerRepository.Table.ToList<Consumer>();
        }

        public IList<Consumer> GetConsumerByIds(int[] consumerIDs)
        {
            if (consumerIDs == null || consumerIDs.Length == 0)
                return new List<Consumer>();

            var query = from o in _ConsumerRepository.Table
                        where consumerIDs.Contains(o.ConsumerID)
                        select o;
            var orders = query.ToList();
            //sort by passed identifiers
            var sortedConsumer = new List<Consumer>();
            foreach (int id in consumerIDs)
            {
                var order = orders.Find(x => x.ConsumerID == id);
                if (order != null)
                    sortedConsumer.Add(order);
            }
            return sortedConsumer;
        }

        public void DeleteConsumer(Consumer consumer)
        {
            if (consumer == null)
                throw new ArgumentNullException("consumer");

            // product.Deleted = true;
           // consumer.IsDeleted = true;
            _ConsumerRepository.Delete(consumer);
           // UpdateConsumer(consumer);
        }

        public void InsertConsumer(Consumer consumer)
        {
            if (consumer == null)
                throw new ArgumentNullException("consumer");
            _ConsumerRepository.Insert(consumer);
        }

        public void UpdateConsumer(Consumer consumer)
        {
            if (consumer == null)
                throw new ArgumentNullException("consumer");

            _ConsumerRepository.Update(consumer);
        }
    }
}
