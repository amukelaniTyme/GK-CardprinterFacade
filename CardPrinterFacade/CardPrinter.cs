using System;
using System.Collections.Generic;
using System.Text;

namespace CardPrinterFacade.Model
{
    public sealed class CardPrinter
    {
        #region Variables
        private static readonly CardPrinter instance = new CardPrinter();
        static PrinterEvent cardprinter = new PrinterEvent();
        #endregion

        #region Methods
        static CardPrinter()
        {
            //try putting a new -- explicit --  
            //Introduce try catches = most methods where unable to predict input/output
            cardprinter.SetCardPrintText("");
        }

        public CardPrinter()
        {
            if (instance!= null)
            {
            }
        }

        public void ClosedCardprinter()
        {
        
        }

        public void PrintCardCompleteProcess()
        {
            cardprinter.PrintCard();
        }

        public void PrintCard(string pCardText)
        {
            cardprinter.SetCardPrintText(pCardText);
            PrintCardCompleteProcess();
        }

        private CardPrinter(string printText)
        {
            cardprinter.SetCardPrintText(printText);
        }

        public void SetCardPrinterInstanceCardText(string printText)
        {
            cardprinter.SetCardPrintText(printText);
        }

        public static CardPrinter Instance
        {
            get
            {
                return instance;
            }
        }
        #endregion
    }
}

