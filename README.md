## ✅ Test Cases

### 1. ✅ Successful Checkout with Expirable + Shippable + Digital Products

### csharp
var cheese = new ProductBoth("Cheese", 100, 5, DateTime.Now.AddDays(3), 0.2);
var biscuits = new ProductBoth("Biscuits", 150, 2, DateTime.Now.AddDays(5), 0.7);
var scratch = new MyProduct("Scratch Card", 50, 10);
var user = new User("Ali", 1000);
var cart = new MyCart();

cart.PutToCart(cheese, 2);
cart.PutToCart(biscuits, 1);
cart.PutToCart(scratch, 1);

CartCheckout.CheckoutNow(user, cart);
---
### 2.Error: Product Expired
csharp
Copy
Edit
var oldMilk = new ProductCanExpire("Milk", 60, 4, DateTime.Now.AddDays(-2));
var user = new User("Omar", 500);
var cart = new MyCart();

cart.PutToCart(oldMilk, 1);

CartCheckout.CheckoutNow(user, cart);
---
### 3.Error: Insufficient Balance
csharp
Copy
Edit
var tv = new ProductCanShip("TV", 1000, 2, 8);
var user = new User("Laila", 500); // Not enough
var cart = new MyCart();

cart.PutToCart(tv, 1);

CartCheckout.CheckoutNow(user, cart);
---
### 4.Error: Empty Cart
csharp
Copy
Edit
var user = new User("Ahmed", 300);
var cart = new MyCart();

CartCheckout.CheckoutNow(user, cart);
---
### 5.Error: Out of Stock
csharp
Copy
Edit
var chips = new MyProduct("Chips", 20, 1);
var user = new User("Sara", 100);
var cart = new MyCart();

cart.PutToCart(chips, 2); // more than available

CartCheckout.CheckoutNow(user, cart);
