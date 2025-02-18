using System;
namespace Assignment_19_Generics
{
    public abstract class Category
    {
        public string CategoryName { get; set; }
    }

    public class BookCategory : Category
    {
        public BookCategory()
        {
            CategoryName = "Books";
        }
    }

    public class ClothingCategory : Category
    {
        public ClothingCategory()
        {
            CategoryName = "Clothes";
        }
    }

    public class Product<T> where T : Category
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public double Price { get; set; }
        public T Category { get; set; }

        public Product(string name, int id, double price, T category)
        {
            Name = name;
            Id = id;
            Price = price;
            Category = category;
        }

        public void DisplayProduct()
        {
            Console.WriteLine("Name of product " + Name + " id of product " + Id + " price of product " + Price + " category of product " + Category.CategoryName);
        }

        public static void ApplyDiscount<TProduct>(TProduct product, double percentage) where TProduct : Product<T>
        {
            product.Price -= product.Price * (percentage / 100);
            Console.WriteLine("Price of product after " + product.Name + " is " + product.Price);
        }
    }

    class Program2
    {
        static void Main(string[] args)
        {
            //creating instances of categories
            var bookCategory = new BookCategory();
            var clothCategory = new ClothingCategory();

            //adding products
            var bookProduct = new Product<BookCategory>("Some book", 1, 75, bookCategory);
            var clothProduct = new Product<ClothingCategory>("Jacket", 2, 120, clothCategory);

            //display products
            Console.WriteLine("Product Catalog:");
            bookProduct.DisplayProduct();
            clothProduct.DisplayProduct();

            //apply discounts
            Console.WriteLine("Applying Discounts:");
            Product<BookCategory>.ApplyDiscount(bookProduct, 10);  //10% discount
            Product<ClothingCategory>.ApplyDiscount(clothProduct, 15);  //15% discount

            //display updated prices
            Console.WriteLine("Updated Product Catalog:");
            bookProduct.DisplayProduct();
            clothProduct.DisplayProduct();
        }
    }
}
