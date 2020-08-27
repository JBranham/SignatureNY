/*
 * Created by Ranorex
 * User: jbranham
 * Date: 1/16/2017
 * Time: 11:48 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace MyWebVIPTest
{
    /// <summary>
    /// Ranorex User Code collection. A collection is used to publish User Code methods to the User Code library.
    /// </summary>
    [UserCodeCollection]
    public class MyCustomMethods
    {
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the User Code library
        /// within a User Code collection.
        /// </summary>
        [UserCodeMethod]
        public static void MyCustomClickAndType(Adapter ItemToClick, string WhatToType)
        {
        	Report.Log(ReportLevel.Info, "Typing: " +WhatToType+ " into item: " + ItemToClick);
        	ItemToClick.Click();
        	ItemToClick.PressKeys(WhatToType);
        }
    }
}
