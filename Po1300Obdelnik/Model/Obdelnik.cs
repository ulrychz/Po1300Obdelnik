namespace Po1300Obdelnik.Model
{
    public class Obdelnik
    {
        public int StranaA { get; set; }
        public int StranaB { get; set; }

        public int Obvod { get; set; }
        public int Obsah { get; set; }
        public double Uhlopricka { get; set; }

        public void SpouctiObvod()
        {
            Obvod = 2 * (StranaA + StranaB);
        }
        public void SpouctiObsah()
        {
            Obsah = (StranaA * StranaB);
        }
        public void SpouctiUhlopricku()
        {
            Uhlopricka = Math.Sqrt(StranaA * StranaA + Math.Pow(StranaB,2));
        }
        public void Vypocet()
        {
            SpouctiObvod();
            SpouctiObsah();
            SpouctiUhlopricku();
        }
    }
}
