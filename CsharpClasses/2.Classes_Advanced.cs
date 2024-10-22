using System;

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

