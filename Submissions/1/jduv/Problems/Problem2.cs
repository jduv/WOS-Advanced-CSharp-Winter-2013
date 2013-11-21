namespace Problems
{
    /// <summary>
    /// Pretend we're building a system where people can order their favorite
    /// coffee online or through a web application. Let's design a basic object
    /// representation of pieces of this system. First, let's create a customer. Think
    /// about the attributes and properties of a customer--don't worry about actually
    /// implementing any methods. Just focus on the data bits. Be creative.
    /// </summary>
    public class Customer
    {
    }

    /// <summary>
    /// Next, let's think about products. Because we may wish to extend our program
    /// later to allow us to sell, say, cakes or breakfast foods we should create a top level
    /// object that represents a product.
    /// </summary>
    public abstract class Product
    {
    }

    /// <summary>
    /// Now, let's get a little bit more specific. Think about the specific bits that a drink has
    /// versus other products.
    /// </summary>
    public class Drink : Product
    {
    }

    /// <summary>
    /// An order consists of a customer, some number of items, and probably a cost. Again, be
    /// creative here.
    /// </summary>
    public class Order
    {
    }
}
