/*
 * PassportPDF API
 *
 * Copyright © 2019 PassportPDF - https://www.passportpdf.com
 *
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;


namespace PassportPDF.Model
{
    /// <summary>
    /// Specifies the format of a document.
    /// </summary>
    /// <value>Specifies the format of a document.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum DocumentFormat
    {
        /// <summary>
        /// Enum UNKNOWN for value: UNKNOWN
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN = 1,

        /// <summary>
        /// Enum ICO for value: ICO
        /// </summary>
        [EnumMember(Value = "ICO")]
        ICO = 2,

        /// <summary>
        /// Enum BMP for value: BMP
        /// </summary>
        [EnumMember(Value = "BMP")]
        BMP = 3,

        /// <summary>
        /// Enum WBMP for value: WBMP
        /// </summary>
        [EnumMember(Value = "WBMP")]
        WBMP = 4,

        /// <summary>
        /// Enum JPEG for value: JPEG
        /// </summary>
        [EnumMember(Value = "JPEG")]
        JPEG = 5,

        /// <summary>
        /// Enum GIF for value: GIF
        /// </summary>
        [EnumMember(Value = "GIF")]
        GIF = 6,

        /// <summary>
        /// Enum PNG for value: PNG
        /// </summary>
        [EnumMember(Value = "PNG")]
        PNG = 7,

        /// <summary>
        /// Enum TIFF for value: TIFF
        /// </summary>
        [EnumMember(Value = "TIFF")]
        TIFF = 8,

        /// <summary>
        /// Enum FAXG3 for value: FAXG3
        /// </summary>
        [EnumMember(Value = "FAXG3")]
        FAXG3 = 9,

        /// <summary>
        /// Enum EXIF for value: EXIF
        /// </summary>
        [EnumMember(Value = "EXIF")]
        EXIF = 10,

        /// <summary>
        /// Enum EMF for value: EMF
        /// </summary>
        [EnumMember(Value = "EMF")]
        EMF = 11,

        /// <summary>
        /// Enum WMF for value: WMF
        /// </summary>
        [EnumMember(Value = "WMF")]
        WMF = 12,

        /// <summary>
        /// Enum JNG for value: JNG
        /// </summary>
        [EnumMember(Value = "JNG")]
        JNG = 13,

        /// <summary>
        /// Enum KOALA for value: KOALA
        /// </summary>
        [EnumMember(Value = "KOALA")]
        KOALA = 14,

        /// <summary>
        /// Enum IFF for value: IFF
        /// </summary>
        [EnumMember(Value = "IFF")]
        IFF = 15,

        /// <summary>
        /// Enum MNG for value: MNG
        /// </summary>
        [EnumMember(Value = "MNG")]
        MNG = 16,

        /// <summary>
        /// Enum PCD for value: PCD
        /// </summary>
        [EnumMember(Value = "PCD")]
        PCD = 17,

        /// <summary>
        /// Enum PCX for value: PCX
        /// </summary>
        [EnumMember(Value = "PCX")]
        PCX = 18,

        /// <summary>
        /// Enum PBM for value: PBM
        /// </summary>
        [EnumMember(Value = "PBM")]
        PBM = 19,

        /// <summary>
        /// Enum PBMRAW for value: PBMRAW
        /// </summary>
        [EnumMember(Value = "PBMRAW")]
        PBMRAW = 20,

        /// <summary>
        /// Enum PFM for value: PFM
        /// </summary>
        [EnumMember(Value = "PFM")]
        PFM = 21,

        /// <summary>
        /// Enum PGM for value: PGM
        /// </summary>
        [EnumMember(Value = "PGM")]
        PGM = 22,

        /// <summary>
        /// Enum PGMRAW for value: PGMRAW
        /// </summary>
        [EnumMember(Value = "PGMRAW")]
        PGMRAW = 23,

        /// <summary>
        /// Enum PPM for value: PPM
        /// </summary>
        [EnumMember(Value = "PPM")]
        PPM = 24,

        /// <summary>
        /// Enum PPMRAW for value: PPMRAW
        /// </summary>
        [EnumMember(Value = "PPMRAW")]
        PPMRAW = 25,

        /// <summary>
        /// Enum RAS for value: RAS
        /// </summary>
        [EnumMember(Value = "RAS")]
        RAS = 26,

        /// <summary>
        /// Enum TARGA for value: TARGA
        /// </summary>
        [EnumMember(Value = "TARGA")]
        TARGA = 27,

        /// <summary>
        /// Enum PSD for value: PSD
        /// </summary>
        [EnumMember(Value = "PSD")]
        PSD = 28,

        /// <summary>
        /// Enum CUT for value: CUT
        /// </summary>
        [EnumMember(Value = "CUT")]
        CUT = 29,

        /// <summary>
        /// Enum XBM for value: XBM
        /// </summary>
        [EnumMember(Value = "XBM")]
        XBM = 30,

        /// <summary>
        /// Enum XPM for value: XPM
        /// </summary>
        [EnumMember(Value = "XPM")]
        XPM = 31,

        /// <summary>
        /// Enum DDS for value: DDS
        /// </summary>
        [EnumMember(Value = "DDS")]
        DDS = 32,

        /// <summary>
        /// Enum HDR for value: HDR
        /// </summary>
        [EnumMember(Value = "HDR")]
        HDR = 33,

        /// <summary>
        /// Enum SGI for value: SGI
        /// </summary>
        [EnumMember(Value = "SGI")]
        SGI = 34,

        /// <summary>
        /// Enum EXR for value: EXR
        /// </summary>
        [EnumMember(Value = "EXR")]
        EXR = 35,

        /// <summary>
        /// Enum J2K for value: J2K
        /// </summary>
        [EnumMember(Value = "J2K")]
        J2K = 36,

        /// <summary>
        /// Enum JP2 for value: JP2
        /// </summary>
        [EnumMember(Value = "JP2")]
        JP2 = 37,

        /// <summary>
        /// Enum PICT for value: PICT
        /// </summary>
        [EnumMember(Value = "PICT")]
        PICT = 38,

        /// <summary>
        /// Enum RAW for value: RAW
        /// </summary>
        [EnumMember(Value = "RAW")]
        RAW = 39,

        /// <summary>
        /// Enum WEBP for value: WEBP
        /// </summary>
        [EnumMember(Value = "WEBP")]
        WEBP = 40,

        /// <summary>
        /// Enum DICOM for value: DICOM
        /// </summary>
        [EnumMember(Value = "DICOM")]
        DICOM = 41,

        /// <summary>
        /// Enum JBIG for value: JBIG
        /// </summary>
        [EnumMember(Value = "JBIG")]
        JBIG = 42,

        /// <summary>
        /// Enum JBIG2 for value: JBIG2
        /// </summary>
        [EnumMember(Value = "JBIG2")]
        JBIG2 = 43,

        /// <summary>
        /// Enum WSQ for value: WSQ
        /// </summary>
        [EnumMember(Value = "WSQ")]
        WSQ = 44,

        /// <summary>
        /// Enum PDF for value: PDF
        /// </summary>
        [EnumMember(Value = "PDF")]
        PDF = 45,

        /// <summary>
        /// Enum SVG for value: SVG
        /// </summary>
        [EnumMember(Value = "SVG")]
        SVG = 46,

        /// <summary>
        /// Enum TXT for value: TXT
        /// </summary>
        [EnumMember(Value = "TXT")]
        TXT = 47,

        /// <summary>
        /// Enum DOCX for value: DOCX
        /// </summary>
        [EnumMember(Value = "DOCX")]
        DOCX = 48,

        /// <summary>
        /// Enum RTF for value: RTF
        /// </summary>
        [EnumMember(Value = "RTF")]
        RTF = 49,

        /// <summary>
        /// Enum DXF for value: DXF
        /// </summary>
        [EnumMember(Value = "DXF")]
        DXF = 50,

        /// <summary>
        /// Enum ODT for value: ODT
        /// </summary>
        [EnumMember(Value = "ODT")]
        ODT = 51,

        /// <summary>
        /// Enum XLSX for value: XLSX
        /// </summary>
        [EnumMember(Value = "XLSX")]
        XLSX = 52,

        /// <summary>
        /// Enum PPTX for value: PPTX
        /// </summary>
        [EnumMember(Value = "PPTX")]
        PPTX = 53

    }

}
