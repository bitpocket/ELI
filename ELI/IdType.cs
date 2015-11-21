using System.Runtime.InteropServices;

namespace ELI
{
    [ComVisible(true)]
    public enum IdType
    {
        /// <summary>
        /// numer 20ESEL pacjenta
        /// </summary>
        PESEL,

        /// <summary>
        /// seria i numer dowodu tożsamości
        /// </summary>
        IDENTITY_CARD,

        /// <summary>
        /// nr 20ESEL matki ( w przypadku noworodków)
        /// </summary>
        MOTHER_PESEL,

        /// <summary>
        /// seria i numer tożsamość matki (w przypadku noworodków)
        /// </summary>
        MOTHER_IDENTITY_CARD
    }
}
