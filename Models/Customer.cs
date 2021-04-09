//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Rocket_Elevators_Customer_Portal.Models
//{
//    public class Customer
//    {
//        private readonly IGraphQLClient _client;
//        public Customer(IGraphQLClient client)
//        {
//            _client = client;
//        }
//    }
//    public async Task<List<Owner>> GetAllCusttomers()
//    {
//        var query = new GraphQLRequest
//        {
//            Query = @"
//                query ownersQuery{
//                  owners {
//                    id
//                    name
//                    address
//                    accounts {
//                      id
//                      type
//                      description
//                    }
//                  }
//                }"
//        };
//        var response = await _client.SendQueryAsync<ResponseCustomerCollectionType>(query);
//        return response.Data.Customers;
//    }
//}
