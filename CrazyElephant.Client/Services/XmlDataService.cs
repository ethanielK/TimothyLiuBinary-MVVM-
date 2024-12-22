using CrazyElephant.Client.Models;

namespace CrazyElephant.Client.Services
{
    internal class XmlDataService : IDataService
    {
        public List<Dish> getAllDishes()
        {
            List<Dish> dishList = new List<Dish>();
            string xmlFileName = System.IO.Path.Combine(Environment.CurrentDirectory, "Data", "Data.xml");
            System.Xml.Linq.XDocument xdoc = System.Xml.Linq.XDocument.Load(xmlFileName);
            var dishes = xdoc.Descendants("Dish");
            foreach (var d in dishes)
            {
                Dish dish = new Dish();
                dish.Name = d.Element("Name").Value;
                dish.Category = d.Element("Category").Value;
                dish.Comment = d.Element("Comment").Value;
                dish.Score = double.Parse(d.Element("Score").Value);
                dishList.Add(dish);
            }

            return dishList;
        }
    }
}
