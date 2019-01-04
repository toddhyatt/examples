using System;
using System.Linq;
using System.Collections.Generic;
namespace LinqExample
{
    public class FileConsole
    {
        public string FileName {get;set;}
        public FileConsole()
        {

        }
        public FileConsole(string fileName)
        {
            FileName=fileName;
        }

        public List<string> GetLinesFromFile(int numberOfLines,int skipLineCount)
        {
            List<string> result= new List<string>();
            int currentLineCnt=0;
            string lineOfText=string.Empty;
            using(System.IO.StreamReader file = new System.IO.StreamReader(FileName))
            {
                while((lineOfText = file.ReadLine()) != null)
                {
                    currentLineCnt=currentLineCnt+1;
                    if(skipLineCount !=0 && currentLineCnt<=skipLineCount)
                    {
                        //ignore line
                        break;
                    }
                    if(numberOfLines==0 || result.Count<numberOfLines)
                    {
                        result.Add(lineOfText);
                    }
                }  
            }
            return result;
        } 
    }
}