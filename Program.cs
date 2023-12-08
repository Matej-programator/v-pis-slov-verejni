
Console.WriteLine("zadej slovo");
string prniSLOVO = Console.ReadLine();

Console.WriteLine("zadej slovo");
string druheSLOVO = Console.ReadLine();

Console.WriteLine("zadej slovo");
string tretSLOVO = Console.ReadLine();

Console.WriteLine("zadej slovo");
string ctvrteSLOVO = Console.ReadLine();

Console.WriteLine("zadej prázní znak");
string pateSLOVO = Console.ReadLine();



if (pateSLOVO == " ")
{
    Console.WriteLine(prniSLOVO + " " + druheSLOVO + " " + tretSLOVO + " " + ctvrteSLOVO);
}

Console.WriteLine("chcete vetu zopakovat dvacetrat ano nebo ne");
string vetata = Console.ReadLine();

if (vetata == "ano")
{
    for (int i = 0; i < 20; i++)
    {
         Console.WriteLine(prniSLOVO + " " + druheSLOVO + " " + tretSLOVO + " " + ctvrteSLOVO);
    }
}