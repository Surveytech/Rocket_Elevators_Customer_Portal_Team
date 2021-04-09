using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;
using System.Text.Json;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;


namespace CustomerPortal.Controllers
{
    public class NewAccountController : Controller
    {
        //public static async Task<bool> GraphqlQuery(string inputEmail)
        //{
        //    var graphQLClient = new GraphQLHttpClient("https://graphql-codeboxx.herokuapp.com/graphiql", new NewtonsoftJsonSerializer());

        //    var checkIfEmailExistsRequest = new GraphQL.GraphQLRequest
        //    {
        //        Query = @"
        //           query CheckEmail($email: String!){
        //              checkIfEmailExists(email: $email)
        //            }",
        //        CompareName = "CheckEmail",
        //        Variables = new
        //        {
        //            email = inputEmail
        //        }
        //    };

        //    var graphQLResponse = await graphQLClient.SendQueryAsync<CustomerPortal.Model.checkIfEmailExistsRequest>(checkIfEmailExistsRequest);

        //    System.Diagnostics.Debug.WriteLine(graphQLResponse.Data.checkIfEmailExists);

        //    return graphQLResponse.Data.checkIfEmailExists;
        //}
    }
}