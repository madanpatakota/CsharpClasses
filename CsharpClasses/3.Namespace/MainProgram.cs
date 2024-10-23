using System;  //console
using PDFFilesFolder;
//using ExcelFilesFolder;
//using DocFilesFolder;

// climax --> 1.

namespace MainFolder
{
    class MainProgram
    {
        static void Main()
        {
            

            PDFFile[] pDFFiles = new PDFFile[]
            {
                new PDFFile()
                {
                    fileName = "CreditcardstatmentMarch.pdf",
                    createdDate = "Mar-10-2024",
                    fileLocation = @"D:/eDucation",
                    fileSize = "10kb"
                },
                 new PDFFile()
                {
                    fileName = "CreditcardstatmentApril.pdf",
                    createdDate = "Mar-10-2024",
                    fileLocation = @"D:/eDucation",
                    fileSize = "10kb"
                }
            };


            PDFFilesSystem pDFFilesSystem = new PDFFilesSystem();
            PDFFile[] pDFFiles1 =  pDFFilesSystem.getAllPDFFiles(pDFFiles);

            //HOme work is foreach loop


        }

    }
}


// 1. in this PDFFolder 

//MainFolder 
//    pdfFolder   - GetAllPDFFiles
//    wordFolder
//ExcelFolder
