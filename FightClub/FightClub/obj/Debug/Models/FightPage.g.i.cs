#pragma checksum "..\..\..\Models\FightPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F39528D8E8725E880564DABA0A39C631"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using FightClub.Models;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace FightClub.Models
{


    /// <summary>
    /// FightPage
    /// </summary>
    public partial class FightPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector
    {


#line 38 "..\..\..\Models\FightPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Fighter1NameTextBlock;

#line default
#line hidden


#line 41 "..\..\..\Models\FightPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar Fighter1HpProgressBar;

#line default
#line hidden


#line 45 "..\..\..\Models\FightPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Fighter2NameTextBlock;

#line default
#line hidden


#line 48 "..\..\..\Models\FightPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar Fighter2HpProgressBar;

#line default
#line hidden


#line 53 "..\..\..\Models\FightPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel Fighter1StackPanel;

#line default
#line hidden


#line 65 "..\..\..\Models\FightPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox LogTextBox;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/FightClub;component/models/fightpage.xaml", System.UriKind.Relative);

#line 1 "..\..\..\Models\FightPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.Fighter1NameTextBlock = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 2:
                    this.Fighter1HpProgressBar = ((System.Windows.Controls.ProgressBar)(target));
                    return;
                case 3:
                    this.Fighter2NameTextBlock = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 4:
                    this.Fighter2HpProgressBar = ((System.Windows.Controls.ProgressBar)(target));
                    return;
                case 5:
                    this.Fighter1StackPanel = ((System.Windows.Controls.StackPanel)(target));
                    return;
                case 6:
                    this.LogTextBox = ((System.Windows.Controls.RichTextBox)(target));
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.Button NextRoundButton;
    }
}

