using Kebab_house;

namespace main
{
    internal class _main
    {
        static void Main(string[] args)
        {
            Sklad sklad = new Sklad();
            Skladník skladník = new Skladník(sklad);
            while (sklad != null)
            {
                Console.WriteLine(sklad.VyberZeSkladuSurovin1());
                skladník.DoskladniMaso();




            }
        }
    }
}
