using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using ExampleBase;

using NetOffice;
using Outlook = NetOffice.OutlookApi;
using NetOffice.OutlookApi.Enums;

namespace OutlookExamplesCS4
{
    /// <summary>
    /// Example 1 - Inbox Folder
    /// </summary>
    internal partial class Example01 : UserControl , IExample
    {
        #region Ctor

        public Example01()
        {
            InitializeComponent();
        }

        #endregion

        #region IExample

        public void RunExample()
        {
            // its an example with an own visual control
            // checkout buttonStartExample_Click
        }

        public string Caption
        {
            get { return "Example01"; }
        }

        public string Description
        {
            get { return "Inbox Folder"; }
        }

        public void Connect(IHost hostApplication)
        {
            HostApplication = hostApplication;
        }

        public UserControl Panel
        {
            get { return this; }
        }
        
        #endregion

        #region Properties

        internal IHost HostApplication { get; private set; }

        #endregion

        #region UI Trigger

        private void buttonStartExample_Click(object sender, EventArgs e)
        {
            // start outlook
            Outlook.Application outlookApplication = new Outlook.Application();

            // get inbox 
            Outlook._NameSpace outlookNS = outlookApplication.GetNamespace("MAPI");
            Outlook.MAPIFolder inboxFolder = outlookNS.GetDefaultFolder(OlDefaultFolders.olFolderInbox);

            // setup gui
            listViewInboxFolder.Items.Clear();
            labelItemsCount.Text = string.Format("You have {0} e-mails.", inboxFolder.Items.Count);

            // we fetch the inbox folder items.
            foreach (COMObject item in inboxFolder.Items)
            {
                // not every item in the inbox is a mail item
                Outlook.MailItem mailItem = item as Outlook.MailItem;
                if (null != mailItem)
                {
                    ListViewItem newItem = listViewInboxFolder.Items.Add(mailItem.SenderName);
                    newItem.SubItems.Add(mailItem.Subject);
                }
            }

            // close outlook and dispose
            outlookApplication.Quit();
            outlookApplication.Dispose();
        }
        
        #endregion
    }
}
