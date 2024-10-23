using System;

namespace DocFilesFolder
{
    class DocProgram
    {
        static void Main()
        {

            //For your homework.

        }
    }

    class DocFile
    {
        public string fileName; // field member
        public string fileLocation;
        public string fileSize;
        public string createdDate;
    }

    class DocFilesSystem
    {
        public void ShowDocFilesLength(string[] fileNames)
        {
            Console.WriteLine(fileNames.Length + " Files");  // 2 files
        }

        // client expecting - return
        // what you are receiving - input

        // I will give you some Docfiles(input). Now i want the (get) first Doc file. give me that.
        // Prepare one method.

        public DocFile getFirstDoc(DocFile[] DocFiles)
        {
            return DocFiles[0];
        }

        // I will give you some Docfiles(input). Now return me same those files to me.
        // Prepare the method for that..

        public DocFile[] getAllDocFiles(DocFile[] DocFiles)
        {
            return DocFiles;
        }
    }
}




//DocFiles
//Namespace  -> Folder(Better folder)

//DocFolder   -> Docfiles
//DocFolder -> Docfiles

//classes
//Doc 
//Doc
//Document