using System;

namespace ExcelFilesFolder
{
    class ExcelProgram
    {
        static void Main()
        {

            int[] numbers = { 1, 2, 3, 4 };
            bool[] bools = { true, false, true, false };
            string[] paySlips =
            {
            "salaryPayslip-june.xlsx" ,
            "salaryPayslip-july.xlsx" ,
            "salaryPayslip-Aug.xlsx"
        };

            // i want to call ShowExcelFileNamesLength method from ExcelFilesSystem;
            ExcelFilesSystem excelFilesSystem = new ExcelFilesSystem();
            excelFilesSystem.ShowExcelFilesLength(paySlips);



            // github // public
            //accessmodifier public

            //File file4 = new File()
            //{
            //    fileName = "Sasi_FullStatckDeveloperResume.docx",
            //    createdDate = "Oct-10-2024",
            //    fileLocation = @"D:/eDucation",
            //    fileSize = "10kb"
            //};

            //ExcelFile excelFile = new ExcelFile()
            //{
            //    fileName = "abc.xlsx",
            //    createdDate = "Oct-10-2024",
            //    fileLocation = @"D:/eDucation",
            //    fileSize = "10kb"
            //};


            ExcelFile[] excelFiles = new ExcelFile[]
            {
            new ExcelFile()
            {
                fileName = "CreditcardstatmentMarch.xlsx",
                createdDate = "Mar-10-2024",
                fileLocation = @"D:/eDucation",
                fileSize = "10kb"
            },
            new ExcelFile()
            {
                fileName = "CreditcardstatmentApril.xlsx",
                createdDate = "April-10-2024",
                fileLocation = @"D:/eDucation",
                fileSize = "10kb"
            },
            new ExcelFile()
            {
                fileName = "CreditcardstatmentMay.xlsx",
                createdDate = "May-10-2024",
                fileLocation = @"D:/eDucation",
                fileSize = "10kb"
            }
            };


            //every //Array 

            //
            foreach (ExcelFile file in excelFiles)
            {
                Console.WriteLine("File Name is " + file.fileName);
            }


            ExcelFilesSystem excelFilesSystem1 = new ExcelFilesSystem();
            ExcelFile firstExcefile = excelFilesSystem1.getFirstExcel(excelFiles);
            // what is the role of this member

            excelFilesSystem1.getAllExcelFiles(excelFiles);

            Console.ReadLine();
        }
    }

    class ExcelFile
    {
        public string fileName; // field member
        public string fileLocation;
        public string fileSize;
        public string createdDate;
    }

    class ExcelFilesSystem
    {
        public void ShowExcelFilesLength(string[] fileNames)
        {
            Console.WriteLine(fileNames.Length + " Files");  // 2 files
        }

        // client expecting - return
        // what you are receiving - input

        // I will give you some Excelfiles(input). Now i want the (get) first excel file. give me that.
        // Prepare one method.

        public ExcelFile getFirstExcel(ExcelFile[] excelFiles)
        {
            return excelFiles[0];
        }

        // I will give you some Excelfiles(input). Now return me same those files to me.
        // Prepare the method for that..

        public ExcelFile[] getAllExcelFiles(ExcelFile[] excelFiles)
        {
            return excelFiles;
        }
    }
}


//public static 


//nomral pro


//House - design

//hallroom
//kitch
//bedroom
//restroom



//Food app

//Custmer
// func


//non-vegitems
// func

//vegitms
//func



//PDFFiles
//Namespace  -> Folder(Better folder)

//PDFFolder   -> Pdffiles
//ExcelFolder -> Excelfiles

//classes
//Excel 
//PDF
//Document