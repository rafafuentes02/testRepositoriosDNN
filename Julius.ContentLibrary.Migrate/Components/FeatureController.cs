/*
' Copyright (c) 2021 Luis Gómez
'  All rights reserved.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
' 
*/

using System.Collections.Generic;
//using System.Xml;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Services.Search;

namespace Julius.Modules.Julius.ContentLibrary.Migrate.Components
{

    /// -----------------------------------------------------------------------------
    /// <summary>
    /// The Controller class for Julius.ContentLibrary.Migrate
    /// 
    /// The FeatureController class is defined as the BusinessController in the manifest file (.dnn)
    /// DotNetNuke will poll this class to find out which Interfaces the class implements. 
    /// 
    /// The IPortable interface is used to import/export content from a DNN module
    /// 
    /// The ISearchable interface is used by DNN to index the content of a module
    /// 
    /// The IUpgradeable interface allows module developers to execute code during the upgrade 
    /// process for a module.
    /// 
    /// Below you will find stubbed out implementations of each, uncomment and populate with your own data
    /// </summary>
    /// -----------------------------------------------------------------------------

    //uncomment the interfaces to add the support.
    public class FeatureController //: IPortable, ISearchable, IUpgradeable
    {


        #region Optional Interfaces

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// ExportModule implements the IPortable ExportModule Interface
        /// </summary>
        /// <param name="ModuleID">The Id of the module to be exported</param>
        /// -----------------------------------------------------------------------------
        //public string ExportModule(int ModuleID)
        //{
        //string strXML = "";

        //List<Julius.ContentLibrary.MigrateInfo> colJulius.ContentLibrary.Migrates = GetJulius.ContentLibrary.Migrates(ModuleID);
        //if (colJulius.ContentLibrary.Migrates.Count != 0)
        //{
        //    strXML += "<Julius.ContentLibrary.Migrates>";

        //    foreach (Julius.ContentLibrary.MigrateInfo objJulius.ContentLibrary.Migrate in colJulius.ContentLibrary.Migrates)
        //    {
        //        strXML += "<Julius.ContentLibrary.Migrate>";
        //        strXML += "<content>" + DotNetNuke.Common.Utilities.XmlUtils.XMLEncode(objJulius.ContentLibrary.Migrate.Content) + "</content>";
        //        strXML += "</Julius.ContentLibrary.Migrate>";
        //    }
        //    strXML += "</Julius.ContentLibrary.Migrates>";
        //}

        //return strXML;

        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// ImportModule implements the IPortable ImportModule Interface
        /// </summary>
        /// <param name="ModuleID">The Id of the module to be imported</param>
        /// <param name="Content">The content to be imported</param>
        /// <param name="Version">The version of the module to be imported</param>
        /// <param name="UserId">The Id of the user performing the import</param>
        /// -----------------------------------------------------------------------------
        //public void ImportModule(int ModuleID, string Content, string Version, int UserID)
        //{
        //XmlNode xmlJulius.ContentLibrary.Migrates = DotNetNuke.Common.Globals.GetContent(Content, "Julius.ContentLibrary.Migrates");
        //foreach (XmlNode xmlJulius.ContentLibrary.Migrate in xmlJulius.ContentLibrary.Migrates.SelectNodes("Julius.ContentLibrary.Migrate"))
        //{
        //    Julius.ContentLibrary.MigrateInfo objJulius.ContentLibrary.Migrate = new Julius.ContentLibrary.MigrateInfo();
        //    objJulius.ContentLibrary.Migrate.ModuleId = ModuleID;
        //    objJulius.ContentLibrary.Migrate.Content = xmlJulius.ContentLibrary.Migrate.SelectSingleNode("content").InnerText;
        //    objJulius.ContentLibrary.Migrate.CreatedByUser = UserID;
        //    AddJulius.ContentLibrary.Migrate(objJulius.ContentLibrary.Migrate);
        //}

        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// GetSearchItems implements the ISearchable Interface
        /// </summary>
        /// <param name="ModInfo">The ModuleInfo for the module to be Indexed</param>
        /// -----------------------------------------------------------------------------
        //public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        //{
        //SearchItemInfoCollection SearchItemCollection = new SearchItemInfoCollection();

        //List<Julius.ContentLibrary.MigrateInfo> colJulius.ContentLibrary.Migrates = GetJulius.ContentLibrary.Migrates(ModInfo.ModuleID);

        //foreach (Julius.ContentLibrary.MigrateInfo objJulius.ContentLibrary.Migrate in colJulius.ContentLibrary.Migrates)
        //{
        //    SearchItemInfo SearchItem = new SearchItemInfo(ModInfo.ModuleTitle, objJulius.ContentLibrary.Migrate.Content, objJulius.ContentLibrary.Migrate.CreatedByUser, objJulius.ContentLibrary.Migrate.CreatedDate, ModInfo.ModuleID, objJulius.ContentLibrary.Migrate.ItemId.ToString(), objJulius.ContentLibrary.Migrate.Content, "ItemId=" + objJulius.ContentLibrary.Migrate.ItemId.ToString());
        //    SearchItemCollection.Add(SearchItem);
        //}

        //return SearchItemCollection;

        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// UpgradeModule implements the IUpgradeable Interface
        /// </summary>
        /// <param name="Version">The current version of the module</param>
        /// -----------------------------------------------------------------------------
        //public string UpgradeModule(string Version)
        //{
        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        #endregion

    }

}
