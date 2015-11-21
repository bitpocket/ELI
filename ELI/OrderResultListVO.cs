using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ELI
{
    /// <summary>
    /// obiekt przechowuje wyniki badań danego pacjenta
    /// </summary>
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ProgId("ELI.OrderResultListVO")]
    public class OrderResultListVO
    {
        #region ErLab

        /// <summary>
        /// Obiekt identyfikujący pacjenta
        /// </summary>
        public PatientIdVO patientIdVO;

        /// <summary>
        /// Lista wyników badań
        /// </summary>
        public OrderResultVO[] ordersResults;

        #endregion

        /// <summary>
        /// Lista wyników badań
        /// </summary>
        private List<OrderResultVO> _ordersResults = new List<OrderResultVO>();

        /// <summary>
        /// dodaj wynik
        /// </summary>
        /// <param name="order"></param>
        public void addOrdersResult(OrderResultVO order)
        {
            _ordersResults.Add(order);
            ordersResults = _ordersResults.ToArray();
        }
    }
}