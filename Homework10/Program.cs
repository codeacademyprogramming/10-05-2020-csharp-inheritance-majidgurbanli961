using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    class Program
    {
        static void Main(string[] args)
        {
            GetFromUser();
            
        }
         static void GetFromUser()
        {
            Console.WriteLine("Give a key please ( basic , pro , expert)");
            string key = Console.ReadLine();
            DocumentProgram myProgram = new DocumentProgram();
            switch (key)
            {
                case "basic":
                    myProgram = new DocumentProgram();
                    
                    
                    break;
                case "pro":
                    myProgram = new ProDocumentProgram();
                    break;
                case "expert":
                     myProgram = new ExpertProgram();
                    break;
                default:
                    Console.WriteLine("Error");
                    return;




            }
            myProgram.OpenDocument();
            myProgram.EditDocument();
            myProgram.SaveDocument();
        }
    }
    class DocumentProgram
    {
        public DocumentProgram()
        {
        

        }
        public void OpenDocument()
        {
            Console.WriteLine("Document Opened");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine(" Can edit in Pro and Expert versions");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine(" Can Save in Pro and Expert versions");
        }
    }
    class ProDocumentProgram : DocumentProgram
    {
        public ProDocumentProgram()
        {
           
        }
        public sealed override void EditDocument()
        {
            Console.WriteLine(" Document Edited ");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Document Saved in doc format, for pdf format buy Expert packet");
        }
    }
    class ExpertProgram : ProDocumentProgram
    {
        public ExpertProgram()
        {
       
        }
        public override void SaveDocument()
        {
            Console.WriteLine(" Document Saved in pdf Format");
        }
    }
}
