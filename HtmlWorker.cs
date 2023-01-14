using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.ComponentModel;

namespace RGR
{
   public class HtmlWorker
    {
        //static private readonly string http = @"https://writers.fandom.com/ru/wiki/%D0%A0%D1%83%D1%81%D1%81%D0%BA%D0%B8%D0%B5_%D0%BF%D0%B8%D1%81%D0%B0%D1%82%D0%B5%D0%BB%D0%B8#.D0.AF";
        static private readonly string firstPageUrl = @"https://www.culture.ru/literature/persons/writer?rubricPath=writer&sort=surname";
        static private readonly string secondPageUrl = @"https://www.culture.ru/literature/persons?rubricPath=&sort=surname";
        static private readonly string xPath = "//div[@class='entity-cards_item col']/div[@class='js-entity-card entity-card-v2 entity-card-v2__fill-height entity-card-v2__theme__cover']";

        public static HtmlNodeCollection GetWritersCards()
        {
            HtmlWeb htmlWeb = new HtmlWeb();


            var document = htmlWeb.Load(firstPageUrl);

            var cards = document.DocumentNode.SelectNodes(xPath);
            
            return cards;
        }


    }
}
