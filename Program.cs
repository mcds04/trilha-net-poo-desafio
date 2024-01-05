using DesafioPOO.Models;

    
    Console.WriteLine("Testando o Nokia:");
    Nokia meuNokia = new Nokia("123456", "Nokia", "Modelo 1", "111111111", 64);
    meuNokia.Ligar();
    meuNokia.InstalarAplicativo("Whatsapp", "2.22.13.75", "WhatsApp, Inc.");
    meuNokia.ReceberLigacao();
    meuNokia.Desligar();

    Console.WriteLine("\n");


    Console.WriteLine("Testando o Iphone:");
    Iphone meuIphone = new Iphone("4987", "Apple", "Modelo 2", "222222222", 126);
    meuIphone.Ligar();
    meuIphone.InstalarAplicativo("Telegram", "1.0.0", "Telegram, Inc.");
    meuIphone.ReceberLigacao();
    meuIphone.Desligar();
  

