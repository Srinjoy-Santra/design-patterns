// See https://aka.ms/new-console-template for more information

using biryani_store;

Console.WriteLine("Hello, World!");

BiryaniStore kolkataStore = new KolkataBiryaniStore();
BiryaniStore lucknowStore = new LucknowBiryaniStore();
BiryaniStore hyderabadStore = new HyderabadBiryaniStore();

Biryani? biryani = kolkataStore.OrderBiryani(BiryaniTypes.CHICKEN);
Console.WriteLine("Srinjoy ordered a "+biryani?.Name);

biryani = lucknowStore.OrderBiryani(BiryaniTypes.VEGETARIAN);
Console.WriteLine("Rohit ordered a "+biryani?.Name);

biryani = hyderabadStore.OrderBiryani(BiryaniTypes.MUTTON);
Console.WriteLine("Ambar ordered a "+biryani?.Name);