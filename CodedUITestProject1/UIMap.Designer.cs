﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 14.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace CodedUITestProject1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// EmptyTermFlashCard
        /// </summary>
        public void EmptyTermFlashCard()
        {
            #region Variable Declarations
            WinEdit uINameEdit = this.UIStudyAidWindow.UIItemWindow.UIStudyAidexeShortcutListItem.UINameEdit;
            WinMenuItem uIFlashcardMenuItem = this.UIStudyAidWindow1.UIMenuStrip1MenuBar.UIModeMenuItem.UIFlashcardMenuItem;
            #endregion

            // Double-Click 'Name' text box
            Mouse.DoubleClick(uINameEdit, new Point(181, 10));

            // Click 'Mode' -> 'Flashcard' menu item
            Mouse.Click(uIFlashcardMenuItem, new Point(65, 10));
        }
        
        /// <summary>
        /// EmptyMatching
        /// </summary>
        public void EmptyMatching()
        {
            #region Variable Declarations
            WinButton uIOKButton = this.UIEmptyTermListWindow.UIOKWindow.UIOKButton;
            WinMenuItem uIMatchingMenuItem = this.UIStudyAidWindow1.UIMenuStrip1MenuBar.UIModeMenuItem.UIMatchingMenuItem;
            #endregion

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(21, 5));

            // Click 'Mode' -> 'Matching' menu item
            Mouse.Click(uIMatchingMenuItem, new Point(50, 14));
        }
        
        /// <summary>
        /// FlashCardWindow1Item - Use 'FlashCardWindow1ItemParams' to pass parameters into this method.
        /// </summary>
        public void FlashCardWindow1Item()
        {
            #region Variable Declarations
            WinButton uIOKButton = this.UIEmptyTermListWindow.UIOKWindow.UIOKButton;
            WinEdit uITermBoxEdit = this.UIStudyAidWindow1.UITermBoxWindow.UITermBoxEdit;
            WinEdit uIDefinitionBoxEdit = this.UIStudyAidWindow1.UIDefinitionBoxWindow.UIDefinitionBoxEdit;
            WinButton uIAddButton = this.UIStudyAidWindow1.UIAddWindow.UIAddButton;
            WinMenuItem uIFlashcardMenuItem = this.UIStudyAidWindow1.UIMenuStrip1MenuBar.UIModeMenuItem.UIFlashcardMenuItem;
            WinButton uIItemButton = this.UIFlashCardWindowWindow.UIItemWindow.UIItemButton;
            WinButton uIItemButton1 = this.UIFlashCardWindowWindow.UIItemWindow1.UIItemButton;
            #endregion

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(43, 14));

            // Type '1' in 'termBox' text box
            uITermBoxEdit.Text = this.FlashCardWindow1ItemParams.UITermBoxEditText;

            // Type '{Tab}' in 'termBox' text box
            Keyboard.SendKeys(uITermBoxEdit, this.FlashCardWindow1ItemParams.UITermBoxEditSendKeys, ModifierKeys.None);

            // Type '1' in 'definitionBox' text box
            uIDefinitionBoxEdit.Text = this.FlashCardWindow1ItemParams.UIDefinitionBoxEditText;

            // Type '{Tab}' in 'definitionBox' text box
            Keyboard.SendKeys(uIDefinitionBoxEdit, this.FlashCardWindow1ItemParams.UIDefinitionBoxEditSendKeys, ModifierKeys.None);

            // Type '{Enter}' in 'Add' button
            Keyboard.SendKeys(uIAddButton, this.FlashCardWindow1ItemParams.UIAddButtonSendKeys, ModifierKeys.None);

            // Click 'Mode' -> 'Flashcard' menu item
            Mouse.Click(uIFlashcardMenuItem, new Point(36, 7));

            // Click '>' button
            Mouse.Click(uIItemButton, new Point(56, 34));

            // Double-Click '>' button
            Mouse.DoubleClick(uIItemButton, new Point(56, 34));

            // Double-Click '>' button
            Mouse.DoubleClick(uIItemButton, new Point(56, 34));

            // Double-Click '>' button
            Mouse.DoubleClick(uIItemButton, new Point(56, 34));

            // Double-Click '>' button
            Mouse.DoubleClick(uIItemButton, new Point(56, 34));

            // Double-Click '>' button
            Mouse.DoubleClick(uIItemButton, new Point(56, 34));

            // Double-Click '>' button
            Mouse.DoubleClick(uIItemButton, new Point(56, 34));

            // Double-Click '>' button
            Mouse.DoubleClick(uIItemButton, new Point(56, 34));

            // Double-Click '<' button
            Mouse.DoubleClick(uIItemButton1, new Point(114, 32));

            // Double-Click '<' button
            Mouse.DoubleClick(uIItemButton1, new Point(114, 32));

            // Double-Click '<' button
            Mouse.DoubleClick(uIItemButton1, new Point(114, 32));

            // Double-Click '<' button
            Mouse.DoubleClick(uIItemButton1, new Point(114, 32));

            // Click '<' button
            Mouse.Click(uIItemButton1, new Point(114, 32));
        }
        
        #region Properties
        public virtual FlashCardWindow1ItemParams FlashCardWindow1ItemParams
        {
            get
            {
                if ((this.mFlashCardWindow1ItemParams == null))
                {
                    this.mFlashCardWindow1ItemParams = new FlashCardWindow1ItemParams();
                }
                return this.mFlashCardWindow1ItemParams;
            }
        }
        
        public UIStudyAidWindow UIStudyAidWindow
        {
            get
            {
                if ((this.mUIStudyAidWindow == null))
                {
                    this.mUIStudyAidWindow = new UIStudyAidWindow();
                }
                return this.mUIStudyAidWindow;
            }
        }
        
        public UIStudyAidWindow1 UIStudyAidWindow1
        {
            get
            {
                if ((this.mUIStudyAidWindow1 == null))
                {
                    this.mUIStudyAidWindow1 = new UIStudyAidWindow1();
                }
                return this.mUIStudyAidWindow1;
            }
        }
        
        public UIEmptyTermListWindow UIEmptyTermListWindow
        {
            get
            {
                if ((this.mUIEmptyTermListWindow == null))
                {
                    this.mUIEmptyTermListWindow = new UIEmptyTermListWindow();
                }
                return this.mUIEmptyTermListWindow;
            }
        }
        
        public UIFlashCardWindowWindow UIFlashCardWindowWindow
        {
            get
            {
                if ((this.mUIFlashCardWindowWindow == null))
                {
                    this.mUIFlashCardWindowWindow = new UIFlashCardWindowWindow();
                }
                return this.mUIFlashCardWindowWindow;
            }
        }
        #endregion
        
        #region Fields
        private FlashCardWindow1ItemParams mFlashCardWindow1ItemParams;
        
        private UIStudyAidWindow mUIStudyAidWindow;
        
        private UIStudyAidWindow1 mUIStudyAidWindow1;
        
        private UIEmptyTermListWindow mUIEmptyTermListWindow;
        
        private UIFlashCardWindowWindow mUIFlashCardWindowWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'FlashCardWindow1Item'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class FlashCardWindow1ItemParams
    {
        
        #region Fields
        /// <summary>
        /// Type '1' in 'termBox' text box
        /// </summary>
        public string UITermBoxEditText = "1";
        
        /// <summary>
        /// Type '{Tab}' in 'termBox' text box
        /// </summary>
        public string UITermBoxEditSendKeys = "{Tab}";
        
        /// <summary>
        /// Type '1' in 'definitionBox' text box
        /// </summary>
        public string UIDefinitionBoxEditText = "1";
        
        /// <summary>
        /// Type '{Tab}' in 'definitionBox' text box
        /// </summary>
        public string UIDefinitionBoxEditSendKeys = "{Tab}";
        
        /// <summary>
        /// Type '{Enter}' in 'Add' button
        /// </summary>
        public string UIAddButtonSendKeys = "{Enter}";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIStudyAidWindow : WinWindow
    {
        
        public UIStudyAidWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Study Aid";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "CabinetWClass";
            this.WindowTitles.Add("Study Aid");
            #endregion
        }
        
        #region Properties
        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this);
                }
                return this.mUIItemWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIItemWindow mUIItemWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIItemWindow : WinWindow
    {
        
        public UIItemWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.AccessibleName] = "Items View";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "DirectUIHWND";
            this.WindowTitles.Add("Study Aid");
            #endregion
        }
        
        #region Properties
        public UIStudyAidexeShortcutListItem UIStudyAidexeShortcutListItem
        {
            get
            {
                if ((this.mUIStudyAidexeShortcutListItem == null))
                {
                    this.mUIStudyAidexeShortcutListItem = new UIStudyAidexeShortcutListItem(this);
                }
                return this.mUIStudyAidexeShortcutListItem;
            }
        }
        #endregion
        
        #region Fields
        private UIStudyAidexeShortcutListItem mUIStudyAidexeShortcutListItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIStudyAidexeShortcutListItem : WinListItem
    {
        
        public UIStudyAidexeShortcutListItem(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinListItem.PropertyNames.Name] = "StudyAid.exe - Shortcut";
            this.WindowTitles.Add("Study Aid");
            #endregion
        }
        
        #region Properties
        public WinEdit UINameEdit
        {
            get
            {
                if ((this.mUINameEdit == null))
                {
                    this.mUINameEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUINameEdit.SearchProperties[WinEdit.PropertyNames.Name] = "Name";
                    this.mUINameEdit.WindowTitles.Add("Study Aid");
                    #endregion
                }
                return this.mUINameEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUINameEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIStudyAidWindow1 : WinWindow
    {
        
        public UIStudyAidWindow1()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Study Aid";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Study Aid");
            #endregion
        }
        
        #region Properties
        public UIMenuStrip1MenuBar UIMenuStrip1MenuBar
        {
            get
            {
                if ((this.mUIMenuStrip1MenuBar == null))
                {
                    this.mUIMenuStrip1MenuBar = new UIMenuStrip1MenuBar(this);
                }
                return this.mUIMenuStrip1MenuBar;
            }
        }
        
        public UITermBoxWindow UITermBoxWindow
        {
            get
            {
                if ((this.mUITermBoxWindow == null))
                {
                    this.mUITermBoxWindow = new UITermBoxWindow(this);
                }
                return this.mUITermBoxWindow;
            }
        }
        
        public UIDefinitionBoxWindow UIDefinitionBoxWindow
        {
            get
            {
                if ((this.mUIDefinitionBoxWindow == null))
                {
                    this.mUIDefinitionBoxWindow = new UIDefinitionBoxWindow(this);
                }
                return this.mUIDefinitionBoxWindow;
            }
        }
        
        public UIAddWindow UIAddWindow
        {
            get
            {
                if ((this.mUIAddWindow == null))
                {
                    this.mUIAddWindow = new UIAddWindow(this);
                }
                return this.mUIAddWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIMenuStrip1MenuBar mUIMenuStrip1MenuBar;
        
        private UITermBoxWindow mUITermBoxWindow;
        
        private UIDefinitionBoxWindow mUIDefinitionBoxWindow;
        
        private UIAddWindow mUIAddWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIMenuStrip1MenuBar : WinMenuBar
    {
        
        public UIMenuStrip1MenuBar(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinMenu.PropertyNames.Name] = "menuStrip1";
            this.WindowTitles.Add("Study Aid");
            #endregion
        }
        
        #region Properties
        public UIModeMenuItem UIModeMenuItem
        {
            get
            {
                if ((this.mUIModeMenuItem == null))
                {
                    this.mUIModeMenuItem = new UIModeMenuItem(this);
                }
                return this.mUIModeMenuItem;
            }
        }
        #endregion
        
        #region Fields
        private UIModeMenuItem mUIModeMenuItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIModeMenuItem : WinMenuItem
    {
        
        public UIModeMenuItem(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinMenuItem.PropertyNames.Name] = "Mode";
            this.WindowTitles.Add("Study Aid");
            #endregion
        }
        
        #region Properties
        public WinMenuItem UIFlashcardMenuItem
        {
            get
            {
                if ((this.mUIFlashcardMenuItem == null))
                {
                    this.mUIFlashcardMenuItem = new WinMenuItem(this);
                    #region Search Criteria
                    this.mUIFlashcardMenuItem.SearchProperties[WinMenuItem.PropertyNames.Name] = "Flashcard";
                    this.mUIFlashcardMenuItem.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
                    this.mUIFlashcardMenuItem.WindowTitles.Add("Study Aid");
                    #endregion
                }
                return this.mUIFlashcardMenuItem;
            }
        }
        
        public WinMenuItem UIMatchingMenuItem
        {
            get
            {
                if ((this.mUIMatchingMenuItem == null))
                {
                    this.mUIMatchingMenuItem = new WinMenuItem(this);
                    #region Search Criteria
                    this.mUIMatchingMenuItem.SearchProperties[WinMenuItem.PropertyNames.Name] = "Matching";
                    this.mUIMatchingMenuItem.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
                    this.mUIMatchingMenuItem.WindowTitles.Add("Study Aid");
                    #endregion
                }
                return this.mUIMatchingMenuItem;
            }
        }
        #endregion
        
        #region Fields
        private WinMenuItem mUIFlashcardMenuItem;
        
        private WinMenuItem mUIMatchingMenuItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UITermBoxWindow : WinWindow
    {
        
        public UITermBoxWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "termBox";
            this.WindowTitles.Add("Study Aid");
            #endregion
        }
        
        #region Properties
        public WinEdit UITermBoxEdit
        {
            get
            {
                if ((this.mUITermBoxEdit == null))
                {
                    this.mUITermBoxEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUITermBoxEdit.WindowTitles.Add("Study Aid");
                    #endregion
                }
                return this.mUITermBoxEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUITermBoxEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIDefinitionBoxWindow : WinWindow
    {
        
        public UIDefinitionBoxWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "definitionBox";
            this.WindowTitles.Add("Study Aid");
            #endregion
        }
        
        #region Properties
        public WinEdit UIDefinitionBoxEdit
        {
            get
            {
                if ((this.mUIDefinitionBoxEdit == null))
                {
                    this.mUIDefinitionBoxEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUIDefinitionBoxEdit.SearchProperties[WinEdit.PropertyNames.Name] = "Term:";
                    this.mUIDefinitionBoxEdit.WindowTitles.Add("Study Aid");
                    #endregion
                }
                return this.mUIDefinitionBoxEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUIDefinitionBoxEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIAddWindow : WinWindow
    {
        
        public UIAddWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "addButton";
            this.WindowTitles.Add("Study Aid");
            #endregion
        }
        
        #region Properties
        public WinButton UIAddButton
        {
            get
            {
                if ((this.mUIAddButton == null))
                {
                    this.mUIAddButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIAddButton.SearchProperties[WinButton.PropertyNames.Name] = "Add";
                    this.mUIAddButton.WindowTitles.Add("Study Aid");
                    #endregion
                }
                return this.mUIAddButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIAddButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIEmptyTermListWindow : WinWindow
    {
        
        public UIEmptyTermListWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Empty Term List";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "#32770";
            this.WindowTitles.Add("Empty Term List");
            #endregion
        }
        
        #region Properties
        public UIOKWindow UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIOKWindow(this);
                }
                return this.mUIOKWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIOKWindow mUIOKWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIOKWindow : WinWindow
    {
        
        public UIOKWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "2";
            this.WindowTitles.Add("Empty Term List");
            #endregion
        }
        
        #region Properties
        public WinButton UIOKButton
        {
            get
            {
                if ((this.mUIOKButton == null))
                {
                    this.mUIOKButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIOKButton.SearchProperties[WinButton.PropertyNames.Name] = "OK";
                    this.mUIOKButton.WindowTitles.Add("Empty Term List");
                    #endregion
                }
                return this.mUIOKButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIOKButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIFlashCardWindowWindow : WinWindow
    {
        
        public UIFlashCardWindowWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Flash Card Window";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Flash Card Window");
            #endregion
        }
        
        #region Properties
        public UIItemWindow1 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow1(this);
                }
                return this.mUIItemWindow;
            }
        }
        
        public UIItemWindow11 UIItemWindow1
        {
            get
            {
                if ((this.mUIItemWindow1 == null))
                {
                    this.mUIItemWindow1 = new UIItemWindow11(this);
                }
                return this.mUIItemWindow1;
            }
        }
        #endregion
        
        #region Fields
        private UIItemWindow1 mUIItemWindow;
        
        private UIItemWindow11 mUIItemWindow1;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIItemWindow1 : WinWindow
    {
        
        public UIItemWindow1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "RightButton";
            this.WindowTitles.Add("Flash Card Window");
            #endregion
        }
        
        #region Properties
        public WinButton UIItemButton
        {
            get
            {
                if ((this.mUIItemButton == null))
                {
                    this.mUIItemButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIItemButton.SearchProperties[WinButton.PropertyNames.Name] = ">";
                    this.mUIItemButton.WindowTitles.Add("Flash Card Window");
                    #endregion
                }
                return this.mUIItemButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIItemButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIItemWindow11 : WinWindow
    {
        
        public UIItemWindow11(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "LeftButton";
            this.WindowTitles.Add("Flash Card Window");
            #endregion
        }
        
        #region Properties
        public WinButton UIItemButton
        {
            get
            {
                if ((this.mUIItemButton == null))
                {
                    this.mUIItemButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIItemButton.SearchProperties[WinButton.PropertyNames.Name] = "<";
                    this.mUIItemButton.WindowTitles.Add("Flash Card Window");
                    #endregion
                }
                return this.mUIItemButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIItemButton;
        #endregion
    }
}
