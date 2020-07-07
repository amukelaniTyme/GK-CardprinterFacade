using CardPrinterFacade.Interface;
using CardPrinterFacade.Model;
using System;

namespace CardPrinterFacade
{
    public class CardPrinterFacade : ICardPrinter
    {

        //Subsystem 1 - Card printer
        private readonly CardPrinter _cardprinter;
        //Subsystem 2 - event logger
        private readonly EventLogger _eventLogger;

        public CardPrinterFacade()
        {
            _cardprinter = new CardPrinter();
        }

        public void ClosePrinter()
        {
            //_cardprinter.Closeprinter()
            throw new NotImplementedException();
        }

        public string GetPrinterStatus()
        {
            //_cardprinter.GetPrinterStatus()
            throw new NotImplementedException();
        }

        public string GetStatus()
        {
            //return _cardprinter.GetStatus()
            throw new NotImplementedException();
        }

        public void PrintCard(String pText)
        {
            _cardprinter.PrintCard(pText);
          //  throw new NotImplementedException();
        }

        public void PrintCard()
        {
            _cardprinter.PrintCardCompleteProcess();
        }

        public void PrinterBinCard()
        {
            //_cardprinter.BinCard()
            throw new NotImplementedException();
        }

        public void PrinterCardOutBack()
        {
            //_cardprinter.sendCardOutBack()
            throw new NotImplementedException();
        }

        public void SetCardPrintText(string pPrintText)
        {
            _cardprinter.SetCardPrinterInstanceCardText(pPrintText);
            //throw new NotImplementedException();
        }
    }
}
