using System;
using System.Runtime.InteropServices;

namespace ELI
{
    /// <summary>
    /// obiekt przechowuje dane o zleceniu
    /// </summary>
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ProgId("ELI.ExaminationResultVO")]
    public class ExaminationResultVO
    {
        /// <summary>
        /// Informacja o badaniu
        /// </summary>
        public ExaminationVO examination;

        /// <summary>
        /// Lista parametrów wyniku badania
        /// </summary>
        public ExaminationResultParameterVO[] examinationParameters;

        /// <summary>
        /// Data i godzina przeprowadzenia autoryzacji
        /// </summary>
        public DateTime validationDate;

        /// <summary>
        /// Imię osoby odpowiedzialnej za autoryzację wyniku
        /// Maksymalnie 30 znaków
        /// </summary>
        public string validatorName;

        /// <summary>
        /// Nazwisko osoby odpowiedzialnej za autoryzację wyniku
        /// Maksymalnie 50 znaków
        /// </summary>
        public string validatorSurname;

        /// <summary>
        /// Data i godzina uzyskania badania
        /// </summary>
        public DateTime attainmentTime;

        /// <summary>
        /// Flaga czy uzyskano wiarygodny wynik
        /// </summary>
        public bool reliableResult;
    }
}