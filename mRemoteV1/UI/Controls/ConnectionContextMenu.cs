﻿using System;
using System.Linq;
using System.Windows.Forms;
using mRemoteNG.App;
using mRemoteNG.Connection;
using mRemoteNG.Connection.Protocol;
using mRemoteNG.Container;
using mRemoteNG.Tools;
using mRemoteNG.Tree.Root;
// ReSharper disable UnusedParameter.Local


namespace mRemoteNG.UI.Controls
{
    internal sealed class ConnectionContextMenu : ContextMenuStrip
    {
        private ToolStripMenuItem _cMenTreeAddConnection;
        private ToolStripMenuItem _cMenTreeAddFolder;
        private ToolStripSeparator _cMenTreeSep1;
        private ToolStripMenuItem _cMenTreeConnect;
        private ToolStripMenuItem _cMenTreeConnectWithOptions;
        private ToolStripMenuItem _cMenTreeConnectWithOptionsConnectToConsoleSession;
        private ToolStripMenuItem _cMenTreeConnectWithOptionsNoCredentials;
        private ToolStripMenuItem _cMenTreeConnectWithOptionsConnectInFullscreen;
        private ToolStripMenuItem _cMenTreeDisconnect;
        private ToolStripSeparator _cMenTreeSep2;
        private ToolStripMenuItem _cMenTreeToolsTransferFile;
        private ToolStripMenuItem _cMenTreeToolsSort;
        private ToolStripMenuItem _cMenTreeToolsSortAscending;
        private ToolStripMenuItem _cMenTreeToolsSortDescending;
        private ToolStripSeparator _cMenTreeSep3;
        private ToolStripMenuItem _cMenTreeRename;
        private ToolStripMenuItem _cMenTreeDelete;
        private ToolStripSeparator _cMenTreeSep4;
        private ToolStripMenuItem _cMenTreeMoveUp;
        private ToolStripMenuItem _cMenTreeMoveDown;
        private ToolStripMenuItem _cMenTreeToolsExternalApps;
        private ToolStripMenuItem _cMenTreeDuplicate;
        private ToolStripMenuItem _cMenTreeConnectWithOptionsChoosePanelBeforeConnecting;
        private ToolStripMenuItem _cMenTreeConnectWithOptionsDontConnectToConsoleSession;
        private ToolStripMenuItem _cMenTreeImport;
        private ToolStripMenuItem _cMenTreeExportFile;
        private ToolStripSeparator _toolStripSeparator1;
        private ToolStripMenuItem _cMenTreeImportFile;
        private ToolStripMenuItem _cMenTreeImportActiveDirectory;
        private ToolStripMenuItem _cMenTreeImportPortScan;


        public ConnectionContextMenu()
        {
            InitializeComponent();
            ApplyLanguage();
            EnableShortcutKeys();
            Opening += (sender, args) => AddExternalApps();
        }

        private void InitializeComponent()
        {
            _cMenTreeConnect = new ToolStripMenuItem();
            _cMenTreeConnectWithOptions = new ToolStripMenuItem();
            _cMenTreeConnectWithOptionsConnectToConsoleSession = new ToolStripMenuItem();
            _cMenTreeConnectWithOptionsDontConnectToConsoleSession = new ToolStripMenuItem();
            _cMenTreeConnectWithOptionsConnectInFullscreen = new ToolStripMenuItem();
            _cMenTreeConnectWithOptionsNoCredentials = new ToolStripMenuItem();
            _cMenTreeConnectWithOptionsChoosePanelBeforeConnecting = new ToolStripMenuItem();
            _cMenTreeDisconnect = new ToolStripMenuItem();
            _cMenTreeSep1 = new ToolStripSeparator();
            _cMenTreeToolsExternalApps = new ToolStripMenuItem();
            _cMenTreeToolsTransferFile = new ToolStripMenuItem();
            _cMenTreeSep2 = new ToolStripSeparator();
            _cMenTreeDuplicate = new ToolStripMenuItem();
            _cMenTreeRename = new ToolStripMenuItem();
            _cMenTreeDelete = new ToolStripMenuItem();
            _cMenTreeSep3 = new ToolStripSeparator();
            _cMenTreeImport = new ToolStripMenuItem();
            _cMenTreeImportFile = new ToolStripMenuItem();
            _cMenTreeImportActiveDirectory = new ToolStripMenuItem();
            _cMenTreeImportPortScan = new ToolStripMenuItem();
            _cMenTreeExportFile = new ToolStripMenuItem();
            _cMenTreeSep4 = new ToolStripSeparator();
            _cMenTreeAddConnection = new ToolStripMenuItem();
            _cMenTreeAddFolder = new ToolStripMenuItem();
            _toolStripSeparator1 = new ToolStripSeparator();
            _cMenTreeToolsSort = new ToolStripMenuItem();
            _cMenTreeToolsSortAscending = new ToolStripMenuItem();
            _cMenTreeToolsSortDescending = new ToolStripMenuItem();
            _cMenTreeMoveUp = new ToolStripMenuItem();
            _cMenTreeMoveDown = new ToolStripMenuItem();


            // 
            // cMenTree
            // 
            Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Items.AddRange(new ToolStripItem[] {
                _cMenTreeConnect,
                _cMenTreeConnectWithOptions,
                _cMenTreeDisconnect,
                _cMenTreeSep1,
                _cMenTreeToolsExternalApps,
                _cMenTreeToolsTransferFile,
                _cMenTreeSep2,
                _cMenTreeDuplicate,
                _cMenTreeRename,
                _cMenTreeDelete,
                _cMenTreeSep3,
                _cMenTreeImport,
                _cMenTreeExportFile,
                _cMenTreeSep4,
                _cMenTreeAddConnection,
                _cMenTreeAddFolder,
                _toolStripSeparator1,
                _cMenTreeToolsSort,
                _cMenTreeMoveUp,
                _cMenTreeMoveDown
            });
            Name = "cMenTree";
            RenderMode = ToolStripRenderMode.Professional;
            Size = new System.Drawing.Size(200, 364);
            // 
            // cMenTreeConnect
            // 
            _cMenTreeConnect.Image = Resources.Play;
            _cMenTreeConnect.Name = "_cMenTreeConnect";
            _cMenTreeConnect.Size = new System.Drawing.Size(199, 22);
            _cMenTreeConnect.Text = "Connect";
            _cMenTreeConnect.Click += OnConnectClicked;
            // 
            // cMenTreeConnectWithOptions
            // 
            _cMenTreeConnectWithOptions.DropDownItems.AddRange(new ToolStripItem[] {
                _cMenTreeConnectWithOptionsConnectToConsoleSession,
                _cMenTreeConnectWithOptionsDontConnectToConsoleSession,
                _cMenTreeConnectWithOptionsConnectInFullscreen,
                _cMenTreeConnectWithOptionsNoCredentials,
                _cMenTreeConnectWithOptionsChoosePanelBeforeConnecting
            });
            _cMenTreeConnectWithOptions.Name = "_cMenTreeConnectWithOptions";
            _cMenTreeConnectWithOptions.Size = new System.Drawing.Size(199, 22);
            _cMenTreeConnectWithOptions.Text = "Connect (with options)";
            // 
            // cMenTreeConnectWithOptionsConnectToConsoleSession
            // 
            _cMenTreeConnectWithOptionsConnectToConsoleSession.Image = Resources.monitor_go;
            _cMenTreeConnectWithOptionsConnectToConsoleSession.Name = "_cMenTreeConnectWithOptionsConnectToConsoleSession";
            _cMenTreeConnectWithOptionsConnectToConsoleSession.Size = new System.Drawing.Size(245, 22);
            _cMenTreeConnectWithOptionsConnectToConsoleSession.Text = "Connect to console session";
            _cMenTreeConnectWithOptionsConnectToConsoleSession.Click += OnConnectToConsoleSessionClicked;
            // 
            // cMenTreeConnectWithOptionsDontConnectToConsoleSession
            // 
            _cMenTreeConnectWithOptionsDontConnectToConsoleSession.Image = Resources.monitor_delete;
            _cMenTreeConnectWithOptionsDontConnectToConsoleSession.Name = "_cMenTreeConnectWithOptionsDontConnectToConsoleSession";
            _cMenTreeConnectWithOptionsDontConnectToConsoleSession.Size = new System.Drawing.Size(245, 22);
            _cMenTreeConnectWithOptionsDontConnectToConsoleSession.Text = "Don\'t connect to console session";
            _cMenTreeConnectWithOptionsDontConnectToConsoleSession.Visible = false;
            _cMenTreeConnectWithOptionsDontConnectToConsoleSession.Click += OnDontConnectToConsoleSessionClicked;
            // 
            // cMenTreeConnectWithOptionsConnectInFullscreen
            // 
            _cMenTreeConnectWithOptionsConnectInFullscreen.Image = Resources.arrow_out;
            _cMenTreeConnectWithOptionsConnectInFullscreen.Name = "_cMenTreeConnectWithOptionsConnectInFullscreen";
            _cMenTreeConnectWithOptionsConnectInFullscreen.Size = new System.Drawing.Size(245, 22);
            _cMenTreeConnectWithOptionsConnectInFullscreen.Text = "Connect in fullscreen";
            _cMenTreeConnectWithOptionsConnectInFullscreen.Click += OnConnectInFullscreenClicked;
            // 
            // cMenTreeConnectWithOptionsNoCredentials
            // 
            _cMenTreeConnectWithOptionsNoCredentials.Image = Resources.key_delete;
            _cMenTreeConnectWithOptionsNoCredentials.Name = "_cMenTreeConnectWithOptionsNoCredentials";
            _cMenTreeConnectWithOptionsNoCredentials.Size = new System.Drawing.Size(245, 22);
            _cMenTreeConnectWithOptionsNoCredentials.Text = "Connect without credentials";
            _cMenTreeConnectWithOptionsNoCredentials.Click += OnConnectWithNoCredentialsClick;
            // 
            // cMenTreeConnectWithOptionsChoosePanelBeforeConnecting
            // 
            _cMenTreeConnectWithOptionsChoosePanelBeforeConnecting.Image = Resources.Panels;
            _cMenTreeConnectWithOptionsChoosePanelBeforeConnecting.Name = "_cMenTreeConnectWithOptionsChoosePanelBeforeConnecting";
            _cMenTreeConnectWithOptionsChoosePanelBeforeConnecting.Size = new System.Drawing.Size(245, 22);
            _cMenTreeConnectWithOptionsChoosePanelBeforeConnecting.Text = "Choose panel before connecting";
            _cMenTreeConnectWithOptionsChoosePanelBeforeConnecting.Click += OnChoosePanelBeforeConnectingClicked;
            // 
            // cMenTreeDisconnect
            // 
            _cMenTreeDisconnect.Image = Resources.Pause;
            _cMenTreeDisconnect.Name = "_cMenTreeDisconnect";
            _cMenTreeDisconnect.Size = new System.Drawing.Size(199, 22);
            _cMenTreeDisconnect.Text = "Disconnect";
            _cMenTreeDisconnect.Click += OnDisconnectClicked;
            // 
            // cMenTreeSep1
            // 
            _cMenTreeSep1.Name = "_cMenTreeSep1";
            _cMenTreeSep1.Size = new System.Drawing.Size(196, 6);
            // 
            // cMenTreeToolsExternalApps
            // 
            _cMenTreeToolsExternalApps.Image = Resources.ExtApp;
            _cMenTreeToolsExternalApps.Name = "_cMenTreeToolsExternalApps";
            _cMenTreeToolsExternalApps.Size = new System.Drawing.Size(199, 22);
            _cMenTreeToolsExternalApps.Text = "External Applications";
            // 
            // cMenTreeToolsTransferFile
            // 
            _cMenTreeToolsTransferFile.Image = Resources.SSHTransfer;
            _cMenTreeToolsTransferFile.Name = "_cMenTreeToolsTransferFile";
            _cMenTreeToolsTransferFile.Size = new System.Drawing.Size(199, 22);
            _cMenTreeToolsTransferFile.Text = "Transfer File (SSH)";
            _cMenTreeToolsTransferFile.Click += OnTransferFileClicked;
            // 
            // cMenTreeSep2
            // 
            _cMenTreeSep2.Name = "_cMenTreeSep2";
            _cMenTreeSep2.Size = new System.Drawing.Size(196, 6);
            // 
            // cMenTreeDuplicate
            // 
            _cMenTreeDuplicate.Image = Resources.page_copy;
            _cMenTreeDuplicate.Name = "_cMenTreeDuplicate";
            _cMenTreeDuplicate.Size = new System.Drawing.Size(199, 22);
            _cMenTreeDuplicate.Text = "Duplicate";
            _cMenTreeDuplicate.Click += OnDuplicateClicked;
            // 
            // cMenTreeRename
            // 
            _cMenTreeRename.Image = Resources.Rename;
            _cMenTreeRename.Name = "_cMenTreeRename";
            _cMenTreeRename.Size = new System.Drawing.Size(199, 22);
            _cMenTreeRename.Text = "Rename";
            _cMenTreeRename.Click += OnRenameClicked;
            // 
            // cMenTreeDelete
            // 
            _cMenTreeDelete.Image = Resources.Delete;
            _cMenTreeDelete.Name = "_cMenTreeDelete";
            _cMenTreeDelete.Size = new System.Drawing.Size(199, 22);
            _cMenTreeDelete.Text = "Delete";
            _cMenTreeDelete.Click += OnDeleteClicked;
            // 
            // cMenTreeSep3
            // 
            _cMenTreeSep3.Name = "_cMenTreeSep3";
            _cMenTreeSep3.Size = new System.Drawing.Size(196, 6);
            // 
            // cMenTreeImport
            // 
            _cMenTreeImport.DropDownItems.AddRange(new ToolStripItem[] {
                _cMenTreeImportFile,
                _cMenTreeImportActiveDirectory,
                _cMenTreeImportPortScan
            });
            _cMenTreeImport.Name = "_cMenTreeImport";
            _cMenTreeImport.Size = new System.Drawing.Size(199, 22);
            _cMenTreeImport.Text = "&Import";
            // 
            // cMenTreeImportFile
            // 
            _cMenTreeImportFile.Name = "_cMenTreeImportFile";
            _cMenTreeImportFile.Size = new System.Drawing.Size(226, 22);
            _cMenTreeImportFile.Text = "Import from &File...";
            _cMenTreeImportFile.Click += OnImportFileClicked;
            // 
            // cMenTreeImportActiveDirectory
            // 
            _cMenTreeImportActiveDirectory.Name = "_cMenTreeImportActiveDirectory";
            _cMenTreeImportActiveDirectory.Size = new System.Drawing.Size(226, 22);
            _cMenTreeImportActiveDirectory.Text = "Import from &Active Directory...";
            _cMenTreeImportActiveDirectory.Click += OnImportActiveDirectoryClicked;
            // 
            // cMenTreeImportPortScan
            // 
            _cMenTreeImportPortScan.Name = "_cMenTreeImportPortScan";
            _cMenTreeImportPortScan.Size = new System.Drawing.Size(226, 22);
            _cMenTreeImportPortScan.Text = "Import from &Port Scan...";
            _cMenTreeImportPortScan.Click += OnImportPortScanClicked;
            // 
            // cMenTreeExportFile
            // 
            _cMenTreeExportFile.Name = "_cMenTreeExportFile";
            _cMenTreeExportFile.Size = new System.Drawing.Size(199, 22);
            _cMenTreeExportFile.Text = "&Export to File...";
            _cMenTreeExportFile.Click += OnExportFileClicked;
            // 
            // cMenTreeSep4
            // 
            _cMenTreeSep4.Name = "_cMenTreeSep4";
            _cMenTreeSep4.Size = new System.Drawing.Size(196, 6);
            // 
            // cMenTreeAddConnection
            // 
            _cMenTreeAddConnection.Image = Resources.Connection_Add;
            _cMenTreeAddConnection.Name = "_cMenTreeAddConnection";
            _cMenTreeAddConnection.Size = new System.Drawing.Size(199, 22);
            _cMenTreeAddConnection.Text = "New Connection";
            _cMenTreeAddConnection.Click += OnAddConnectionClicked;
            // 
            // cMenTreeAddFolder
            // 
            _cMenTreeAddFolder.Image = Resources.Folder_Add;
            _cMenTreeAddFolder.Name = "_cMenTreeAddFolder";
            _cMenTreeAddFolder.Size = new System.Drawing.Size(199, 22);
            _cMenTreeAddFolder.Text = "New Folder";
            _cMenTreeAddFolder.Click += OnAddFolderClicked;
            // 
            // ToolStripSeparator1
            // 
            _toolStripSeparator1.Name = "_toolStripSeparator1";
            _toolStripSeparator1.Size = new System.Drawing.Size(196, 6);
            // 
            // cMenTreeToolsSort
            // 
            _cMenTreeToolsSort.DropDownItems.AddRange(new ToolStripItem[] {
                _cMenTreeToolsSortAscending,
                _cMenTreeToolsSortDescending
            });
            _cMenTreeToolsSort.Name = "_cMenTreeToolsSort";
            _cMenTreeToolsSort.Size = new System.Drawing.Size(199, 22);
            _cMenTreeToolsSort.Text = "Sort";
            // 
            // cMenTreeToolsSortAscending
            // 
            _cMenTreeToolsSortAscending.Image = Resources.Sort_AZ;
            _cMenTreeToolsSortAscending.Name = "_cMenTreeToolsSortAscending";
            _cMenTreeToolsSortAscending.Size = new System.Drawing.Size(161, 22);
            _cMenTreeToolsSortAscending.Text = "Ascending (A-Z)";
            _cMenTreeToolsSortAscending.Click += OnSortAscendingClicked;
            // 
            // cMenTreeToolsSortDescending
            // 
            _cMenTreeToolsSortDescending.Image = Resources.Sort_ZA;
            _cMenTreeToolsSortDescending.Name = "_cMenTreeToolsSortDescending";
            _cMenTreeToolsSortDescending.Size = new System.Drawing.Size(161, 22);
            _cMenTreeToolsSortDescending.Text = "Descending (Z-A)";
            _cMenTreeToolsSortDescending.Click += OnSortDescendingClicked;
            // 
            // cMenTreeMoveUp
            // 
            _cMenTreeMoveUp.Image = Resources.Arrow_Up;
            _cMenTreeMoveUp.Name = "_cMenTreeMoveUp";
            _cMenTreeMoveUp.Size = new System.Drawing.Size(199, 22);
            _cMenTreeMoveUp.Text = "Move up";
            _cMenTreeMoveUp.Click += OnMoveUpClicked;
            // 
            // cMenTreeMoveDown
            // 
            _cMenTreeMoveDown.Image = Resources.Arrow_Down;
            _cMenTreeMoveDown.Name = "_cMenTreeMoveDown";
            _cMenTreeMoveDown.Size = new System.Drawing.Size(199, 22);
            _cMenTreeMoveDown.Text = "Move down";
            _cMenTreeMoveDown.Click += OnMoveDownClicked;
        }

        private void ApplyLanguage()
        {
            _cMenTreeConnect.Text = Language.strConnect;
            _cMenTreeConnectWithOptions.Text = Language.strConnectWithOptions;
            _cMenTreeConnectWithOptionsConnectToConsoleSession.Text = Language.strConnectToConsoleSession;
            _cMenTreeConnectWithOptionsDontConnectToConsoleSession.Text = Language.strDontConnectToConsoleSessionMenuItem;
            _cMenTreeConnectWithOptionsConnectInFullscreen.Text = Language.strConnectInFullscreen;
            _cMenTreeConnectWithOptionsNoCredentials.Text = Language.strConnectNoCredentials;
            _cMenTreeConnectWithOptionsChoosePanelBeforeConnecting.Text = Language.strChoosePanelBeforeConnecting;
            _cMenTreeDisconnect.Text = Language.strMenuDisconnect;

            _cMenTreeToolsExternalApps.Text = Language.strMenuExternalTools;
            _cMenTreeToolsTransferFile.Text = Language.strMenuTransferFile;

            _cMenTreeDuplicate.Text = Language.strDuplicate;
            _cMenTreeRename.Text = Language.strRename;
            _cMenTreeDelete.Text = Language.strMenuDelete;

            _cMenTreeImport.Text = Language.strImportMenuItem;
            _cMenTreeImportFile.Text = Language.strImportFromFileMenuItem;
            _cMenTreeImportActiveDirectory.Text = Language.strImportAD;
            _cMenTreeImportPortScan.Text = Language.strImportPortScan;
            _cMenTreeExportFile.Text = Language.strExportToFileMenuItem;

            _cMenTreeAddConnection.Text = Language.strAddConnection;
            _cMenTreeAddFolder.Text = Language.strAddFolder;

            _cMenTreeToolsSort.Text = Language.strSort;
            _cMenTreeToolsSortAscending.Text = Language.strSortAsc;
            _cMenTreeToolsSortDescending.Text = Language.strSortDesc;
            _cMenTreeMoveUp.Text = Language.strMoveUp;
            _cMenTreeMoveDown.Text = Language.strMoveDown;
        }

        internal void ShowHideMenuItems(ConnectionInfo connectionInfo)
        {
            if (connectionInfo == null)
                return;

            try
            {
                Enabled = true;
                EnableMenuItemsRecursive(Items);
                if (connectionInfo is RootPuttySessionsNodeInfo)
                {
                    ShowHideMenuItemsForRootPuttyNode();
                }
                else if (connectionInfo is RootNodeInfo)
                {
                    ShowHideMenuItemsForRootConnectionNode();
                }
                else if (connectionInfo is ContainerInfo)
                {
                    ShowHideMenuItemsForContainer(connectionInfo);
                }
                else if (connectionInfo is PuttySessionInfo)
                {
                    ShowHideMenuItemsForPuttyNode(connectionInfo);
                }
                else
                {
                    ShowHideMenuItemsForConnectionNode(connectionInfo);
                }
            }
            catch (Exception ex)
            {
                Runtime.MessageCollector.AddExceptionStackTrace("ShowHideMenuItems (UI.Controls.ConnectionContextMenu) failed", ex);
            }
        }

        internal void ShowHideMenuItemsForRootPuttyNode()
        {
            _cMenTreeAddConnection.Enabled = false;
            _cMenTreeAddFolder.Enabled = false;
            _cMenTreeConnect.Enabled = false;
            _cMenTreeConnectWithOptions.Enabled = false;
            _cMenTreeDisconnect.Enabled = false;
            _cMenTreeToolsTransferFile.Enabled = false;
            _cMenTreeConnectWithOptions.Enabled = false;
            _cMenTreeToolsSort.Enabled = false;
            _cMenTreeToolsExternalApps.Enabled = false;
            _cMenTreeDuplicate.Enabled = false;
            _cMenTreeRename.Enabled = true;
            _cMenTreeDelete.Enabled = false;
            _cMenTreeMoveUp.Enabled = false;
            _cMenTreeMoveDown.Enabled = false;
        }

        internal void ShowHideMenuItemsForRootConnectionNode()
        {
            _cMenTreeConnect.Enabled = false;
            _cMenTreeConnectWithOptions.Enabled = false;
            _cMenTreeConnectWithOptionsConnectInFullscreen.Enabled = false;
            _cMenTreeConnectWithOptionsConnectToConsoleSession.Enabled = false;
            _cMenTreeConnectWithOptionsChoosePanelBeforeConnecting.Enabled = false;
            _cMenTreeDisconnect.Enabled = false;
            _cMenTreeToolsTransferFile.Enabled = false;
            _cMenTreeToolsExternalApps.Enabled = false;
            _cMenTreeDuplicate.Enabled = false;
            _cMenTreeDelete.Enabled = false;
            _cMenTreeMoveUp.Enabled = false;
            _cMenTreeMoveDown.Enabled = false;
        }

        internal void ShowHideMenuItemsForContainer(ConnectionInfo connectionInfo)
        {
            _cMenTreeConnectWithOptionsConnectInFullscreen.Enabled = false;
            _cMenTreeConnectWithOptionsConnectToConsoleSession.Enabled = false;
            _cMenTreeDisconnect.Enabled = false;

            var openConnections = ((ContainerInfo)connectionInfo).Children.Sum(child => child.OpenConnections.Count);
            if (openConnections > 0)
                _cMenTreeDisconnect.Enabled = true;

            _cMenTreeToolsTransferFile.Enabled = false;
            _cMenTreeToolsExternalApps.Enabled = false;
        }

        internal void ShowHideMenuItemsForPuttyNode(ConnectionInfo connectionInfo)
        {
            _cMenTreeAddConnection.Enabled = false;
            _cMenTreeAddFolder.Enabled = false;

            if (connectionInfo.OpenConnections.Count == 0)
                _cMenTreeDisconnect.Enabled = false;

            if (!(connectionInfo.Protocol == ProtocolType.SSH1 | connectionInfo.Protocol == ProtocolType.SSH2))
                _cMenTreeToolsTransferFile.Enabled = false;

            _cMenTreeConnectWithOptionsConnectInFullscreen.Enabled = false;
            _cMenTreeConnectWithOptionsConnectToConsoleSession.Enabled = false;
            _cMenTreeToolsSort.Enabled = false;
            _cMenTreeDuplicate.Enabled = false;
            _cMenTreeRename.Enabled = false;
            _cMenTreeDelete.Enabled = false;
            _cMenTreeMoveUp.Enabled = false;
            _cMenTreeMoveDown.Enabled = false;
        }

        internal void ShowHideMenuItemsForConnectionNode(ConnectionInfo connectionInfo)
        {
            if (connectionInfo.OpenConnections.Count == 0)
                _cMenTreeDisconnect.Enabled = false;

            if (!(connectionInfo.Protocol == ProtocolType.SSH1 | connectionInfo.Protocol == ProtocolType.SSH2))
                _cMenTreeToolsTransferFile.Enabled = false;

            if (!(connectionInfo.Protocol == ProtocolType.RDP | connectionInfo.Protocol == ProtocolType.ICA))
            {
                _cMenTreeConnectWithOptionsConnectInFullscreen.Enabled = false;
                _cMenTreeConnectWithOptionsConnectToConsoleSession.Enabled = false;
            }

            if (connectionInfo.Protocol == ProtocolType.IntApp)
                _cMenTreeConnectWithOptionsNoCredentials.Enabled = false;
        }

        internal void DisableShortcutKeys()
        {
            _cMenTreeConnect.ShortcutKeys = Keys.None;
            _cMenTreeDuplicate.ShortcutKeys = Keys.None;
            _cMenTreeRename.ShortcutKeys = Keys.None;
            _cMenTreeDelete.ShortcutKeys = Keys.None;
            _cMenTreeMoveUp.ShortcutKeys = Keys.None;
            _cMenTreeMoveDown.ShortcutKeys = Keys.None;
        }

        internal void EnableShortcutKeys()
        {
            _cMenTreeConnect.ShortcutKeys = ((Keys.Control | Keys.Shift) | Keys.C);
            _cMenTreeDuplicate.ShortcutKeys = Keys.Control | Keys.D;
            _cMenTreeRename.ShortcutKeys = Keys.F2;
            _cMenTreeDelete.ShortcutKeys = Keys.Delete;
            _cMenTreeMoveUp.ShortcutKeys = Keys.Control | Keys.Up;
            _cMenTreeMoveDown.ShortcutKeys = Keys.Control | Keys.Down;
        }

        private static void EnableMenuItemsRecursive(ToolStripItemCollection items, bool enable = true)
        {
            foreach (ToolStripItem item in items)
            {
                var menuItem = item as ToolStripMenuItem;
                if (menuItem == null)
                {
                    continue;
                }
                menuItem.Enabled = enable;
                if (menuItem.HasDropDownItems)
                {
                    EnableMenuItemsRecursive(menuItem.DropDownItems, enable);
                }
            }
        }

        private void AddExternalApps()
        {
            try
            {
                ResetExternalAppMenu();

                foreach (ExternalTool extA in Runtime.ExternalTools)
                {
                    var menuItem = new ToolStripMenuItem
                    {
                        Text = extA.DisplayName,
                        Tag = extA,
                        Image = extA.Image
                    };

                    menuItem.Click += OnExternalToolClicked;
                    _cMenTreeToolsExternalApps.DropDownItems.Add(menuItem);
                }
            }
            catch (Exception ex)
            {
                Runtime.MessageCollector.AddExceptionStackTrace("cMenTreeTools_DropDownOpening failed (UI.Window.ConnectionTreeWindow)", ex);
            }
        }

        private void ResetExternalAppMenu()
        {
            if (_cMenTreeToolsExternalApps.DropDownItems.Count <= 0) return;
            for (var i = _cMenTreeToolsExternalApps.DropDownItems.Count - 1; i >= 0; i--)
                _cMenTreeToolsExternalApps.DropDownItems[i].Dispose();

            _cMenTreeToolsExternalApps.DropDownItems.Clear();
        }

        #region Events
        public event EventHandler ConnectClicked;

        private void OnConnectClicked(object sender, EventArgs e)
        {
            var handler = ConnectClicked;
            handler?.Invoke(this, e);
        }

        public event EventHandler ConnectToConsoleSessionClicked;

        private void OnConnectToConsoleSessionClicked(object sender, EventArgs e)
        {
            var handler = ConnectToConsoleSessionClicked;
            handler?.Invoke(this, e);
        }
        
        public event EventHandler DontConnectToConsoleSessionClicked;

        private void OnDontConnectToConsoleSessionClicked(object sender, EventArgs e)
        {
            var handler = DontConnectToConsoleSessionClicked;
            handler?.Invoke(this, e);
        }

        public event EventHandler ConnectInFullscreenClicked;

        private void OnConnectInFullscreenClicked(object sender, EventArgs e)
        {
            var handler = ConnectInFullscreenClicked;
            handler?.Invoke(this, e);
        }

        public event EventHandler ConnectWithNoCredentialsClick;

        private void OnConnectWithNoCredentialsClick(object sender, EventArgs e)
        {
            var handler = ConnectWithNoCredentialsClick;
            handler?.Invoke(this, e);
        }

        public event EventHandler ChoosePanelBeforeConnectingClicked;

        private void OnChoosePanelBeforeConnectingClicked(object sender, EventArgs e)
        {
            var handler = ChoosePanelBeforeConnectingClicked;
            handler?.Invoke(this, e);
        }


        public event EventHandler DisconnectClicked;

        private void OnDisconnectClicked(object sender, EventArgs e)
        {
            var handler = DisconnectClicked;
            handler?.Invoke(this, e);
        }

        public event EventHandler TransferFileClicked;

        private void OnTransferFileClicked(object sender, EventArgs e)
        {
            var handler = TransferFileClicked;
            handler?.Invoke(this, e);
        }

        public event EventHandler DuplicateClicked;

        private void OnDuplicateClicked(object sender, EventArgs e)
        {
            var handler = DuplicateClicked;
            handler?.Invoke(this, e);
        }

        public event EventHandler RenameClicked;

        private void OnRenameClicked(object sender, EventArgs e)
        {
            var handler = RenameClicked;
            handler?.Invoke(this, e);
        }

        public event EventHandler DeleteClicked;

        private void OnDeleteClicked(object sender, EventArgs e)
        {
            var handler = DeleteClicked;
            handler?.Invoke(this, e);
        }

        public event EventHandler ImportFileClicked;

        private void OnImportFileClicked(object sender, EventArgs e)
        {
            var handler = ImportFileClicked;
            handler?.Invoke(this, e);
        }

        public event EventHandler ImportActiveDirectoryClicked;

        private void OnImportActiveDirectoryClicked(object sender, EventArgs e)
        {
            var handler = ImportActiveDirectoryClicked;
            handler?.Invoke(this, e);
        }

        public event EventHandler ImportPortScanClicked;

        private void OnImportPortScanClicked(object sender, EventArgs e)
        {
            var handler = ImportPortScanClicked;
            handler?.Invoke(this, e);
        }

        public event EventHandler ExportFileClicked;

        private void OnExportFileClicked(object sender, EventArgs e)
        {
            var handler = ExportFileClicked;
            handler?.Invoke(this, e);
        }

        public event EventHandler AddConnectionClicked;

        private void OnAddConnectionClicked(object sender, EventArgs e)
        {
            var handler = AddConnectionClicked;
            handler?.Invoke(this, e);
        }

        public event EventHandler AddFolderClicked;

        private void OnAddFolderClicked(object sender, EventArgs e)
        {
            var handler = AddFolderClicked;
            handler?.Invoke(this, e);
        }

        public event EventHandler SortAscendingClicked;

        private void OnSortAscendingClicked(object sender, EventArgs e)
        {
            var handler = SortAscendingClicked;
            handler?.Invoke(this, e);
        }

        public event EventHandler SortDescendingClicked;

        private void OnSortDescendingClicked(object sender, EventArgs e)
        {
            var handler = SortDescendingClicked;
            handler?.Invoke(this, e);
        }

        public event EventHandler MoveUpClicked;

        private void OnMoveUpClicked(object sender, EventArgs e)
        {
            var handler = MoveUpClicked;
            handler?.Invoke(this, e);
        }

        public event EventHandler MoveDownClicked;

        private void OnMoveDownClicked(object sender, EventArgs e)
        {
            var handler = MoveDownClicked;
            handler?.Invoke(this, e);
        }

        public event EventHandler ExternalToolClicked;

        private void OnExternalToolClicked(object sender, EventArgs e)
        {
            var handler = ExternalToolClicked;
            handler?.Invoke(sender, e);
        }
        #endregion
    }
}