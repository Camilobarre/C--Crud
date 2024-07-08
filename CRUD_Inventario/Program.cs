// //Define type of dates
// using System.Reflection;

// public class Products
// {
//     //Name = Nombre
//     public string? Name { get; set; }
//     //Cantidad = Quantity
//     public int Quantity { get; set; } 
//     //PrecioUnitario = UnitPrice
//     public decimal UnitPrice { get; set; }

//     public Products(string Name, int Quantity, decimal UnitPrice){
//         this.Name = Name;
//         this.Quantity = Quantity;
//         this.UnitPrice = UnitPrice;
//     }
// }

// public class Program{
//   List<Products> Products = new List<Products>();
//     public void Main (){
//         //Add products to list
//         Products.Add(new Products("Producto 1", 10, 10.50m));
//         Products.Add(new Products("Producto 2", 5, 20.00m));
//         Products.Add(new Products("Producto 3", 20, 5.00m));

//         //Print products
//         foreach(Products product in Products){
//             Console.WriteLine($"Name: {product.Name}, Quantity: {product.Quantity}, Unit Price: {product.UnitPrice}");
//         }

//     }
// }