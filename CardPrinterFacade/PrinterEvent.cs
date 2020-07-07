


namespace CardPrinterFacade
{
    using System;
    using System.Runtime.InteropServices;
    using CardPrinterSDKv1;
    using CardPrinterSDKv1.Model;
    using global::CardPrinterFacade.Interface;
    using static CardPrinterSDKv1.Win32;

    public class PrinterEvent
    {
        #region Fields
        private SmartComm2.SMART_PRINTER_LIST deviceList;
        private IntPtr deviceList_ptr;
        private Int32 printerresponse;
        private Int64 hsmartprinterid = 0;
        private IntPtr hsmartprinter_ptr;
        private string printerStrDescription = "";
        private IntPtr printerStrDescription_ptr;
        private string textToPrintOnCard = "";
        private Boolean isCardPrintDone = false;
        private Boolean isCardPresent = false;
        private Boolean isCardRetracted = false;
        private Boolean isCardPresented = false;
        private string printerStatus = "Waiting for Printer";
        private Int64 valuePlaceholder = 0;
        private Int64 placeHolderStatus = 0;
        private Printer printer;
        //private readonly Byte pbuf[300];
        private Int64 pnRead = 300;
        private Int64 m_nTestModeSet = 0;
        Int64 CENTER_SENSOR = 0x20;
        Int64 OUT_SENSOR = 0x40;
        private readonly EventLogger _eventLogger;
        #endregion

        #region Properties
        /// <summary>
        /// Property : Card Present in Card Printer
        /// </summary>
        public bool printerHasCard => isCardPresent;

        /// <summary>
        /// Property : Card Printer finish Printing
        /// </summary>
        public bool printerPrintComplete => isCardPrintDone;

        /// <summary>
        /// Property : Card Has been issued
        /// </summary>
        public bool printerhasCardIssued => isCardPresented;

        /// <summary>
        /// Property : Card Present in Tray
        /// </summary>
        public bool printerHasCardinTray => isCardRetracted;

        #endregion

        #region Methods
        /// <summary>
        /// Set Card Printer Print Text
        /// </summary>
        /// <param name="pPrintText"></param>
        public new void SetCardPrintText(String pPrintText)
        {
            textToPrintOnCard = pPrintText;
        }

        /// <summary>
        /// Get List of Available Card Printers
        /// </summary>
        private string getDeviceList()
        {
            // get device list
            deviceList_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(SmartComm2.SMART_PRINTER_LIST)));
            int convertedPointer = (int)deviceList_ptr.ToInt64();
            printerresponse = SmartComm2.SmartComm_GetDeviceList2((long)deviceList_ptr);
            object listUndefined = Marshal.PtrToStructure(deviceList_ptr, typeof(SmartComm2.SMART_PRINTER_LIST));
            deviceList = (SmartComm2.SMART_PRINTER_LIST)listUndefined;

            if (printerresponse != SmartComm2.SM_SUCCESS)
            {
                Marshal.FreeHGlobal(deviceList_ptr);
            }

            int i;
            SmartComm2.SMART_PRINTER_ITEM smartItem = deviceList.item[0];

            for (i = 0; i <= deviceList.n - 1; i++)
            {
                printerStrDescription = new string(deviceList.item[i].desc);
            }

            Marshal.FreeHGlobal(deviceList_ptr);
            return printerStrDescription;
        }

        /// <summary>
        /// Presents card out back of card Printer
        /// </summary>
        public void PrinterCardOutBack()
        {
            //Move Card Out
            if (hsmartprinterid != 0 && printerHasCard)
            {
                Int32 nres2;
                nres2 = SmartComm2.SmartComm_CardOutBack(hsmartprinterid);
                if (printerresponse == SmartComm2.SM_SUCCESS)
                {
                    printerStatus = "Card in back";
                    printerresponse = nres2;
                }
            }
        }

        /// <summary>
        /// Moves card back into tray
        /// </summary>
        public void PrinterMoveCardMegnetic()
        {
            //Move Card Out
            if (hsmartprinterid != 0 && printerHasCard)
            {
                Int32 nres2;
                nres2 = SmartComm2.SmartComm_Move(hsmartprinterid, SmartComm2.CARDPOS_MAGNETIC);
                if (printerresponse == SmartComm2.SM_SUCCESS)
                {
                    printerStatus = "Card in Tray";
                    SetPrinterStatus(nres2);
                    printerresponse = nres2;
                }
            }
        }

        /// <summary>
        /// Moves card to card bin
        /// </summary>
        public void PrinterBinCard()
        {
            if (hsmartprinterid != 0)
            {
                Int32 nres2;
                nres2 = SmartComm2.SmartComm_CardOut(hsmartprinterid);
                if (printerresponse == SmartComm2.SM_SUCCESS)
                    printerresponse = nres2;

                printerStatus = "Card has been Binned";
                SetPrinterStatus(nres2);
            }
        }


        /// <summary>
        /// Opens first Card printer on card printer device list
        /// </summary>
        private void openCardPrinter()
        {
            getDeviceList();
            // open device
            hsmartprinter_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(Int64)));
            printerresponse = SmartComm2.SmartDCL_OpenDevice2((long)hsmartprinter_ptr, (long)printerStrDescription_ptr, SmartComm2.SMART_OPENDEVICE_BYDESC, DMORIENT_LANDSCAPE);
            if (printerresponse == SmartComm2.SM_SUCCESS)
                hsmartprinterid = Marshal.ReadInt64(hsmartprinter_ptr);
            Marshal.FreeHGlobal(hsmartprinter_ptr);
            Marshal.FreeHGlobal(printerStrDescription_ptr);

            moveCardIntoPrinter();
        }


        /// <summary>
        /// Moves card into card printer from card stock
        /// </summary>
        private void moveCardIntoPrinter()
        {
            string strDesc = "";
            IntPtr strDesc_ptr;
            int nres;
            IntPtr hsmart_ptr;
            SmartComm2.SMART_PRINTER_INFO DevInfo;
            IntPtr DevInfo_ptr;


            getDeviceList();

            // acquire destination device information
            strDesc_ptr = Marshal.StringToHGlobalUni(strDesc);
            DevInfo_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(SmartComm2.SMART_PRINTER_INFO)));
            nres = SmartComm2.SmartComm_GetDeviceInfo2((long)DevInfo_ptr, (long)strDesc_ptr, SmartComm2.SMART_OPENDEVICE_BYDESC);
            DevInfo = (SmartComm2.SMART_PRINTER_INFO)Marshal.PtrToStructure(DevInfo_ptr, typeof(SmartComm2.SMART_PRINTER_INFO));
            Marshal.FreeHGlobal(DevInfo_ptr);

            Int32 devGroup = 0;
            switch ((DevInfo.std.pid >> 4))
            {
                case 0x385:
                    {
                        devGroup = SmartComm2.GROUP_SMART50;   // PRINTER_50
                        break;
                    }

                case 0x386:
                    {
                        devGroup = SmartComm2.GROUP_SMART50;   // PRINTER_50
                        break;
                    }

                case 0x387:
                    {
                        devGroup = SmartComm2.GROUP_SMART50;   // PRINTER_30
                        break;
                    }

                case 0x388:
                    {
                        devGroup = SmartComm2.GROUP_SMART50;   // PRINTER_30
                        break;
                    }

                case 0x370:
                    {
                        devGroup = SmartComm2.GROUP_SMART70;   // PRINTER_70
                        break;
                    }

                case 0x351:
                    {
                        devGroup = SmartComm2.GROUP_SMART51;   // PRINTER_51
                        break;
                    }

                case 0x331:
                    {
                        devGroup = SmartComm2.GROUP_SMART51;   // PRINTER_31
                        break;
                    }
            }

            // open device
            hsmart_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(Int64)));
            nres = SmartComm2.SmartDCL_OpenDevice2((long)hsmart_ptr, (long)strDesc_ptr, SmartComm2.SMART_OPENDEVICE_BYDESC, DMORIENT_LANDSCAPE);
            if (nres == SmartComm2.SM_SUCCESS)
                hsmartprinterid = Marshal.ReadInt64(hsmart_ptr);
            Marshal.FreeHGlobal(hsmart_ptr);
            Marshal.FreeHGlobal(strDesc_ptr);


            // enter sbs mode
            if (nres == SmartComm2.SM_SUCCESS)
            {
                nres = 111;
                nres = SmartComm2.SmartComm_SBSStart((long)hsmartprinterid);
            }

            // card in
            if (nres == SmartComm2.SM_SUCCESS)
            {
                nres = 111;
                nres = SmartComm2.SmartComm_CardIn((long)hsmartprinterid);
            }
        }


        /// <summary>
        /// Returns card printer status
        /// </summary>
        /// <param name="nres"></param>
        private void SetPrinterStatus(Int64 nres)
        {
            #region Switch
            switch (nres) {
                #region Case SM_Success
                case SmartComm2.SM_SUCCESS:
                    if (nres == SmartComm2.SM_SUCCESS)
                    {
                        return;
                    }
                    else
                    {
                        printerStatus = nres.ToString();
                    }   
                    break;
                #endregion

                #region Case SM_F_INVALIDHANDLE
                case SmartComm2.SM_F_INVALIDHANDLE:
                printerStatus = "Invalid Hangle Operation";
                    break;
                #endregion

                #region Case SM_F_CARDISINSIDE
                case SmartComm2.SM_F_CARDISINSIDE:
                    printerStatus = "Card Inside";
                    break;
                #endregion

                #region Case SM_F_NOCARDISINSIDE
                case SmartComm2.SM_F_NOCARDISINSIDE:
                printerStatus = "No Card Inside";
                    break;
                #endregion

                #region Case SM_F_WAITTIMEOUT
                case SmartComm2.SM_F_WAITTIMEOUT:
                printerStatus = "Action Time Out";
                    break;
                #endregion

                #region Case SM_F_ERRORSTATUS
                case SmartComm2.SM_F_ERRORSTATUS:
                    printerStatus = "Card Error Status";
                    break;
                #endregion

                #region Case SM_F_CARDOUTBACK
                case SmartComm2.SM_F_CARDOUTBACK:
                printerStatus = "Card is Out Back";
                        break;
                #endregion

                #region Case SM_F_NOPRINTDATA
                case SmartComm2.SM_F_NOPRINTDATA:
                printerStatus = "Nothing to Print";
                        break;
                #endregion

                #region Case SM_F_EMPTYRIBBON
                case SmartComm2.SM_F_EMPTYRIBBON:
                printerStatus = "Empty Ribbon";
                        break;
                #endregion

                #region Case SM_F_OVERHEATED
                case SmartComm2.SM_F_OVERHEATED:
                printerStatus = "Printer has overheated";
                        break;
                #endregion

                #region Case SMSC_F_CARDOUT
                case SmartComm2.SMSC_F_CARDOUT:
                printerStatus = "Card moving out error ";
                        break;
                #endregion

                #region Case SMSC_F_PRINT
                case SmartComm2.SMSC_F_PRINT:
                printerStatus = "Fail in printing";
                        break;
                #endregion

                #region Case SMSC_S_HOPPERHASCARD
                case SmartComm2.SMSC_S_HOPPERHASCARD:
                printerStatus = "Card is in Hopper";
                        break;
                #endregion

                #region Case SMSC_M_INIT
                case SmartComm2.SMSC_M_INIT:
                printerStatus = "Under initialization ";
                        break;
                #endregion

                #region Case SM_F_CARDIN
                case SmartComm2.SM_F_CARDIN:
                printerStatus = "Unable to pull in card";
                isCardPresent = false;
                        break;
                #endregion

                #region Case SM_F_MOVE2MAG
                case SmartComm2.SM_F_MOVE2MAG:
                printerStatus = "Card has been removed";
                isCardPresent = false;
                        break;
                    #endregion
            }
            #endregion
        }

        public int EnterTestMode()
        {
            int nres;

            nres = SmartComm2.SmartComm_GetStatus((long)hsmartprinterid, m_nTestModeSet);
            if (nres == SmartComm2.SM_SUCCESS)
            {
                m_nTestModeSet &= SmartComm2.SMSC_S_TESTMODE;
                if (m_nTestModeSet == 0x00)
                    nres = SmartComm2.SmartCommEx_ToggleTestMode((long)hsmartprinterid);
            }

            return nres;
        }

        public int OperateStepMotor()
        {
            int nres;
            int ncmdlen = 13;
            byte pcmd = 0x40;
            nres = SmartComm2.SmartCommEx_CmdSend((long)hsmartprinterid, pcmd, ncmdlen);
            if (nres == SmartComm2.SM_SUCCESS)
            {
            }
            return nres;
        }

        Int64 SMSC_S_TESTMODE = 0x0000000080000000;
        public int ExitTestMode()
        {
            int nres;
            Int64 uis = SMSC_S_TESTMODE;
            nres = SmartComm2.SmartComm_GetStatus((long)hsmartprinterid, (long)uis);
            if (nres == SmartComm2.SM_SUCCESS)
            {
                uis &= SmartComm2.SMSC_S_TESTMODE;
                if (m_nTestModeSet != uis)
                    nres = SmartComm2.SmartCommEx_ToggleTestMode((long)hsmartprinterid);
            }

            return nres;
        }

        /// <summary>
        /// Prints a card using the first printer on the card printer device list.
        /// </summary>
        public void PrintCard()
        {
            string strDesc = "";
            IntPtr strDesc_ptr;
            int nres;
            IntPtr hsmart_ptr;
            SmartComm2.SMART_PRINTER_INFO DevInfo;
            IntPtr DevInfo_ptr;

            nres = AllocateCardprinter();

            if (nres != SmartComm2.SM_SUCCESS)
            {
                Marshal.FreeHGlobal(deviceList_ptr);
                return;
            }
            else
            {
                printerStatus = "no printer";
            }

            int i;
            SmartComm2.SMART_PRINTER_ITEM smartItem = deviceList.item[0];

            for (i = 0; i <= deviceList.n - 1; i++)
            {
                printerStatus = "Ready for printing";
                strDesc = new string(deviceList.item[i].desc);
            }

            Marshal.FreeHGlobal(deviceList_ptr);
            printerStatus = "Preparing device";

            int devGroup;

            AquireDeviceInformation(strDesc, out strDesc_ptr, out nres, out DevInfo, out DevInfo_ptr, out devGroup);

            nres = 111111;
            try
            {
                OpenCardprinter(strDesc_ptr, out nres, out hsmart_ptr);

                nres = EnterSBSMode(nres);

                //SetPrinterStatus(nres);

                nres = PullCardIntoCardprinter(nres);

                //SetPrinterStatus(nres);

                nres = PrepareCardforPrinting(nres);

                //SetPrinterStatus(nres);

                nres = UpdatePrinterSettings(nres, DevInfo, devGroup);

                //SetPrinterStatus(nres);

                nres = PrepareCardText(nres);

                //SetPrinterStatus(nres);

                nres = PrintCard(nres, DevInfo);

                //SetPrinterStatus(nres);

                nres = CompleteFrontPrint(nres);

                nres = RotateCardifPossible(nres, DevInfo);

                //SetPrinterStatus(nres);

                nres = ClosePrintDocument(nres);

                //SetPrinterStatus(nres);

                nres = PresetCard(nres);

                //SetPrinterStatus(nres);

                nres = LeaveSBSMode(nres);

                //SetPrinterStatus(nres);

            }
            catch
            {
                throw;
            }
        }

        private int AllocateCardprinter()
        {
            printerStatus = "initializing printer";
            // get device list
            int nres;
            deviceList_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(SmartComm2.SMART_PRINTER_LIST)));
            int convertedPointer = (int)deviceList_ptr.ToInt64();
            nres = SmartComm2.SmartComm_GetDeviceList2((long)deviceList_ptr);
            object listUndefined = Marshal.PtrToStructure(deviceList_ptr, typeof(SmartComm2.SMART_PRINTER_LIST));
            deviceList = (SmartComm2.SMART_PRINTER_LIST)listUndefined;
            return nres;
        }

        private static void AquireDeviceInformation(string strDesc, out IntPtr strDesc_ptr, out int nres, out SmartComm2.SMART_PRINTER_INFO DevInfo, out IntPtr DevInfo_ptr, out int devGroup)
        {
            // acquire destination device information
            strDesc_ptr = Marshal.StringToHGlobalUni(strDesc);
            DevInfo_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(SmartComm2.SMART_PRINTER_INFO)));
            nres = SmartComm2.SmartComm_GetDeviceInfo2((long)DevInfo_ptr, (long)strDesc_ptr, SmartComm2.SMART_OPENDEVICE_BYDESC);
            DevInfo = (SmartComm2.SMART_PRINTER_INFO)Marshal.PtrToStructure(DevInfo_ptr, typeof(SmartComm2.SMART_PRINTER_INFO));
            Marshal.FreeHGlobal(DevInfo_ptr);

            devGroup = 0;
            switch ((DevInfo.std.pid >> 4))
            {
                case 0x385:
                    {
                        devGroup = SmartComm2.GROUP_SMART50;   // PRINTER_50
                        break;
                    }

                case 0x386:
                    {
                        devGroup = SmartComm2.GROUP_SMART50;   // PRINTER_50
                        break;
                    }

                case 0x387:
                    {
                        devGroup = SmartComm2.GROUP_SMART50;   // PRINTER_30
                        break;
                    }

                case 0x388:
                    {
                        devGroup = SmartComm2.GROUP_SMART50;   // PRINTER_30
                        break;
                    }

                case 0x370:
                    {
                        devGroup = SmartComm2.GROUP_SMART70;   // PRINTER_70
                        break;
                    }

                case 0x351:
                    {
                        devGroup = SmartComm2.GROUP_SMART51;   // PRINTER_51
                        break;
                    }

                case 0x331:
                    {
                        devGroup = SmartComm2.GROUP_SMART51;   // PRINTER_31
                        break;
                    }
            }
        }

        private void OpenCardprinter(IntPtr strDesc_ptr, out int nres, out IntPtr hsmart_ptr)
        {
            // open device
            hsmart_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(Int64)));
            nres = SmartComm2.SmartDCL_OpenDevice2((long)hsmart_ptr, (long)strDesc_ptr, SmartComm2.SMART_OPENDEVICE_BYDESC, DMORIENT_LANDSCAPE);
            if (nres == SmartComm2.SM_SUCCESS)
                hsmartprinterid = Marshal.ReadInt64(hsmart_ptr);
            Marshal.FreeHGlobal(hsmart_ptr);
            Marshal.FreeHGlobal(strDesc_ptr);

            SetPrinterStatus(nres);
        }

        private int EnterSBSMode(int nres)
        {
            // enter sbs mode
            if (nres == SmartComm2.SM_SUCCESS)
            {
                printerStatus = "SBS Start";
                nres = 111;
                nres = SmartComm2.SmartComm_SBSStart((long)hsmartprinterid);
            }

            return nres;
        }

        private int PullCardIntoCardprinter(int nres)
        {
            // card in
            if (nres == SmartComm2.SM_SUCCESS)
            {
                printerStatus = "Moving Card into Tray";
                nres = 111;
                nres = SmartComm2.SmartComm_CardIn((long)hsmartprinterid);
                isCardPresent = true;
            }

            return nres;
        }

        private int PrepareCardforPrinting(int nres)
        {
            if (nres == SmartComm2.SM_F_CARDISINSIDE)
            {
                isCardPresent = true;
                printerStatus = "Preparing card for print";
                nres = SmartComm2.SM_SUCCESS;
                nres = SmartComm2.SmartComm_Move((long)hsmartprinterid, SmartComm2.CARDPOS_PRINT);
            }

            return nres;
        }

        private int UpdatePrinterSettings(int nres, SmartComm2.SMART_PRINTER_INFO DevInfo, int devGroup)
        {
            // change printer settings to both print, if possible
            if (DevInfo.opt.is_dual == SmartComm2.VC_TRUE)
            {
                if (devGroup == SmartComm2.GROUP_SMART50)
                {
                    nres = ConfigureSmart50(nres);
                }
                else if (devGroup == SmartComm2.GROUP_SMART51)
                {
                    nres = ConfigureSmart51(nres);
                }
            }

            return nres;
        }

        private int ConfigureSmart51(int nres)
        {
            SmartComm2.SMART51_DEVMODE smdm;
            IntPtr smdm_ptr;
            Int32 dmlen = Marshal.SizeOf(typeof(SmartComm2.SMART51_DEVMODE));
            IntPtr dmlen_ptr = Marshal.AllocHGlobal(dmlen);

            // allocate printer
            smdm_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(SmartComm2.SMART51_DEVMODE)));
            Marshal.WriteInt32(dmlen_ptr, dmlen);

            // get current printer settings...
            if (nres == SmartComm2.SM_SUCCESS)
                nres = SmartComm2.SmartComm_GetPrinterSettings2((long)hsmartprinterid, (int)smdm_ptr, (int)dmlen_ptr);
            // set to both printing...
            smdm = (SmartComm2.SMART51_DEVMODE)Marshal.PtrToStructure(smdm_ptr, typeof(SmartComm2.SMART51_DEVMODE));
            smdm.devmode.dmOrientation = DMORIENT_LANDSCAPE;       // set landscape printing...
            smdm.oemdev.dwPrtSide = SmartComm2.SMART_PRINTSIDE_BOTH;
            Marshal.StructureToPtr(smdm, smdm_ptr, true);
            // change printer settings...
            if (nres == SmartComm2.SM_SUCCESS)
                nres = SmartComm2.SmartComm_SetPrinterSettings2((long)hsmartprinterid, (int)smdm_ptr, dmlen);

            // free
            Marshal.FreeHGlobal(smdm_ptr);
            Marshal.FreeHGlobal(dmlen_ptr);
            return nres;
        }

        private int ConfigureSmart50(int nres)
        {
            SmartComm2.SMART_DEVMODE smdm;
            IntPtr smdm_ptr;

            // alloc
            smdm_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(SmartComm2.SMART_DEVMODE)));

            // get current printer settings...
            if (nres == SmartComm2.SM_SUCCESS)
                nres = SmartComm2.SmartComm_GetPrinterSettings((long)hsmartprinterid, (int)smdm_ptr);
            // set to both printing...
            smdm = (SmartComm2.SMART_DEVMODE)Marshal.PtrToStructure(smdm_ptr, typeof(SmartComm2.SMART_DEVMODE));
            smdm.dmDevmode.dmOrientation = DMORIENT_LANDSCAPE;       // set landscape printing...
            smdm.dmOemdev.dwDocPrintSide = SmartComm2.SMART_PRINTSIDE_BOTH;
            Marshal.StructureToPtr(smdm, smdm_ptr, true);
            // change printer settings...
            if (nres == SmartComm2.SM_SUCCESS)
                nres = SmartComm2.SmartComm_SetPrinterSettings((long)hsmartprinterid, (int)smdm_ptr);

            // free smart printer
            Marshal.FreeHGlobal(smdm_ptr);
            return nres;
        }

        private int PrepareCardText(int nres)
        {
            // drawing routines are followed....
            // draw image to front page
            string strImg;
            IntPtr strImg_ptr;
            SmartComm2.RECT rcDraws;
            IntPtr rcDraws_ptr;

            // draw text to front page
            string strText;
            IntPtr strText_ptr;
            string strFont;
            IntPtr strFont_ptr;

            strText = textToPrintOnCard;
            strText_ptr = Marshal.StringToHGlobalUni(strText);
            strFont = "Tahoma";
            strFont_ptr = Marshal.StringToHGlobalUni(strFont);
            rcDraws_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(SmartComm2.RECT)));
            if (nres == SmartComm2.SM_SUCCESS)
                nres = SmartComm2.SmartComm_DrawText((long)hsmartprinterid, System.Convert.ToByte(SmartComm2.PAGE_FRONT), System.Convert.ToByte(SmartComm2.PANEL_BLACK), 90, 480, (long)strFont_ptr, 11, SmartComm2.FONT_BOLD, (long)strText_ptr, (long)rcDraws_ptr);
            Marshal.FreeHGlobal(strText_ptr);
            Marshal.FreeHGlobal(strFont_ptr);
            Marshal.FreeHGlobal(rcDraws_ptr);
            return nres;
        }

        private int PrintCard(int nres, SmartComm2.SMART_PRINTER_INFO DevInfo)
        {
            // print
            if (nres == SmartComm2.SM_SUCCESS)
            {
                if (DevInfo.opt.is_dual == SmartComm2.VC_FALSE)
                    nres = SmartComm2.SmartDCL_Print((long)hsmartprinterid, SmartComm2.SMART_PRINTSIDE_FRONT);
                else
                    nres = SmartComm2.SmartDCL_Print((long)hsmartprinterid, SmartComm2.SMART_PRINTSIDE_BOTH);
            }

            return nres;
        }

        private int CompleteFrontPrint(int nres)
        {
            // print front page
            if (nres == SmartComm2.SM_SUCCESS)
            {
                printerStatus = "Print Ready";
                nres = SmartComm2.SmartComm_DoPrint((long)hsmartprinterid);
            }

            return nres;
        }

        private int RotateCardifPossible(int nres, SmartComm2.SMART_PRINTER_INFO DevInfo)
        {
            // print back pageand rotator is installed
            if (nres == SmartComm2.SM_SUCCESS & DevInfo.opt.is_dual == SmartComm2.VC_TRUE)
            {
                printerStatus = "Printing";
                nres = SmartComm2.SmartComm_DoPrint((long)hsmartprinterid);
                isCardPrintDone = true;
                printerStatus = "Print Complete";
            }

            return nres;
        }

        private int ClosePrintDocument(int nres)
        {
            // close document...
            if (nres == SmartComm2.SM_SUCCESS)
            {
                nres = SmartComm2.SmartComm_CloseDocument((long)hsmartprinterid);
            }
            else
            {
                _eventLogger.LogError("Unable to close printer : " + nres);
            }

            return nres;
        }

        private int PresetCard(int nres)
        {
            // card out
            if (hsmartprinterid != 0 && nres == SmartComm2.SM_SUCCESS)
            {
                Int32 nres2;
                nres2 = SmartComm2.SmartComm_CardOutBack((long)hsmartprinterid);
                if (nres == SmartComm2.SM_SUCCESS)
                    nres = nres2;

                printerStatus = "Card in back";
            }

            return nres;
        }

        private int LeaveSBSMode(int nres)
        {
            // leave sbs-mode
            if (hsmartprinterid != 0)
            {
                Int32 nres2;
                nres2 = SmartComm2.SmartComm_SBSEnd((long)hsmartprinterid);
                if (nres == SmartComm2.SM_SUCCESS)
                    nres = nres2;
            }

            return nres;
        }

        private int CloseCardPrinter(int nres)
        {
            // close card printer...
            if (nres == SmartComm2.SM_SUCCESS)
            {
                nres = SmartComm2.SmartComm_CloseDevice((long)hsmartprinterid);
            }
            else
            {
                _eventLogger.LogError("Unable to close printer : " + nres);
            }

            return nres;
        }

        #endregion
    }
}
