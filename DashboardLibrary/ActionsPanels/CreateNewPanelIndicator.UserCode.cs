﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace DashboardLibrary.ActionsPanels
{
    public partial class CreateNewPanelIndicator
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void AddFromColor(RepoItemInfo From, RepoItemInfo txtColor, RepoItemInfo color, RepoItemInfo add,String varFromColor)
        {
        	String[] lstFromColor= null;
        	
        	if(varFromColor.Contains(";"))
        	{
        		lstFromColor= varFromColor.Split(';');
        	}
        	else
        	{
        		lstFromColor = new string[1]{varFromColor};
        	}
        	int i=0;
        	do
        	{
        		String[] varFC = lstFromColor[i].Split(',');
        		
	            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '$varFrom' on item 'From'.", From);
	            Report.Info(varFC[0]);
	            int j=i+1;
	            DashboardLibraryRepository.Instance.varNumber=(j+1).ToString();
	            From.FindAdapter<InputTag>().Element.SetAttributeValue("Value", varFC[0]);
	            
	            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'txtColor' at Center.", txtColor);
	            txtColor.FindAdapter<InputTag>().Click();
	            
	            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'color' at Center.", color);
	            DashboardLibraryRepository.Instance.varColor=varFC[1];
	            color.FindAdapter<TdTag>().Click();
	            if(i<lstFromColor.Length-1)
	            {
	            	Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'add' at Center.", add);
	            	add.FindAdapter<ImgTag>().Click();
	            }
	            i=i+1;
	            
        	}while(i<lstFromColor.Length);
        }

       
    }
}
