// See https://aka.ms/new-console-template for more information

using biryani_store;

BiryaniStore kolkataStore = new KolkataBiryaniStore();
BiryaniStore lucknowStore = new LucknowBiryaniStore();
BiryaniStore hyderabadStore = new HyderabadBiryaniStore();

Biryani? biryani = kolkataStore.OrderBiryani(BiryaniTypes.CHICKEN);
Console.WriteLine("Srinjoy received the order for a "+biryani?.Name);

biryani = lucknowStore.OrderBiryani(BiryaniTypes.VEGETARIAN);
Console.WriteLine("Rohit received the order for a "+biryani?.Name);

biryani = hyderabadStore.OrderBiryani(BiryaniTypes.MUTTON);
Console.WriteLine("Ambar received the order for a "+biryani?.Name);