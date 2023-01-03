using DesafioPOO.Models;

// realizando testes com as classes

Console.WriteLine("__________________________  Smartphone Nokia ______________________________");
Nokia n1 = new Nokia(numero: "88224411", modelo : "C01 Plus", imei : "IMEI 000444454554", memoria : 60);
n1.Ligar();
n1.InstalarAplicativo("Bloco de Notas");



Console.WriteLine("\n __________________________  Smartphone Iphone ______________________________");
Iphone i1 = new Iphone(numero: "22005515", modelo : "Pro Max", imei : "IMEI 5151554554", memoria : 120);
i1.ReceberLigacao();
i1.InstalarAplicativo("Netflix");


Console.WriteLine("__________________________  Smartphone Nokia ______________________________");
Nokia n2 = new Nokia(numero: "66226262", modelo : "C02 Plus", imei : "IMEI 22222222", memoria : 70);
n2.Ligar();
n2.InstalarAplicativo("Whatsapp");


Console.WriteLine("\n __________________________  Smartphone Iphone ______________________________");
Iphone i2 = new Iphone(numero: "33333333", modelo : "Apple", imei : "IMEI 7788844844", memoria : 130);
i2.ReceberLigacao();
i2.InstalarAplicativo("Whatsapp");



