using System;

namespace SRP
{
    public class Almacenamiento
    {
        
    public Almacenamiento(String sector, String shelve)
    {
        this.LibrarySector = sector;
        this.LibraryShelve = shelve;
    }
        public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }
    }
}