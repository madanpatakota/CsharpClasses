using System;


namespace CsharpInterfaces
{
   interface IAFamilyService
    {
        void ABCFamilyMembersCount();

        void GetFirstMemberDetails();

    }

    interface ILogService
    {
         void logMessage();

        int LogsCount();
    }
    class AFamily : IAFamilyService , ILogService
    {
        public void logMessage()
        {
            //throw new NotImplementedException();
        }

        public int LogsCount()
        {
            return 0;
        }

        public void ABCFamilyMembersCount()
        {
            //throw new NotImplementedException();
        }

        public void GetFirstMemberDetails()
        {
            //throw new NotImplementedException();
        }

    }


    class MainProgram
    {
        public static void Main()
        {

            AFamily family = new AFamily();

            IAFamilyService aFamily = new AFamily();
            //aFamily.

            //IAFamilyService i1 = new IAFamilyService();

            ILogService logService = new AFamily();
            //logService.


            //aFamily.Logs  // only 2 memeber

            //family.
            //Do't assign the instance directly to the class
            //architect secreats real time code 

            //ifnd the interface then they use the interface
        }
    }



}


/*class vs interface

  1. YOu Should not add directly the methods(member)
     you have to always use interface.(Real time projects)
   

*/
