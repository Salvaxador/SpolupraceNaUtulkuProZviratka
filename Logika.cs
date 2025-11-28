using System;
using System.Linq;

namespace UtulekSpoluprace
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
    }
}