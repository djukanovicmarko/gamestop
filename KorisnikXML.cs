using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml;

namespace Domaci8_9_10
{
    class KorisnikXML
    {
    
        
        
        public static void uveziXML(string putanja)
        {
            
            XmlDocument xmlDoc = new XmlDocument();
            
            xmlDoc.Load(putanja);
            
            
            XmlNodeList korisnikNodes =
                xmlDoc.GetElementsByTagName("korisnik");
            
            foreach (XmlNode korisniciNode in korisnikNodes)
            {
                
                
                
                Korisnik kor = new Korisnik();
                kor.Ime = korisniciNode.ChildNodes[0].InnerText;
                kor.Prezime = korisniciNode.ChildNodes[1].InnerText;
                kor.Adresa = korisniciNode.ChildNodes[2].InnerText;
                
                kor.dodajKorisnika();
            }
        }

        
        
        public static Boolean izveziXML(string putanja, List<Korisnik> korisnik)
        {
            
            XmlDocument xmlDoc = new XmlDocument();
            
            
            
            XmlTextWriter xmlWriter =
                new XmlTextWriter(putanja, System.Text.Encoding.UTF8);
            
            
            xmlWriter.WriteProcessingInstruction(
                "xml", "version='1.0' encoding='UTF-8'");
            
            xmlWriter.WriteStartElement("Korisnici");
            
            
            
            xmlWriter.Close();
            xmlDoc.Load(putanja);

            
            foreach (Korisnik kor in korisnik )
            {
                
                XmlElement korisnikNode = xmlDoc.CreateElement("korisnik");

                
                XmlElement imekorisnika = xmlDoc.CreateElement("ImeKorisnika");
                
                imekorisnika.InnerText = kor.Ime;
                
                korisnikNode.AppendChild(imekorisnika);

                
                XmlElement prezimekorisnika =
                    xmlDoc.CreateElement("PrezimeKorisnika");
                
                prezimekorisnika.InnerText = kor.Prezime;
                
                korisnikNode.AppendChild(prezimekorisnika);

                
                XmlElement adresa = xmlDoc.CreateElement("Adresa");
                
                adresa.InnerText = kor.Adresa;
                
                korisnikNode.AppendChild(adresa);

                
                xmlDoc.DocumentElement.InsertAfter(korisnikNode, xmlDoc.DocumentElement.LastChild);
            }
            
            xmlDoc.Save(putanja);
            return true;
        }
    }
}
