using System;
using System.Collections.Generic;
using System.Text;

namespace CardPrinterSDKv1.Model
{
    class Printer
    {
        #region Fields
        private String printerDescription;
        private String printerStatus;
        private Boolean isCardPrintDone = false;
        private Boolean isCardPresent = false;
        private Boolean isCardRetracted = false;
        private Boolean isCardPresented = false;
        #endregion

        #region Methods
        public Printer(string printerDescription)
        {
            this.PrinterDescription = printerDescription ?? throw new ArgumentNullException(nameof(printerDescription));
        }
        #endregion Methods

        #region Properties
        public string PrinterDescription { get => printerDescription; set => printerDescription = value; }
        public string PrinterStatus { get => printerStatus; set => printerStatus = value; }
        public bool IsCardPrintDone { get => isCardPrintDone; set => isCardPrintDone = value; }
        public bool IsCardPresent { get => isCardPresent; set => isCardPresent = value; }
        #endregion Properties
    }
}
