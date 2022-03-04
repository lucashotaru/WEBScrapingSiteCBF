using System;

namespace CBFWebScraping.DTOs
{
    public class CBFInfoDTO
    {
        public string NomeTimeCasa { get; set; }
        public int PlacarTimeCasa { get; set; }
        public string NomeTimeVisitante { get; set; }
        public int PlacarTimeVisitante { get; set; }
        public int Rodada { get; set; }
        public string DataHoraJogo { get; set; }


        public CBFInfoDTO(string TimeCasa,int PlacarCasa, string TimeVisitante, int PlacaVisitante, int rodada, string dataHora)
        {
            NomeTimeCasa= TimeCasa;
            PlacarTimeCasa = PlacarCasa;
            NomeTimeVisitante = TimeVisitante;
            PlacarTimeVisitante = PlacaVisitante;
            Rodada = rodada;
            DataHoraJogo = dataHora;
        }
    }
}
