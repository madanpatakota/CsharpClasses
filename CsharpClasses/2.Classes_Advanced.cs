using System;

class ExcelProgram
{
    static void Main()
    {
        string[] fileNames =
        {
            "Excelfile1.xlsx" , "Excelfile2.xlsx" , "Excelfile3.xlsx"
        };

        // i want to call ShowExcelFileNamesLength method from ExcelFilesSystem;
        ExcelFilesSystem excelFilesSystem = new ExcelFilesSystem();
        excelFilesSystem.ShowExcelFilesLength(fileNames);
        // github // public
        //accessmodifier public

        Console.ReadLine();
    }
}


class ExcelFile
{
    string fileName; // field member
    string fileLocation;
    string fileSize;
    string createdDate;
}


class ExcelFilesSystem
{
    public void ShowExcelFilesLength(string[] fileNames)
    {
        Console.WriteLine(fileNames.Length + " Files");  // 2 files
    }

}

