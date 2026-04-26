using DnsClient;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BookmyNoteAPI
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
    public class LoginandRegister
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
    public class Products
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }

        public string Shopid { get; set; }

        public string productid { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public decimal oldPrice { get; set; }
        public string category { get; set; }
        public string from { get; set; }
        public string unit { get; set; }
        public int unitStock { get; set; }
        public DateTime stockDate { get; set; }
        public bool inStock { get; set; }
        public string Imagespath { get; set; }
        public bool hasImage { get; set; }
        public int rating { get; set; }
        public int reviews { get; set; }

        public List<string> tags { get; set; } = new();

        public string areacode { get; set; }


    }
    public class Users
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }   // ✅ use Id (standard)

        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }

        public UserRegisteraddress Useraddress { get; set; } 
    }
    public class Login
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
    public class Sales
    {
        public int SalesId { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime SalesDate { get; set; }
    }

    public class Purchase
    {
        public int PurchaseId { get; set; }
        public int ProductId { get; set; }
        public int SupplierId { get; set; }
        public int Quantity { get; set; }
        public decimal PurchaseAmount { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
    public class ProductDetails
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }


        public string Name { get; set; } = string.Empty;
        public string ProductImage { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public decimal? OldPrice { get; set; }    // optional (?)
        public string From { get; set; } = string.Empty;
        public double Rating { get; set; }
        public int Reviews { get; set; }
        public List<string> Badges { get; set; } = new();   // string[]
        public string Unit { get; set; } = string.Empty;
        public DateTime StockDate { get; set; } = DateTime.Now;
        public bool InStock { get; set; }
    }

    public class MobileVendorRegister
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }   // ✅ use Id (standard)

        public string EmailId { get; set; }
        public string Password { get; set; }
        public int MobileNumber { get; set; }

        public int AlternateNumber { get; set; }

        public string ShopName { get; set; }
        public string Doorno { get; set; }
        public string Street { get; set; }

        public string City { get; set; }
        public string State { get; set; }
        public int Pincode { get; set; }

        public string Latlong { get; set; }
        public string GSTNumber { get; set; }

        public string ShopCategory { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public int LisenceNo { get; set; }

    }
    public class UserRegisteraddress
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }   // ✅ use Id (standard)

        public string Addressid { get; set; }

        public string Address { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedDate { get; set; }

    }
}
