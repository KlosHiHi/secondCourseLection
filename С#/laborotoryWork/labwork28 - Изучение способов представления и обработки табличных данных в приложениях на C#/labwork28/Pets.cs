using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace labwork28
{
    public class Pets
    {
        public static Pets Instance { get; set; } = new Pets();
        private List<PetClass> _pets = [
            new PetClass() {
                Name = "Жорик",
                Kind = "Кошка",
                Age = 8
            },
            new PetClass{
                Name = "Гавришка",
                Kind = "Собака",
                Age = 12
            },
            new PetClass{
                Name = "Челобей",
                Kind = "Рыбка",
                Age = 3
            }
            ];
        public List<PetClass> all { get => _pets; }
    }

}
