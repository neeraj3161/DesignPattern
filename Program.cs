// Console.WriteLine("Hello, World!");
// PaymentService paymentService = new PaymentService(new CreditCardPayment());
// paymentService.ProcessPayment(100.00m);

// ShippingService shippingService = new ShippingService(new International());
// shippingService.CalculateShippingCost(10.0m);

//Deorator Pattern
//each decorator adds something to the coffee
ICoffee coffee = new Coffee();

// ICoffee milkCoffee = new MilkCoffee(coffee);
// milkCoffee.makeCoffee();

ICoffee sugarCoffee = new AddSugar(coffee);
sugarCoffee.makeCoffee();


