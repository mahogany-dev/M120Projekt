//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace M120Projekt
{
    using System;
    using System.Collections.Generic;
    
    public partial class Produkt
    {
        public int ProduktId { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> Lieferdatum { get; set; }
        public Nullable<bool> Verfuegbar { get; set; }
        public Nullable<int> Preis { get; set; }
        public string Farbe { get; set; }
        public string Hersteller { get; set; }
    }
}