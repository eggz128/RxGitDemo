﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace GlobalParams
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the GlobalParamsRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("515b2500-81e2-48a0-8c1f-38e7f7747356")]
    public partial class GlobalParamsRepository : RepoGenBaseFolder
    {
        static GlobalParamsRepository instance = new GlobalParamsRepository();
        GlobalParamsRepositoryFolders.AutomatedToolsTestSiteAppFolder _automatedtoolstestsite;

        /// <summary>
        /// Gets the singleton class instance representing the GlobalParamsRepository element repository.
        /// </summary>
        [RepositoryFolder("515b2500-81e2-48a0-8c1f-38e7f7747356")]
        public static GlobalParamsRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public GlobalParamsRepository() 
            : base("GlobalParamsRepository", "/", null, 0, false, "515b2500-81e2-48a0-8c1f-38e7f7747356", ".\\RepositoryImages\\GlobalParamsRepository515b2500.rximgres")
        {
            _automatedtoolstestsite = new GlobalParamsRepositoryFolders.AutomatedToolsTestSiteAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("515b2500-81e2-48a0-8c1f-38e7f7747356")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The AutomatedToolsTestSite folder.
        /// </summary>
        [RepositoryFolder("d0410b5c-e94c-463c-a25c-0bbb61d9e674")]
        public virtual GlobalParamsRepositoryFolders.AutomatedToolsTestSiteAppFolder AutomatedToolsTestSite
        {
            get { return _automatedtoolstestsite; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class GlobalParamsRepositoryFolders
    {
        /// <summary>
        /// The AutomatedToolsTestSiteAppFolder folder.
        /// </summary>
        [RepositoryFolder("d0410b5c-e94c-463c-a25c-0bbb61d9e674")]
        public partial class AutomatedToolsTestSiteAppFolder : RepoGenBaseFolder
        {
            GlobalParamsRepositoryFolders.SomeUlTagFolder _someultag;

            /// <summary>
            /// Creates a new AutomatedToolsTestSite  folder.
            /// </summary>
            public AutomatedToolsTestSiteAppFolder(RepoGenBaseFolder parentFolder) :
                    base("AutomatedToolsTestSite", "/dom[@domain>'www.edgewords']", parentFolder, 30000, null, false, "d0410b5c-e94c-463c-a25c-0bbb61d9e674", "")
            {
                _someultag = new GlobalParamsRepositoryFolders.SomeUlTagFolder(this);
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("d0410b5c-e94c-463c-a25c-0bbb61d9e674")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("d0410b5c-e94c-463c-a25c-0bbb61d9e674")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The SomeUlTag folder.
            /// </summary>
            [RepositoryFolder("527baefa-a513-48e0-8941-d4854c5370bb")]
            public virtual GlobalParamsRepositoryFolders.SomeUlTagFolder SomeUlTag
            {
                get { return _someultag; }
            }
        }

        /// <summary>
        /// The SomeUlTagFolder folder.
        /// </summary>
        [RepositoryFolder("527baefa-a513-48e0-8941-d4854c5370bb")]
        public partial class SomeUlTagFolder : RepoGenBaseFolder
        {
            RepoItemInfo _basichtmlInfo;
            RepoItemInfo _cssxpathlinkInfo;
            RepoItemInfo _dynamiccontentInfo;
            RepoItemInfo _formsInfo;
            RepoItemInfo _homeInfo;

            /// <summary>
            /// Creates a new SomeUlTag  folder.
            /// </summary>
            public SomeUlTagFolder(RepoGenBaseFolder parentFolder) :
                    base("SomeUlTag", ".//div[#'menu']/ul", parentFolder, 30000, null, false, "527baefa-a513-48e0-8941-d4854c5370bb", "")
            {
                _basichtmlInfo = new RepoItemInfo(this, "BasicHTML", ".//span[@innertext='Basic HTML']", "", 30000, null, "93ff4984-7fa1-45f0-8bd6-9a650b7c5864");
                _cssxpathlinkInfo = new RepoItemInfo(this, "CSSXPathLink", ".//span[@innertext='CSS/XPath']", "", 30000, null, "833ebf82-4eee-4e1c-ae5c-178791a5fc99");
                _dynamiccontentInfo = new RepoItemInfo(this, "DynamicContent", ".//span[@innertext='Dynamic Content']", "", 30000, null, "a8fefb24-8639-4dc2-a6ec-083d079a09d9");
                _formsInfo = new RepoItemInfo(this, "Forms", ".//span[@innertext='Forms']", "", 30000, null, "84af2668-7bb7-4e45-af80-d0925ff165c2");
                _homeInfo = new RepoItemInfo(this, "Home", ".//span[@innertext='Home1']", "", 30000, null, "3d78ff45-bc70-464d-a6fe-16d1176fbe4c");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("527baefa-a513-48e0-8941-d4854c5370bb")]
            public virtual Ranorex.UlTag Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.UlTag>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("527baefa-a513-48e0-8941-d4854c5370bb")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The BasicHTML item.
            /// </summary>
            [RepositoryItem("93ff4984-7fa1-45f0-8bd6-9a650b7c5864")]
            public virtual Ranorex.SpanTag BasicHTML
            {
                get
                {
                    return _basichtmlInfo.CreateAdapter<Ranorex.SpanTag>(true);
                }
            }

            /// <summary>
            /// The BasicHTML item info.
            /// </summary>
            [RepositoryItemInfo("93ff4984-7fa1-45f0-8bd6-9a650b7c5864")]
            public virtual RepoItemInfo BasicHTMLInfo
            {
                get
                {
                    return _basichtmlInfo;
                }
            }

            /// <summary>
            /// The CSSXPathLink item.
            /// </summary>
            [RepositoryItem("833ebf82-4eee-4e1c-ae5c-178791a5fc99")]
            public virtual Ranorex.SpanTag CSSXPathLink
            {
                get
                {
                    return _cssxpathlinkInfo.CreateAdapter<Ranorex.SpanTag>(true);
                }
            }

            /// <summary>
            /// The CSSXPathLink item info.
            /// </summary>
            [RepositoryItemInfo("833ebf82-4eee-4e1c-ae5c-178791a5fc99")]
            public virtual RepoItemInfo CSSXPathLinkInfo
            {
                get
                {
                    return _cssxpathlinkInfo;
                }
            }

            /// <summary>
            /// The DynamicContent item.
            /// </summary>
            [RepositoryItem("a8fefb24-8639-4dc2-a6ec-083d079a09d9")]
            public virtual Ranorex.SpanTag DynamicContent
            {
                get
                {
                    return _dynamiccontentInfo.CreateAdapter<Ranorex.SpanTag>(true);
                }
            }

            /// <summary>
            /// The DynamicContent item info.
            /// </summary>
            [RepositoryItemInfo("a8fefb24-8639-4dc2-a6ec-083d079a09d9")]
            public virtual RepoItemInfo DynamicContentInfo
            {
                get
                {
                    return _dynamiccontentInfo;
                }
            }

            /// <summary>
            /// The Forms item.
            /// </summary>
            [RepositoryItem("84af2668-7bb7-4e45-af80-d0925ff165c2")]
            public virtual Ranorex.SpanTag Forms
            {
                get
                {
                    return _formsInfo.CreateAdapter<Ranorex.SpanTag>(true);
                }
            }

            /// <summary>
            /// The Forms item info.
            /// </summary>
            [RepositoryItemInfo("84af2668-7bb7-4e45-af80-d0925ff165c2")]
            public virtual RepoItemInfo FormsInfo
            {
                get
                {
                    return _formsInfo;
                }
            }

            /// <summary>
            /// The Home item.
            /// </summary>
            [RepositoryItem("3d78ff45-bc70-464d-a6fe-16d1176fbe4c")]
            public virtual Ranorex.SpanTag Home
            {
                get
                {
                    return _homeInfo.CreateAdapter<Ranorex.SpanTag>(true);
                }
            }

            /// <summary>
            /// The Home item info.
            /// </summary>
            [RepositoryItemInfo("3d78ff45-bc70-464d-a6fe-16d1176fbe4c")]
            public virtual RepoItemInfo HomeInfo
            {
                get
                {
                    return _homeInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
