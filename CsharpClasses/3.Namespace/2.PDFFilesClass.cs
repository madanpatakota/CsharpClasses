using System;

namespace PDFFilesFolder
{
    class PDFProgram
    {
        static void Main()
        {

            //For your homework.

        }
    }

    class PDFFile
    {
        public string fileName; // field member
        public string fileLocation;
        public string fileSize;
        public string createdDate;
    }

    class PDFFilesSystem
    {
        public void ShowPDFFilesLength(string[] fileNames)
        {
            Console.WriteLine(fileNames.Length + " Files");  // 2 files
        }

        // client expecting - return
        // what you are receiving - input

        // I will give you some PDFfiles(input). Now i want the (get) first PDF file. give me that.
        // Prepare one method.

        public PDFFile getFirstPDF(PDFFile[] PDFFiles)
        {
            return PDFFiles[0];
        }

        // I will give you some PDFfiles(input). Now return me same those files to me.
        // Prepare the method for that..

        public PDFFile[] getAllPDFFiles(PDFFile[] PDFFiles)
        {
            return PDFFiles;
        }
    }
}




//PDFFiles
//Namespace  -> Folder(Better folder)

//PDFFolder   -> Pdffiles
//PDFFolder -> PDFfiles

//classes
//PDF 
//PDF
//Document