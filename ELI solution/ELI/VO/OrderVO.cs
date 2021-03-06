﻿using System;
using System.Runtime.InteropServices;

namespace ELI
{
    /// <summary>
    /// obiekt przechowuje dane o zleceniu
    /// </summary>
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ProgId("ELI.OrderVO")]
    public class OrderVO
    {
        /// <summary>
        /// identyfikator zlecenia
        /// kod świadczeniodawcylub regon (prywatne placówki) + ‘-’ + kolejny nr zlecenia w placówce  medycznej, maksymalnie 50 znaków
        /// </summary>
        public string id;

        /// <summary>
        /// kontrahent zlecający badania
        /// </summary>
        public ContractorVO contractor;

        /// <summary>
        /// Lista badań do wykonania
        /// </summary>
        public ExaminationVO[] examination;

        /// <summary>
        /// Dane lekarza 
        /// </summary>
        public DoctorVO doctor;

        /// <summary>
        /// Data wystawienia zlecenia 
        /// </summary>
        public DateTime orderTime;

        /// <summary>
        /// Dane istotne klinicznie
        /// Maksymalnie 500 znaków
        /// </summary>
        public string valuableClinicInfo;

        /// <summary>
        /// Dane o pobraniu próbek
        /// </summary>
        public SpecimenCollectionVO specimenCollection;
    }
}