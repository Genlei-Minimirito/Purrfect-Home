using System.Drawing;

namespace Purrfect_Home
{
    public class GachaResult
{
    public string Name { get; set; }
    public string FilePath { get; set; }   // <-- ADD THIS
    public string Rarity { get; set; }
    public int Stars{ get; set; }
        public Image Image { get; set; }
    }

}
