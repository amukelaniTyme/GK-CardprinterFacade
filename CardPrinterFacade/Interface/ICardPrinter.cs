namespace CardPrinterFacade.Interface
{
    public interface ICardPrinter
    {

        #region Methods
        /// <summary>
        /// Method : Set Card Printing Text
        /// </summary>
        public void SetCardPrintText(string pPrintText);

        /// <summary>
        /// Method : Returns card printer status
        /// </summary>
        string GetPrinterStatus();

        /// <summary>
        /// Method : Returns card printer status
        /// </summary>
        string GetStatus();

        /// <summary>
        /// Method : Print Card
        /// </summary>
        public void PrintCard();

        /// <summary>
        /// Method : Moves Card out back of card printer
        /// </summary>
        public void PrinterCardOutBack();

        /// <summary>
        /// Method : Bins Card Currently in  card printer
        /// </summary>
        public void PrinterBinCard();

        /// <summary>
        /// Method : Closes card printer connection
        /// </summary>
        public void ClosePrinter();
        #endregion

    }
}
