namespace CardPrinterSDKv1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Threading.Tasks;

    [StandardModule]
    public class Win32
    {
        [DllImport("kernel32")]
        public static extern void Sleep(long dwMilliseconds);
        [DllImport("kernel32", EntryPoint = "RtlMoveMemory")]
        public static extern void CopyMemory(int pDest, int pSource, int SIZE);


        // lpInitData : DEVMODEW
        [DllImport("gdi32")]
        public static extern int CreateDCW(int lpszDriver, int lpszDevice, int lpszOutput, int lpInitData);

        // return : BOOL type
        [DllImport("gdi32")]
        public static extern int DeleteDC(int hdc);
        [DllImport("gdi32", EntryPoint = "ResetDCW")]
        public static extern int ResetDC(int hdc, int lpdm);
        [DllImport("winspool.drv", EntryPoint = "DocumentPropertiesW")]
        public static extern int DocumentProperties(int hwnd, int hprinter, int pDevName, int pDevModeOutput, int pDevModeInput, int fMode);
        [DllImport("gdi32")]
        public static extern int StartDocW(int hdc, int lpdi);     // lpdi --> DOCINFO *
        [DllImport("gdi32")]
        public static extern int EndDoc(int hdc);
        [DllImport("gdi32")]
        public static extern int AbortDoc(int hdc);
        [DllImport("gdi32")]
        public static extern int StartPage(int hdc);
        [DllImport("gdi32")]
        public static extern int EndPage(int hdc);
        [DllImport("user32")]
        public static extern int DrawTextW(int hdc, int szText, int ntext, int pRect, int dwFormat);
        [DllImport("user32")]
        public static extern int LoadImageW(int hInst, int szurl, int utype, int cx, int cy, int fuLoad);
        [DllImport("gdi32")]
        public static extern int GetObjectW(int h, int nlen, int pv);
        [DllImport("gdi32")]
        public static extern int SetDIBitsToDevice(int hdc, int xDest, int yDest, int w, int h, int xSrc, int ySrc, int StartScan, int cLines, int lpvBits, int lpbmi, int ColorUseas);
        [DllImport("gdi32")]
        public static extern int GetDeviceCaps(int hdc, int index);
        [DllImport("gdi32")]
        public static extern int DeleteObject(int ho);
        [DllImport("gdi32")]
        public static extern int BitBlt(int hdc, int x, int y, int cx, int cy, int hdcSrc, int x1, int y1, int rop);
        [DllImport("gdi32")]
        public static extern int StretchDIBits(int hdc, int xDest, int yDest, int DestWidth, int DestHeight, int xSrc, int ySrc, int SrcWidth, int SrcHeight, int lpBits, int lpbmi, int iUsage, int rop);
        [DllImport("gdi32")]
        public static extern int SetStretchBltMode(int hdc, int mode);
        [DllImport("gdi32")]
        public static extern int CreateFontW(int nHeight, int nWidth, int nEscapement, int nOrientation, int fnWeight, int fdwItalic, int fdwUnderline, int fdwStrikeOut, int fdwCharSet, int fdwOutputPrecision, int fdwClipPrecision, int fdwQuality, int fdwPitchAndFamily, int lpszFace);

        [DllImport("gdi32")]
        public static extern int SelectObject(int hdc, int h);
        [DllImport("gdi32")]
        public static extern int SetTextColor(int hdc, int color);

        public const int CCDEVICENAME = 32;
        public const int CCFORMNAME = 32;
        public const short DMORIENT_PORTRAINT = 1;
        public const short DMORIENT_LANDSCAPE = 2;
        public const int DMPELSWIDTH = 0x80000;
        public const int DMPELSHEIGHT = 0x100000;

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public partial struct DEVMODEW
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = CCDEVICENAME)]
            public char[] dmDeviceName;
            public short dmSpecVersion;
            public short dmDriverVersion;
            public short dmSize;
            public short dmDriverExtra;
            public int dmFields;
            public short dmOrientation;
            public short dmPaperSize;
            public short dmPaperLength;
            public short dmPaperWidth;
            public short dmScale;
            public short dmCopies;
            public short dmDefaultSource;
            public short dmPrintQuality;
            public short dmColor;
            public short dmDuplex;
            public short dmYResolution;
            public short dmTTOption;
            public short dmCollate;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = CCFORMNAME)]
            public char[] dmFormName;
            public short dmUnusedPadding;
            public int dmBitsPerPel;
            public int DMPELSWIDTH;
            public int DMPELSHEIGHT;
            public int dmDisplayFlags;
            public int dmDisplayFrequency;
            public int dmICMMethod;
            public int dmICMIntent;
            public int dmMediaType;
            public int dmDitherType;
            public int dmReserved1;
            public int dmReserved2;
            public int dmPanningWidth;
            public int dmPanningHeight;
        }

        public const int BI_RGB = 0;
        public const int DM_OUT_BUFFER = 2;
        public const int DT_LEFT = 0;
        public const int DT_TOP = 0;
        public const int DT_CENTER = 0x1;
        public const int DT_RIGHT = 0x2;
        public const int DT_VCENTER = 0x4;
        public const int DT_BOTTOM = 0x8;
        public const int DT_WORDBREAK = 0x10;
        public const int DT_SINGLELINE = 0x20;
        public const int DT_EXPANDTABS = 0x40;
        public const int DT_TABSTOP = 0x80;
        public const int DT_NOCLIP = 0x100;
        public const int DT_EXTERNALLEADING = 0x200;
        public const int DT_CALCRECT = 0x400;
        public const int DT_NOPREFIX = 0x800;
        public const int DT_INTERNAL = 0x1000;
        public const int IMAGE_BITMAP = 0;
        public const int LR_LOADFROMFILE = 0x10;
        public const int LR_CREATEDIBSECTION = 0x2000;
        public const int HORZRES = 8;     // Horizontal width in pixels
        public const int VERTRES = 10;    // Vertical height in pixels
        public const int DIB_RGB_COLORS = 0;     // color table in RGBs
        public const int FW_DONTCARE = 0;
        public const int FW_THIN = 100;
        public const int FW_NORMAL = 400;
        public const int FW_BOLD = 700;
        public const int FW_HEAVY = 900;
        public const int ANSI_CHARSET = 0;
        public const int DEFAULT_CHARSET = 1;
        public const int SYMBOL_CHARSET = 2;
        public const int SHIFTJIS_CHARSET = 128;
        public const int HANGEUL_CHARSET = 129;
        public const int HANGUL_CHARSET = 129;
        public const int GB2312_CHARSET = 134;
        public const int CHINESEBIG5_CHARSET = 136;
        public const int OEM_CHARSET = 255;
        public const int OUT_DEFAULT_PRECIS = 0;
        public const int OUT_STRING_PRECIS = 1;
        public const int OUT_CHARACTER_PRECIS = 2;
        public const int OUT_STROKE_PRECIS = 3;
        public const int OUT_TT_PRECIS = 4;
        public const int OUT_DEVICE_PRECIS = 5;
        public const int OUT_RASTER_PRECIS = 6;
        public const int OUT_TT_ONLY_PRECIS = 7;
        public const int OUT_OUTLINE_PRECIS = 8;
        public const int OUT_SCREEN_OUTLINE_PRECIS = 9;
        public const int OUT_PS_ONLY_PRECIS = 10;
        public const int CLIP_DEFAULT_PRECIS = 0;
        public const int CLIP_CHARACTER_PRECIS = 1;
        public const int CLIP_STROKE_PRECIS = 2;
        public const int CLIP_MASK = 0xF;
        public const int CLIP_LH_ANGLES = 0x10;
        public const int CLIP_TT_ALWAYS = 0x20;
        public const int CLIP_DFA_DISABLE = 0x40;
        public const int CLIP_EMBEDDED = 0x80;
        public const int DEFAULT_QUALITY = 0;
        public const int DRAFT_QUALITY = 1;
        public const int PROOF_QUALITY = 2;
        public const int NONANTIALIASED_QUALITY = 3;
        public const int ANTIALIASED_QUALITY = 4;
        public const int DEFAULT_PITCH = 0;
        public const int FIXED_PITCH = 1;
        public const int VARIABLE_PITCH = 2;
        public const int MONO_FONT = 8;
        public const int FF_DONTCARE = 0x0;
        public const int FF_ROMAN = 0x10;
        public const int FF_SWISS = 0x20;
        public const int FF_MODERN = 0x30;
        public const int FF_SCRIPT = 0x40;
        public const int FF_DECORATIVE = 0x50;
        public const int SRCCOPY = 0xCC0020;        // dest = source
        public const int DIBRGBCOLORS = 0;          // color table in RGBs
        public const int DIBPALCOLORS = 1;          // color table in palette indices
        public const int BLACKONWHITE = 1;
        public const int WHITEONBLACK = 2;
        public const int COLORONCOLOR = 3;
        public const int HALFTONE = 4;

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public partial struct DOCINFO
        {
            public int cbSize;
            public int lpszDocName;
            public int lpszOutput;
            public int lpszDatatype;
            public int fwType;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public partial struct W32BITMAP
        {
            public int bmType;
            public int bmWidth;
            public int bmHeight;
            public int bmWidthBytes;
            public short bmPlanes;
            public short bmBitsPixel;
            public int bmBits;     // void *
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public partial struct BITMAPINFOHEADER
        {
            public int biSize;
            public int biWidth;
            public int biHeight;
            public short biPlanes;
            public short biBitCount;
            public int biCompression;
            public int biSizeImage;
            public int biXPelsPerMeter;
            public int biYPelsPerMeter;
            public int biClrUsed;
            public int biClrImportant;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public partial struct BITMAPINFO
        {
            public BITMAPINFOHEADER bmiHeader;
            // datas are followed...
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] bmiColors;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public partial struct DIBSECTION
        {
            public W32BITMAP dsBm;
            public BITMAPINFOHEADER dsBmih;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public int[] dsBitfields;
            public int dshSection;    // HANDLE
            public int dsOffset;
        }
    }
}
