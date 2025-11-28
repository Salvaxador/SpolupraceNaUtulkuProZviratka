using System;
using System.Linq;

namespace SpolupraceNaUtulkuProZviratka
{
    public class Logika
    {
        private ListClass data = new ListClass();

        public void PridatZvire(string jmeno, int vek, string druh)
        {
            data.ZvireList.Add(new Zvire(jmeno, false, vek, druh));
        }

        public Zvire[] FindByName(string namePart)
        {
            if (string.IsNullOrWhiteSpace(namePart)) return new Zvire[0];

            return data.ZvireList
                .Where(z => z.Name.IndexOf(namePart, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToArray();
        }

        public void ToggleAdopce(string jmeno)
        {
            var zvire = data.ZvireList.FirstOrDefault(z => z.Name.Equals(jmeno, StringComparison.OrdinalIgnoreCase));
            if (zvire != null)
                zvire.AdoptedToggle();
            else
                Console.WriteLine("Zvíře nenalezeno.");
        }

        public Zvire[] Vyhledat(string name, string druh, bool? adopted, int? minAge, int? maxAge)
        {
            return data.ZvireList.Where(z =>
                (string.IsNullOrEmpty(name) || z.Name.Contains(name, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(druh) || z.AnimalType.Contains(druh, StringComparison.OrdinalIgnoreCase)) &&
                (!adopted.HasValue || z.Adopted == adopted.Value) &&
                (!minAge.HasValue || z.Age >= minAge.Value) &&
                (!maxAge.HasValue || z.Age <= maxAge.Value)
            ).ToArray();
        }
    }
}