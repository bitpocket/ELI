using System;

namespace ELI
{
    /// <summary>
    /// obiekt przechowuje dane o pacjencie
    /// </summary>
    public class PatientVO
    {
        /// <summary>
        /// imię
        /// </summary>
        public string firstName;

        /// <summary>
        /// drugie imię
        /// </summary>
        public string secondName;

        /// <summary>
        /// nazwisko
        /// </summary>
        public string surname;

        /// <summary>
        /// Obiekt identyfikujący pacjenta
        /// </summary>
        public PatientIdVO patientIdVO;

        /// <summary>
        /// data urodzenia
        /// </summary>
        public DateTime birthDate;

        /// <summary>
        /// Płeć: M –mężczyzna; K- kobieta; N-nieznana
        /// </summary>
        public Gender gender;

        /// <summary>
        /// adres e-mail
        /// </summary>
        public string email;

        /// <summary>
        /// imię ojca
        /// </summary>
        public string fatherName;

        /// <summary>
        /// adres zam.
        /// </summary>
        public AddressVO address;

        /// <summary>
        /// Identyfikator klucza, którym są  zaszyfrowane dane pacjenta
        /// </summary>
        public long hciPrivateKeyId;
    }
}
