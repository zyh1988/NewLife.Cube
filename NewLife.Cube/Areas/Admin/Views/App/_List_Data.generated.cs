﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    
    #line 6 "..\..\Areas\Admin\Views\App\_List_Data.cshtml"
    using System.Web.Mvc;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Areas\Admin\Views\App\_List_Data.cshtml"
    using System.Web.Mvc.Ajax;
    
    #line default
    #line hidden
    
    #line 8 "..\..\Areas\Admin\Views\App\_List_Data.cshtml"
    using System.Web.Mvc.Html;
    
    #line default
    #line hidden
    
    #line 9 "..\..\Areas\Admin\Views\App\_List_Data.cshtml"
    using System.Web.Routing;
    
    #line default
    #line hidden
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 2 "..\..\Areas\Admin\Views\App\_List_Data.cshtml"
    using NewLife;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    
    #line 3 "..\..\Areas\Admin\Views\App\_List_Data.cshtml"
    using NewLife.Web;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Areas\Admin\Views\App\_List_Data.cshtml"
    using XCode;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Areas\Admin\Views\App\_List_Data.cshtml"
    using XCode.Configuration;
    
    #line default
    #line hidden
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/App/_List_Data.cshtml")]
    public partial class _Areas_Admin_Views_App__List_Data_cshtml : System.Web.Mvc.WebViewPage<IList<NewLife.Cube.Entity.App>>
    {
        public _Areas_Admin_Views_App__List_Data_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 10 "..\..\Areas\Admin\Views\App\_List_Data.cshtml"
  
    var fact = ViewBag.Factory as IEntityOperate;
    var page = ViewBag.Page as Pager;
    var fields = ViewBag.Fields as IList<FieldItem>;
    var set = ViewBag.PageSetting as PageSetting;
    var provider = ManageProvider.Provider;

            
            #line default
            #line hidden
WriteLiteral("\r\n<table");

WriteLiteral(" class=\"table table-bordered table-hover table-striped table-condensed\"");

WriteLiteral(">\r\n    <thead>\r\n        <tr>\r\n");

            
            #line 20 "..\..\Areas\Admin\Views\App\_List_Data.cshtml"
            
            
            #line default
            #line hidden
            
            #line 20 "..\..\Areas\Admin\Views\App\_List_Data.cshtml"
             if (set.EnableSelect)
            {

            
            #line default
            #line hidden
WriteLiteral("                <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" style=\"width:10px;\"");

WriteLiteral("><input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" id=\"chkAll\"");

WriteLiteral(" title=\"全选\"");

WriteLiteral(" /></th>\r\n");

            
            #line 23 "..\..\Areas\Admin\Views\App\_List_Data.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            <th");

WriteLiteral(" class=\"text-center hidden-md hidden-sm hidden-xs\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 834), Tuple.Create("\"", 873)
            
            #line 24 "..\..\Areas\Admin\Views\App\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 841), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("ID"))
            
            #line default
            #line hidden
, 841), false)
);

WriteLiteral(">编号</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" title=\"名称。AppID\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 943), Tuple.Create("\"", 984)
            
            #line 25 "..\..\Areas\Admin\Views\App\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 950), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Name"))
            
            #line default
            #line hidden
, 950), false)
);

WriteLiteral(">名称</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1037), Tuple.Create("\"", 1085)
            
            #line 26 "..\..\Areas\Admin\Views\App\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1044), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("DisplayName"))
            
            #line default
            #line hidden
, 1044), false)
);

WriteLiteral(">显示名</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" title=\"密钥。AppSecret\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1160), Tuple.Create("\"", 1203)
            
            #line 27 "..\..\Areas\Admin\Views\App\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1167), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Secret"))
            
            #line default
            #line hidden
, 1167), false)
);

WriteLiteral(">密钥</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1256), Tuple.Create("\"", 1297)
            
            #line 28 "..\..\Areas\Admin\Views\App\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1263), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Urls"))
            
            #line default
            #line hidden
, 1263), false)
);

WriteLiteral(">回调地址</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1352), Tuple.Create("\"", 1395)
            
            #line 29 "..\..\Areas\Admin\Views\App\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1359), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Enable"))
            
            #line default
            #line hidden
, 1359), false)
);

WriteLiteral(">启用</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1448), Tuple.Create("\"", 1490)
            
            #line 30 "..\..\Areas\Admin\Views\App\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1455), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Auths"))
            
            #line default
            #line hidden
, 1455), false)
);

WriteLiteral(">次数</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" style=\"min-width:134px;\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1568), Tuple.Create("\"", 1613)
            
            #line 31 "..\..\Areas\Admin\Views\App\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1575), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("LastAuth"))
            
            #line default
            #line hidden
, 1575), false)
);

WriteLiteral(">最后请求</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1668), Tuple.Create("\"", 1717)
            
            #line 32 "..\..\Areas\Admin\Views\App\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1675), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("UpdateUserID"))
            
            #line default
            #line hidden
, 1675), false)
);

WriteLiteral(">更新者</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" style=\"min-width:134px;\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1796), Tuple.Create("\"", 1843)
            
            #line 33 "..\..\Areas\Admin\Views\App\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1803), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("UpdateTime"))
            
            #line default
            #line hidden
, 1803), false)
);

WriteLiteral(">更新时间</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1898), Tuple.Create("\"", 1943)
            
            #line 34 "..\..\Areas\Admin\Views\App\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1905), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("UpdateIP"))
            
            #line default
            #line hidden
, 1905), false)
);

WriteLiteral(">更新地址</a></th>\r\n");

            
            #line 35 "..\..\Areas\Admin\Views\App\_List_Data.cshtml"
            
            
            #line default
            #line hidden
            
            #line 35 "..\..\Areas\Admin\Views\App\_List_Data.cshtml"
             if (this.Has(PermissionFlags.Detail, PermissionFlags.Update, PermissionFlags.Delete))
            {

            
            #line default
            #line hidden
WriteLiteral("                <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" style=\"min-width:100px;\"");

WriteLiteral(">操作</th>\r\n");

            
            #line 38 "..\..\Areas\Admin\Views\App\_List_Data.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n");

            
            #line 42 "..\..\Areas\Admin\Views\App\_List_Data.cshtml"
        
            
            #line default
            #line hidden
            
            #line 42 "..\..\Areas\Admin\Views\App\_List_Data.cshtml"
         foreach (var entity in Model)
        {

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n");

            
            #line 45 "..\..\Areas\Admin\Views\App\_List_Data.cshtml"
                
            
            #line default
            #line hidden
            
            #line 45 "..\..\Areas\Admin\Views\App\_List_Data.cshtml"
                 if (set.EnableSelect)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" name=\"keys\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2412), Tuple.Create("\"", 2430)
            
            #line 47 "..\..\Areas\Admin\Views\App\_List_Data.cshtml"
      , Tuple.Create(Tuple.Create("", 2420), Tuple.Create<System.Object, System.Int32>(entity.ID
            
            #line default
            #line hidden
, 2420), false)
);

WriteLiteral(" /></td>\r\n");

            
            #line 48 "..\..\Areas\Admin\Views\App\_List_Data.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                <td");

WriteLiteral(" class=\"text-center hidden-md hidden-sm hidden-xs\"");

WriteLiteral(">");

            
            #line 49 "..\..\Areas\Admin\Views\App\_List_Data.cshtml"
                                                                 Write(entity.ID);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 50 "..\..\Areas\Admin\Views\App\_List_Data.cshtml"
               Write(entity.Name);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 51 "..\..\Areas\Admin\Views\App\_List_Data.cshtml"
               Write(entity.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 52 "..\..\Areas\Admin\Views\App\_List_Data.cshtml"
               Write(entity.Secret);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 53 "..\..\Areas\Admin\Views\App\_List_Data.cshtml"
               Write(entity.Urls);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n                    <i");

WriteAttribute("class", Tuple.Create(" class=\"", 2776), Tuple.Create("\"", 2838)
, Tuple.Create(Tuple.Create("", 2784), Tuple.Create("glyphicon", 2784), true)
, Tuple.Create(Tuple.Create(" ", 2793), Tuple.Create("glyphicon-", 2794), true)
            
            #line 55 "..\..\Areas\Admin\Views\App\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 2804), Tuple.Create<System.Object, System.Int32>(entity.Enable ? "ok" : "remove"
            
            #line default
            #line hidden
, 2804), false)
);

WriteAttribute("style", Tuple.Create(" style=\"", 2839), Tuple.Create("\"", 2889)
, Tuple.Create(Tuple.Create("", 2847), Tuple.Create("color:", 2847), true)
            
            #line 55 "..\..\Areas\Admin\Views\App\_List_Data.cshtml"
                    , Tuple.Create(Tuple.Create(" ", 2853), Tuple.Create<System.Object, System.Int32>(entity.Enable ? "green" : "red"
            
            #line default
            #line hidden
, 2854), false)
, Tuple.Create(Tuple.Create("", 2888), Tuple.Create(";", 2888), true)
);

WriteLiteral("></i>\r\n                </td>\r\n                <td");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 57 "..\..\Areas\Admin\Views\App\_List_Data.cshtml"
                                  Write(entity.Auths.ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 58 "..\..\Areas\Admin\Views\App\_List_Data.cshtml"
               Write(entity.LastAuth.ToFullString(""));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 59 "..\..\Areas\Admin\Views\App\_List_Data.cshtml"
                                  Write(UserX.FindByID(entity.UpdateUserID));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 60 "..\..\Areas\Admin\Views\App\_List_Data.cshtml"
               Write(entity.UpdateTime.ToFullString(""));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteAttribute("title", Tuple.Create(" title=\"", 3217), Tuple.Create("\"", 3255)
            
            #line 61 "..\..\Areas\Admin\Views\App\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 3225), Tuple.Create<System.Object, System.Int32>(entity.UpdateIP.IPToAddress()
            
            #line default
            #line hidden
, 3225), false)
);

WriteLiteral(">");

            
            #line 61 "..\..\Areas\Admin\Views\App\_List_Data.cshtml"
                                                      Write(entity.UpdateIP);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 62 "..\..\Areas\Admin\Views\App\_List_Data.cshtml"
                
            
            #line default
            #line hidden
            
            #line 62 "..\..\Areas\Admin\Views\App\_List_Data.cshtml"
                 if (this.Has(PermissionFlags.Detail, PermissionFlags.Update, PermissionFlags.Delete))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 65 "..\..\Areas\Admin\Views\App\_List_Data.cshtml"
                   Write(Html.Partial("_List_Data_Action", (Object)entity));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n");

            
            #line 67 "..\..\Areas\Admin\Views\App\_List_Data.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </tr>\r\n");

            
            #line 69 "..\..\Areas\Admin\Views\App\_List_Data.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </tbody>\r\n</table>");

        }
    }
}
#pragma warning restore 1591
