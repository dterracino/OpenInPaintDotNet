using OpenInApp.Common.Helpers;
using System.Collections.Generic;

namespace OpenInApp.Helpers
{
    public static class ConstantsForApp 
    {
        public const string AppFolderName = "$gregt$";//"Altova", "Paint.NET"
        public const string AppSubFolderName = null;//null in most cases, "XMLSpy"
        public const string ExecutableFileToBrowseFor = "$gregt$";//"XmlSpy.exe", "PaintDotNet.exe"
        public static IEnumerable<string> GetDefaultTypicalFileExtensions()
        {
            return new List<string>
            {
                //Source(s) $gregt$ e.g. http://manual.altova.com/XMLSpy/spyprofessional/index.html?filetypes.htm
                #region Extensions
                "$gregt$",
                "$gregt$",
                "$gregt$", 
	            #endregion
            };
        }



        internal const string CommonActualPathToExeOptionLabel = CommonConstants.ActualPathToExeOptionLabelPrefix + ExecutableFileToBrowseFor;
    }
}
