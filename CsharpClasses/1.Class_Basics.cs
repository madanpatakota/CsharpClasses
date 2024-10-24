using System;

// class have the fields , properties , methods and constructor

class File
{
    //cons is a special method automatically call
    public File()
    {
        Console.WriteLine("Constructor called");
    }


    string fileName; // field member
    string fileLocation;
    string fileSize;
    string createdDate;

    //Main Member
    static void Main()
    {

        //string str = "Madan";
        //string srr1 = "Madan";

        //new File().ShowMessage();
        string str = "asdfasdfas";

        //Array of File
        //File[] files = new File[]
        //{

        //}

        File file = new File();

        file.ShowMessage("Resume.docx", @"D:/Eductation"); // string

        //---------------------------------------------------------------

        File file1 = new File();
        file1.fileName = "HDFCCreditcardStatement.pdf";
        file1.createdDate = "May-10-2024";
        //ShowPDFFileHistory("HDFCCreditcardStatement.pdf", "May-10-2024";);
        ShowPDFFileHistory(file1.fileName, file1.createdDate);

        File file2 = new File();
        file2.fileName = "VisualStudioCodeInstallizationdocument.docx";
        file2.fileSize = "10kb";

        //ShowWordFileSize("VisualStudioCodeInstallizationdocument.docx", "10kb");
        ShowWordFileSize(file2.fileName, file2.fileSize);


        //string fileName; // field member
        //string fileLocation;
        //string fileSize;
        //string createdDate;

        File file3 = new File();
        file3.fileName = "Sasi_FullStatckDeveloperResume.docx";
        file3.createdDate = "Oct-10-2024";
        file3.fileLocation = @"D:/eDucation";
        file3.fileSize = "10kb";

        Console.WriteLine("Test File3" + file3.fileName);
        Console.WriteLine("Test File3" + file3.createdDate);
        Console.WriteLine("Test File3" + file3.fileLocation);
        Console.WriteLine("Test File3" + file3.fileSize);


        File file4 = new File()
        {
            fileName = "Sasi_FullStatckDeveloperResume.docx",
            createdDate = "Oct-10-2024",
            fileLocation = @"D:/eDucation",
            fileSize = "10kb"
        };




        Console.ReadLine();
    }

    //non-static method
    void ShowMessage(string name, string loc) // method member
    {
        Console.WriteLine(name);
        Console.WriteLine(loc);
    }

    static void ShowPDFFileHistory(string name, string createdDate)
    {
        Console.WriteLine($"Hello , File name is {name} and creareddate {createdDate}");
    }

    static void ShowWordFileSize(string name, string filesize)
    {
        Console.WriteLine($"Hello, File name is {name} and filelocation is {filesize}");
    }


}

