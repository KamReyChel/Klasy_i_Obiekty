namespace KartaOcenFilmow
{
    internal interface IKartaPodstawowa
    {
        void DodajOcene(float ocena);

        KartaStatystyki ObliczStatystyki();
    }
}