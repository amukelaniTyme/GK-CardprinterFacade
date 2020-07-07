namespace CardPrinterSDKv1
{
    using System;
    using System.Drawing;
    using System.Runtime.InteropServices;

    [StandardModule]
    public class SmartComm2
    {
        public const int MAX_SMART_PRINTER = 32;
        public const int VC_NULL = 0;
        public const int VC_TRUE = 1;
        public const int VC_FALSE = 0;
        public const int PRINTER_SMART50 = 0;
        public const int PRINTER_SMART30 = 1;
        public const int PRINTER_SMART70 = 2;
        public const int PRINTER_SMART51 = 3;
        public const int GROUP_SMART50 = 0;
        public const int GROUP_SMART70 = 1;
        public const int GROUP_SMART51 = 2;
        public const int SMART_DEVICELIST_USB = 1;
        public const int SMART_DEVICELIST_NET = 2;
        public const int SMART_DEVICELIST_ALL = 3;
        public const int SMART_OPENDEVICE_BYID = 0;
        public const int SMART_OPENDEVICE_BYDESC = 1;
        public const int CARDPOS_PRINT = 0;
        public const int CARDPOS_MAGNETIC = 1;
        public const int CARDPOS_IC = 2;
        public const int CARDPOS_RF2 = 6;
        public const int PAGE_FRONT = 0;
        public const int PAGE_BACK = 1;
        public const int PANEL_COLOR = 1;
        public const int PANEL_BLACK = 2;
        public const int PANEL_OVERLAY = 4;
        public const int PANEL_FLUORESCENT = 8;
        public const int MAG_T1 = 1;
        public const int MAG_T2 = 2;
        public const int MAG_T3 = 4;
        public const int MAG_JIS = 8;
        public const int MAG_T1MAX = 76;
        public const int MAG_T2MAX = 37;
        public const int MAG_T3MAX = 104;
        public const int MAG_JISMAX = 69;
        public const int MAG_NORMAL = 0;
        public const int MAG_HIGHCO = 16;
        public const int MAG_SUPERCO = 32;
        public const int MAG_USERCO = 48;
        public const int MAG_BITMODE = 128;
        public const int SMART_MAG_LOCO = 0;
        public const int SMART_MAG_HICO = 1;
        public const int SMART_MAG_SPCO = 2;
        public const int SMART_MAG_AUTO = 3;
        public const int SMART_MAG_NOREPEAT = 0;
        public const int SMART_MAG_REPEAT1 = 1;
        public const int SMART_MAG_REPEAT2 = 2;
        public const int SMART_MAG_REPEAT3 = 3;
        public const int SMART_MAG_REPEAT4 = 4;
        public const int SMART_MAG_FORMAT_IATA = 0;
        public const int SMART_MAG_FORMAT_ABA = 1;
        public const int SMART_MAG_FORMAT_MINS = 2;
        public const int SMART_MAG_FORMAT_JIS2 = 3;
        public const int SMART_MAG_FORMAT_BITS = 4;
        public const int OPT_INTERNAL = 1;
        public const int OPT_EXTERNAL = 2;
        public const int LCD_LINE1 = 0;
        public const int LCD_LINE2 = 1;
        public const int LCD_LINE3 = 2;
        public const int LCD_LINE4 = 3;
        public const int LCD_LINE5 = 4;
        public const int LCD_LINE6 = 5;
        public const int LCD_LINE7 = 6;
        public const int LCD_LINE8 = 7;
        public const int LCD_TYPE_CH = 0;
        public const int LCD_TYPE_GSMALL = 1;
        public const int LCD_TYPE_GBIG = 2;
        public const int LCD_LENSMALL = 21;
        public const int LCD_LENBIG = 16;
        public const int OBJ_ALIGN_LEFT = 0;
        public const int OBJ_ALIGN_CENTER = 1;
        public const int OBJ_ALIGN_RIGHT = 2;
        public const int OBJ_ALIGN_JUSTIFY = 3;
        public const int OBJ_ALIGN_HNOALIGN = 4;
        public const int OBJ_ALIGN_TOP = 0;
        public const int OBJ_ALIGN_MIDDLE = 16;
        public const int OBJ_ALIGN_BOTTOM = 32;
        public const int OBJ_ALIGN_VNOALIGN = 48;
        public const int OBJ_ALIGN_CENTERMIDDLE = 0;
        public const int OBJ_ALIGN_NOALIGN = 0;
        public const int IMGSCALE_FITHORZ = 0;
        public const int IMGSCALE_FITVERT = 1;
        public const int IMGSCALE_FITFRAME = 2;
        public const int IMGSCALE_USER = 3;
        public const int IMGSCALE_BASEAMP = 10000;
        public const int IMGEFFECT_CONTRASTMIN = -100;
        public const int IMGEFFECT_CONTRASTMAX = 100;
        public const int IMGEFFECT_BRIGHTMIN = -256;
        public const int IMGEFFECT_BRIGHTMAX = 255;
        public const int FONT_NORMAL = 0;
        public const int FONT_BOLD = 1;
        public const int FONT_ITALIC = 2;
        public const int FONT_UNDERLINE = 4;
        public const int FONT_STRIKEOUT = 8;
        public const int MAX_FIELDNAMELEN = 32;
        public const int MAX_FIELDVALUELEN = 1024;
        public const int SMART_DEFAULT_LENGTH = 1012;
        public const int SMART_DEFAULT_HEIGHT = 636;
        public const int SMART_ENCODE_NORMAL = 0;
        public const int SMART_ENCODE_REVERSE = 1;
        public const int SMART_ENCODE_BIT = 2;
        public const int SMART_ENCODE_HICO_NORM = 3;
        public const int SMART_ENCODE_HICO_REV = 4;
        public const int SMART_ENCODE_HICO_BIT = 5;
        public const int SMART_SUPPLY_AUTO = 0;
        public const int SMART_SUPPLY_HOPPER = 1;
        public const int SMART_TRAY_CR80 = 0;
        public const int SMART_RIBBON_YMCKO = 0;
        public const int SMART_RIBBON_YMCKOK = 1;
        public const int SMART_RIBBON_hYMCKO = 2;
        public const int SMART_RIBBON_KO = 3;
        public const int SMART_RIBBON_K = 4;
        public const int SMART_RIBBON_BO = 5;
        public const int SMART_RIBBON_B = 6;

        internal static int SmartDCL_OpenDevice2(long hsmartprinter_ptr, long printerStrDescription_ptr, int sMART_OPENDEVICE_BYDESC, object dMORIENT_LANDSCAPE)
        {
            throw new NotImplementedException();
        }

        public const int SMART_RIBBON_BYMCKO = 7;
        public const int SMART_RIBBON_YMCKFO = 8;
        public const int SMART_RIBBON_REWRITABLE = 9;
        public const int SMART_RESIN_BLACKTEXT = 0;
        public const int SMART_RESIN_BLACKDOT = 1;
        public const int SMART_RESIN_NOTUSE = 2;
        public const int CHSM_RIBBONSPLIT_NORMAL = 0;
        public const int CHSM_RIBBONSPLIT_FORBACK = 1;
        public const int SMART_QUALITY_STANDARD = 0;
        public const int SMART_QUALITY_VERYHIGH = 1;
        public const int SMART_QUALITY_PARTIAL = 2;
        public const int SMART_QUALITY_SEMIPARTIAL = 3;
        public const int SMART_COLOR_COLOR = 0;
        public const int SMART_COLOR_BLACKNWHITE = 1;
        public const int SMART_DITHER_THRESHOLD = 0;
        public const int SMART_DITHER_RANDOM = 1;
        public const int SMART_DITHER_DIFFUSION = 2;
        public const int SMART_PRINTSIDE_FRONT = 0;
        public const int SMART_PRINTSIDE_BOTH = 1;
        public const int SMART_MEDIA_STANDARD = 0;
        public const int SMART_MEDIA_SMART = 1;
        public const int SMART_MEDIA_SMARTRIGHT = 2;
        public const int SMART_MEDIA_MSISO = 3;
        public const int SMART_MEDIA_MSJIS = 4;
        public const int SMART_MEDIA_SMARTMSJIS = 5;
        public const int SMART_MEDIA_NOOVERLAY = 6;
        public const int SMART_MEDIA_USERDEFINED = 7;
        public const int SMART_LAMINATESIDE_NONE = 0;
        public const int SMART_LAMINATESIDE_TOP = 1;
        public const int SMART_LAMINATESIDE_BOTTOM = 2;
        public const int SMART_LAMINATESIDE_BOTH = 3;
        public const int SMART_EJECT_EJECT_CARD = 0;
        public const int SMART_EJECT_HOLD_CARD = 1;
        public const int SMART51_SENSOR_NONE = 0;
        public const int SMART51_SENSOR_CENTER = 1;
        public const int SMART51_SENSOR_REAR = 2;
        public const int SMART51_SENSOR_FLIPMOTOR = 3;
        public const int SMART51_SENSOR_FLIPCENTER = 4;
        public const int SMART51_SENSOR_FLIPREAR = 5;
        public const int SMART51_SENSOR_FLIPANGLE = 6;
        public const int MAGCFG_VER_1 = 1;
        public const int MAGCFG_BALLYS_NOTUSE = 0;
        public const int MAGCFG_BALLYS_1 = 1;
        public const int MAGCFG_BALLYS_2 = 2;
        public const int MAGCFG_FORWARD = 0;
        public const int MAGCFG_BACKWARD = 1;
        public const int MAGCFG_FORMAT_IATA = 0;
        public const int MAGCFG_FORMAT_ABA = 1;
        public const int MAGCFG_FORMAT_MINS = 2;
        public const int MAGCFG_FORMAT_JIS2 = 3;
        public const int MAGCFG_FORMAT_BITS = 4;
        public const int MIFARE_AUTHENT1A = 96;
        public const int MIFARE_AUTHENT1B = 97;
        public const int SMEX_CFG_STATUS51TO50 = 14;
        public const int SMEX_CFG_RESOLUTION = 16;
        public const int SMEX_CFG_USE = 1;
        public const int SMEX_CFG_NOTUSE = 0;
        public const int SMEX_CFG_RES300X300 = 1;
        public const int SMEX_CFG_RES300X600 = 2;
        public const int SMEX_CFG_RES300X1200 = 3;
        public const long UNITTYPE_IMAGE = 16;
        public const long UNITTYPE_TEXT = 32;
        public const long UNITTYPE_BARCODE = 64;
        public const long UNITINFO_FIRST = 0;
        public const long UNITINFO_NEXT = 1;
        public const long MAX_FONTNAME = 32;
        public const long SIZEOF_UNITTEXT = 156;
        public const long SIZEOF_UNITIMAGE = 104;
        public const long SIZEOF_UNITBAR = 94;
        public const long SIZEOF_UNITUNION = 156;
        public const long ALIGN_LEFT = 0;
        public const long ALIGN_CENTER = 1;
        public const long ALIGN_RIGHT = 2;
        public const long ALIGN_JUSTIFY = 3;
        public const long ALIGN_NOHALIGN = 4;
        public const long ALIGN_TOP = 0;
        public const long ALIGN_MIDDLE = 16;
        public const long ALIGN_BOTTOM = 32;
        public const long ALIGN_NOVALIGN = 48;
        public const long TEXT_NOFIT = 0;
        public const long TEXT_AUTOSIZE = 4;
        public const long SMSC_M_CARDIN = 1;
        public const long SMSC_M_CARDOUT = 2;
        public const long SMSC_M_MOVE_PRINT = 4;
        public const long SMSC_M_MOVE_PRN2ROT = 8;
        public const long SMSC_M_MOVE_ROT2PRN = 16;
        public const long SMSC_M_MOVE_IC = 32;
        public const long SMSC_M_MOVE_RF = 64;
        public const long SMSC_M_MOVE_MAG = 128;
        public const long SMSC_M_THUP = 256;
        public const long SMSC_M_THDOWN = 512;
        public const long SMSC_M_ICHUP = 1024;
        public const long SMSC_M_ICHDOWN = 2048;
        public const long SMSC_M_PRINT = 4096;
        public const long SMSC_M_MAGRW = 8192;
        public const long SMSC_M_SEEKRIBBON = 16384;
        public const long SMSC_M_MOVERIBBON = 32768;
        public const long SMSC_M_ROTATORTOP = 65536;
        public const long SMSC_M_ROTATORBOTTOM = 131072;
        public const long SMSC_S_HOPPERHASCARD = 262144;
        public const long SMSC_S_THUP = 524288;
        public const long SMSC_S_CLEANWARNING = 524288;
        public const long SMSC_S_CARDIN = 1048576;
        public const long SMSC_S_CARDOUT = 2097152;
        public const long SMSC_S_ROTATORTOP = 4194304;
        public const long SMSC_S_EQUIPLAMINATOR = 4194304;
        public const long SMSC_S_EQUIPROTATOR = 8388608;
        public const long SMSC_M_RECVPRINTDATA = 16777216;
        public const long SMSC_S_HASPRINTBUFFER = 33554432;
        public const long SMSC_M_SBSRUNNING = 67108864;
        public const long SMSC_S_SBSMODE = 134217728;
        public const long SMSC_S_CASEOPEN = 268435456;
        public const long SMSC_M_INIT = 536870912;
        public const long SMSC_S_TESTMODE = -2147483648;
        public const long SMSC_F_CARDIN = 4294967296;
        public const long SMSC_F_MOVETOPRINT = 8589934592;
        public const long SMSC_F_CARDOUT = 17179869184;
        public const long SMSC_F_MOVETOMAG = 34359738368;
        public const long SMSC_F_MOVETOIC = 68719476736;
        public const long SMSC_F_MOVETORF = 137438953472;
        public const long SMSC_F_MOVETOROTATOR = 274877906944;
        public const long SMSC_F_MOVEFROMROTATOR = 549755813888;
        public const long SMSC_F_THUP = 1099511627776;
        public const long SMSC_F_THDOWN = 2199023255552;
        public const long SMSC_F_ICHUP = 4398046511104;
        public const long SMSC_F_ICHDOWN = 8796093022208;
        public const long SMSC_F_ROTATORTOP = 17592186044416;
        public const long SMSC_F_ROTATORBOTTOM = 35184372088832;
        public const long SMSC_F_PRINT = 70368744177664;
        public const long SMSC_F_MAGRW = 140737488355328;
        public const long SMSC_E_SEEKRIBBON = 281474976710656;
        public const long SMSC_E_MOVERIBBON = 562949953421312;
        public const long SMSC_E_NOTH = 1125899906842624;
        public const long SMSC_E_THOVERHEAT = 2251799813685248;
        public const long SMSC_E_EMPTYRIBBON = 4503599627370496;
        public const long SMSC_F_DATA = 9007199254740992;
        public const long SMSC_F_CARDBACKOUT = 18014398509481984;
        public const long SMSC_F_CARDERASE = 36028797018963968;
        public const long SMSC_F_INCORRECT_PW = 72057594037927936;
        public const long SMSC_F_MAGREADT1 = 144115188075855872;
        public const long SMSC_F_MAGREADT2 = 288230376151711744;
        public const long SMSC_F_MAGREADT3 = 576460752303423488;
        public const long SMSC_F_LOCKED = 1152921504606846976;
        public const long SMSC_F_SPOOLFULL = 2305843009213693952;
        public const long SMSC_F_SET = 4611686018427387904;
        public const long LMSC_M_HEATHDRLIFTUP = 1;
        public const long LMSC_M_HEATHDRLIFTDOWN = 4;
        public const long LMSC_M_CARDIN = 16;
        public const long LMSC_M_MOVE_LAMINATE = 64;
        public const long LMSC_M_FRONTCARDOUT = 256;
        public const long LMSC_M_REARCARDOUT = 512;
        public const long LMSC_M_ROTATE = 1024;
        public const long LMSC_S_WAIT = 2048;
        public const long LMSC_S_CMDRUN = 8192;
        public const long LMSC_M_HEATING = 16384;
        public const long LMSC_S_CASEOPEN = 32768;
        public const long LMSC_M_LAMINATING = 65536;
        public const long LMSC_S_CARDINSENSOR = 536870912;
        public const long LMSC_S_CARDOUTSENSOR = 1073741824;
        public const long LMSC_S_OUTDOORSENSOR = -2147483648;
        public const long LMSC_E_HEATHDRLIFTUP = 4294967296;
        public const long LMSC_E_HEATHDRLIFTDOWN = 17179869184;
        public const long LMSC_E_CARDIN = 68719476736;
        public const long LMSC_E_MOVE_LAMINATE = 274877906944;
        public const long LMSC_E_FRONTCARDOUT = 1099511627776;
        public const long LMSC_E_REARCARDOUT = 2199023255552;
        public const long LMSC_E_ROTATE = 4398046511104;
        public const long LMSC_E_INIT = 140737488355328;
        public const long LMSC_E_EMPTYFILM = 281474976710656;
        public const long LMSC_E_NOFILM = -9223372036854775808;
        public const long S51PS_M_CARDIN = 1;
        public const long S51PS_M_CARDMOVE = 2;
        public const long S51PS_M_CARDMOVEEXT = 4;
        public const long S51PS_M_CARDEJECT = 8;
        public const long S51PS_M_THEADLIFT = 16;
        public const long S51PS_M_ICLIFT = 32;
        public const long S51PS_M_RIBBONSEARCH = 64;
        public const long S51PS_M_RIBBONWIND = 128;
        public const long S51PS_M_MAGNETIC = 256;
        public const long S51PS_M_PRINT = 512;
        public const long S51PS_M_INIT = 1024;
        public const long S51PS_S_CONNHOPPER = 2048;
        public const long S51PS_S_CONNICENCODEER = 4096;
        public const long S51PS_S_CONNMAGNETIC = 8192;
        public const long S51PS_S_CONNLAMINATOR = 16384;
        public const long S51PS_S_CONNFLIPPER = 32768;
        public const long S51PS_S_FLIPPERTOP = 65536;
        public const long S51PS_S_COVEROPENED = 131072;
        public const long S51PS_S_DETECTIN = 262144;
        public const long S51PS_S_DETECTOUT = 524288;
        public const long S51PS_S_CARDEMPTY = 1048576;
        public const long S51PS_S_RECVPRINTDATA = 2097152;
        public const long S51PS_S_HAVEPRINTDATA = 4194304;
        public const long S51PS_S_NEEDCLEANING = 67108864;
        public const long S51PS_S_SWLOCKED = 134217728;
        public const long S51PS_S_HWLOCKED = 268435456;
        public const long S51PS_M_SBSCOMMAND = 536870912;
        public const long S51PS_S_SBSMODE = 1073741824;
        public const long S51PS_S_TESTMODE = -2147483648;
        public const long S51PS_F_CARDIN = 4294967296;
        public const long S51PS_F_CARDMOVE = 8589934592;
        public const long S51PS_F_CARDMOVEEXT = 17179869184;
        public const long S51PS_F_CARDEJECT = 34359738368;
        public const long S51PS_F_THEADLIFT = 68719476736;
        public const long S51PS_F_ICLIFT = 137438953472;
        public const long S51PS_F_RIBBONSEARCH = 274877906944;
        public const long S51PS_F_RIBBONWIND = 549755813888;
        public const long S51PS_F_MAGNETIC = 1099511627776;
        public const long S51PS_F_READMAGT1 = 2199023255552;
        public const long S51PS_F_READMAGT2 = 4398046511104;
        public const long S51PS_F_READMAGT3 = 8796093022208;
        public const long S51PS_F_PRINT = 17592186044416;
        public const long S51PS_E_INIT = 35184372088832;
        public const long S51PS_E_CONNEXT = 70368744177664;
        public const long S51PS_E_CONNLAMINATOR = 140737488355328;
        public const long S51PS_E_CONNFLIPPER = 281474976710656;
        public const long S51PS_E_RIBBON0 = 9007199254740992;
        public const long S51PS_E_NORIBBON = 18014398509481984;
        public const long S51PS_E_NOTHEAD = 36028797018963968;
        public const long S51PS_E_OVERHEAT = 72057594037927936;
        public const long S51PS_F_INVALIDPRINTDATA = 144115188075855872;
        public const long S51PS_F_INVALIDPASSWORD = 288230376151711744;
        public const long S51PS_F_SET = 4611686018427387904;
        public const long S51PS_F_SPOOLFULL = -9223372036854775808;
        public const long S51FS_S_READY = 1;
        public const long S51FS_S_BUSY = 2;
        public const long S51FS_M_CARDMOVE = 4;
        public const long S51FS_M_CARDIN = 8;
        public const long S51FS_M_CARDEJECT = 16;
        public const long S51FS_M_FLIP = 32;
        public const long S51FS_S_FLIPTRAYTOPSIDED = 256;
        public const long S51FS_S_ACTIVATEDREARSENSOR = 33554432;
        public const long S51FS_M_CARDMOVESTEPMOTOR = 67108864;
        public const long S51FS_M_FLIPSTEPMOTOR = 134217728;
        public const long S51FS_S_COVERCLOSED = 268435456;
        public const long S51FS_S_CENTERSENSOR = 536870912;
        public const long S51FS_S_REARSENSOR = 1073741824;
        public const long S51FS_S_FLIPSENSOR = -2147483648;
        public const long S51FS_F_CARDIN = 4294967296;
        public const long S51FS_F_CARDMOVE = 8589934592;
        public const long S51FS_F_CARDEJECT = 17179869184;
        public const long S51FS_F_MOVEFLIPTRAY = 34359738368;
        public const long S51FS_F_COMMAND = 68719476736;
        public const long S51FS_E_INIT = 281474976710656;
        public const long S51LS_S_READY = 1;
        public const long S51LS_S_BUSY = 2;
        public const long S51LS_M_CARDMOVE = 4;
        public const long S51LS_M_CARDIN = 8;
        public const long S51LS_M_CARDEJECT = 16;
        public const long S51LS_M_THEADLIFT = 32;
        public const long S51LS_M_LAMINATE = 64;
        public const long S51LS_M_FLIPTRAYMOVE = 128;
        public const long S51LS_S_FLIPTRAYTOPSIDED = 256;
        public const long S51LS_M_HEATHEADHEAT = 65536;
        public const long S51LS_M_FILMMOTOR = 131072;
        public const long S51LS_M_HEADMOTOR = 262144;
        public const long S51LS_M_CARDMOVESTEPMOTOR = 524288;
        public const long S51LS_M_FLIPSTEPMOTOR = 1048576;
        public const long S51LS_S_DETECTENCODERCNTINC = 2097152;
        public const long S51LS_S_DETECTENCODERCNTDEC = 4194304;
        public const long S51LS_S_COVEROPENED = 8388608;
        public const long S51LS_S_LOCKSENSOR = 16777216;
        public const long S51LS_S_CARDCENTERSENSOR = 33554432;
        public const long S51LS_S_CARDOUTSENSOR = 67108864;
        public const long S51LS_S_FLIPPERCENTERSENSOR = 134217728;
        public const long S51LS_S_FLIPPERFLIPSENSOR = 268435456;
        public const long S51LS_S_HEADSENSOR = 536870912;
        public const long S51LS_S_FILMMARKMAINSENSOR = 1073741824;
        public const long S51LS_S_FILMMARKSUBSENSOR = -2147483648;
        public const long S51LS_F_CARDIN = 4294967296;
        public const long S51LS_F_CARDMOVE = 8589934592;
        public const long S51LS_F_CARDEJECT = 17179869184;
        public const long S51LS_F_HEADLIFT = 34359738368;
        public const long S51LS_F_LAMINATE = 68719476736;
        public const long S51LS_F_COMMAND = 137438953472;
        public const long S51LS_F_FLIPTRAYMOVE = 274877906944;
        public const long S51LS_E_INIT = 281474976710656;
        public const long S51LS_E_FILMSEARCH = 562949953421312;
        public const long S51LS_E_FILM0 = 1125899906842624;
        public const long S51LS_E_NOFILM = 2251799813685248;
        public const long S51LS_E_HEADOVERHEAT = 4503599627370496;
        public const int SM_SUCCESS = 0;
        public const int SM_FAIL = -1;
        public const int SM_F_FOUNDNODEV = -2147483648;
        public const int SM_F_INVALIDDEVIDX = -2147483647;
        public const int SM_F_INVALIDBUFPOINTER = -2147483646;
        public const int SM_F_NOTEXISTDEV = -2147483645;
        public const int SM_F_INVALIDPARAM = -2147483644;
        public const int SM_F_DEVOPENFAILED = -2147483643;
        public const int SM_F_DEVIO = -2147483642;
        public const int SM_F_FOUNDNODRV = -2147483641;
        public const int SM_F_INVALIDHANDLE = -2147483640;
        public const int SM_F_CARDISINSIDE = -2147483639;
        public const int SM_F_NOCARDISINSIDE = -2147483638;
        public const int SM_F_HOPPEREMPTY = -2147483637;
        public const int SM_F_NOCARDONBOTH = -2147483636;
        public const int SM_F_WAITTIMEOUT = -2147483635;
        public const int SM_F_CASEOPEN = -2147483634;
        public const int SM_F_ERRORSTATUS = -2147483633;
        public const int SM_F_CARDIN = -2147483632;
        public const int SM_F_CARDOUT = -2147483631;
        public const int SM_F_CARDOUTBACK = -2147483630;
        public const int SM_F_MOVE2MAG = -2147483629;
        public const int SM_F_MOVE2IC = -2147483628;
        public const int SM_F_MOVE2RF = -2147483627;
        public const int SM_F_MOVE2ROT = -2147483626;
        public const int SM_F_MOVE2DEV = -2147483625;
        public const int SM_F_MAGRW = -2147483624;
        public const int SM_F_NOPRINTDATA = -2147483623;
        public const int SM_F_PRINT = -2147483622;
        public const int SM_F_SEEKRIBBON = -2147483621;
        public const int SM_F_MOVERIBBON = -2147483620;
        public const int SM_F_EMPTYRIBBON = -2147483619;
        public const int SM_F_ICHUP = -2147483618;
        public const int SM_F_ICHDN = -2147483617;
        public const int SM_F_ROTTOP = -2147483616;
        public const int SM_F_ROTBOTTOM = -2147483615;
        public const int SM_F_REQNOMAGTRACK = -2147483614;
        public const int SM_F_REQMULTIMAGTRACK = -2147483613;
        public const int SM_F_FILENOTFOUND = -2147483612;
        public const int SM_F_FIELDNOTFOUND = -2147483611;
        public const int SM_F_IMAGELOAD = -2147483610;
        public const int SM_F_CREATEDC = -2147483609;
        public const int SM_F_VERIFYDRV = -2147483608;
        public const int SM_F_SPOOLING = -2147483607;
        public const int SM_F_DEVNOTOPENED = -2147483606;
        public const int SM_F_USEDBYOTHER = -2147483605;
        public const int SM_F_SOCKETCREATE = -2147483604;
        public const int SM_F_SOCKETCONNECT = -2147483603;
        public const int SM_F_SSLINIT = -2147483602;
        public const int SM_F_SSLCREATE = -2147483601;
        public const int SM_F_SSLCONNECT = -2147483600;
        public const int SM_F_RESERVED = -2147483599;
        public const int SM_F_INVALIDSOCKET = -2147483598;
        public const int SM_F_LESSSENDED = -2147483597;
        public const int SM_F_LESSRECVED = -2147483596;
        public const int SM_F_SOCKETERROR = -2147483595;
        public const int SM_F_INVALIDPACKET = -2147483594;
        public const int SM_F_PACKETSEQDIFFER = -2147483593;
        public const int SM_F_PACKETFLAGNOREPLY = -2147483592;
        public const int SM_F_PACKETFLAGHEADER = -2147483591;
        public const int SM_F_PACKETFLAGARGUMENT = -2147483590;
        public const int SM_F_PACKETFLAGEXE = -2147483589;
        public const int SM_F_PACKETFLAGBADCMD = -2147483588;
        public const int SM_F_PACKETFLAGINIT = -2147483587;
        public const int SM_F_PACKETFLAGHANDLE = -2147483586;
        public const int SM_F_FILEOPEN = -2147483585;
        public const int SM_F_FILEREAD = -2147483584;
        public const int SM_F_NOTSUPPORTYET = -2147483583;
        public const int SM_F_INSUFFICIENTBUF = -2147483582;
        public const int SM_F_INVALIDNAME = -2147483136;
        public const int SM_F_OBJECTNOTFOUND = -2147483133;
        public const int SM_F_OVERHEATED = -2147483130;
        public const int SM_F_NOPRINTHREAD = -2147483129;
        public const int SM_F_CHANGEPASSWORD = -2147483124;
        public const int SM_F_UNLOCK = -2147483123;
        public const int SM_F_LOCK = -2147483122;
        public const int SM_F_FILESIZEZERO = -2147483104;
        public const int SM_F_DEPRECATED = -2147483103;
        public const int SM_F_SERIALNORESPONSE = -2147483102;
        public const int SM_F_NETAUTHFAIL = -2147482880;
        public const int SM_F_NETREBOOTERROR = -2147482879;
        public const int SM_F_NETRELOADERROR = -2147482878;
        public const int SM_F_NETRESETERROR = -2147482877;
        public const int SM_F_NETUPGRADEERROR = -2147482876;
        public const int SM_F_NETGETSYSCFGERROR = -2147482875;
        public const int SM_F_NETSETSYSCFGERROR = -2147482874;
        public const int SM_F_NETGETSVCCFGERROR = -2147482873;
        public const int SM_F_NETSETSVCCFGERROR = -2147482872;
        public const int SM_F_NETLISTUSERERROR = -2147482871;
        public const int SM_F_NETADDUSERERROR = -2147482870;
        public const int SM_F_NETDELUSERERROR = -2147482869;
        public const int SM_F_NETPASSWDUSERERROR = -2147482868;
        public const int SM_F_PREEMPTION = -2147482800;
        public const int SM_F_CARDMOVE = -2147482799;
        public const int SM_F_MOVEPOSITION = -2147482798;
        public const int SM_F_SETENCCONFIG = -2147482797;
        public const int SM_F_ENCODING = -2147482796;
        public const int SM_F_NOTEXISTMODULE = -2147482795;
        public const int SM_F_MODULERESERVED = -2147482794;
        public const int SM_F_MODULEOCUPIED = -2147482793;
        public const int SM_F_NOTEXISTJOB = -2147482792;
        public const int SM_F_MODULEBUSY = -2147482791;
        public const int SM_F_MODULEHASERROR = -2147482790;
        public const int SM_F_CANCELBYUSER = -2147482789;
        public const int SM_F_EMPTYDATA = -2147482788;
        public const int SM_F_LAMINATE = -2147482787;
        public const int SM_W_HOLDINGPRINTDATA = -2147482786;
        public const int SM_F_INVALIDMODULEID = -2147482785;
        public const int SM_W_BLANKIMAGE = -2147482752;
        public const int SM_F_SCARD_F_INTERNAL_ERROR = -2146435071;
        public const int SM_F_SCARD_E_CANCELLED = -2146435070;
        public const int SM_F_SCARD_E_INVALID_HANDLE = -2146435069;
        public const int SM_F_SCARD_E_INVALID_PARAMETER = -2146435068;
        public const int SM_F_SCARD_E_INVALID_TARGET = -2146435067;
        public const int SM_F_SCARD_E_NO_MEMORY = -2146435066;
        public const int SM_F_SCARD_F_WAITED_TOO_int32 = -2146435065;
        public const int SM_F_SCARD_E_INSUFFICIENT_BUFFER = -2146435064;
        public const int SM_F_SCARD_E_UNKNOWN_READER = -2146435063;
        public const int SM_F_SCARD_E_TIMEOUT = -2146435062;
        public const int SM_F_SCARD_E_SHARING_VIOLATION = -2146435061;
        public const int SM_F_SCARD_E_NO_SMARTCARD = -2146435060;
        public const int SM_F_SCARD_E_UNKNOWN_CARD = -2146435059;
        public const int SM_F_SCARD_E_CANT_DISPOSE = -2146435058;
        public const int SM_F_SCARD_E_PROTO_MISMATCH = -2146435057;
        public const int SM_F_SCARD_E_NOT_READY = -2146435056;
        public const int SM_F_SCARD_E_INVALID_VALUE = -2146435055;
        public const int SM_F_SCARD_E_SYSTEM_CANCELLED = -2146435054;
        public const int SM_F_SCARD_F_COMM_ERROR = -2146435053;
        public const int SM_F_SCARD_F_UNKNOWN_ERROR = -2146435052;
        public const int SM_F_SCARD_E_INVALID_ATR = -2146435051;
        public const int SM_F_SCARD_E_NOT_TRANSACTED = -2146435050;
        public const int SM_F_SCARD_E_READER_UNAVAILABLE = -2146435049;
        public const int SM_F_SCARD_P_SHUTDOWN = -2146435048;
        public const int SM_F_SCARD_E_PCI_TOO_SMALL = -2146435047;
        public const int SM_F_SCARD_E_READER_UNSUPPORTED = -2146435046;
        public const int SM_F_SCARD_E_DUPLICATE_READER = -2146435045;
        public const int SM_F_SCARD_E_CARD_UNSUPPORTED = -2146435044;
        public const int SM_F_SCARD_E_NO_SERVICE = -2146435043;
        public const int SM_F_SCARD_E_SERVICE_STOPPED = -2146435042;
        public const int SM_F_SCARD_E_UNEXPECTED = -2146435041;
        public const int SM_F_SCARD_E_ICC_INSTALLATION = -2146435040;
        public const int SM_F_SCARD_E_ICC_CREATEORDER = -2146435039;
        public const int SM_F_SCARD_E_UNSUPPORTED_FEATURE = -2146435038;
        public const int SM_F_SCARD_E_DIR_NOT_FOUND = -2146435037;
        public const int SM_F_SCARD_E_FILE_NOT_FOUND = -2146435036;
        public const int SM_F_SCARD_E_NO_DIR = -2146435035;
        public const int SM_F_SCARD_E_NO_FILE = -2146435034;
        public const int SM_F_SCARD_E_NO_ACCESS = -2146435033;
        public const int SM_F_SCARD_E_WRITE_TOO_MANY = -2146435032;
        public const int SM_F_SCARD_E_BAD_SEEK = -2146435031;
        public const int SM_F_SCARD_E_INVALID_CHV = -2146435030;
        public const int SM_F_SCARD_E_UNKNOWN_RES_MNG = -2146435029;
        public const int SM_F_SCARD_E_NO_SUCH_CERTIFICATE = -2146435028;
        public const int SM_F_SCARD_E_CERTIFICATE_UNAVAILABLE = -2146435027;
        public const int SM_F_SCARD_E_NO_READERS_AVAILABLE = -2146435026;
        public const int SM_F_SCARD_E_COMM_DATA_LOST = -2146435025;
        public const int SM_F_SCARD_E_NO_KEY_CONTAINER = -2146435024;
        public const int SM_F_SCARD_E_SERVER_TOO_BUSY = -2146435023;
        public const int SM_F_SCARD_W_UNSUPPORTED_CARD = -2146434971;
        public const int SM_F_SCARD_W_UNRESPONSIVE_CARD = -2146434970;
        public const int SM_F_SCARD_W_UNPOWERED_CARD = -2146434969;
        public const int SM_F_SCARD_W_RESET_CARD = -2146434968;
        public const int SM_F_SCARD_W_REMOVED_CARD = -2146434967;
        public const int SM_F_SCARD_W_SECURITY_VIOLATION = -2146434966;
        public const int SM_F_SCARD_W_WRONG_CHV = -2146434965;
        public const int SM_F_SCARD_W_CHV_BLOCKED = -2146434964;
        public const int SM_F_SCARD_W_EOF = -2146434963;
        public const int SM_F_SCARD_W_CANCELLED_BY_USER = -2146434962;
        public const int SM_F_SCARD_W_CARD_NOT_AUTHENTICATED = -2146434961;

        //[DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        //public static extern int SmartComm_GetDeviceList2(int pList);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartComm_GetDeviceList2(long pList);

        //[DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        //public static extern int SmartComm_GetDeviceInfo2(int pInfo, int szDev, int nDevType);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartComm_GetDeviceInfo2(long pInfo, long szDev, int nDevType);

        //[DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        //public static extern int SmartComm_OpenDevice2(int handle_ptr, int szDev, int nDevType);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartComm_OpenDevice2(long handle_ptr, long szDev, int nDevType);

        //[DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        //public static extern int SmartDCL_OpenDevice2(
        //  int handle_ptr,
        //  int szDev,
        //  int nDevType,
        //  int nOrient);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartDCL_OpenDevice2(
  long handle_ptr,
  long szDev,
  int nDevType,
  int nOrient);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartDCL_OpenDevice3(
          int handle_ptr,
          int szDev,
          int nPort,
          int useSSL,
          int nOrient);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartComm_CloseDevice(long handle);
        //public static extern int SmartComm_CloseDevice(int handle);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartDCL_CloseDevice(long handle);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartDCL_GetSurface(int handle, int ppSurfaceFront, int ppSurfaceBack);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        //public static extern int SmartComm_CardIn(int handle);
        public static extern int SmartComm_CardIn(long handle);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartComm_CardOut(long handle);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartComm_CardOutBack(long handle);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartComm_CardOutBackAngle(int handle, int angle);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartComm_GetStatus(long handle, long status_ptr);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartLami_GetStatus(int handle, int status_ptr);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartFlip_GetStatus(int handle, int status_ptr);

        //[DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        //public static extern int SmartComm_SBSStart(int handle);


        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartComm_SBSStart(long handle);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartComm_SBSEnd(long handle);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        //public static extern int SmartComm_Move(int handle, int pos);
        public static extern int SmartComm_Move(long handle, int pos);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        //public static extern int SmartComm_GetPrinterSettings(int handle, int dmdevmode);
        public static extern int SmartComm_GetPrinterSettings(long handle, long dmdevmode);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        //public static extern int SmartComm_SetPrinterSettings(int handle, int dmdevmode);
        public static extern int SmartComm_SetPrinterSettings(long handle, long dmdevmode);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        //public static extern int SmartComm_GetPrinterSettings2(int handle, int dmdevmode51, int pdmlen);
        public static extern int SmartComm_GetPrinterSettings2(long handle, long dmdevmode51, long pdmlen);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        //public static extern int SmartComm_SetPrinterSettings2(int handle, int dmdevmode51, int dmlen);
        public static extern int SmartComm_SetPrinterSettings2(long handle, long dmdevmode51, int dmlen);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartComm_OpenDocument(int handle, int szcsd);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartComm_CloseDocument(long handle);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartComm_IsBackEnable(int handle, int pbBack);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartComm_GetFieldCount(int handle, int pnCount);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartComm_GetFieldName(int handle, int idx, int szName, int nBufLen);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartComm_GetFieldValue(int handle, int szName, int szValue);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartComm_SetFieldValue(int handle, int szName, int szValue);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartComm_MagConfig(int handle, int pMagCfg);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartComm_MagSetAllBuffer(
          int handle,
          int bSetT1,
          int BufT1,
          int LenT1,
          int bSetT2,
          int BufT2,
          int LenT2,
          int bSetT3,
          int BufT3,
          int LenT3);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartComm_MagWriteAction(int handle, int TrackID, int nHighCo);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartComm_MagWriteAction2(
          int handle,
          int TrackID,
          int nOpt,
          int nT1BPI,
          int nT2BPI,
          int nT3BPI);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartComm_MagGetAllBuffer(
          int handle,
          int bSetT1,
          int BufT1,
          int pLenT1,
          int bSetT2,
          int BufT2,
          int pLenT2,
          int bSetT3,
          int BufT3,
          int pLenT3);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartComm_MagReadAction(int handle, int TrackID);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartComm_MagReadAction2(int handle, int TrackID, int nOpt);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartComm_DrawText(
          long handle,
          byte page,
          byte panel,
          int x,
          int y,
          long szFontName,
          int FontSize,
          byte FontStyle,
          long szText,
          long prcArea);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartComm_DrawImage(
          int handle,
          byte page,
          byte panel,
          int x,
          int y,
          int cx,
          int cy,
          int imageName,
          int rcDraw);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartComm_DrawBitmap(
          int handle,
          byte page,
          byte panel,
          int x,
          int y,
          int cx,
          int cy,
          int hbmp,
          int rcDraw);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartComm_DrawBarcode(
          int handle,
          byte page,
          byte panel,
          int x,
          int y,
          int cx,
          int cy,
          int color,
          int rcDraw,
          int strBarName,
          int barSize,
          int strBarText,
          int strPost);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartComm_GetPreviewBitmap(int handle, int page, int pbitmapinfo);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartComm_GetUnitInfo(int handle, int pUnit, int dir);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartComm_GetFieldLinkedUnitInfo(
          int handle,
          int szField,
          int pUnit,
          int dir);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartComm_SetUnitInfo(int handle, int pUnit);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartComm_Print(int handle);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartDCL_Print(long handle, int page);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartComm_DoPrint(long handle);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartComm_ICHContact(int handle);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartComm_ICHDiscontact(int handle);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartComm_Rotate(int handle);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartComm_RFPowerOn(
          int handle,
          int nDev,
          int pnCardType,
          int pdwOutLen,
          int pOutBuf);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartComm_RFPowerOff(int handle, int nDev);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartComm_RFTransmit(
          int handle,
          int nDev,
          int dwInLen,
          int pInBuf,
          int pdwOutLen,
          int pOutBuf);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartComm_ICPowerOn(int handle, int nDev, int pdwOutLen, int pOutBuf);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartComm_ICPowerOff(int handle, int nDev);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartComm_ICTransmit(
          int handle,
          int nDev,
          int dwInLen,
          int pInBuf,
          int pdwOutLen,
          int pOutBuf);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartCommEx_GetConfig(int handle, int nID, int pValue);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartCommEx_SetConfig(int handle, int nID, int value);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartCommEx_ToggleTestMode(long hsmart);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartCommEx_CmdSend(long hsmart, Byte pcmd, int ncmdlen);

        [DllImport("SmartComm2.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SmartCommEx_GetMonitorings(int hsmart, Byte pbuf, int pnRead);

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct SMART_PRINTER_ITEM
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
            public char[] name;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public char[] id;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public char[] dev;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public char[] desc;
            public int pid;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct SMART_PRINTER_LIST
        {
            public int n;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public SmartComm2.SMART_PRINTER_ITEM[] item;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct SMART_PRINTER_PORT_USB
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public char[] port;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public char[] link;
            public int is_bridge;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct SMART_PRINTER_PORT_NET
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public char[] ver;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public char[] ip;
            public int port;
            public int is_ssl;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct SMART_PRINTER_STANDARD
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
            public char[] name;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public char[] id;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public char[] dev;
            public int dev_type;
            public int pid;
            public SmartComm2.SMART_PRINTER_PORT_USB usb;
            public SmartComm2.SMART_PRINTER_PORT_NET net;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct SMART_PRINTER_OPTIONS
        {
            public int is_dual;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public char[] ic1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public char[] ic2;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public char[] rf1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public char[] rf2;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct SMART_PRINTER_INFO
        {
            public SmartComm2.SMART_PRINTER_STANDARD std;
            public SmartComm2.SMART_PRINTER_OPTIONS opt;
        }

        public struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        public struct POINT
        {
            public int x;
            public int y;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct OEM_DMEXTRAHEADER
        {
            public int dwSize;
            public int dwSignature;
            public int dwVersion;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct OEMDEV
        {
            public SmartComm2.OEM_DMEXTRAHEADER dmOEMExtra;
            public int dwCCMain;
            public int dwCCYellow;
            public int dwCCMagenta;
            public int dwCCCyan;
            public int dwCCBlack;
            public int dwCCOverlay;
            public int dwCCIntensity;
            public int dwCCContrast;
            public int dwBPText;
            public int dwBPDot;
            public int dwBPThreshold;
            public int dwBPDitherDegree;
            public int dwEdgeSize;
            public int dwEjectCard;
            public int dwDocPrinterType;
            public int dwDocHeatControl;
            public int dwMSTrack1;
            public int dwMSTrack2;
            public int dwMSTrack3;
            public int dwJISTrack;
            public int dwManualEncoding;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
            public char[] strMSTrack1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
            public char[] strMSTrack2;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
            public char[] strMSTrack3;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
            public char[] strJISTrack;
            public int dwDocSupply;
            public int dwDocTray;
            public int dwDocRibbon;
            public int dwDocResin;
            public int dwDocQuality;
            public int dwDocColor;
            public int dwDocDither;
            public int dwDocPrintSide;
            public int dwDocMediaFront;
            public int dwDocMediaBack;
            public int dwDocEdgeFront;
            public int dwDocEdgeBack;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
            public char[] strDocMediaUserFront;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
            public char[] strDocMediaUserBack;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct SMART_DEVMODE
        {
            public Win32.DEVMODEW dmDevmode;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 564)]
            public byte[] reserved;
            public SmartComm2.OEMDEV dmOemdev;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct OEMDEV51
        {
            public SmartComm2.OEM_DMEXTRAHEADER dmOEMExtra;
            public int dwASMain;
            public int dwASYellow;
            public int dwASMagenta;
            public int dwASCyan;
            public int dwASBlack;
            public int dwASOverlay;
            public int dwASCorrectColor;
            public int dwASCorrectMono;
            public int dwASCorrectOverlay;
            public int dwASBPText;
            public int dwASBPDot;
            public int dwASBPThreshold;
            public int dwASBPDitherDegree;
            public int dwASBPResin;
            public int dwASBPResinOnly;
            public int dwASErase;
            public int dwASFastAlignment;
            public int dwASWaitRFUse;
            public int dwASWaitRFSide;
            public int dwASWaitRFPos;
            public int dwASWaitRFTime;
            public int dwASWaitICUse;
            public int dwASWaitICSide;
            public int dwASWaitICPos;
            public int dwASWaitICTime;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 40)]
            public byte[] btAsReserved;
            public int dwIOSupply;
            public int dwIOTray;
            public int dwPrtUse;
            public int dwPrtSide;
            public int dwPrtColorFront;
            public int dwPrtColorBack;
            public int dwPrtFlipFront;
            public int dwPrtFlipBack;
            public int dwPrtMediaFront;
            public int dwPrtMediaBack;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
            public char[] strPrtMediaUserFront;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
            public char[] strPrtMediaUserBack;
            public int dwPrtRibbon;
            public int dwPrtSpeed;
            public int dwPrtQuality;
            public int dwPrtDither;
            public int dwPrtHeatControl;
            public int dwPrtRibbonSplit;
            public int dwPrtAntiAliasing;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 36)]
            public byte[] btPrtReserved;
            public int dwLamUse;
            public int dwLamSide;
            public int dwLamOverlay;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 40)]
            public byte[] btLamReserved;
            public int dwEncUse;
            public int dwEncSide;
            public int dwEncCoer;
            public int dwEncMagRepeat;
            public int dwEncMagFlipBefore;
            public int dwEncMagFlipAfter;
            public int dwEncUseUserOption;
            public int dwEncUserHeadValue;
            public int dwEncFormat1;
            public int dwEncFormat2;
            public int dwEncFormat3;
            public int dwEncFormatJ;
            public int dwEncDensity1;
            public int dwEncDensity2;
            public int dwEncDensity3;
            public int dwEncDensityJ;
            public int dwEncOption1;
            public int dwEncOption2;
            public int dwEncOption3;
            public int dwEncOptionJ;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
            public char[] strEncTrack1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
            public char[] strEncTrack2;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
            public char[] strEncTrack3;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
            public char[] strEncJISTrack;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public char[] strEncMSST1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public char[] strEncMSST2;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public char[] strEncMSST3;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public char[] strEncMSSTJ;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public char[] strEncMSET1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public char[] strEncMSET2;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public char[] strEncMSET3;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public char[] strEncMSETJ;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 40)]
            public byte[] btEncReserved;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100)]
            public byte[] reserved;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct SMART51_DEVMODE
        {
            public Win32.DEVMODEW devmode;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 564)]
            public byte[] reserved;
            public SmartComm2.OEMDEV51 oemdev;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct SMART_SURFACE_PROPERTIES
        {
            public int side;
            public int orientation;
            public int ribbon;
            public int ribbon_type;
            public int width;
            public int height;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct SMART_SURFACE_BITMAPS
        {
            public int hdcColor;
            public int hdcResin;
            public int hdcFluorescent;
            public int hdcOverlay;
            public int hBmpColor;
            public int hBmpResin;
            public int hBmpFluorescent;
            public int hBmpOverlay;
            public int lpPRN;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct SMART_SURFACE_OEMDEV
        {
            public int dwCCMain;
            public int dwCCYellow;
            public int dwCCMagenta;
            public int dwCCCyan;
            public int dwCCBlack;
            public int dwCCOverlay;
            public int dwDocRibbonSplit;
            public int dwDocFlip;
            public int dwBPText;
            public int dwBPDot;
            public int dwBPThreshold;
            public int dwBPDitherDegree;
            public int dwEdgeSize;
            public int dwEjectCard;
            public int dwErase;
            public int dwDocHeatControl;
            public int dwMSTrack1;
            public int dwMSTrack2;
            public int dwMSTrack3;
            public int dwJISTrack;
            public int dwManualEncoding;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
            public char[] strMSTrack1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
            public char[] strMSTrack2;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
            public char[] strMSTrack3;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
            public char[] strJISTrack;
            public int dwDocSupply;
            public int dwDocTray;
            public int dwDocRibbon;
            public int dwDocResin;
            public int dwDocQuality;
            public int dwDocColor;
            public int dwDocDither;
            public int dwDocPrintSide;
            public int dwDocMediaFront;
            public int dwDocMediaBack;
            public int dwDocEdgeFront;
            public int dwDocEdgeBack;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
            public char[] strDocMediaUserFront;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
            public char[] strDocMediaUserBack;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct SMART_SURFACE
        {
            public SmartComm2.SMART_SURFACE_PROPERTIES prop;
            public SmartComm2.SMART_SURFACE_BITMAPS bmp;
            public SmartComm2.SMART_SURFACE_OEMDEV oemdev;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct BORDER
        {
            public short type;
            public short width;
            public int color;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct BACKGROUND
        {
            public int fill;
            public int color;
            public int transparency;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct FONTINFO
        {
            public int SIZE;
            public byte style;
            public int color;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] fontname;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct UNITTEXT
        {
            public short leftMargin;
            public short topMargin;
            public short rightMargin;
            public short bottomMargin;
            public byte align;
            public SmartComm2.FONTINFO font;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 33)]
            public char[] field;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct UNITIMAGE
        {
            public int widthZoom;
            public int heightZoom;
            public short contrast;
            public short brightness;
            public int grayscale;
            public short align;
            public SmartComm2.POINT offset;
            public byte scaleMethod;
            public int round;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 33)]
            public char[] field;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct UNITBAR
        {
            public int type;
            public int SIZE;
            public int opt;
            public Size size2D;
            public int barColor;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 33)]
            public char[] field;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct UNITINFO
        {
            public int index;
            public int type;
            public byte page;
            public byte panel;
            public int left;
            public int top;
            public int width;
            public int height;
            public int rotate;
            public SmartComm2.BORDER BORDER;
            public SmartComm2.BACKGROUND back;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 156)]
            public byte[] union;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct MAGCONFIG
        {
            public int ver;
            public int t1_ballys_count;
            public int t1_backward;
            public int t1_format;
            public int t1_bpias;
            public int t2_ballys_countas;
            public int t2_backward;
            public int t2_formatas;
            public int t2_bpi;
            public int t3_ballys_count;
            public int t3_backward;
            public int t3_format;
            public int t3_bpi;
            public int jis_ballys_count;
            public int jis_backward;
            public int jis_format;
            public int jis_bpi;
        }
    }
}
