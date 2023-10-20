using Amazon.Runtime.Internal;
using MongoDB.Driver;
using ProductInventory.DAL;
using ProductInventory.Models;

namespace ProductInventory.Services
{
    public class ProductService : IproductServices
    {
        private MongoDb _mongoDb;

        public ProductService(MongoDb mongoDB) 
        {
            _mongoDb = mongoDB;

        }

        public async Task<AddProductResponse> AddProductToInventory(AddProductRequest request)
        {
            AddProductResponse response = new AddProductResponse();
            response.IsSuccess = true;
            response.Message = "Data Successfully Inserted ";
            try
            {
                request.DateAdded = DateTime.Now.ToString();
                await _mongoDb._MongoCollection.InsertOneAsync(request);
            }catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Occurs : " + ex.Message;
            }
            return response;
        }

        public async Task<GetAllProductResponse> GetAllProduct()
        {
            GetAllProductResponse response = new GetAllProductResponse();
            response.IsSuccess = true;
            response.Message = "Data Fetched Successfully";
            try
            {
                response.Data = new List<AddProductRequest>();
                response.Data = await _mongoDb._MongoCollection.Find
                    (x => true).ToListAsync();
                if(response.Data.Count == 0) { response.Message = "No Data"; }

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Occurs : " + ex.Message;
            }
            return response;
        }
    }
}
